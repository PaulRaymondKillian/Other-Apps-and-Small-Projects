Public Class Intersection
    Inherits TrafficBlock

    Private _TrafficLight As Integer = 2
    Private _TrafficLightYellowTimer As Integer = 0

    Enum GreenLight
        NorthSouth = 0
        NorthSouthYellow = 1
        EastWest = 2
        EastWestYellow = 3
    End Enum

    Public Sub updateTrafficLight()

        If _TrafficLightYellowTimer <> 0 Then
            _TrafficLightYellowTimer = _TrafficLightYellowTimer - 1
        ElseIf _TrafficLightYellowTimer = 0 And _TrafficLight = GreenLight.EastWestYellow Then
            _TrafficLight = GreenLight.NorthSouth
        ElseIf _TrafficLightYellowTimer = 0 And _TrafficLight = GreenLight.NorthSouthYellow Then
            _TrafficLight = GreenLight.EastWest
        End If

    End Sub

    Public Sub New()
        For y As Integer = 0 To 7
            For x As Integer = 0 To 7
                _TrafficBlock(x, y) = New Car

                If y = 1 Or y = 2 Or y = 5 Or y = 6 Or x = 1 Or x = 2 Or x = 5 Or x = 6 Then
                    _TrafficBlock(x, y).carId = 8
                End If

            Next
        Next

    End Sub


    'Public Sub setGreenLightNorthSouth()
    '    _TrafficLight = GreenLight.NorthSouth
    'End Sub

    'Public Sub setGreenLightEastWest()
    '    _TrafficLight = GreenLight.EastWest
    'End Sub

    'Public Sub setGreenLightNorthSouth()
    '    _TrafficBlock(0, 5).carExist = True
    '    _TrafficBlock(0, 5).carId = 9

    '    _TrafficBlock(0, 6).carExist = True
    '    _TrafficBlock(0, 6).carId = 9

    '    _TrafficBlock(7, 1).carExist = True
    '    _TrafficBlock(7, 1).carId = 9

    '    _TrafficBlock(7, 2).carExist = True
    '    _TrafficBlock(7, 2).carId = 9


    '    _TrafficBlock(1, 0).carExist = False
    '    _TrafficBlock(1, 0).carId = 8

    '    _TrafficBlock(2, 0).carExist = False
    '    _TrafficBlock(2, 0).carId = 8

    '    _TrafficBlock(5, 7).carExist = False
    '    _TrafficBlock(5, 7).carId = 8

    '    _TrafficBlock(6, 7).carExist = False
    '    _TrafficBlock(6, 7).carId = 8

    'End Sub

    'Public Sub setGreenLightEastWest()

    '    _TrafficBlock(0, 5).carExist = False
    '    _TrafficBlock(0, 5).carId = 8

    '    _TrafficBlock(0, 6).carExist = False
    '    _TrafficBlock(0, 6).carId = 8

    '    _TrafficBlock(7, 1).carExist = False
    '    _TrafficBlock(7, 1).carId = 8

    '    _TrafficBlock(7, 2).carExist = False
    '    _TrafficBlock(7, 2).carId = 8


    '    _TrafficBlock(1, 0).carExist = True
    '    _TrafficBlock(1, 0).carId = 9

    '    _TrafficBlock(2, 0).carExist = True
    '    _TrafficBlock(2, 0).carId = 9

    '    _TrafficBlock(5, 7).carExist = True
    '    _TrafficBlock(5, 7).carId = 9

    '    _TrafficBlock(6, 7).carExist = True
    '    _TrafficBlock(6, 7).carId = 9

    'End Sub


    Public Sub changeTrafficLight()

        If _TrafficLight = GreenLight.EastWest Or _TrafficLight = GreenLight.EastWestYellow Then
            _TrafficLight = GreenLight.EastWestYellow
            _TrafficLightYellowTimer = 16
        ElseIf _TrafficLight = GreenLight.NorthSouth Or _TrafficLight = GreenLight.NorthSouthYellow Then
            _TrafficLight = GreenLight.NorthSouthYellow
            _TrafficLightYellowTimer = 16
        Else
            MsgBox("Error changeTrafficLight() of Intersection Class - You Should Never Reach This Point")
        End If

        'If _TrafficLight = GreenLight.EastWest Then
        '    _TrafficLight = GreenLight.NorthSouth
        '    setGreenLightNorthSouth()
        'ElseIf _TrafficLight = GreenLight.NorthSouth Then
        '    _TrafficLight = GreenLight.EastWest
        '    setGreenLightEastWest()
        'End If
    End Sub

    Public Overrides Function isGreenLightEastWest() As Object
        If _TrafficLight = GreenLight.EastWest Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Overrides Function isGreenLightNorthSouth() As Object
        If _TrafficLight = GreenLight.NorthSouth Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Overrides Sub advanceEastBoundTraffic()

        updateTrafficLight()

        Dim lane As Integer = 5

        For j As Integer = 0 To 1

            For x As Integer = 7 To 0 Step -1

                If _TrafficBlock(x, lane).carExist = True And (_TrafficLight = GreenLight.EastWest Or _TrafficLight = GreenLight.EastWestYellow) Then
                    If x = 7 And _TrafficBlock(x, lane).carSpeed = 2 Then
                        If _linkEast.isCarAtLocation(1, lane) = False And _linkEast.isCarAtLocation(0, lane) = False Then
                            _linkEast.setCarAtLocation(_TrafficBlock(x, lane), 1, lane)
                            removeCarAtLocation(x, lane)
                        ElseIf _linkEast.isCarAtLocation(0, lane) = False Then
                            _linkEast.setCarAtLocation(_TrafficBlock(x, lane), 0, lane)
                            removeCarAtLocation(x, lane)
                        Else
                            _TrafficBlock(x, lane).carSpeed = 0
                        End If
                    ElseIf x = 7 And _TrafficBlock(x, lane).carSpeed < 2 Then
                        If _linkEast.isCarAtLocation(0, lane) = False Then
                            _linkEast.setCarAtLocation(_TrafficBlock(x, lane), 0, lane)
                            _linkEast.increaseCarSpeedAtLocation(0, lane)
                            removeCarAtLocation(x, lane)
                        Else
                            stopCarSpeedAtLocation(x, lane)
                        End If
                    ElseIf x = 6 And _TrafficBlock(x, lane).carSpeed = 2 Then
                        If _linkEast.isCarAtLocation(0, lane) = False And _TrafficBlock(7, lane).carExist = False Then
                            _linkEast.setCarAtLocation(_TrafficBlock(x, lane), 0, lane)
                            removeCarAtLocation(x, lane)
                        ElseIf _TrafficBlock(7, lane).carExist = False Then
                            setCarAtLocation(_TrafficBlock(x, lane), 7, lane)
                            removeCarAtLocation(x, lane)
                            decreaseCarSpeedAtLocation(7, lane)
                        Else
                            stopCarSpeedAtLocation(x, lane)
                        End If
                    ElseIf x = 6 And _TrafficBlock(x, lane).carSpeed < 2 Then
                        If _TrafficBlock(x + 1, lane).carExist = False Then
                            setCarAtLocation(_TrafficBlock(x, lane), 7, lane)
                            increaseCarSpeedAtLocation(7, lane)
                            removeCarAtLocation(x, lane)
                        Else
                            stopCarSpeedAtLocation(x, lane)
                        End If
                    Else
                        If _TrafficBlock(x + 1, lane).carExist = False And _TrafficBlock(x + 2, lane).carExist = False And _TrafficBlock(x, lane).carSpeed = 2 Then
                            setCarAtLocation(_TrafficBlock(x, lane), x + 2, lane)
                            removeCarAtLocation(x, lane)
                        ElseIf _TrafficBlock(x + 1, lane).carExist = False And _TrafficBlock(x, lane).carSpeed = 2 Then
                            setCarAtLocation(_TrafficBlock(x, lane), x + 1, lane)
                            removeCarAtLocation(x, lane)
                            decreaseCarSpeedAtLocation(x + 1, lane)
                        ElseIf _TrafficBlock(x + 1, lane).carExist = False And _TrafficBlock(x, lane).carSpeed < 2 Then
                            setCarAtLocation(_TrafficBlock(x, lane), x + 1, lane)
                            removeCarAtLocation(x, lane)
                            increaseCarSpeedAtLocation(x + 1, lane)
                        Else
                            stopCarSpeedAtLocation(x, lane)
                        End If

                    End If
                End If

            Next

            lane = lane + 1

        Next

    End Sub


    Public Overrides Sub advanceNorthBoundTraffic()

        updateTrafficLight()

        Dim lane As Integer = 5

        For j As Integer = 0 To 2

            For y As Integer = 0 To 7 Step 1

                If _TrafficBlock(lane, y).carExist = True And (_TrafficLight = GreenLight.NorthSouth Or _TrafficLight = GreenLight.NorthSouthYellow) Then
                    If y = 0 And _TrafficBlock(lane, y).carSpeed = 2 Then
                        If _linkNorth.isCarAtLocation(lane, 6) = False And _linkNorth.isCarAtLocation(lane, 7) = False And _linkNorth.isGreenLightNorthSouth() = True Then
                            _linkNorth.setCarAtLocation(_TrafficBlock(lane, y), lane, 6)
                            removeCarAtLocation(lane, y)
                        ElseIf _linkNorth.isCarAtLocation(lane, 7) = False And _linkNorth.isGreenLightNorthSouth() = True Then
                            _linkNorth.setCarAtLocation(_TrafficBlock(lane, y), lane, 7)
                            removeCarAtLocation(lane, y)
                        Else
                            _TrafficBlock(lane, y).carSpeed = 0
                        End If
                    ElseIf y = 0 And _TrafficBlock(lane, y).carSpeed < 2 Then
                        If _linkNorth.isCarAtLocation(lane, 7) = False And _linkNorth.isGreenLightNorthSouth() = True Then
                            _linkNorth.setCarAtLocation(_TrafficBlock(lane, y), lane, 7)
                            _linkNorth.increaseCarSpeedAtLocation(lane, 7)
                            removeCarAtLocation(lane, y)
                        Else
                            stopCarSpeedAtLocation(lane, y)
                        End If
                    ElseIf y = 1 And _TrafficBlock(lane, y).carSpeed = 2 Then
                        If _linkNorth.isCarAtLocation(lane, 7) = False And _TrafficBlock(lane, 0).carExist = False And _linkNorth.isGreenLightNorthSouth() = True Then
                            _linkNorth.setCarAtLocation(_TrafficBlock(lane, y), lane, 7)
                            removeCarAtLocation(lane, y)
                        ElseIf _TrafficBlock(lane, 0).carExist = False Then
                            setCarAtLocation(_TrafficBlock(lane, y), lane, 0)
                            removeCarAtLocation(lane, y)
                            decreaseCarSpeedAtLocation(lane, 0)
                        Else
                            stopCarSpeedAtLocation(lane, y)
                        End If
                    ElseIf y = 1 And _TrafficBlock(lane, y).carSpeed < 2 Then
                        If _TrafficBlock(lane, y - 1).carExist = False Then
                            setCarAtLocation(_TrafficBlock(lane, y), lane, 0)
                            increaseCarSpeedAtLocation(lane, 0)
                            removeCarAtLocation(lane, y)
                        Else
                            stopCarSpeedAtLocation(lane, y)
                        End If
                    Else
                        If _TrafficBlock(lane, y - 1).carExist = False And _TrafficBlock(lane, y - 2).carExist = False And _TrafficBlock(lane, y).carSpeed = 2 Then
                            setCarAtLocation(_TrafficBlock(lane, y), lane, y - 2)
                            removeCarAtLocation(lane, y)
                        ElseIf _TrafficBlock(lane, y - 1).carExist = False And _TrafficBlock(lane, y).carSpeed = 2 Then
                            setCarAtLocation(_TrafficBlock(lane, y), lane, y - 1)
                            removeCarAtLocation(lane, y)
                            decreaseCarSpeedAtLocation(lane, y - 1)
                        ElseIf _TrafficBlock(lane, y - 1).carExist = False And _TrafficBlock(lane, y).carSpeed < 2 Then
                            setCarAtLocation(_TrafficBlock(lane, y), lane, y - 1)
                            removeCarAtLocation(lane, y)
                            increaseCarSpeedAtLocation(lane, y - 1)
                        Else
                            stopCarSpeedAtLocation(lane, y)
                        End If
                    End If

                End If

            Next

            lane = lane + 1

        Next

    End Sub

    Public Overrides Sub advanceSouthBoundTraffic()

        updateTrafficLight()

        Dim lane As Integer = 1

        For j As Integer = 0 To 2

            For y As Integer = 7 To 0 Step -1

                If _TrafficBlock(lane, y).carExist = True And (_TrafficLight = GreenLight.NorthSouth Or _TrafficLight = GreenLight.NorthSouthYellow) Then
                    If y = 7 And _TrafficBlock(lane, y).carSpeed = 2 Then
                        If _linkSouth.isCarAtLocation(lane, 1) = False And _linkSouth.isCarAtLocation(lane, 0) = False And _linkSouth.isGreenLightNorthSouth = True Then
                            _linkSouth.setCarAtLocation(_TrafficBlock(lane, y), lane, 1)
                            removeCarAtLocation(lane, y)
                        ElseIf _linkSouth.isCarAtLocation(lane, 0) = False And _linkSouth.isGreenLightNorthSouth = True Then
                            _linkSouth.setCarAtLocation(_TrafficBlock(lane, y), lane, 0)
                            removeCarAtLocation(lane, y)
                        Else
                            _TrafficBlock(lane, y).carSpeed = 0
                        End If
                    ElseIf y = 7 And _TrafficBlock(lane, y).carSpeed < 2 Then
                        If _linkSouth.isCarAtLocation(lane, 0) = False And _linkSouth.isGreenLightNorthSouth = True Then
                            _linkSouth.setCarAtLocation(_TrafficBlock(lane, y), lane, 0)
                            _linkSouth.increaseCarSpeedAtLocation(lane, 0)
                            removeCarAtLocation(lane, y)
                        Else
                            stopCarSpeedAtLocation(lane, y)
                        End If
                    ElseIf y = 6 And _TrafficBlock(lane, y).carSpeed = 2 Then
                        If _linkSouth.isCarAtLocation(lane, 0) = False And _TrafficBlock(lane, 7).carExist = False And _linkSouth.isGreenLightNorthSouth = True Then
                            _linkSouth.setCarAtLocation(_TrafficBlock(lane, y), lane, 0)
                            removeCarAtLocation(lane, y)
                        ElseIf _TrafficBlock(lane, 7).carExist = False Then
                            setCarAtLocation(_TrafficBlock(lane, y), lane, 7)
                            removeCarAtLocation(lane, y)
                            decreaseCarSpeedAtLocation(lane, 7)
                        Else
                            stopCarSpeedAtLocation(lane, y)
                        End If
                    ElseIf y = 6 And _TrafficBlock(lane, y).carSpeed < 2 Then
                        If _TrafficBlock(lane, y + 1).carExist = False Then
                            setCarAtLocation(_TrafficBlock(lane, y), lane, 7)
                            increaseCarSpeedAtLocation(lane, 7)
                            removeCarAtLocation(lane, y)
                        Else
                            stopCarSpeedAtLocation(lane, y)
                        End If
                    Else
                        If _TrafficBlock(lane, y + 1).carExist = False And _TrafficBlock(lane, y + 2).carExist = False And _TrafficBlock(lane, y).carSpeed = 2 Then
                            setCarAtLocation(_TrafficBlock(lane, y), lane, y + 2)
                            removeCarAtLocation(lane, y)
                        ElseIf _TrafficBlock(lane, y + 1).carExist = False And _TrafficBlock(lane, y).carSpeed = 2 Then
                            setCarAtLocation(_TrafficBlock(lane, y), lane, y + 1)
                            removeCarAtLocation(lane, y)
                            decreaseCarSpeedAtLocation(lane, y + 1)
                        ElseIf _TrafficBlock(lane, y + 1).carExist = False And _TrafficBlock(lane, y).carSpeed < 2 Then
                            setCarAtLocation(_TrafficBlock(lane, y), lane, y + 1)
                            removeCarAtLocation(lane, y)
                            increaseCarSpeedAtLocation(lane, y + 1)
                        Else
                            stopCarSpeedAtLocation(lane, y)
                        End If
                    End If

                End If

            Next

            lane = lane + 1

        Next

    End Sub


    Public Overrides Sub advanceWestBoundTraffic()

        updateTrafficLight()

        Dim lane As Integer = 1

        For j As Integer = 0 To 1

            For x As Integer = 0 To 7 Step 1

                If _TrafficBlock(x, lane).carExist = True And (_TrafficLight = GreenLight.EastWest Or _TrafficLight = GreenLight.EastWestYellow) Then
                    If x = 0 And _TrafficBlock(x, lane).carSpeed = 2 Then
                        If _linkWest.isCarAtLocation(6, lane) = False And _linkWest.isCarAtLocation(7, lane) = False Then
                            _linkWest.setCarAtLocation(_TrafficBlock(x, lane), 6, lane)
                            removeCarAtLocation(x, lane)
                        ElseIf _linkWest.isCarAtLocation(7, lane) = False Then
                            _linkWest.setCarAtLocation(_TrafficBlock(x, lane), 7, lane)
                            removeCarAtLocation(x, lane)
                        Else
                            _TrafficBlock(x, lane).carSpeed = 0
                        End If
                    ElseIf x = 0 And _TrafficBlock(x, lane).carSpeed < 2 Then
                        If _linkWest.isCarAtLocation(7, lane) = False Then
                            _linkWest.setCarAtLocation(_TrafficBlock(x, lane), 7, lane)
                            _linkWest.increaseCarSpeedAtLocation(7, lane)
                            removeCarAtLocation(x, lane)
                        Else
                            stopCarSpeedAtLocation(x, lane)
                        End If
                    ElseIf x = 1 And _TrafficBlock(x, lane).carSpeed = 2 Then
                        If _linkWest.isCarAtLocation(7, lane) = False And _TrafficBlock(0, lane).carExist = False Then
                            _linkWest.setCarAtLocation(_TrafficBlock(x, lane), 7, lane)
                            removeCarAtLocation(x, lane)
                        ElseIf _TrafficBlock(0, lane).carExist = False Then
                            setCarAtLocation(_TrafficBlock(x, lane), 0, lane)
                            removeCarAtLocation(x, lane)
                            decreaseCarSpeedAtLocation(0, lane)
                        Else
                            stopCarSpeedAtLocation(x, lane)
                        End If
                    ElseIf x = 1 And _TrafficBlock(x, lane).carSpeed = 1 Then
                        If _TrafficBlock(x - 1, lane).carExist = False Then
                            setCarAtLocation(_TrafficBlock(x, lane), 0, lane)
                            increaseCarSpeedAtLocation(0, lane)
                            removeCarAtLocation(x, lane)
                        Else
                            stopCarSpeedAtLocation(x, lane)
                        End If
                    Else
                        If _TrafficBlock(x - 1, lane).carExist = False And _TrafficBlock(x - 2, lane).carExist = False And _TrafficBlock(x, lane).carSpeed = 2 Then
                            setCarAtLocation(_TrafficBlock(x, lane), x - 2, lane)
                            removeCarAtLocation(x, lane)
                        ElseIf _TrafficBlock(x - 1, lane).carExist = False And _TrafficBlock(x, lane).carSpeed = 2 Then
                            setCarAtLocation(_TrafficBlock(x, lane), x - 1, lane)
                            removeCarAtLocation(x, lane)
                            decreaseCarSpeedAtLocation(x - 1, lane)
                        ElseIf _TrafficBlock(x - 1, lane).carExist = False And _TrafficBlock(x, lane).carSpeed < 2 Then
                            setCarAtLocation(_TrafficBlock(x, lane), x - 1, lane)
                            removeCarAtLocation(x, lane)
                            increaseCarSpeedAtLocation(x - 1, lane)
                        Else
                            stopCarSpeedAtLocation(x, lane)
                        End If

                    End If
                End If

            Next

            lane = lane + 1

        Next

    End Sub
End Class
