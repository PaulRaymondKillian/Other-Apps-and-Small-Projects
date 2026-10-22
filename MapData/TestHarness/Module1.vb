Module Module1

    Sub Main()
        Dim Random As New Random(Now.Millisecond)
        Dim Threshold As Integer
        Dim Rows, Cols As Integer
        Threshold = 15
        Rows = 10
        Cols = 10
        Dim RawMapData(Rows, Cols) As MapData.Tile

        ''Create a test map
        'For row As Integer = 0 To Rows - 1
        '    For col As Integer = 0 To Cols - 1
        '        If (Random.Next Mod 100) < Threshold Then
        '            RawMapData(row, col) = MapData.Tile.WATER
        '        Else
        '            RawMapData(row, col) = MapData.Tile.LAND
        '        End If
        '    Next
        'Next

        'Create a test map
        For row As Integer = 0 To Rows - 1
            For col As Integer = 0 To Cols - 1
                If col = 3 And (row > 2 And row < 8) Then
                    RawMapData(row, col) = MapData.Tile.WATER
                Else
                    RawMapData(row, col) = MapData.Tile.LAND
                End If
            Next
        Next

        Dim Map As New MapData.MapData(Rows, Cols, RawMapData)

        'Output
        For row As Integer = 0 To Rows - 1
            For col As Integer = 0 To Cols - 1
                If Map._Map(row, col).Passable Then
                    Console.Write("_")
                Else
                    Console.Write("W")
                End If
            Next
            Console.WriteLine()
        Next

    End Sub

End Module
