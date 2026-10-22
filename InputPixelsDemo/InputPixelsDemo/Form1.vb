Imports System.IO

Public Class Form1

    Private DataFolder As String
    Private ImgWidth As Integer
    Private ImgHeight As Integer
    Private CurrentColor As Color
    Private CharacterMaps As Hashtable

    Private Sub DrawImageGrid(ByVal Img As Image, ByVal Width As Integer, ByVal Height As Integer)
        Dim UnitWidth As Integer, UnitHeight As Integer
        Dim X As Integer, Y As Integer
        Dim G As Graphics, P As Pen

        UnitWidth = (Img.Width - 1) \ Width
        UnitHeight = (Img.Height - 1) \ Height

        G = CreateGraphics.FromImage(Img)
        P = Pens.LightGray

        G.FillRectangle(Brushes.White, 0, 0, Width * UnitWidth, Height * UnitHeight)
        For X = 0 To Width
            G.DrawLine(P, X * UnitWidth, 0, X * UnitWidth, Height * UnitHeight)
        Next
        For Y = 0 To Height
            G.DrawLine(P, 0, Y * UnitHeight, Width * UnitWidth, Y * UnitHeight)
        Next
    End Sub


    Private Sub SetGridCellColor(ByVal Img As Image, ByVal Width As Integer, ByVal Height As Integer, ByVal X As Integer, ByVal Y As Integer, ByVal Color As Color)
        Dim UnitWidth As Integer, UnitHeight As Integer
        Dim G As Graphics, B As Brush

        UnitWidth = (Img.Width - 1) \ Width
        UnitHeight = (Img.Height - 1) \ Height

        G = CreateGraphics.FromImage(Img)
        B = New SolidBrush(Color)

        G.FillRectangle(B, X * UnitWidth + 1, Y * UnitHeight + 1, UnitWidth - 1, UnitHeight - 1)
    End Sub


    Private Function GetGridCellColor(ByVal Img As Bitmap, ByVal Width As Integer, ByVal Height As Integer, ByVal X As Integer, ByVal Y As Integer) As Color
        Dim UnitWidth As Integer, UnitHeight As Integer

        UnitWidth = (Img.Width - 1) \ Width
        UnitHeight = (Img.Height - 1) \ Height

        Return Img.GetPixel(X * UnitWidth + UnitWidth * 0.5, Y * UnitHeight + UnitHeight * 0.5)
    End Function

    Private Function WhichGridCell(ByVal Img As Bitmap, ByVal Width As Integer, ByVal Height As Integer, ByRef X As Integer, ByRef Y As Integer) As Boolean
        Dim UnitWidth As Integer, UnitHeight As Integer, C As Color

        UnitWidth = Img.Width \ Width
        UnitHeight = Img.Height \ Height

        X = X \ UnitWidth
        Y = Y \ UnitWidth

        If X < 0 Then Return False
        If Y < 0 Then Return False
        If X >= Width Then Return False
        If Y >= Height Then Return False
        Return True
    End Function

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ImgWidth = 5
        ImgHeight = 8
        InputPixels.Image = New Bitmap(InputPixels.Width, InputPixels.Height)
        DrawImageGrid(InputPixels.Image, ImgWidth, ImgHeight)

    End Sub

    Private Sub InputPixels_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles InputPixels.MouseDown
        Dim X As Integer, Y As Integer
        X = e.X
        Y = e.Y
        If Not WhichGridCell(InputPixels.Image, ImgWidth, ImgHeight, X, Y) Then
            CurrentColor = Color.White
        Else
            CurrentColor = GetGridCellColor(InputPixels.Image, ImgWidth, ImgHeight, X, Y)
            If CurrentColor.ToArgb = Color.Black.ToArgb Then
                CurrentColor = Color.White
            Else
                CurrentColor = Color.Black
            End If
            InputPixels_MouseMove(Nothing, e)
        End If
    End Sub

    Private Sub InputPixels_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles InputPixels.MouseMove
        Dim X As Integer, Y As Integer

        If Not e.Button = MouseButtons.Left Then Return

        X = e.X
        Y = e.Y
        If Not WhichGridCell(InputPixels.Image, ImgWidth, ImgHeight, X, Y) Then Return

        SetGridCellColor(InputPixels.Image, ImgWidth, ImgHeight, X, Y, CurrentColor)
        InputPixels.Refresh()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveToFile.Click
        Dim sr As New StreamWriter("c:\test.txt")
        Dim s As String = ""
        For i As Integer = 0 To ImgHeight - 1
            For j As Integer = 0 To ImgWidth - 1
                CurrentColor = GetGridCellColor(InputPixels.Image, ImgWidth, ImgHeight, j, i)
                If CurrentColor.ToArgb = Color.Black.ToArgb Then
                    s += "1"
                Else
                    s += "-1"
                End If

                If i <> ImgHeight - 1 Or j <> ImgWidth - 1 Then
                    s += ","
                End If
            Next
        Next
        sr.WriteLine("[" & s & "]")
        sr.Close()
    End Sub

    Private Sub btnLoadFromFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadFromFile.Click
        Dim sr As StreamReader
        Dim s As String
        Dim elements() As String
        Dim values() As Integer

        sr = File.OpenText("c:\5.txt")
        s = sr.ReadToEnd
        s = s.Substring(1, s.Length - 2)
        elements = Split(s, ",")
        ReDim values(elements.Length - 1)
        For i As Integer = 0 To elements.Length - 1
            values(i) = Convert.ToDouble(elements(i))
        Next

        If values.Length <> ImgHeight * ImgWidth Then
            Throw New Exception("Inputted Vector does not match required dimensions for vector space")
        End If

        For i As Integer = 0 To ImgHeight - 1
            For j As Integer = 0 To ImgWidth - 1
                If values((i * ImgWidth) + j) > 0 Then
                    SetGridCellColor(InputPixels.Image, ImgWidth, ImgHeight, j, i, Color.Black)
                Else
                    SetGridCellColor(InputPixels.Image, ImgWidth, ImgHeight, j, i, Color.White)
                End If
            Next
        Next

        InputPixels.Refresh()



    End Sub

End Class
