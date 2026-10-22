Module Module1

    Sub Main()
        Console.WriteLine("Progrma Started")
        Dim grid As New Traffic_Grid_Controller.Traffic_Grid_Controller("E:\Artificial Neural Networks\Traffic_Grid_Learner\grid1_configuration.txt")


        Dim s() As String = grid.debugReturnBlockTypes.Split(" ")

        grid._currentBlock = grid._endBlock
        For i As Integer = 0 To 8
            Console.WriteLine("BlockName: " & grid._currentBlock._blockName & " BlockType: " & grid._currentBlock._blockType)

            grid._currentBlock = grid._currentBlock._linkNorth
        Next

        Console.ReadLine()
    End Sub

End Module
