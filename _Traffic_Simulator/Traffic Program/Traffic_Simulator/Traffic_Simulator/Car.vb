Public Class Car
    Private _carId As Integer
    Private _carSpeed As Integer
    Private _carExist As Boolean
    Private _carDirection As Direction

    Enum Direction
        East = 0
        South = 1
        West = 2
        North = 3
    End Enum

    Public Property carDirection() As Direction
        Get
            Return _carDirection
        End Get
        Set(ByVal value As Direction)
            _carDirection = value
        End Set
    End Property

    Public Property carId() As Int32
        Get
            Return _carId
        End Get
        Set(ByVal Value As Int32)
            _carId = Value
        End Set
    End Property

    Public Property carSpeed() As Int32
        Get
            Return _carSpeed
        End Get
        Set(ByVal Value As Int32)
            _carSpeed = Value
        End Set
    End Property

    Public Property carExist() As Boolean
        Get
            Return _carExist
        End Get
        Set(ByVal Value As Boolean)
            _carExist = Value
        End Set
    End Property

    'Parameterless Constructor
    Public Sub New()
        _carId = 0
        _carExist = False
        _carSpeed = 0
    End Sub

    Public Sub New(ByVal carId As Integer, ByVal carSpeed As Integer)
        _carId = carId
        _carExist = True
        _carSpeed = carSpeed
    End Sub

    Public Sub New(ByVal carId As Integer, ByVal carSpeed As Integer, ByVal carDirection As Direction)
        _carId = carId
        _carExist = True
        _carSpeed = carSpeed
        _carDirection = carDirection
    End Sub

    Public Sub New(ByVal car As Car)
        _carId = car.carId
        _carExist = car.carExist
        _carSpeed = car.carSpeed
    End Sub

End Class
