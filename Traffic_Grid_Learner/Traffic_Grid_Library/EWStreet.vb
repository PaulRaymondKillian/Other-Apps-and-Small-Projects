Public Class EWStreet
    Inherits TrafficBlock


    Public Sub New()

        _blockType = "EWS"

        For y As Integer = 0 To 19
            For x As Integer = 0 To 19
                _TrafficBlock(x, y) = New Car

                If y = 7 Or y = 8 Or y = 11 Or y = 12 Then
                    _TrafficBlock(x, y).carId = 8
                End If

            Next
        Next
    End Sub


    Public Overrides Sub advanceEastBoundTraffic()

    End Sub

    Public Overrides Sub advanceWestBoundTraffic()

    End Sub

    Public Overrides Sub advanceNorthBoundTraffic()
        'There is no North Bound Traffic, so this method does nothing
    End Sub

    Public Overrides Sub advanceSouthBoundTraffic()
        'There is no South Bound Traffic, so this method does nothing
    End Sub


End Class



