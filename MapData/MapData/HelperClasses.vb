Option Strict On

Imports System.Collections.Generic

Public Enum Tile
    ANTS = 0
    DEAD = -1
    LAND = -2
    FOOD = -3
    WATER = -4
    UNSEEN = -5
End Enum

Public Enum Direction
    n
    s
    e
    w
End Enum

Public Structure Location
    Public Row As Integer
    Public Col As Integer
    Public Sub new(row As Integer, col As Integer)
        Me.Row = row
        Me.Col = col
    End Sub
End Structure

