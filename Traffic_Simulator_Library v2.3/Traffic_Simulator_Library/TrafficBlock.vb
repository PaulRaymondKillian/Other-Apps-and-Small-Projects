Public MustInherit Class TrafficBlock

    Protected _TrafficBlock(7, 7) As Car

    Protected _linkNorth As TrafficBlock
    Protected _linkSouth As TrafficBlock
    Protected _linkEast As TrafficBlock
    Protected _linkWest As TrafficBlock


    Public Sub New()
        For y As Integer = 0 To 7
            For x As Integer = 0 To 7
                _TrafficBlock(x, y) = New Car
            Next
        Next
    End Sub

    Public Function isCarAtLocation(ByVal x As Integer, ByVal y As Integer) As Boolean

        Return _TrafficBlock(x, y).carExist

    End Function

    Public Function getCarIdAtLocation(ByVal x As Integer, ByVal y As Integer)

        Return _TrafficBlock(x, y).carId

    End Function

    Public Function getCarAtLocation(ByVal x As Integer, ByVal y As Integer)
        Return _TrafficBlock(x, y)
    End Function

    Public Sub increaseCarSpeedAtLocation(ByVal x As Integer, ByVal y As Integer)
        _TrafficBlock(x, y).carSpeed = _TrafficBlock(x, y).carSpeed + 1
    End Sub

    Public Sub decreaseCarSpeedAtLocation(ByVal x As Integer, ByVal y As Integer)
        _TrafficBlock(x, y).carSpeed = _TrafficBlock(x, y).carSpeed - 1
    End Sub

    Public Sub stopCarSpeedAtLocation(ByVal x As Integer, ByVal y As Integer)
        _TrafficBlock(x, y).carSpeed = 0
    End Sub


    Public Sub setCarAtLocation(ByVal car As Car, ByVal x As Integer, ByVal y As Integer)
        Dim tempCar = New Car
        tempCar.carId = car.carId
        tempCar.carExist = car.carExist
        tempCar.carSpeed = car.carSpeed
        tempCar.carDirection = car.carDirection
        _TrafficBlock(x, y) = tempCar
    End Sub

    Public Sub setCarAtPosition(ByVal car As Car, ByVal lanePosition As Integer)
        Dim tempCar As Car = New Car
        tempCar = car

        Select Case lanePosition
            Case 1
                _TrafficBlock(4, 0) = tempCar
            Case 2
                _TrafficBlock(5, 0) = tempCar
            Case 3
                _TrafficBlock(6, 4) = tempCar
            Case 4
                _TrafficBlock(6, 5) = tempCar
            Case 5
                _TrafficBlock(2, 6) = tempCar
            Case 6
                _TrafficBlock(1, 6) = tempCar
            Case 7
                _TrafficBlock(0, 2) = tempCar
            Case 8
                _TrafficBlock(0, 1) = tempCar
        End Select
    End Sub

    Public Sub removeCarAtLocation(ByVal x As Integer, ByVal y As Integer)
        Dim tempCar = New Car
        tempCar.carId = 8
        _TrafficBlock(x, y) = tempCar
    End Sub

    Public Sub setlinkNorth(ByRef trafficBlock As TrafficBlock)
        _linkNorth = trafficBlock
    End Sub

    Public Sub setlinkSouth(ByRef trafficBlock As TrafficBlock)
        _linkSouth = trafficBlock
    End Sub

    Public Sub setlinkEast(ByRef trafficBlock As TrafficBlock)
        _linkEast = trafficBlock
    End Sub

    Public Sub setlinkWest(ByRef trafficBlock As TrafficBlock)
        _linkWest = trafficBlock
    End Sub

    Public Overridable Function isGreenLightEastWest()
        Return True
    End Function

    Public Overridable Function isGreenLightNorthSouth()
        Return True
    End Function

    Public MustOverride Sub advanceEastBoundTraffic()
    Public MustOverride Sub advanceWestBoundTraffic()
    Public MustOverride Sub advanceNorthBoundTraffic()
    Public MustOverride Sub advanceSouthBoundTraffic()

    Public Function RandomNumber() As Integer
        Randomize(System.DateTime.Now.Millisecond)
        RandomNumber = Int(Rnd() * 100)
    End Function



End Class
