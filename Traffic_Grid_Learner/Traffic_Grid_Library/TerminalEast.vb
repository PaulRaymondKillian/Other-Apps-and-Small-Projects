Public Class TerminalEast
    Inherits EWStreet

    Private _carCount As Integer = 0
    Private _createCarRatio As Integer = 50
    Private _lanes() As Integer = {7, 8}
    Private _carID As Integer = 3

    Private Shadows _blockType As String = "TE"

    Public Property carCount() As Integer
        Get
            Return _carCount
        End Get
        Set(ByVal value As Integer)
            _carCount = value
        End Set
    End Property

    Public Property createCarRatio() As Integer
        Get
            Return _createCarRatio
        End Get
        Set(ByVal value As Integer)
            _createCarRatio = value
        End Set
    End Property


    Public Overrides Sub advanceEastBoundTraffic()
        For x As Integer = 16 To 19
            For y As Integer = 11 To 12
                If _TrafficBlock(x, y).carExist = True Then
                    _carCount = _carCount + 1
                    removeCarAtLocation(x, y)
                End If
            Next
        Next
    End Sub

    Public Sub chanceGenerateNewCar()

        If RandomNumber() > _createCarRatio Then
            Dim newCar As New Car(_carID, 2, Car.Direction.West)

            'There are 2 lanes, 50-50 chance the car will be put in either lane
            If RandomNumber() > 50 Then
                setCarAtLocation(newCar, 19, _lanes(0))
            Else
                setCarAtLocation(newCar, 19, _lanes(1))
            End If
        End If

    End Sub

End Class
