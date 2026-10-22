Public Class FoodItem
    Public _FoodStrengthGrid As FoodStrengthGrid

    Public Sub New(pLocation As Location, pMap() As Location)
        _FoodStrengthGrid = New FoodStrengthGrid(pLocation, pMap)
    End Sub


End Class
