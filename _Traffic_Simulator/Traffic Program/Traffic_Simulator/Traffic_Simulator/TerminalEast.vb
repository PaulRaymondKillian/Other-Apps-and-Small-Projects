Public Class TerminalEast
    Inherits EWStreet

    Private _carCount As Integer = 0
    Private Const _createCarRatio As Integer = 50

    Public ReadOnly Property carCount() As Integer
        Get
            Return _carCount
        End Get
    End Property

    Public Overrides Sub advanceEastBoundTraffic()
        For x As Integer = 0 To 7
            For y As Integer = 5 To 6
                If _TrafficBlock(x, y).carExist = True Then
                    _carCount = _carCount + 1
                    removeCarAtLocation(x, y)
                End If
            Next
        Next
    End Sub

    Public Sub chanceGenerateNewCar()

        If RandomNumber() > _createCarRatio Then
            Dim newCar As New Car(1, 2)
            If RandomNumber() > 50 Then
                setCarAtLocation(newCar, 7, 1)
            Else
                setCarAtLocation(newCar, 7, 2)
            End If
        End If

    End Sub

End Class
