Module Module1

    Sub Main()

        Dim weightsArray(319) As Double

        For i As Integer = 0 To 319
            weightsArray(i) = 2
        Next

        Dim ANN As ArtificialNeuralNetwork10x10x10x9 = New ArtificialNeuralNetwork10x10x10x9(weightsArray)

        ANN.setInputNodes(100, 100, 100, 100, 100, 100, 100, 100, 100, 100)

        Console.WriteLine(ANN.outputWeights)

        Console.WriteLine(ANN.calculateOutput)

        Console.Write("Press Enter to Exit")
        Dim z As String
        z = Console.ReadLine

    End Sub

End Module
