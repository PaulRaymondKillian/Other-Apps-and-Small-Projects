Public Class Intersection
    Inherits TrafficBlock

    Private _TrafficLight As New TrafficLight

    Public Sub New()

        _blockType = "I"

        For y As Integer = 0 To 19
            For x As Integer = 0 To 19
                _TrafficBlock(x, y) = New Car

                If x = 7 Or x = 8 Or x = 11 Or x = 12 Or y = 7 Or y = 8 Or y = 11 Or y = 12 Then
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

    End Sub

    Public Overrides Sub advanceSouthBoundTraffic()

    End Sub


End Class



