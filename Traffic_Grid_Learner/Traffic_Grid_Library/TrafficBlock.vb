Public MustInherit Class TrafficBlock
    Protected _TrafficBlock(19, 19) As Car

    Public _linkNorth As TrafficBlock
    Public _linkSouth As TrafficBlock
    Public _linkEast As TrafficBlock
    Public _linkWest As TrafficBlock

    Public _blockName As String = ""
    Public _blockType As String = "N/A"

    Public Property blockName() As String
        Get
            Return _blockName
        End Get
        Set(ByVal value As String)
            _blockName = value
        End Set
    End Property

    Public Property blockType() As String
        Get
            Return _blockType
        End Get
        Set(ByVal value As String)
            _blockType = value
        End Set
    End Property


    Public Sub New()
        For y As Integer = 0 To 19
            For x As Integer = 0 To 19
                _TrafficBlock(x, y) = New Car
            Next
        Next
    End Sub


    Public Function isCarAtLocation(ByVal x As Integer, ByVal y As Integer) As Boolean
        Return _TrafficBlock(x, y).carExist
    End Function

    Public Function getCarIdAtLocation(ByVal x As Integer, ByVal y As Integer) As Integer
        Return _TrafficBlock(x, y).carId
    End Function

    Public Function getCarDirectionAtLocation(ByVal x As Integer, ByVal y As Integer) As Car.Direction
        Return _TrafficBlock(x, y).carDirection
    End Function

    Public Function getCarSpeedAtLocation(ByVal x As Integer, ByVal y As Integer) As Integer
        Return _TrafficBlock(x, y).carSpeed
    End Function

    Public Function getCarWasMovedAlreadyAtLocation(ByVal x As Integer, ByVal y As Integer) As Boolean
        Return _TrafficBlock(x, y).carWasMovedAlready
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
        tempCar.carWasMovedAlready = car.carWasMovedAlready
        _TrafficBlock(x, y) = tempCar
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

