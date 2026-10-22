Imports Microsoft.DirectX
Imports Microsoft.DirectX.Direct3D
Imports Traffic_Simulator_Library

Public Class Form1
    Private device As Direct3D.Device
    Dim TrafficSimulatorController As New Traffic_Simulator_Controller.Traffic_Simulator_Controller



    Public Sub Initialize()

        Dim weightsArr(319) As Double
        'weightsArr = New Double() {4.31818181818182, 0.0510204081632653, 1.21518987341772, 1.98913043478261, -6.55555555555556, -3.59302325581395, -2.16129032258065, -5.83333333333333, -2.74509803921569, 0.71, 0.753086419753086, -2.6063829787234, 5.48717948717949, -4.13333333333333, -3.84375, 8.55555555555556, -1.07547169811321, 13.3333333333333, -1.09090909090909, -7.17391304347826, 4.35294117647059, -8.88235294117647, 4.47474747474747, 2.13157894736842, -3.25, 2.0625, -7.15384615384615, -6.38461538461539, 1.28571428571429, 1.06521739130435, 0.464285714285714, -1.2, -3.42352941176471, -5, -3.76190476190476, 3.50909090909091, 1.75342465753425, 5.79591836734694, 3.63333333333333, -2.72093023255814, 4.86206896551724, -2.53125, -6.17777777777778, 5.62068965517241, -12.5, 1.03846153846154, 0.745762711864407, -2.55555555555556, 0.455555555555556, -3, -4.36170212765957, 5, -20.4, -1.24691358024691, 2.35483870967742, -3.05333333333333, 1.36842105263158, 4.95652173913043, -4.39473684210526, 0.292134831460674, -4.55882352941176, -3.02409638554217, -2.765625, -3.58441558441558, 4.31818181818182, 0.0510204081632653, 1.21518987341772, 1.98913043478261, -6.55555555555556, -3.59302325581395, -2.16129032258065, -5.83333333333333, -2.74509803921569, 0.71, 0.753086419753086, -2.6063829787234, 5.48717948717949, -4.13333333333333, -3.84375, 8.55555555555556, -1.07547169811321, 13.3333333333333, -1.09090909090909, -7.17391304347826, 4.35294117647059, -8.88235294117647, 4.47474747474747, 2.13157894736842, -3.25, 2.0625, -7.15384615384615, -6.38461538461539, 1.28571428571429, 1.06521739130435, 0.464285714285714, -1.2, -3.42352941176471, -5, -3.76190476190476, 3.50909090909091, 1.75342465753425, 5.79591836734694, 3.63333333333333, -2.72093023255814, 4.86206896551724, -2.53125, -6.17777777777778, 5.62068965517241, -12.5, 1.03846153846154, 0.745762711864407, -2.55555555555556, 0.455555555555556, -3, -4.36170212765957, 5, -20.4, -1.24691358024691, 2.35483870967742, -3.05333333333333, 1.36842105263158, 4.95652173913043, -4.39473684210526, 0.292134831460674, -4.55882352941176, -3.02409638554217, -2.765625, -3.58441558441558, 4.31818181818182, 0.0510204081632653, 1.21518987341772, 1.98913043478261, -6.55555555555556, -3.59302325581395, -2.16129032258065, -5.83333333333333, -2.74509803921569, 0.71, 0.753086419753086, -2.6063829787234, 5.48717948717949, -4.13333333333333, -3.84375, 8.55555555555556, -1.07547169811321, 13.3333333333333, -1.09090909090909, -7.17391304347826, 4.35294117647059, -8.88235294117647, 4.47474747474747, 2.13157894736842, -3.25, 2.0625, -7.15384615384615, -6.38461538461539, 1.28571428571429, 1.06521739130435, 0.464285714285714, -1.2, -3.42352941176471, -5, -3.76190476190476, 3.50909090909091, 1.75342465753425, 5.79591836734694, 3.63333333333333, -2.72093023255814, 4.86206896551724, -2.53125, -6.17777777777778, 5.62068965517241, -12.5, 1.03846153846154, 0.745762711864407, -2.55555555555556, 0.455555555555556, -3, -4.36170212765957, 5, -20.4, -1.24691358024691, 2.35483870967742, -3.05333333333333, 1.36842105263158, 4.95652173913043, -4.39473684210526, 0.292134831460674, -4.55882352941176, -3.02409638554217, -2.765625, -3.58441558441558, 4.31818181818182, 0.0510204081632653, 1.21518987341772, 1.98913043478261, -6.55555555555556, -3.59302325581395, -2.16129032258065, -5.83333333333333, -2.74509803921569, 0.71, 0.753086419753086, -2.6063829787234, 5.48717948717949, -4.13333333333333, -3.84375, 8.55555555555556, -1.07547169811321, 13.3333333333333, -1.09090909090909, -7.17391304347826, 4.35294117647059, -8.88235294117647, 4.47474747474747, 2.13157894736842, -3.25, 2.0625, -7.15384615384615, -6.38461538461539, 1.28571428571429, 1.06521739130435, 0.464285714285714, -1.2, -3.42352941176471, -5, -3.76190476190476, 3.50909090909091, 1.75342465753425, 5.79591836734694, 3.63333333333333, -2.72093023255814, 4.86206896551724, -2.53125, -6.17777777777778, 5.62068965517241, -12.5, 1.03846153846154, 0.745762711864407, -2.55555555555556, 0.455555555555556, -3, -4.36170212765957, 5, -20.4, -1.24691358024691, 2.35483870967742, -3.05333333333333, 1.36842105263158, 4.95652173913043, -4.39473684210526, 0.292134831460674, -4.55882352941176, -3.02409638554217, -2.765625, -3.58441558441558, 4.31818181818182, 0.0510204081632653, 1.21518987341772, 1.98913043478261, -6.55555555555556, -3.59302325581395, -2.16129032258065, -5.83333333333333, -2.74509803921569, 0.71, 0.753086419753086, -2.6063829787234, 5.48717948717949, -4.13333333333333, -3.84375, 8.55555555555556, -1.07547169811321, 13.3333333333333, -1.09090909090909, -7.17391304347826, 4.35294117647059, -8.88235294117647, 4.47474747474747, 2.13157894736842, -3.25, 2.0625, -7.15384615384615, -6.38461538461539, 1.28571428571429, 1.06521739130435, 0.464285714285714, -1.2, -3.42352941176471, -5, -3.76190476190476, 3.50909090909091, 1.75342465753425, 5.79591836734694, 3.63333333333333, -2.72093023255814, 4.86206896551724, -2.53125, -6.17777777777778, 5.62068965517241, -12.5, 1.03846153846154, 0.745762711864407, -2.55555555555556, 0.455555555555556, -3, -4.36170212765957, 5, -20.4, -1.24691358024691, 2.35483870967742, -3.05333333333333, 1.36842105263158, 4.95652173913043, -4.39473684210526, 0.292134831460674, -4.55882352941176, -3.02409638554217, -2.765625}
        'TrafficSimulatorController.setANNWeights(weightsArr)

        TrafficSimulatorController.readWeightsfromFile()

        'Dim present As PresentParameters = New PresentParameters
        'present.Windowed = True 'we?ll draw on a window
        'present.SwapEffect = SwapEffect.Discard 'discuss later
        'device = New Direct3D.Device(0, DeviceType.Hardware, Me, CreateFlags.SoftwareVertexProcessing, present)
        device = New Direct3D.Device(0, DeviceType.Hardware, Me, CreateFlags.SoftwareVertexProcessing)

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
        Dim y As Integer = 10
        Dim pixelSize As Integer = 6
        Dim carSizeSubtract As Integer = 1
        Dim s As String = TrafficSimulatorController.getTrafficRow(0)

        device.Clear(ClearFlags.Target, color.Green, 1.0, 0)

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
                ElseIf s(i) = "2" Then
                    color = Drawing.Color.Blue
                ElseIf s(i) = "3" Then
                    color = Drawing.Color.Yellow
                ElseIf s(i) = "4" Then
                    color = Drawing.Color.DarkViolet
                Else
                    color = Drawing.Color.DeepPink
                End If

                Dim vertices As CustomVertex.TransformedColored() = New CustomVertex.TransformedColored(0 To 2) {} 'create an array of vertices
                vertices(0).Position = New Vector4(x, y, 0, 1)
                vertices(0).Color = color.ToArgb
                vertices(1).Position = New Vector4(x + pixelSize - carSizeSubtract, y, 0, 1)
                vertices(1).Color = color.ToArgb
                vertices(2).Position = New Vector4(x, y + pixelSize - carSizeSubtract, 0, 1)
                vertices(2).Color = color.ToArgb

                Dim vertices2 As CustomVertex.TransformedColored() = New CustomVertex.TransformedColored(0 To 2) {} 'create an array of vertices
                vertices2(0).Position = New Vector4(x, y + pixelSize - carSizeSubtract, 0, 1)
                vertices2(0).Color = color.ToArgb
                vertices2(1).Position = New Vector4(x + pixelSize - carSizeSubtract, y, 0, 1)
                vertices2(1).Color = color.ToArgb
                vertices2(2).Position = New Vector4(x + pixelSize - carSizeSubtract, y + pixelSize - carSizeSubtract, 0, 1)
                vertices2(2).Color = color.ToArgb


                If s(i) <> "0" Then
                    device.DrawUserPrimitives(PrimitiveType.TriangleList, 1, vertices)
                    device.DrawUserPrimitives(PrimitiveType.TriangleList, 1, vertices2)
                End If



                x = x + pixelSize

            Next

            s = TrafficSimulatorController.getTrafficRow(j)
            y = y + pixelSize
        Next

        'Sleep(1)
        TrafficSimulatorController.advanceTime()

        lblCarCountx1y4.Text = TrafficSimulatorController.getCarCount(0)
        lblCarCountx1y4.Refresh()

        lblCarCountx1y7.Text = TrafficSimulatorController.getCarCount(1)
        lblCarCountx1y7.Refresh()

        lblCarCountx1y10.Text = TrafficSimulatorController.getCarCount(2)
        lblCarCountx1y10.Refresh()

        lblCarCountx4y1.Text = TrafficSimulatorController.getCarCount(3)
        lblCarCountx4y1.Refresh()

        lblCarCountx4y13.Text = TrafficSimulatorController.getCarCount(4)
        lblCarCountx4y13.Refresh()

        lblCarCountx7y1.Text = TrafficSimulatorController.getCarCount(5)
        lblCarCountx7y1.Refresh()

        lblCarCountx7y13.Text = TrafficSimulatorController.getCarCount(6)
        lblCarCountx7y13.Refresh()

        lblCarCountx10y1.Text = TrafficSimulatorController.getCarCount(7)
        lblCarCountx10y1.Refresh()

        lblCarCountx10y13.Text = TrafficSimulatorController.getCarCount(8)
        lblCarCountx10y13.Refresh()

        lblCarCountx13y4.Text = TrafficSimulatorController.getCarCount(9)
        lblCarCountx13y4.Refresh()

        lblCarCountx13y7.Text = TrafficSimulatorController.getCarCount(10)
        lblCarCountx13y7.Refresh()

        lblCarCountx13y10.Text = TrafficSimulatorController.getCarCount(11)
        lblCarCountx13y10.Refresh()


        lblLightState0.Text = TrafficSimulatorController.debugGetTrafficLightState(0)
        lblLightState1.Text = TrafficSimulatorController.debugGetTrafficLightState(1)
        lblLightState2.Text = TrafficSimulatorController.debugGetTrafficLightState(2)
        lblLightState3.Text = TrafficSimulatorController.debugGetTrafficLightState(3)
        lblLightState4.Text = TrafficSimulatorController.debugGetTrafficLightState(4)
        lblLightState5.Text = TrafficSimulatorController.debugGetTrafficLightState(5)
        lblLightState6.Text = TrafficSimulatorController.debugGetTrafficLightState(6)
        lblLightState7.Text = TrafficSimulatorController.debugGetTrafficLightState(7)
        lblLightState8.Text = TrafficSimulatorController.debugGetTrafficLightState(8)
        lblTimeSinceChange.Text = TrafficSimulatorController.debugGetTrafficLightChangeTimer


        lblOutputNode0.Text = TrafficSimulatorController.debugGetANNOutput(0)
        lblOutputNode1.Text = TrafficSimulatorController.debugGetANNOutput(1)
        lblOutputNode2.Text = TrafficSimulatorController.debugGetANNOutput(2)
        lblOutputNode3.Text = TrafficSimulatorController.debugGetANNOutput(3)
        lblOutputNode4.Text = TrafficSimulatorController.debugGetANNOutput(4)
        lblOutputNode5.Text = TrafficSimulatorController.debugGetANNOutput(5)
        lblOutputNode6.Text = TrafficSimulatorController.debugGetANNOutput(6)
        lblOutputNode7.Text = TrafficSimulatorController.debugGetANNOutput(7)
        lblOutputNode8.Text = TrafficSimulatorController.debugGetANNOutput(8)

        lblANNWeights.Text = TrafficSimulatorController.debugGetANNWeights

        lblTimeElapsed.Text = TrafficSimulatorController.debugGetTimeElapsed
        lblTimeOfDay.Text = TrafficSimulatorController.debugGetTimeOfDay

        lblTotalCarCount.Text = TrafficSimulatorController.getCarCount
        lblTotalCarCount.Refresh()

        GroupBox1.Refresh()
        GroupBox2.Refresh()
        GroupBox3.Refresh()
        GroupBox4.Refresh()

        device.EndScene() 'all drawings before this line

        device.Present()
        Me.Invalidate() 'redraw
    End Sub


    Private Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Long)


End Class

