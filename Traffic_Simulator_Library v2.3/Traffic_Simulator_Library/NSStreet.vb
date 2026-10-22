Public Class NSStreet
    Inherits TrafficBlock


    Public Sub New()
        For y As Integer = 0 To 7
            For x As Integer = 0 To 7
                _TrafficBlock(x, y) = New Car

                If x = 1 Or x = 2 Or x = 5 Or x = 6 Then
                    _TrafficBlock(x, y).carId = 8
                End If

            Next
        Next
    End Sub


    Public Overrides Sub advanceEastBoundTraffic()

        MsgBox("Method Call: advanceEastBoundTraffic() - NSStreet has no East Bound Traffic")

    End Sub

    Public Overrides Sub advanceWestBoundTraffic()

        MsgBox("Method Call: advanceWestBoundTraffic() - NSStreet has no West Bound Traffic")

    End Sub

    Public Overrides Sub advanceNorthBoundTraffic()

        Dim lane As Integer = 5

        For j As Integer = 0 To 2

            For y As Integer = 0 To 7 Step 1

                If _TrafficBlock(lane, y).carExist = True Then
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

        Dim lane As Integer = 1

        For j As Integer = 0 To 2

            For y As Integer = 7 To 0 Step -1

                If _TrafficBlock(lane, y).carExist = True Then
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


End Class

