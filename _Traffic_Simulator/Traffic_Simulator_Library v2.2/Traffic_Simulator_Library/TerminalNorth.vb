Public Class TerminalNorth
    Inherits NSStreet

    Private _carCount As Integer = 0
    Private Const _createCarRatio As Integer = 50

    Public Property carCount() As Int32
        Get
            Return _carCount
        End Get
        Set(ByVal value As Integer)
            _carCount = value
        End Set
    End Property

    Public Overrides Sub advanceNorthBoundTraffic()
        For x As Integer = 5 To 6
            For y As Integer = 0 To 7
                If _TrafficBlock(x, y).carExist = True Then
                    _carCount = _carCount + 1
                    removeCarAtLocation(x, y)
                End If
            Next
        Next
    End Sub

    Public Sub chanceGenerateNewCar()

        If RandomNumber() > _createCarRatio Then
            Dim newCar As New Car(4, 2, Car.Direction.South)
            If RandomNumber() > 50 Then
                setCarAtLocation(newCar, 1, 0)
            Else
                setCarAtLocation(newCar, 2, 0)
            End If
        End If

    End Sub

End Class
