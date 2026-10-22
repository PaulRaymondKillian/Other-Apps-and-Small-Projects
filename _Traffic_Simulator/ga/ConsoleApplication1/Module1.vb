Imports System.Math

Module Module1

    Private geneticAlgorithm As New ga.GeneticAlgorithm

    Sub Main()

        'For i As Integer = 0 To 99
        For j As Integer = 0 To 318
            Console.Write(Round(geneticAlgorithm.getWeight(50, j), 5) & ",")
        Next
        '    Console.Write("|")
        'Next

        geneticAlgorithm.nextGeneration()

        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("New Generation!")
        Console.WriteLine()

        'For i As Integer = 0 To 99
        For j As Integer = 0 To 318
            Console.Write(Round(geneticAlgorithm.getWeight(50, j), 5) & ",")
        Next
        '    Console.Write("|")
        'Next

        Dim z As String
        Console.WriteLine("Press Enter to Exit...")
        z = Console.Read()

    End Sub

End Module
