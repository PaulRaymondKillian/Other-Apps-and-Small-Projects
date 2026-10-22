Imports Microsoft.DirectX
Imports Microsoft.DirectX.Direct3D

Public Class Form1
    Private device As Direct3D.Device
    Private TrafficGridController As New Traffic_Grid_Controller.Traffic_Grid_Controller("C:\Documents and Settings\Administrator\My Documents\Traffic Program\Traffic_Grid_Learner\grid2_configuration.txt")

    Private resetGrid As Boolean = False
    Private runSim As Boolean = False


    Public Sub Initialize()

        Dim present As PresentParameters = New PresentParameters
        present.Windowed = True 'we?ll draw on a window
        present.SwapEffect = SwapEffect.Discard 'discuss later
        device = New Direct3D.Device(0, DeviceType.Hardware, Me, CreateFlags.SoftwareVertexProcessing, present)

    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.Opaque, True) 'Do not draw form?s background\
        'Me.Height = 750
        'Me.Width = 1200
        Me.Text = "Traffic Simulator"

        Initialize()

    End Sub

    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint

        Dim color As Color = Drawing.Color.Red

        device.Clear(ClearFlags.Target, color.Green, 1.0, 0)

        device.BeginScene() 'all drawings after this line

        device.VertexFormat = CustomVertex.TransformedColored.Format


        If resetGrid = True Then
            'TrafficGridController.resetGrid()
            resetGrid = False
        End If

        Dim vertices As CustomVertex.TransformedColored() = New CustomVertex.TransformedColored(0 To 2) {} 'create an array of vertices
        Dim vertices2 As CustomVertex.TransformedColored() = New CustomVertex.TransformedColored(0 To 2) {} 'create an array of vertices

        ''
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '' Begin Drawing Traffic Grid
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ''

        Dim s As String = TrafficGridController.returnGridAsString
        Dim c As Char

        Dim x As Integer = 0
        Dim y As Integer = 0

        Dim gridWidth As Integer = TrafficGridController.gridWidth
        Dim gridHeight As Integer = TrafficGridController.gridHeight
        Dim blockSize As Integer = TrafficGridController.blockSize

        Dim maxWidthSize As Integer = 650
        Dim maxHeightSize As Integer = 650
        Dim pixelSize As Integer

        pixelSize = maxWidthSize / (blockSize * gridWidth)

        If pixelSize < 1 Then
            MsgBox("Error - Class: Form1, Method: Form1_Paint, Desc: pixelSize is less than 1")
        End If


        For i As Integer = 0 To (blockSize * blockSize * gridWidth * gridHeight - 1)
            c = s(i)

            If c = "0" Then
                color = Drawing.Color.Blue
            ElseIf c = "8" Then
                color = Drawing.Color.Gray
            ElseIf c = "1" Then
                color = Drawing.Color.Red
            ElseIf c = "2" Then
                color = Drawing.Color.Blue
            ElseIf c = "3" Then
                color = Drawing.Color.Yellow
            ElseIf c = "4" Then
                color = Drawing.Color.DarkViolet
            Else
                color = Drawing.Color.DeepPink
            End If

            If c <> "0" Then
                vertices(0).Position = New Vector4(x, y, 0, 1)
                vertices(0).Color = color.ToArgb
                vertices(1).Position = New Vector4(x + pixelSize - 1, y, 0, 1)
                vertices(1).Color = color.ToArgb
                vertices(2).Position = New Vector4(x, y + pixelSize - 1, 0, 1)
                vertices(2).Color = color.ToArgb

                vertices2(0).Position = New Vector4(x, y + pixelSize - 1, 0, 1)
                vertices2(0).Color = color.ToArgb
                vertices2(1).Position = New Vector4(x + pixelSize - 1, y, 0, 1)
                vertices2(1).Color = color.ToArgb
                vertices2(2).Position = New Vector4(x + pixelSize - 1, y + pixelSize - 1, 0, 1)
                vertices2(2).Color = color.ToArgb

                device.DrawUserPrimitives(PrimitiveType.TriangleList, 1, vertices)
                device.DrawUserPrimitives(PrimitiveType.TriangleList, 1, vertices2)
            End If

            x = x + pixelSize

            If ((x / pixelSize) >= (blockSize * gridWidth)) Then
                y = y + pixelSize
                x = 0
            End If

        Next

        ''
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '' End Drawing Traffic Grid
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ''

        ''
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '' Begin Update Form Stats Output
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ''

        txtOutput.Text = txtOutput.Text & ""

        txtLog.Text = txtLog.Text & ""

        ''
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '' Begin Update Form Stats Output
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ''


        ''
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '' Begin Advance Time
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ''

        If runSim = True Then
            'TrafficGridController.advanceTime()
            txtLog.Text = TrafficGridController.debugReturnBlockTypes
        End If

        ''
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        '' End Advance Time
        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        ''

        'Set sleep timer to slow down or speed up the simulation
        Sleep(tbSpeedStep.Value * 100)


        GroupBox1.Refresh()
        GroupBox2.Refresh()

        device.EndScene() 'all drawings before this line

        device.Present()
        Me.Invalidate() 'redraw
    End Sub


    Private Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Long)

    Private Sub btnPause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPause.Click
        If btnPause.Text = "Pause" Then
            btnPause.Text = "Resume"
            runSim = False
        Else
            btnPause.Text = "Pause"
            runSim = True
        End If
    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        btnReset.Enabled = True
        btnStart.Enabled = False
        runSim = True
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        btnReset.Enabled = False
        btnStart.Enabled = True
        runSim = False
    End Sub
End Class


