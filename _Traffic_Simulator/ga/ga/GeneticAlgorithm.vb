Public Class Chromosome319

    Private _result As Integer
    Private _weights(319) As Double
    Private _selected As Boolean

    Public Sub New()

        _result = 0
        _selected = False

        For i As Integer = 0 To 318
            Dim tempRand As Double = ((RandomNumber() / RandomNumber() + 1) Mod 3)

            If RandomNumber() > 50 Then
                tempRand = -tempRand
            End If

            _weights(i) = tempRand

            If _weights(i) > 3 Then
                MsgBox("You Should Never Get Here - Chromosome Constructor: _weight(" & i & ") = " & _weights(i))
            End If
        Next


    End Sub

    Public Property result() As Integer
        Get
            Return _result
        End Get
        Set(ByVal Value As Integer)
            _result = Value
        End Set
    End Property

    Public Property selected() As Boolean
        Get
            Return _selected
        End Get
        Set(ByVal Value As Boolean)
            _selected = Value
        End Set
    End Property

    Public Sub setWeight(ByVal i As Integer, ByVal v As Double)
        _weights(i) = v
    End Sub

    Public Function getWeight(ByVal i As Integer) As Double
        Return _weights(i)
    End Function

    Public Function getWeights() As Double()
        Return _weights
    End Function

    Public Function RandomNumber() As Integer
        Randomize(System.DateTime.Now.Millisecond)
        RandomNumber = Int(Rnd() * 100)
    End Function

End Class

Public Class GeneticAlgorithm

    Private _populationCount As Integer
    Private _chromosomeWeightCount As Integer
    Private _generations As Integer
    Private _population(100) As Chromosome319

    Public Sub New()
        For i As Integer = 0 To 99
            _population(i) = New Chromosome319
        Next

        _generations = 0
        _populationCount = 100
        _chromosomeWeightCount = 319

    End Sub

    Public Function getWeight(ByVal i As Integer, ByVal j As Integer) As Double

        If (i < _populationCount And j < _chromosomeWeightCount) Then
            Return _population(i).getWeight(j)
        Else
            MsgBox("You Should Never Reach This Point - Function: getweight  Class: GeneticAlgorithm")
        End If
    End Function

    Public Function getWeights(ByVal i As Integer) As Double()
        Return _population(i).getWeights
    End Function

    Public Function getResult(ByVal i As Integer) As Integer
        Return _population(i).result
    End Function

    Public Function wasSelected(ByVal i As Integer) As Boolean
        Return _population(i).selected
    End Function

    Public Sub sortPopulation()
        Dim index As Integer = 0
        Dim sortedPopulation(100) As Chromosome319
        Dim newPopulation(100) As Chromosome319
        Dim currentBestResult As Integer = -1
        Dim currentBestIndex As Integer = -1

        'Sort the list of Chromosomes into sortedPopulation
        For i As Integer = 0 To 99
            If getResult(i) > currentBestResult And wasSelected(i) = False Then
                currentBestResult = getResult(i)
                currentBestIndex = i
            End If

            newPopulation(index) = _population(i)
            _population(i).selected = True
            index = index + 1
        Next
        'Done Sorting

        _population = newPopulation

    End Sub

    Public Function crossBreed(ByVal a As Chromosome319, ByVal b As Chromosome319)
        Dim tempChromosome As New Chromosome319
        Dim point As Integer = (RandomNumber() * RandomNumber()) Mod 318

        For i As Integer = 0 To point
            tempChromosome.setWeight(i, a.getWeight(i))
        Next

        For i As Integer = point + 1 To 318
            tempChromosome.setWeight(i, b.getWeight(i))
        Next

        Return tempChromosome
    End Function

    Public Sub nextGeneration()
        Dim newPopulation(100) As Chromosome319
        Dim mutationPercentage As Integer = 5


        'First sort the population with the best first
        sortPopulation()


        'Clone the top 25, so we leave them entirely alone and continue
        For i As Integer = 0 To 24
            newPopulation(i) = _population(i)
        Next


        'Cross Breed the best 25 together
        For i As Integer = 25 To 49
            newPopulation(i) = crossBreed(_population(RandomNumber() Mod 25), _population(RandomNumber() Mod 25))
        Next



        'Cross Breed all together (no class restrictions)
        For i As Integer = 50 To 74
            newPopulation(i) = crossBreed(_population(RandomNumber() Mod 100), _population(RandomNumber() Mod 100))
        Next

        'Randomly produce last 25 chromosomes
        For i As Integer = 75 To 99
            Dim tempChromosome As New Chromosome319
            newPopulation(i) = tempChromosome
        Next


        'Allow a small number of mutations to occur (no class restrictions)
        For i As Integer = 0 To 99
            If (RandomNumber() < mutationPercentage) Then
                Dim rand As Integer = (RandomNumber() / (RandomNumber() + 1))   'Mutation will always be less than 1
                Dim weightIndex = (RandomNumber() * RandomNumber() Mod 319)     'Index of weight to be mutated

                If RandomNumber() > 50 Then 'Either + or -
                    rand = -rand
                End If

                newPopulation(i).setWeight(weightIndex, newPopulation(i).getWeight(weightIndex) + rand)

            End If
        Next

        _population = newPopulation

    End Sub

    Public Function RandomNumber() As Integer
        Randomize(System.DateTime.Now.Millisecond)
        RandomNumber = Int(Rnd() * 100)
    End Function

End Class
