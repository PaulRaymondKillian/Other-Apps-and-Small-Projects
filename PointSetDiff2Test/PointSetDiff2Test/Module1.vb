Public Structure PointSet
    Public First As Integer
    Public Second As Integer
End Structure

Module Module1

    Sub Main()
        Dim p1, p2 As PointSet

        p1.First = 7
        p1.Second = 15
        p2.First = 3
        p2.Second = 10

        Dim x As Integer = PointSetDiff2(p1, p2)

    End Sub

    Public Function PointSetDiff2(ByVal Set1 As PointSet, ByVal Set2 As PointSet) As Integer
        Dim Index As Integer = 0
        Dim CurrentVal As Integer = Set1.First
        Dim Diff As Integer
        Dim DiffSet(3) As Integer

        'Find first diff
        Diff = 0
        Do
            If Base16(CurrentVal + Index) = Set2.First Then
                CurrentVal = Set2.First
                Exit Do
            ElseIf Base16(CurrentVal + Index) = Set2.Second Then
                CurrentVal = Set2.Second
                Exit Do
            Else
                Diff += 1
            End If
            Index = Base16(Index + 1)
        Loop
        DiffSet(0) = Diff

        'Find second diff
        Diff = 0
        Index = 0
        Do
            If Base16(CurrentVal + Index) = Set1.First Then
                CurrentVal = Set1.First
                Exit Do
            ElseIf Base16(CurrentVal + Index) = Set1.Second Then
                CurrentVal = Set1.Second
                Exit Do
            Else
                Diff += 1
            End If
            Index = Base16(Index + 1)
        Loop
        DiffSet(1) = Diff

        'Find third diff
        Diff = 0
        Index = 0
        Do
            If Base16(CurrentVal + Index) = Set2.First Then
                CurrentVal = Set2.First
                Exit Do
            ElseIf Base16(CurrentVal + Index) = Set2.Second Then
                CurrentVal = Set2.Second
                Exit Do
            Else
                Diff += 1
            End If
            Index = Base16(Index + 1)
        Loop
        DiffSet(2) = Diff

        'Find fourth diff
        Diff = 0
        Index = 0
        Do
            If Base16(CurrentVal + Index) = Set1.First Then
                CurrentVal = Set1.First
                Exit Do
            ElseIf Base16(CurrentVal + Index) = Set1.Second Then
                CurrentVal = Set1.Second
                Exit Do
            Else
                Diff += 1
            End If
            Index = Base16(Index + 1)
        Loop
        DiffSet(3) = Diff

        Return Mode(DiffSet)

    End Function

    'This method is needed to easily stay within the base 16 set, which includes negative values also being modulo properly
    Public Function Base16(ByVal Value As Integer) As Integer
        If Value >= 0 Then
            Return Value Mod 16
        Else
            Return (16 + (Value Mod 16)) Mod 16
        End If
    End Function

    Public Function Mode(ByVal Array() As Integer) As Integer
        Dim count(15) As Integer
        'Dim ModeVal As Integer

        'If Integer Array does not default to zero, uncomment out this code
        'For i As Integer = 0 To 15
        '    count(i) = 0
        'Next

        For i As Integer = 0 To Array.Length - 1
            If Array(i) >= 0 And Array(i) <= 15 Then
                count(Array(i)) += 1
            Else
                Throw New Exception("Invalid Value for Neuron Point: " & Array(i))
            End If
        Next

        For i As Integer = 0 To 15
            If i = 0 Then
                Mode = i
            Else
                If count(i) > count(Mode) Then
                    Mode = i
                End If
            End If
        Next

        Return Mode

    End Function

End Module
