Public Class TrafficGrid

    Private _TimeElapsed As Integer = 0
    Private _TimeOfDay As Integer = 0

#Region "Declare Street Blocks"

    Private x1y1 As New Grass
    Private x1y2 As New Grass
    Private x1y3 As New Grass
    Private x1y4 As New TerminalWest
    Private x1y5 As New Grass
    Private x1y6 As New Grass
    Private x1y7 As New TerminalWest
    Private x1y8 As New Grass
    Private x1y9 As New Grass
    Private x1y10 As New TerminalWest
    Private x1y11 As New Grass
    Private x1y12 As New Grass
    Private x1y13 As New Grass


    Private x2y1 As New Grass
    Private x2y2 As New Grass
    Private x2y3 As New Grass
    Private x2y4 As New EWStreet
    Private x2y5 As New Grass
    Private x2y6 As New Grass
    Private x2y7 As New EWStreet
    Private x2y8 As New Grass
    Private x2y9 As New Grass
    Private x2y10 As New EWStreet
    Private x2y11 As New Grass
    Private x2y12 As New Grass
    Private x2y13 As New Grass


    Private x3y1 As New Grass
    Private x3y2 As New Grass
    Private x3y3 As New Grass
    Private x3y4 As New EWStreet
    Private x3y5 As New Grass
    Private x3y6 As New Grass
    Private x3y7 As New EWStreet
    Private x3y8 As New Grass
    Private x3y9 As New Grass
    Private x3y10 As New EWStreet
    Private x3y11 As New Grass
    Private x3y12 As New Grass
    Private x3y13 As New Grass


    Private x4y1 As New TerminalNorth
    Private x4y2 As New NSStreet
    Private x4y3 As New NSStreet
    Private x4y4 As New Intersection
    Private x4y5 As New NSStreet
    Private x4y6 As New NSStreet
    Private x4y7 As New Intersection
    Private x4y8 As New NSStreet
    Private x4y9 As New NSStreet
    Private x4y10 As New Intersection
    Private x4y11 As New NSStreet
    Private x4y12 As New NSStreet
    Private x4y13 As New TerminalSouth


    Private x5y1 As New Grass
    Private x5y2 As New Grass
    Private x5y3 As New Grass
    Private x5y4 As New EWStreet
    Private x5y5 As New Grass
    Private x5y6 As New Grass
    Private x5y7 As New EWStreet
    Private x5y8 As New Grass
    Private x5y9 As New Grass
    Private x5y10 As New EWStreet
    Private x5y11 As New Grass
    Private x5y12 As New Grass
    Private x5y13 As New Grass



    Private x6y1 As New Grass
    Private x6y2 As New Grass
    Private x6y3 As New Grass
    Private x6y4 As New EWStreet
    Private x6y5 As New Grass
    Private x6y6 As New Grass
    Private x6y7 As New EWStreet
    Private x6y8 As New Grass
    Private x6y9 As New Grass
    Private x6y10 As New EWStreet
    Private x6y11 As New Grass
    Private x6y12 As New Grass
    Private x6y13 As New Grass


    Private x7y1 As New TerminalNorth
    Private x7y2 As New NSStreet
    Private x7y3 As New NSStreet
    Private x7y4 As New Intersection
    Private x7y5 As New NSStreet
    Private x7y6 As New NSStreet
    Private x7y7 As New Intersection
    Private x7y8 As New NSStreet
    Private x7y9 As New NSStreet
    Private x7y10 As New Intersection
    Private x7y11 As New NSStreet
    Private x7y12 As New NSStreet
    Private x7y13 As New TerminalSouth


    Private x8y1 As New Grass
    Private x8y2 As New Grass
    Private x8y3 As New Grass
    Private x8y4 As New EWStreet
    Private x8y5 As New Grass
    Private x8y6 As New Grass
    Private x8y7 As New EWStreet
    Private x8y8 As New Grass
    Private x8y9 As New Grass
    Private x8y10 As New EWStreet
    Private x8y11 As New Grass
    Private x8y12 As New Grass
    Private x8y13 As New Grass


    Private x9y1 As New Grass
    Private x9y2 As New Grass
    Private x9y3 As New Grass
    Private x9y4 As New EWStreet
    Private x9y5 As New Grass
    Private x9y6 As New Grass
    Private x9y7 As New EWStreet
    Private x9y8 As New Grass
    Private x9y9 As New Grass
    Private x9y10 As New EWStreet
    Private x9y11 As New Grass
    Private x9y12 As New Grass
    Private x9y13 As New Grass


    Private x10y1 As New TerminalNorth
    Private x10y2 As New NSStreet
    Private x10y3 As New NSStreet
    Private x10y4 As New Intersection
    Private x10y5 As New NSStreet
    Private x10y6 As New NSStreet
    Private x10y7 As New Intersection
    Private x10y8 As New NSStreet
    Private x10y9 As New NSStreet
    Private x10y10 As New Intersection
    Private x10y11 As New NSStreet
    Private x10y12 As New NSStreet
    Private x10y13 As New TerminalSouth


    Private x11y1 As New Grass
    Private x11y2 As New Grass
    Private x11y3 As New Grass
    Private x11y4 As New EWStreet
    Private x11y5 As New Grass
    Private x11y6 As New Grass
    Private x11y7 As New EWStreet
    Private x11y8 As New Grass
    Private x11y9 As New Grass
    Private x11y10 As New EWStreet
    Private x11y11 As New Grass
    Private x11y12 As New Grass
    Private x11y13 As New Grass


    Private x12y1 As New Grass
    Private x12y2 As New Grass
    Private x12y3 As New Grass
    Private x12y4 As New EWStreet
    Private x12y5 As New Grass
    Private x12y6 As New Grass
    Private x12y7 As New EWStreet
    Private x12y8 As New Grass
    Private x12y9 As New Grass
    Private x12y10 As New EWStreet
    Private x12y11 As New Grass
    Private x12y12 As New Grass
    Private x12y13 As New Grass


    Private x13y1 As New Grass
    Private x13y2 As New Grass
    Private x13y3 As New Grass
    Private x13y4 As New TerminalEast
    Private x13y5 As New Grass
    Private x13y6 As New Grass
    Private x13y7 As New TerminalEast
    Private x13y8 As New Grass
    Private x13y9 As New Grass
    Private x13y10 As New TerminalEast
    Private x13y11 As New Grass
    Private x13y12 As New Grass
    Private x13y13 As New Grass

#End Region

    Public Sub New()

        'Dim newCar As Car = New Car(0, 1, Car.Direction.North)
        'Dim newCar2 As Car = New Car(1, 1, Car.Direction.North)
        'Dim newCar3 As Car = New Car(2, 1, Car.Direction.North)
        'Dim newCar4 As Car = New Car(3, 1, Car.Direction.North)
        'Dim newCar5 As Car = New Car(4, 1, Car.Direction.North)
        'Dim newCar6 As Car = New Car(5, 1, Car.Direction.North)
        'Dim newCar7 As Car = New Car(6, 1, Car.Direction.North)
        'Dim newCar8 As Car = New Car(7, 1, Car.Direction.North)
        'x4y13.setCarAtLocation(newCar, 6, 0)
        'x4y13.setCarAtLocation(newCar2, 6, 1)
        'x4y13.setCarAtLocation(newCar3, 6, 2)
        'x4y13.setCarAtLocation(newCar4, 6, 3)
        'x4y13.setCarAtLocation(newCar5, 6, 4)
        'x4y13.setCarAtLocation(newCar6, 6, 5)
        'x4y13.setCarAtLocation(newCar7, 6, 6)
        'x4y13.setCarAtLocation(newCar8, 6, 7)

        setGridLinks()

    End Sub

    Public Sub setGridLinks()
        'Begin Column 4 NS Links
        x4y1.setlinkSouth(x4y2)
        x4y2.setlinkSouth(x4y3)
        x4y3.setlinkSouth(x4y4)
        x4y4.setlinkSouth(x4y5)
        x4y5.setlinkSouth(x4y6)
        x4y6.setlinkSouth(x4y7)
        x4y7.setlinkSouth(x4y8)
        x4y8.setlinkSouth(x4y9)
        x4y9.setlinkSouth(x4y10)
        x4y10.setlinkSouth(x4y11)
        x4y11.setlinkSouth(x4y12)
        x4y12.setlinkSouth(x4y13)

        x4y13.setlinkNorth(x4y12)
        x4y12.setlinkNorth(x4y11)
        x4y11.setlinkNorth(x4y10)
        x4y10.setlinkNorth(x4y9)
        x4y9.setlinkNorth(x4y8)
        x4y8.setlinkNorth(x4y7)
        x4y7.setlinkNorth(x4y6)
        x4y6.setlinkNorth(x4y5)
        x4y5.setlinkNorth(x4y4)
        x4y4.setlinkNorth(x4y3)
        x4y3.setlinkNorth(x4y2)
        x4y2.setlinkNorth(x4y1)
        'End Column 4 NS Links

        'Begin Column 7 NS Links
        x7y1.setlinkSouth(x7y2)
        x7y2.setlinkSouth(x7y3)
        x7y3.setlinkSouth(x7y4)
        x7y4.setlinkSouth(x7y5)
        x7y5.setlinkSouth(x7y6)
        x7y6.setlinkSouth(x7y7)
        x7y7.setlinkSouth(x7y8)
        x7y8.setlinkSouth(x7y9)
        x7y9.setlinkSouth(x7y10)
        x7y10.setlinkSouth(x7y11)
        x7y11.setlinkSouth(x7y12)
        x7y12.setlinkSouth(x7y13)

        x7y13.setlinkNorth(x7y12)
        x7y12.setlinkNorth(x7y11)
        x7y11.setlinkNorth(x7y10)
        x7y10.setlinkNorth(x7y9)
        x7y9.setlinkNorth(x7y8)
        x7y8.setlinkNorth(x7y7)
        x7y7.setlinkNorth(x7y6)
        x7y6.setlinkNorth(x7y5)
        x7y5.setlinkNorth(x7y4)
        x7y4.setlinkNorth(x7y3)
        x7y3.setlinkNorth(x7y2)
        x7y2.setlinkNorth(x7y1)
        'End Column 7 NS Links

        'Begin Column 10 NS Links
        x10y1.setlinkSouth(x10y2)
        x10y2.setlinkSouth(x10y3)
        x10y3.setlinkSouth(x10y4)
        x10y4.setlinkSouth(x10y5)
        x10y5.setlinkSouth(x10y6)
        x10y6.setlinkSouth(x10y7)
        x10y7.setlinkSouth(x10y8)
        x10y8.setlinkSouth(x10y9)
        x10y9.setlinkSouth(x10y10)
        x10y10.setlinkSouth(x10y11)
        x10y11.setlinkSouth(x10y12)
        x10y12.setlinkSouth(x10y13)

        x10y13.setlinkNorth(x10y12)
        x10y12.setlinkNorth(x10y11)
        x10y11.setlinkNorth(x10y10)
        x10y10.setlinkNorth(x10y9)
        x10y9.setlinkNorth(x10y8)
        x10y8.setlinkNorth(x10y7)
        x10y7.setlinkNorth(x10y6)
        x10y6.setlinkNorth(x10y5)
        x10y5.setlinkNorth(x10y4)
        x10y4.setlinkNorth(x10y3)
        x10y3.setlinkNorth(x10y2)
        x10y2.setlinkNorth(x10y1)
        'End Column 10 NS Links




        'Begin Row 4 EW Links
        x1y4.setlinkEast(x2y4)
        x2y4.setlinkEast(x3y4)
        x3y4.setlinkEast(x4y4)
        x4y4.setlinkEast(x5y4)
        x5y4.setlinkEast(x6y4)
        x6y4.setlinkEast(x7y4)
        x7y4.setlinkEast(x8y4)
        x8y4.setlinkEast(x9y4)
        x9y4.setlinkEast(x10y4)
        x10y4.setlinkEast(x11y4)
        x11y4.setlinkEast(x12y4)
        x12y4.setlinkEast(x13y4)

        x13y4.setlinkWest(x12y4)
        x12y4.setlinkWest(x11y4)
        x11y4.setlinkWest(x10y4)
        x10y4.setlinkWest(x9y4)
        x9y4.setlinkWest(x8y4)
        x8y4.setlinkWest(x7y4)
        x7y4.setlinkWest(x6y4)
        x6y4.setlinkWest(x5y4)
        x5y4.setlinkWest(x4y4)
        x4y4.setlinkWest(x3y4)
        x3y4.setlinkWest(x2y4)
        x2y4.setlinkWest(x1y4)
        'End Row 4 EW Links


        'Begin Row 7 EW Links
        x1y7.setlinkEast(x2y7)
        x2y7.setlinkEast(x3y7)
        x3y7.setlinkEast(x4y7)
        x4y7.setlinkEast(x5y7)
        x5y7.setlinkEast(x6y7)
        x6y7.setlinkEast(x7y7)
        x7y7.setlinkEast(x8y7)
        x8y7.setlinkEast(x9y7)
        x9y7.setlinkEast(x10y7)
        x10y7.setlinkEast(x11y7)
        x11y7.setlinkEast(x12y7)
        x12y7.setlinkEast(x13y7)

        x13y7.setlinkWest(x12y7)
        x12y7.setlinkWest(x11y7)
        x11y7.setlinkWest(x10y7)
        x10y7.setlinkWest(x9y7)
        x9y7.setlinkWest(x8y7)
        x8y7.setlinkWest(x7y7)
        x7y7.setlinkWest(x6y7)
        x6y7.setlinkWest(x5y7)
        x5y7.setlinkWest(x4y7)
        x4y7.setlinkWest(x3y7)
        x3y7.setlinkWest(x2y7)
        x2y7.setlinkWest(x1y7)
        'End Row 7 EW Links


        'Begin Row 10 EW Links
        x1y10.setlinkEast(x2y10)
        x2y10.setlinkEast(x3y10)
        x3y10.setlinkEast(x4y10)
        x4y10.setlinkEast(x5y10)
        x5y10.setlinkEast(x6y10)
        x6y10.setlinkEast(x7y10)
        x7y10.setlinkEast(x8y10)
        x8y10.setlinkEast(x9y10)
        x9y10.setlinkEast(x10y10)
        x10y10.setlinkEast(x11y10)
        x11y10.setlinkEast(x12y10)
        x12y10.setlinkEast(x13y10)

        x13y10.setlinkWest(x12y10)
        x12y10.setlinkWest(x11y10)
        x11y10.setlinkWest(x10y10)
        x10y10.setlinkWest(x9y10)
        x9y10.setlinkWest(x8y10)
        x8y10.setlinkWest(x7y10)
        x7y10.setlinkWest(x6y10)
        x6y10.setlinkWest(x5y10)
        x5y10.setlinkWest(x4y10)
        x4y10.setlinkWest(x3y10)
        x3y10.setlinkWest(x2y10)
        x2y10.setlinkWest(x1y10)
        'End Row 10 EW Links
    End Sub

    Public Sub advanceTime()

        'Begin Column 4 Traffic Advance
        x4y1.advanceNorthBoundTraffic()
        x4y2.advanceNorthBoundTraffic()
        x4y3.advanceNorthBoundTraffic()
        x4y4.advanceNorthBoundTraffic()
        x4y5.advanceNorthBoundTraffic()
        x4y6.advanceNorthBoundTraffic()
        x4y7.advanceNorthBoundTraffic()
        x4y8.advanceNorthBoundTraffic()
        x4y9.advanceNorthBoundTraffic()
        x4y10.advanceNorthBoundTraffic()
        x4y11.advanceNorthBoundTraffic()
        x4y12.advanceNorthBoundTraffic()
        x4y13.advanceNorthBoundTraffic()

        x4y13.advanceSouthBoundTraffic()
        x4y12.advanceSouthBoundTraffic()
        x4y11.advanceSouthBoundTraffic()
        x4y10.advanceSouthBoundTraffic()
        x4y9.advanceSouthBoundTraffic()
        x4y8.advanceSouthBoundTraffic()
        x4y7.advanceSouthBoundTraffic()
        x4y6.advanceSouthBoundTraffic()
        x4y5.advanceSouthBoundTraffic()
        x4y4.advanceSouthBoundTraffic()
        x4y3.advanceSouthBoundTraffic()
        x4y2.advanceSouthBoundTraffic()
        x4y1.advanceSouthBoundTraffic()
        'End Column 4 Traffic Advance


        'Begin Column 7 Traffic Advance
        x7y1.advanceNorthBoundTraffic()
        x7y2.advanceNorthBoundTraffic()
        x7y3.advanceNorthBoundTraffic()
        x7y4.advanceNorthBoundTraffic()
        x7y5.advanceNorthBoundTraffic()
        x7y6.advanceNorthBoundTraffic()
        x7y7.advanceNorthBoundTraffic()
        x7y8.advanceNorthBoundTraffic()
        x7y9.advanceNorthBoundTraffic()
        x7y10.advanceNorthBoundTraffic()
        x7y11.advanceNorthBoundTraffic()
        x7y12.advanceNorthBoundTraffic()
        x7y13.advanceNorthBoundTraffic()

        x7y13.advanceSouthBoundTraffic()
        x7y12.advanceSouthBoundTraffic()
        x7y11.advanceSouthBoundTraffic()
        x7y10.advanceSouthBoundTraffic()
        x7y9.advanceSouthBoundTraffic()
        x7y8.advanceSouthBoundTraffic()
        x7y7.advanceSouthBoundTraffic()
        x7y6.advanceSouthBoundTraffic()
        x7y5.advanceSouthBoundTraffic()
        x7y4.advanceSouthBoundTraffic()
        x7y3.advanceSouthBoundTraffic()
        x7y2.advanceSouthBoundTraffic()
        x7y1.advanceSouthBoundTraffic()
        'End Column 7 Traffic Advance

        'Begin Column 10 Traffic Advance
        x10y1.advanceNorthBoundTraffic()
        x10y2.advanceNorthBoundTraffic()
        x10y3.advanceNorthBoundTraffic()
        x10y4.advanceNorthBoundTraffic()
        x10y5.advanceNorthBoundTraffic()
        x10y6.advanceNorthBoundTraffic()
        x10y7.advanceNorthBoundTraffic()
        x10y8.advanceNorthBoundTraffic()
        x10y9.advanceNorthBoundTraffic()
        x10y10.advanceNorthBoundTraffic()
        x10y11.advanceNorthBoundTraffic()
        x10y12.advanceNorthBoundTraffic()
        x10y13.advanceNorthBoundTraffic()

        x10y13.advanceSouthBoundTraffic()
        x10y12.advanceSouthBoundTraffic()
        x10y11.advanceSouthBoundTraffic()
        x10y10.advanceSouthBoundTraffic()
        x10y9.advanceSouthBoundTraffic()
        x10y8.advanceSouthBoundTraffic()
        x10y7.advanceSouthBoundTraffic()
        x10y6.advanceSouthBoundTraffic()
        x10y5.advanceSouthBoundTraffic()
        x10y4.advanceSouthBoundTraffic()
        x10y3.advanceSouthBoundTraffic()
        x10y2.advanceSouthBoundTraffic()
        x10y1.advanceSouthBoundTraffic()
        'End Column 10 Traffic Advance


        'Begin Row 4 Traffic Advance
        x1y4.advanceWestBoundTraffic()
        x2y4.advanceWestBoundTraffic()
        x3y4.advanceWestBoundTraffic()
        x4y4.advanceWestBoundTraffic()
        x5y4.advanceWestBoundTraffic()
        x6y4.advanceWestBoundTraffic()
        x7y4.advanceWestBoundTraffic()
        x8y4.advanceWestBoundTraffic()
        x9y4.advanceWestBoundTraffic()
        x10y4.advanceWestBoundTraffic()
        x11y4.advanceWestBoundTraffic()
        x12y4.advanceWestBoundTraffic()
        x13y4.advanceWestBoundTraffic()

        x13y4.advanceEastBoundTraffic()
        x12y4.advanceEastBoundTraffic()
        x11y4.advanceEastBoundTraffic()
        x10y4.advanceEastBoundTraffic()
        x9y4.advanceEastBoundTraffic()
        x8y4.advanceEastBoundTraffic()
        x7y4.advanceEastBoundTraffic()
        x6y4.advanceEastBoundTraffic()
        x5y4.advanceEastBoundTraffic()
        x4y4.advanceEastBoundTraffic()
        x3y4.advanceEastBoundTraffic()
        x2y4.advanceEastBoundTraffic()
        x1y4.advanceEastBoundTraffic()
        'End Row 4 Traffic Advance



        'Begin Row 7 Traffic Advance
        x1y7.advanceWestBoundTraffic()
        x2y7.advanceWestBoundTraffic()
        x3y7.advanceWestBoundTraffic()
        x4y7.advanceWestBoundTraffic()
        x5y7.advanceWestBoundTraffic()
        x6y7.advanceWestBoundTraffic()
        x7y7.advanceWestBoundTraffic()
        x8y7.advanceWestBoundTraffic()
        x9y7.advanceWestBoundTraffic()
        x10y7.advanceWestBoundTraffic()
        x11y7.advanceWestBoundTraffic()
        x12y7.advanceWestBoundTraffic()
        x13y7.advanceWestBoundTraffic()

        x13y7.advanceEastBoundTraffic()
        x12y7.advanceEastBoundTraffic()
        x11y7.advanceEastBoundTraffic()
        x10y7.advanceEastBoundTraffic()
        x9y7.advanceEastBoundTraffic()
        x8y7.advanceEastBoundTraffic()
        x7y7.advanceEastBoundTraffic()
        x6y7.advanceEastBoundTraffic()
        x5y7.advanceEastBoundTraffic()
        x4y7.advanceEastBoundTraffic()
        x3y7.advanceEastBoundTraffic()
        x2y7.advanceEastBoundTraffic()
        x1y7.advanceEastBoundTraffic()
        'End Row 7 Traffic Advance



        'Begin Row 10 Traffic Advance
        x1y10.advanceWestBoundTraffic()
        x2y10.advanceWestBoundTraffic()
        x3y10.advanceWestBoundTraffic()
        x4y10.advanceWestBoundTraffic()
        x5y10.advanceWestBoundTraffic()
        x6y10.advanceWestBoundTraffic()
        x7y10.advanceWestBoundTraffic()
        x8y10.advanceWestBoundTraffic()
        x9y10.advanceWestBoundTraffic()
        x10y10.advanceWestBoundTraffic()
        x11y10.advanceWestBoundTraffic()
        x12y10.advanceWestBoundTraffic()
        x13y10.advanceWestBoundTraffic()

        x13y10.advanceEastBoundTraffic()
        x12y10.advanceEastBoundTraffic()
        x11y10.advanceEastBoundTraffic()
        x10y10.advanceEastBoundTraffic()
        x9y10.advanceEastBoundTraffic()
        x8y10.advanceEastBoundTraffic()
        x7y10.advanceEastBoundTraffic()
        x6y10.advanceEastBoundTraffic()
        x5y10.advanceEastBoundTraffic()
        x4y10.advanceEastBoundTraffic()
        x3y10.advanceEastBoundTraffic()
        x2y10.advanceEastBoundTraffic()
        x1y10.advanceEastBoundTraffic()
        'End Row 10 Traffic Advance

        _TimeElapsed = _TimeElapsed + 1
        _TimeOfDay = (_TimeElapsed Mod 86400)

        randomlyGenerateCar()

    End Sub

    Public Function getTimeElapsed() As Integer
        Return _TimeElapsed
    End Function

    Public Function getTimeOfDay() As Integer
        Return _TimeOfDay
    End Function

    Public Sub changeTrafficLight(ByVal i As Integer)
        If i = 0 Then
            x4y4.changeTrafficLight()
        ElseIf i = 1 Then
            x7y4.changeTrafficLight()
        ElseIf i = 2 Then
            x10y4.changeTrafficLight()
        ElseIf i = 3 Then
            x4y7.changeTrafficLight()
        ElseIf i = 4 Then
            x7y7.changeTrafficLight()
        ElseIf i = 5 Then
            x10y7.changeTrafficLight()
        ElseIf i = 6 Then
            x4y10.changeTrafficLight()
        ElseIf i = 7 Then
            x7y10.changeTrafficLight()
        ElseIf i = 8 Then
            x10y10.changeTrafficLight()
        Else
            MsgBox("You should never get here - Class: TrafficGrid  Method: changeTrafficLight")
        End If

    End Sub

    Public Sub randomlyGenerateCar()

        x1y4.chanceGenerateNewCar()
        x1y7.chanceGenerateNewCar()
        x1y10.chanceGenerateNewCar()
        x13y4.chanceGenerateNewCar()
        x13y7.chanceGenerateNewCar()
        x13y10.chanceGenerateNewCar()

        x4y1.chanceGenerateNewCar()
        x7y1.chanceGenerateNewCar()
        x10y1.chanceGenerateNewCar()
        x4y13.chanceGenerateNewCar()
        x7y13.chanceGenerateNewCar()
        x10y13.chanceGenerateNewCar()

    End Sub

    Public Function returnGridRow(ByVal row As Integer) As String
        Dim s As String = ""
        Dim sb As New System.Text.StringBuilder

        If row >= 0 And row <= 7 Then
            For i As Integer = 0 To 7
                sb.Append(x1y1.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x2y1.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x3y1.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x4y1.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x5y1.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x6y1.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x7y1.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x8y1.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x9y1.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x10y1.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x11y1.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x12y1.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x13y1.getCarIdAtLocation(i, row))
            Next
        End If


        If row >= 8 And row <= 15 Then

            row = row Mod 8

            For i As Integer = 0 To 7
                sb.Append(x1y2.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x2y2.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x3y2.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x4y2.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x5y2.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x6y2.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x7y2.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x8y2.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x9y2.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x10y2.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x11y2.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x12y2.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x13y2.getCarIdAtLocation(i, row))
            Next
        End If

        If row >= 16 And row <= 23 Then

            row = row Mod 8

            For i As Integer = 0 To 7
                sb.Append(x1y3.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x2y3.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x3y3.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x4y3.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x5y3.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x6y3.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x7y3.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x8y3.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x9y3.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x10y3.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x11y3.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x12y3.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x13y3.getCarIdAtLocation(i, row))
            Next
        End If


        If row >= 24 And row <= 31 Then

            row = row Mod 8

            For i As Integer = 0 To 7
                sb.Append(x1y4.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x2y4.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x3y4.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x4y4.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x5y4.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x6y4.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x7y4.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x8y4.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x9y4.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x10y4.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x11y4.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x12y4.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x13y4.getCarIdAtLocation(i, row))
            Next
        End If



        If row >= 32 And row <= 39 Then

            row = row Mod 8

            For i As Integer = 0 To 7
                sb.Append(x1y5.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x2y5.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x3y5.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x4y5.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x5y5.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x6y5.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x7y5.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x8y5.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x9y5.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x10y5.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x11y5.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x12y5.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x13y5.getCarIdAtLocation(i, row))
            Next
        End If



        If row >= 40 And row <= 47 Then

            row = row Mod 8

            For i As Integer = 0 To 7
                sb.Append(x1y6.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x2y6.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x3y6.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x4y6.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x5y6.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x6y6.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x7y6.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x8y6.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x9y6.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x10y6.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x11y6.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x12y6.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x13y6.getCarIdAtLocation(i, row))
            Next
        End If



        If row >= 48 And row <= 55 Then

            row = row Mod 8

            For i As Integer = 0 To 7
                sb.Append(x1y7.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x2y7.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x3y7.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x4y7.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x5y7.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x6y7.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x7y7.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x8y7.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x9y7.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x10y7.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x11y7.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x12y7.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x13y7.getCarIdAtLocation(i, row))
            Next
        End If



        If row >= 56 And row <= 63 Then

            row = row Mod 8

            For i As Integer = 0 To 7
                sb.Append(x1y8.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x2y8.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x3y8.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x4y8.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x5y8.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x6y8.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x7y8.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x8y8.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x9y8.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x10y8.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x11y8.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x12y8.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x13y8.getCarIdAtLocation(i, row))
            Next
        End If



        If row >= 64 And row <= 71 Then

            row = row Mod 8

            For i As Integer = 0 To 7
                sb.Append(x1y9.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x2y9.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x3y9.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x4y9.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x5y9.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x6y9.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x7y9.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x8y9.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x9y9.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x10y9.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x11y9.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x12y9.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x13y9.getCarIdAtLocation(i, row))
            Next
        End If



        If row >= 72 And row <= 79 Then

            row = row Mod 8

            For i As Integer = 0 To 7
                sb.Append(x1y10.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x2y10.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x3y10.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x4y10.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x5y10.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x6y10.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x7y10.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x8y10.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x9y10.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x10y10.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x11y10.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x12y10.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x13y10.getCarIdAtLocation(i, row))
            Next
        End If



        If row >= 80 And row <= 87 Then

            row = row Mod 8

            For i As Integer = 0 To 7
                sb.Append(x1y11.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x2y11.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x3y11.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x4y11.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x5y11.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x6y11.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x7y11.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x8y11.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x9y11.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x10y11.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x11y11.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x12y11.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x13y11.getCarIdAtLocation(i, row))
            Next
        End If



        If row >= 88 And row <= 95 Then

            row = row Mod 8

            For i As Integer = 0 To 7
                sb.Append(x1y12.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x2y12.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x3y12.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x4y12.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x5y12.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x6y12.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x7y12.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x8y12.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x9y12.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x10y12.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x11y12.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x12y12.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x13y12.getCarIdAtLocation(i, row))
            Next
        End If



        If row >= 96 And row <= 103 Then

            row = row Mod 8

            For i As Integer = 0 To 7
                sb.Append(x1y13.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x2y13.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x3y13.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x4y13.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x5y13.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x6y13.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x7y13.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x8y13.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x9y13.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x10y13.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x11y13.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x12y13.getCarIdAtLocation(i, row))
            Next
            For i As Integer = 0 To 7
                sb.Append(x13y13.getCarIdAtLocation(i, row))
            Next
        End If

        s = sb.ToString

        Return s

    End Function

    Public Function getCarCount() As Integer

        Return x1y4.carCount + x1y7.carCount + x1y10.carCount + x4y1.carCount + x4y13.carCount + x7y1.carCount + x7y13.carCount + x10y1.carCount + x10y13.carCount + x13y4.carCount + x13y7.carCount + x13y10.carCount

    End Function

    Public Function getCarCount(ByVal i As Integer) As Integer
        If i = 0 Then
            Return x1y4.carCount
        ElseIf i = 1 Then
            Return x1y7.carCount
        ElseIf i = 2 Then
            Return x1y10.carCount
        ElseIf i = 3 Then
            Return x4y1.carCount
        ElseIf i = 4 Then
            Return x4y13.carCount
        ElseIf i = 5 Then
            Return x7y1.carCount
        ElseIf i = 6 Then
            Return x7y13.carCount
        ElseIf i = 7 Then
            Return x10y1.carCount
        ElseIf i = 8 Then
            Return x10y13.carCount
        ElseIf i = 9 Then
            Return x13y4.carCount
        ElseIf i = 10 Then
            Return x13y7.carCount
        ElseIf i = 11 Then
            Return x13y10.carCount
        End If
    End Function

    Public Sub resetCarCount()
        x1y4.carCount = 0
        x1y7.carCount = 0
        x1y10.carCount = 0
        x4y1.carCount = 0
        x4y13.carCount = 0
        x7y1.carCount = 0
        x7y13.carCount = 0
        x10y1.carCount = 0
        x10y13.carCount = 0
        x13y4.carCount = 0
        x13y7.carCount = 0
        x13y10.carCount = 0
    End Sub

    Public Function getTrafficLightState(ByVal x As Integer) As Integer

        If x = 0 Then
            If x4y4.isGreenLightEastWest = True Then
                Return 1
            ElseIf x4y4.isGreenLightNorthSouth = True Then
                Return -1
            Else
                MsgBox("You Should Never Reach This Point - Class: TrafficGrid  Method: getTrafficLightState")
            End If
        ElseIf x = 1 Then
            If x7y4.isGreenLightEastWest = True Then
                Return 1
            ElseIf x7y4.isGreenLightNorthSouth = True Then
                Return -1
            Else
                MsgBox("You Should Never Reach This Point - Class: TrafficGrid  Method: getTrafficLightState")
            End If
        ElseIf x = 2 Then
            If x10y4.isGreenLightEastWest = True Then
                Return 1
            ElseIf x10y4.isGreenLightNorthSouth = True Then
                Return -1
            Else
                MsgBox("You Should Never Reach This Point - Class: TrafficGrid  Method: getTrafficLightState")
            End If
        ElseIf x = 3 Then
            If x4y7.isGreenLightEastWest = True Then
                Return 1
            ElseIf x4y7.isGreenLightNorthSouth = True Then
                Return -1
            Else
                MsgBox("You Should Never Reach This Point - Class: TrafficGrid  Method: getTrafficLightState")
            End If
        ElseIf x = 4 Then
            If x7y7.isGreenLightEastWest = True Then
                Return 1
            ElseIf x7y7.isGreenLightNorthSouth = True Then
                Return -1
            Else
                MsgBox("You Should Never Reach This Point - Class: TrafficGrid  Method: getTrafficLightState")
            End If
        ElseIf x = 5 Then
            If x10y7.isGreenLightEastWest = True Then
                Return 1
            ElseIf x10y7.isGreenLightNorthSouth = True Then
                Return -1
            Else
                MsgBox("You Should Never Reach This Point - Class: TrafficGrid  Method: getTrafficLightState")
            End If
        ElseIf x = 6 Then
            If x4y10.isGreenLightEastWest = True Then
                Return 1
            ElseIf x4y10.isGreenLightNorthSouth = True Then
                Return -1
            Else
                MsgBox("You Should Never Reach This Point - Class: TrafficGrid  Method: getTrafficLightState")
            End If
        ElseIf x = 7 Then
            If x7y10.isGreenLightEastWest = True Then
                Return 1
            ElseIf x7y10.isGreenLightNorthSouth = True Then
                Return -1
            Else
                MsgBox("You Should Never Reach This Point - Class: TrafficGrid  Method: getTrafficLightState")
            End If
        ElseIf x = 8 Then
            If x10y10.isGreenLightEastWest = True Then
                Return 1
            ElseIf x10y10.isGreenLightNorthSouth = True Then
                Return -1
            Else
                MsgBox("You Should Never Reach This Point - Class: TrafficGrid  Method: getTrafficLightState")
            End If
        Else
            MsgBox("You Should Never Reach This Point - Class: TrafficGrid  Method: getTrafficLightState")
        End If

    End Function

End Class
