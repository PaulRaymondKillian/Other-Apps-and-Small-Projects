Public Class TrafficLight

    Private _currentLightState As New TrafficLightState
    Private _nextLightState As New TrafficLightState
    Private _yellowLightTimer As New Integer


    Public Property currentLightState() As TrafficLightState
        Get
            Return _currentLightState
        End Get
        Set(ByVal value As TrafficLightState)
            _currentLightState = value
        End Set
    End Property

    Public Property nextLightState() As TrafficLightState
        Get
            Return _nextLightState
        End Get
        Set(ByVal value As TrafficLightState)
            _nextLightState = value
        End Set
    End Property

    Enum TrafficLightState

        NorthSouthGreen = 0
        YellowLight = 1 '**Note on Yellow Light Below
        EastWestGreen = 2

        'Yellow Light should be used so that no new cars can 'enter' the intersection, but
        'otherwise the traffic flow's regularly. As long as no new cars enter the intersection,
        'all the other cars can remain in motion without worry of collisions or other errors
    End Enum

    Public Sub New()
        Dim rand As Integer
        rand = RandomNumber() Mod 3

        _currentLightState = rand
        _nextLightState = rand
        _yellowLightTimer = 0

    End Sub

    Public Sub updateLightState(ByVal nextState As TrafficLightState)

        If nextState <> _nextLightState Then
            _nextLightState = nextState
            _currentLightState = TrafficLightState.YellowLight
            resetYellowLightTimer()

            'If _currentLightState <> TrafficLightState.YellowLight Then
            '    _currentLightState = TrafficLightState.YellowLight
            '    resetYellowLightTimer()
            'End If

        End If
    End Sub

    Public Sub advanceTime()

    End Sub

    Private Sub resetYellowLightTimer()
        _yellowLightTimer = 5
    End Sub

    Public Function RandomNumber() As Integer
        Randomize(System.DateTime.Now.Millisecond)
        RandomNumber = Int(Rnd() * 100)
    End Function

End Class
