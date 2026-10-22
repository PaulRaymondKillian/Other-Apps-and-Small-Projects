Public Class EWStreet
    Inherits TrafficBlock


    Public Sub New()
        For y As Integer = 0 To 7
            For x As Integer = 0 To 7
                _TrafficBlock(x, y) = New Car

                If y = 1 Or y = 2 Or y = 5 Or y = 6 Then
                    _TrafficBlock(x, y).carId = 8
                End If

            Next
        Next
    End Sub


    Public Overrides Sub advanceEastBoundTraffic()

        Dim lane As Integer = 5

        For j As Integer = 0 To 2

            For x As Integer = 7 To 0 Step -1

                If _TrafficBlock(x, lane).carExist = True Then
                    If x = 7 And _TrafficBlock(x, lane).carSpeed = 2 Then
                        If _linkEast.isCarAtLocation(1, lane) = False And _linkEast.isCarAtLocation(0, lane) = False And _linkEast.isGreenLightEastWest() = True Then
                            _linkEast.setCarAtLocation(_TrafficBlock(x, lane), 1, lane)
                            removeCarAtLocation(x, lane)
                        ElseIf _linkEast.isCarAtLocation(0, lane) = False And _linkEast.isGreenLightEastWest() = True Then
                            _linkEast.setCarAtLocation(_TrafficBlock(x, lane), 0, lane)
                            removeCarAtLocation(x, lane)
                        Else
                            _TrafficBlock(x, lane).carSpeed = 0
                        End If
                    ElseIf x = 7 And _TrafficBlock(x, lane).carSpeed < 2 Then
                        If _linkEast.isCarAtLocation(0, lane) = False And _linkEast.isGreenLightEastWest() = True Then
                            _linkEast.setCarAtLocation(_TrafficBlock(x, lane), 0, lane)
                            _linkEast.increaseCarSpeedAtLocation(0, lane)
                            removeCarAtLocation(x, lane)
                        Else
                            stopCarSpeedAtLocation(x, lane)
                        End If
                    ElseIf x = 6 And _TrafficBlock(x, lane).carSpeed = 2 Then
                        If _linkEast.isCarAtLocation(0, lane) = False And _TrafficBlock(7, lane).carExist = False And _linkEast.isGreenLightEastWest() = True Then
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

    Public Overrides Sub advanceWestBoundTraffic()

        Dim lane As Integer = 1

        For j As Integer = 0 To 2

            For x As Integer = 0 To 7 Step 1

                If _TrafficBlock(x, lane).carExist = True Then
                    If x = 0 And _TrafficBlock(x, lane).carSpeed = 2 Then
                        If _linkWest.isCarAtLocation(6, lane) = False And _linkWest.isCarAtLocation(7, lane) = False And _linkWest.isGreenLightEastWest() = True Then
                            _linkWest.setCarAtLocation(_TrafficBlock(x, lane), 6, lane)
                            removeCarAtLocation(x, lane)
                        ElseIf _linkWest.isCarAtLocation(7, lane) = False And _linkWest.isGreenLightEastWest() = True Then
                            _linkWest.setCarAtLocation(_TrafficBlock(x, lane), 7, lane)
                            removeCarAtLocation(x, lane)
                        Else
                            _TrafficBlock(x, lane).carSpeed = 0
                        End If
                    ElseIf x = 0 And _TrafficBlock(x, lane).carSpeed < 2 Then
                        If _linkWest.isCarAtLocation(7, lane) = False And _linkWest.isGreenLightEastWest() = True Then
                            _linkWest.setCarAtLocation(_TrafficBlock(x, lane), 7, lane)
                            _linkWest.increaseCarSpeedAtLocation(7, lane)
                            removeCarAtLocation(x, lane)
                        Else
                            stopCarSpeedAtLocation(x, lane)
                        End If
                    ElseIf x = 1 And _TrafficBlock(x, lane).carSpeed = 2 Then
                        If _linkWest.isCarAtLocation(7, lane) = False And _TrafficBlock(0, lane).carExist = False And _linkWest.isGreenLightEastWest() = True Then
                            _linkWest.setCarAtLocation(_TrafficBlock(x, lane), 7, lane)
                            removeCarAtLocation(x, lane)
                        ElseIf _TrafficBlock(0, lane).carExist = False Then
                            setCarAtLocation(_TrafficBlock(x, lane), 0, lane)
                            removeCarAtLocation(x, lane)
                            decreaseCarSpeedAtLocation(0, lane)
                        Else
                            stopCarSpeedAtLocation(x, lane)
                        End If
                    ElseIf x = 1 And _TrafficBlock(x, lane).carSpeed < 2 Then
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

    Public Overrides Sub advanceNorthBoundTraffic()

    End Sub

    Public Overrides Sub advanceSouthBoundTraffic()

    End Sub


End Class
