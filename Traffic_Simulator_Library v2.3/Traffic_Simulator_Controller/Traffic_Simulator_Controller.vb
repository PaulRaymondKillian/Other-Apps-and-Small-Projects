Public Class Traffic_Simulator_Controller
    Dim TrafficGrid As New Traffic_Simulator_Library.TrafficGrid
    Dim ArtificialNeuralNetwork As New ArtificialNeuralNetwork10x10x10x9.ArtificialNeuralNetwork10x10x10x9

    Dim trafficLightChangeTimer As Integer
    Dim newTrafficLightStates(9) As Integer

    Public Sub New()
        Dim initialLightStates(9) As Integer
        Dim initialWeights(319) As Integer
        trafficLightChangeTimer = 0

        For i As Integer = 0 To 318
            initialWeights(i) = 0
        Next

        setANNInputNodes(TrafficGrid.getTrafficLightState(0), TrafficGrid.getTrafficLightState(1), TrafficGrid.getTrafficLightState(2), TrafficGrid.getTrafficLightState(3), TrafficGrid.getTrafficLightState(4), TrafficGrid.getTrafficLightState(5), TrafficGrid.getTrafficLightState(6), TrafficGrid.getTrafficLightState(7), TrafficGrid.getTrafficLightState(8), trafficLightChangeTimer)

    End Sub

    Public Sub resetTrafficGrid()

        TrafficGrid = Nothing

        TrafficGrid = New Traffic_Simulator_Library.TrafficGrid

        TrafficGrid.resetCarCount()

    End Sub

    Public Sub setANNWeights(ByRef weightsArr() As Double)
        ArtificialNeuralNetwork.setWeights(weightsArr)
    End Sub

    Public Sub setANNInputNodes(ByVal i1 As Double, ByVal i2 As Double, ByVal i3 As Double, ByVal i4 As Double, ByVal i5 As Double, ByVal i6 As Double, ByVal i7 As Double, ByVal i8 As Double, ByVal i9 As Double, ByVal i10 As Double)
        ArtificialNeuralNetwork.setInputNodes(i1, i2, i3, i4, i5, i6, i7, i8, i9, i10)
    End Sub

    Public Sub advanceTime()
        Dim x As Integer
        TrafficGrid.advanceTime()
        trafficLightChangeTimer = trafficLightChangeTimer + 1

        If (TrafficGrid.getTimeElapsed Mod 10 = 0) Then

            For i As Integer = 0 To 8
                x = ArtificialNeuralNetwork.calculateOutput(i)
                If (x > 0) Then
                    newTrafficLightStates(i) = 1
                ElseIf (x <= 0) Then
                    newTrafficLightStates(i) = -1
                Else
                    MsgBox("You Should Never Get Here - Class: Traffic_Simulator_Controller  Method: advanceTime")
                End If
            Next

            For i As Integer = 0 To 8
                If newTrafficLightStates(i) <> TrafficGrid.getTrafficLightState(i) Then
                    TrafficGrid.changeTrafficLight(i)
                    trafficLightChangeTimer = 0
                End If
            Next

            ArtificialNeuralNetwork.setInputNodes(newTrafficLightStates(0), newTrafficLightStates(1), newTrafficLightStates(2), newTrafficLightStates(3), newTrafficLightStates(4), newTrafficLightStates(5), newTrafficLightStates(6), newTrafficLightStates(7), newTrafficLightStates(8), trafficLightChangeTimer)
        End If
    End Sub

    Public Function runSimulation(ByVal s As Integer) As Integer
        For i As Integer = 0 To s
            advanceTime()
        Next

        Return getCarCount()

    End Function

    Public Function getCarCount() As Integer
        Return TrafficGrid.getCarCount
    End Function

    Public Function getCarCount(ByVal i As Integer) As Integer
        Return TrafficGrid.getCarCount(i)
    End Function

    Public Function getTrafficRow(ByVal i As Integer) As String
        Return TrafficGrid.returnGridRow(i)
    End Function

    Public Sub writeWeightsToFile()
        ArtificialNeuralNetwork.writeWeightsToFile()
    End Sub

    Public Sub readWeightsfromFile()
        ArtificialNeuralNetwork.readWeightsFromFile()
    End Sub

    Public Sub debugChangeLight(ByVal i As Integer)
        TrafficGrid.changeTrafficLight(i)
    End Sub
    Public Function debugGetTrafficLightState(ByVal i As Integer) As Integer
        Return TrafficGrid.getTrafficLightState(i)
    End Function
    Public Function debugGetTrafficLightChangeTimer() As Integer
        Return trafficLightChangeTimer
    End Function
    Public Function debugGetANNOutput(ByVal i As Integer) As Integer
        Return ArtificialNeuralNetwork.calculateOutput(i)
    End Function

    Public Function debugGetANNWeights() As String
        Return ArtificialNeuralNetwork.outputWeights
    End Function
    Public Function debugGetTimeElapsed() As Integer
        Return TrafficGrid.getTimeElapsed
    End Function
    Public Function debugGetTimeOfDay() As Integer
        Return TrafficGrid.getTimeOfDay
    End Function

End Class
