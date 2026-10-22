Option Strict On

Public Class MapTile
    Public Passable As Boolean
    Public FoodHere As Boolean

    Public Sub New()
        Passable = False
        FoodHere = False
    End Sub
End Class

Public Class MapData
    Public _Map(,) As MapTile
    Public _Rows, _Cols As Integer

    Public Sub New(pRows As Integer, pCols As Integer, pMapLocations(,) As Tile)
        'Initialize the Tiles array of MapTile objects for the game map
        _Rows = pRows
        _Cols = pCols
        InitMapTiles()
        UpdateMap(pMapLocations)
    End Sub

    Private Sub InitMapTiles()
        ReDim _Map(_Rows - 1, _Cols - 1)
        For Row As Integer = 0 To _Rows - 1
            For Col As Integer = 0 To _Cols - 1
                _Map(Row, Col) = New MapTile()
            Next
        Next
    End Sub

    Public Sub UpdateMap(pMapLocations(,) As Tile)
        For Row As Integer = 0 To _Rows - 1
            For Col As Integer = 0 To _Cols - 1
                If pMapLocations(Row, Col) = Tile.LAND Or pMapLocations(Row, Col) = Tile.FOOD Then
                    _Map(Row, Col).Passable = True
                    If pMapLocations(Row, Col) = Tile.FOOD Then
                        _Map(Row, Col).FoodHere = True
                    End If
                Else
                    _Map(Row, Col).Passable = False
                End If
            Next
        Next
    End Sub
End Class
