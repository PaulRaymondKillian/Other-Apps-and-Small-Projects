Public Class NSStreet
    Inherits TrafficBlock


    Public Sub New()

        _blockType = "NSS "

        For y As Integer = 0 To 19
            For x As Integer = 0 To 19
                _TrafficBlock(x, y) = New Car

                If x = 7 Or x = 8 Or x = 11 Or x = 12 Then
                    _TrafficBlock(x, y).carId = 8
                End If

            Next
        Next
    End Sub


    Public Overrides Sub advanceEastBoundTraffic()
        'There is no East Bound Traffic, so this method does nothing
    End Sub

    Public Overrides Sub advanceWestBoundTraffic()
        'There is no West Bound Traffic, so this method does nothing
    End Sub

    Public Overrides Sub advanceNorthBoundTraffic()

    End Sub

    Public Overrides Sub advanceSouthBoundTraffic()

    End Sub


End Class


