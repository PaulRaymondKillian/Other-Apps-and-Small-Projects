Imports System.IO
Imports System.Math

Module Module1

    Sub Main()

        Dim sr As StreamWriter
        sr = New StreamWriter("C:\PopulationData2.txt")

        Dim TrafficSimulatorController As New Traffic_Simulator_Controller.Traffic_Simulator_Controller
        Dim GeneticAlgorithmController As New Genetic_Algorithm_Controller.Genetic_Algorithm_Controller

        Dim currentEpoch As Integer = 0
        Dim endEpoch As Integer = 100

        Dim simulationLength As Integer = 5000
        Dim populationCarCount As Integer = 0
        Dim currentChromosomeCarCount As Integer = 0

        For i As Integer = 0 To endEpoch

            For j As Integer = 0 To 99
                'Run the current population through the simulation
                TrafficSimulatorController.setANNWeights(GeneticAlgorithmController.getWeights(j))

                currentChromosomeCarCount = 0
                For t As Integer = 0 To 5
                    TrafficSimulatorController.runSimulation(simulationLength)
                    currentChromosomeCarCount = currentChromosomeCarCount + TrafficSimulatorController.getCarCount
                    TrafficSimulatorController.resetTrafficGrid()
                Next

                GeneticAlgorithmController.setResult(j, currentChromosomeCarCount)

                populationCarCount = populationCarCount + currentChromosomeCarCount
                'Console.WriteLine("Epoch: " & i & " Chromosome: " & j & " CarCount: " & GeneticAlgorithmController.getResult(j))

                'sr.WriteLine("Epoch:    " & i & " Chromosome:   " & j & " CarCount: " & GeneticAlgorithmController.getResult(j))

            Next

            GeneticAlgorithmController.nextGeneration()
            Console.WriteLine("** Generation: " & i & " Total Population Car Count: " & populationCarCount & " Best Result: " & GeneticAlgorithmController._population(0).result)
            'For w As Integer = 0 To 99
            '    Console.WriteLine("Chromosome: " & w & " Result: " & GeneticAlgorithmController._population(w).result & " Weights: " & Round(GeneticAlgorithmController.debugGetWeights(w, 0), 2) & ", " & Round(GeneticAlgorithmController.debugGetWeights(w, 1), 2) & ", " & Round(GeneticAlgorithmController.debugGetWeights(w, 2), 2) & " ... " & Round(GeneticAlgorithmController.debugGetWeights(w, 316), 2) & ", " & Round(GeneticAlgorithmController.debugGetWeights(w, 317), 2) & ", " & Round(GeneticAlgorithmController.debugGetWeights(w, 318), 2))
            'Next
            'Console.WriteLine()
            'Console.WriteLine()


            'sr.WriteLine("** Generation:    " & i & " Total Population Car Count:   " & populationCarCount & " Best Result: " & GeneticAlgorithmController.getBest)
            'For w As Integer = 0 To 99
            '    sr.WriteLine("Chromosome:   " & w & " Result:   " & GeneticAlgorithmController._population(w).result & "    Weights: " & Round(GeneticAlgorithmController.debugGetWeights(w, 0), 2) & ",        " & Round(GeneticAlgorithmController.debugGetWeights(w, 1), 2) & ",     " & Round(GeneticAlgorithmController.debugGetWeights(w, 2), 2) & "      ...     " & Round(GeneticAlgorithmController.debugGetWeights(w, 316), 2) & ",       " & Round(GeneticAlgorithmController.debugGetWeights(w, 317), 2) & ",       " & Round(GeneticAlgorithmController.debugGetWeights(w, 318), 2))
            'Next
            'sr.WriteLine()
            'sr.WriteLine()
            'sr.WriteLine()

            populationCarCount = 0

        Next



        Dim z As String = ""

        sr.Close()

        Console.Write("Press Enter to Exit...")
        z = Console.ReadLine()

    End Sub

    Public Function RandomNumber() As Integer
        Randomize(System.DateTime.Now.Millisecond)
        RandomNumber = Int(Rnd() * 100)
    End Function

End Module
