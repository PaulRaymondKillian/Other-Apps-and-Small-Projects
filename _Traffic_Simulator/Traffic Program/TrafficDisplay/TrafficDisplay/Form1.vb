Imports Microsoft.DirectX
Imports Microsoft.DirectX.Direct3D

Public Class Form1
    Private device As Direct3D.Device
    Dim _TrafficGrid As New TrafficGrid
    


    Public Sub Initialize()
        Dim present As PresentParameters = New PresentParameters
        present.Windowed = True 'we?ll draw on a window
        present.SwapEffect = SwapEffect.Discard 'discuss later
        device = New Direct3D.Device(0, DeviceType.Hardware, Me, CreateFlags.SoftwareVertexProcessing, present)
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.Opaque, True) 'Do not draw form?s background\
        Me.Height = 610
        Me.Width = 650
        Me.Text = "DirectX Tutorial using Visual Basic"

        Initialize()

    End Sub

    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint

        
        Dim color As Color = Drawing.Color.Red
        Dim y As Integer = 10
        Dim pixelSize As Integer = 6
        Dim s As String = _TrafficGrid.returnGridRow(0)

        device.Clear(ClearFlags.Target, color.Black, 1.0, 0)

        device.BeginScene() 'all drawings after this line

        device.VertexFormat = CustomVertex.TransformedColored.Format
        For j As Integer = 1 To (s.Length - 1)

            Dim x As Integer = 10

            For i As Integer = 0 To (s.Length - 1)

                If s(i) = "0" Then
                    color = Drawing.Color.Green
                ElseIf s(i) = "8" Then
                    color = Drawing.Color.Gray
                ElseIf s(i) = "1" Then
                    color = Drawing.Color.Red
                Else
                    color = Drawing.Color.DeepPink
                End If

                Dim vertices As CustomVertex.TransformedColored() = New CustomVertex.TransformedColored(0 To 2) {} 'create an array of vertices
                vertices(0).Position = New Vector4(x, y, 0, 1)
                vertices(0).Color = color.ToArgb
                vertices(1).Position = New Vector4(x + pixelSize, y, 0, 1)
                vertices(1).Color = color.ToArgb
                vertices(2).Position = New Vector4(x, y + pixelSize, 0, 1)
                vertices(2).Color = color.ToArgb

                Dim vertices2 As CustomVertex.TransformedColored() = New CustomVertex.TransformedColored(0 To 2) {} 'create an array of vertices
                vertices2(0).Position = New Vector4(x, y + pixelSize, 0, 1)
                vertices2(0).Color = color.ToArgb
                vertices2(1).Position = New Vector4(x + pixelSize, y, 0, 1)
                vertices2(1).Color = color.ToArgb
                vertices2(2).Position = New Vector4(x + pixelSize, y + pixelSize, 0, 1)
                vertices2(2).Color = color.ToArgb



                device.DrawUserPrimitives(PrimitiveType.TriangleList, 1, vertices)
                device.DrawUserPrimitives(PrimitiveType.TriangleList, 1, vertices2)


                x = x + pixelSize

            Next

            s = _TrafficGrid.returnGridRow(j)
            y = y + pixelSize
        Next

        Sleep(500)
        _TrafficGrid.advanceTime()
        _TrafficGrid.randomlyGenerateCar()


        device.EndScene() 'all drawings before this line

        device.Present()
        Me.Invalidate() 'redraw
    End Sub


    Private Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Long)


End Class

