Imports System.Text.RegularExpressions

''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
' Begin Public Class Node
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Public Class Node
    Protected Friend _value As Double
    Protected Friend _links(10) As Node
    Protected Friend _weights(11) As Double

    Public Sub New()
        _value = 0

        For i As Integer = 0 To 11
            _weights(i) = 1
        Next

    End Sub

    Protected Friend Overridable Function getValue() As Double
        Return _value
    End Function

End Class








'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
' Begin Public Class InputNode
'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Public Class InputNode
    Inherits Node

    Protected Friend Sub setValue(ByVal v As Integer)
        _value = v
    End Sub

End Class








''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
' Begin Public class HLL Node
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Public Class HLLNode
    Inherits Node

    Protected Friend Sub setLinks(ByVal n1 As Node, ByVal n2 As Node, ByVal n3 As Node, ByVal n4 As Node, ByVal n5 As Node, ByVal n6 As Node, ByVal n7 As Node, ByVal n8 As Node, ByVal n9 As Node, ByVal n10 As Node)

        _links(0) = n1
        _links(1) = n2
        _links(2) = n3
        _links(3) = n4
        _links(4) = n5
        _links(5) = n6
        _links(6) = n7
        _links(7) = n8
        _links(8) = n9
        _links(9) = n10

    End Sub

    Protected Friend Sub setWeights(ByVal w1 As Double, ByVal w2 As Double, ByVal w3 As Double, ByVal w4 As Double, ByVal w5 As Double, ByVal w6 As Double, ByVal w7 As Double, ByVal w8 As Double, ByVal w9 As Double, ByVal w10 As Double, ByVal w11 As Double)

        _weights(0) = w1
        _weights(1) = w2
        _weights(2) = w3
        _weights(3) = w4
        _weights(4) = w5
        _weights(5) = w6
        _weights(6) = w7
        _weights(7) = w8
        _weights(8) = w9
        _weights(9) = w10
        _weights(10) = w11

    End Sub

    Protected Friend Overrides Function getValue() As Double

        _value = _links(0).getValue * _weights(0) + _
                _links(1).getValue * _weights(1) + _
                _links(2).getValue * _weights(2) + _
                _links(3).getValue * _weights(3) + _
                _links(4).getValue * _weights(4) + _
                _links(5).getValue * _weights(5) + _
                _links(6).getValue * _weights(6) + _
                _links(7).getValue * _weights(7) + _
                _links(8).getValue * _weights(8) + _
                _links(9).getValue * _weights(9) + _
                _weights(10)

        Return _value

    End Function

End Class






''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
' Begin Public Class ArtificialNeuralNetwork10x10x10x9
''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
Public Class ArtificialNeuralNetwork10x10x10x9

    Private inputNodes(10) As InputNode
    Private hiddenLayer1Nodes(10) As HLLNode
    Private hiddenLayer2Nodes(10) As HLLNode
    Private outputLayerNodes(9) As HLLNode


    Public Sub New()

        inputNodes(0) = New InputNode
        inputNodes(1) = New InputNode
        inputNodes(2) = New InputNode
        inputNodes(3) = New InputNode
        inputNodes(4) = New InputNode
        inputNodes(5) = New InputNode
        inputNodes(6) = New InputNode
        inputNodes(7) = New InputNode
        inputNodes(8) = New InputNode
        inputNodes(9) = New InputNode

        hiddenLayer1Nodes(0) = New HLLNode
        hiddenLayer1Nodes(1) = New HLLNode
        hiddenLayer1Nodes(2) = New HLLNode
        hiddenLayer1Nodes(3) = New HLLNode
        hiddenLayer1Nodes(4) = New HLLNode
        hiddenLayer1Nodes(5) = New HLLNode
        hiddenLayer1Nodes(6) = New HLLNode
        hiddenLayer1Nodes(7) = New HLLNode
        hiddenLayer1Nodes(8) = New HLLNode
        hiddenLayer1Nodes(9) = New HLLNode

        hiddenLayer2Nodes(0) = New HLLNode
        hiddenLayer2Nodes(1) = New HLLNode
        hiddenLayer2Nodes(2) = New HLLNode
        hiddenLayer2Nodes(3) = New HLLNode
        hiddenLayer2Nodes(4) = New HLLNode
        hiddenLayer2Nodes(5) = New HLLNode
        hiddenLayer2Nodes(6) = New HLLNode
        hiddenLayer2Nodes(7) = New HLLNode
        hiddenLayer2Nodes(8) = New HLLNode
        hiddenLayer2Nodes(9) = New HLLNode

        outputLayerNodes(0) = New HLLNode
        outputLayerNodes(1) = New HLLNode
        outputLayerNodes(2) = New HLLNode
        outputLayerNodes(3) = New HLLNode
        outputLayerNodes(4) = New HLLNode
        outputLayerNodes(5) = New HLLNode
        outputLayerNodes(6) = New HLLNode
        outputLayerNodes(7) = New HLLNode
        outputLayerNodes(8) = New HLLNode

        For i As Integer = 0 To 9
            hiddenLayer1Nodes(i).setLinks(inputNodes(0), inputNodes(1), inputNodes(2), inputNodes(3), inputNodes(4), inputNodes(5), inputNodes(6), inputNodes(7), inputNodes(8), inputNodes(9))
            hiddenLayer2Nodes(i).setLinks(hiddenLayer1Nodes(0), hiddenLayer1Nodes(1), hiddenLayer1Nodes(2), hiddenLayer1Nodes(3), hiddenLayer1Nodes(4), hiddenLayer1Nodes(5), hiddenLayer1Nodes(6), hiddenLayer1Nodes(7), hiddenLayer1Nodes(8), hiddenLayer1Nodes(9))

            If i < 9 Then
                outputLayerNodes(i).setLinks(hiddenLayer2Nodes(0), hiddenLayer2Nodes(1), hiddenLayer2Nodes(2), hiddenLayer2Nodes(3), hiddenLayer2Nodes(4), hiddenLayer2Nodes(5), hiddenLayer2Nodes(6), hiddenLayer2Nodes(7), hiddenLayer2Nodes(8), hiddenLayer2Nodes(9))
            End If

        Next

    End Sub

    Public Sub setInputNodes(ByVal i1 As Double, ByVal i2 As Double, ByVal i3 As Double, ByVal i4 As Double, ByVal i5 As Double, ByVal i6 As Double, ByVal i7 As Double, ByVal i8 As Double, ByVal i9 As Double, ByVal i10 As Double)

        inputNodes(0).setValue(i1)
        inputNodes(1).setValue(i2)
        inputNodes(2).setValue(i3)
        inputNodes(3).setValue(i4)
        inputNodes(4).setValue(i5)
        inputNodes(5).setValue(i6)
        inputNodes(6).setValue(i7)
        inputNodes(7).setValue(i8)
        inputNodes(8).setValue(i9)
        inputNodes(9).setValue(i10)

    End Sub

    Public Sub setWeights(ByRef weightsArr() As Double)

        For i As Integer = 0 To 109 Step 11

            Dim k As Integer

            If i > 0 Then
                k = (i / 11)
            End If

            hiddenLayer1Nodes(k).setWeights(weightsArr(i), weightsArr(i + 1), weightsArr(i + 2), weightsArr(i + 3), weightsArr(i + 4), weightsArr(i + 5), weightsArr(i + 6), weightsArr(i + 7), weightsArr(i + 8), weightsArr(i + 9), weightsArr(i + 10))
        Next

        For i As Integer = 110 To 219 Step 11

            Dim k As Integer

            If i > 0 Then
                k = ((i / 11) - 10)
            End If

            hiddenLayer2Nodes(k).setWeights(weightsArr(i), weightsArr(i + 1), weightsArr(i + 2), weightsArr(i + 3), weightsArr(i + 4), weightsArr(i + 5), weightsArr(i + 6), weightsArr(i + 7), weightsArr(i + 8), weightsArr(i + 9), weightsArr(i + 10))
        Next


        For i As Integer = 220 To 318 Step 11

            Dim k As Integer

            If i > 0 Then
                k = ((i / 11) - 20)
            End If

            outputLayerNodes(k).setWeights(weightsArr(i), weightsArr(i + 1), weightsArr(i + 2), weightsArr(i + 3), weightsArr(i + 4), weightsArr(i + 5), weightsArr(i + 6), weightsArr(i + 7), weightsArr(i + 8), weightsArr(i + 9), weightsArr(i + 10))
        Next


    End Sub

    Public Function calculateOutput() As String
        Dim s As String = ""

        For i As Integer = 0 To 8
            s = s + outputLayerNodes(i).getValue.ToString + " "
        Next

        Return s

    End Function

    Public Function outputWeights() As String
        Dim s As String = "*"

        For i As Integer = 0 To 9
            For k As Integer = 0 To 10
                s = s + " " + hiddenLayer1Nodes(i)._weights(k).ToString
            Next

            s = s + " | "
        Next

        s = s + "*"

        For i As Integer = 0 To 9
            For k As Integer = 0 To 10
                s = s + " " + hiddenLayer2Nodes(i)._weights(k).ToString
            Next
        Next

        s = s + "*"

        For i As Integer = 0 To 8
            For k As Integer = 0 To 10
                s = s + " " + outputLayerNodes(i)._weights(k).ToString
            Next
        Next

        Return s

    End Function

End Class
