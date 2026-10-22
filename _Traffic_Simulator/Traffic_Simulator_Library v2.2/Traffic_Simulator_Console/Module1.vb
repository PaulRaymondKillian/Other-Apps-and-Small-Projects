Module Module1

    Sub Main()

        Dim TrafficSimulatorController As New Traffic_Simulator_Controller.Traffic_Simulator_Controller

        Dim populationChromosomes(100, 319) As Double
        Dim currentChromosome(319) As Double
        Dim populationResults(100) As Integer

        'Create Initial Random Population
        Dim rndNumber As Double
        For i As Integer = 0 To 99
            For j As Integer = 0 To 318
                rndNumber = RandomNumber() / (RandomNumber() + 1) + (RandomNumber() Mod 2)

                If (RandomNumber() > 50) Then
                    rndNumber = -rndNumber
                End If

                populationChromosomes(i, j) = rndNumber

            Next
        Next


        For i As Integer = 0 To 99

            Console.WriteLine("Current Chromosome: " + i.ToString)

            'Fill currentChromosome with current weights
            For j As Integer = 0 To 318
                currentChromosome(j) = populationChromosomes(i, j)
            Next

            TrafficSimulatorController.setANNWeights(currentChromosome)

            populationResults(i) = TrafficSimulatorController.runSimulation(1000)

            Console.WriteLine("Chromosome " + i.ToString + " is Done: " + populationResults(i).ToString)

            TrafficSimulatorController.resetTrafficGrid()

            If (populationResults(i) < 100) Then
                TrafficSimulatorController.writeWeightsToFile()
                Console.WriteLine("****Weights Written To File*****")
            End If

        Next


        Dim z As String = ""

        Console.Write("Press Enter to Exit...")
        z = Console.ReadLine()

    End Sub

    Public Function RandomNumber() As Integer
        Randomize(System.DateTime.Now.Millisecond)
        RandomNumber = Int(Rnd() * 100)
    End Function

End Module
