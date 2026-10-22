Module Module1

    Public Function PointSetDiff(ByVal Set1 As PointSet, ByVal Set2 As PointSet) As Integer

        ''OLD METHOD 1
        'Return AbsVal((Set1.First - Set2.First)) + AbsVal((Set1.Second - Set2.Second))

        ''OLD METHOD 2
        'Dim val1, val2, val3, val4 As Integer
        'val1 = AbsVal(Set1.First - Set2.First)
        'val2 = AbsVal(Set1.First - Set2.Second)
        'val3 = AbsVal(Set1.Second - Set2.First)
        'val4 = AbsVal(Set1.Second - Set2.Second)

        ''Return the smallest of the 4 values
        'If val1 <= val2 AndAlso val1 <= val3 AndAlso val1 <= val4 Then
        '    Return val1
        'ElseIf val2 <= val1 AndAlso val2 <= val3 AndAlso val2 <= val4 Then
        '    Return val2
        'ElseIf val3 <= val1 AndAlso val3 <= val2 AndAlso val3 <= val4 Then
        '    Return val3
        'ElseIf val4 <= val1 AndAlso val4 <= val2 AndAlso val4 <= val3 Then
        '    Return val4
        'Else
        '    Throw New Exception("Should never reach this point....")
        'End If

        Dim SumDiff, SubDiff As Integer
        Dim Diff1 As Integer = 0
        Dim Diff2 As Integer = 0

        Do
            SumDiff = Base16(Set1.First + Diff1)
            SubDiff = Base16(Set1.First - Diff1)
            If SumDiff - Set2.First = 0 Or SumDiff - Set2.Second = 0 Or SubDiff - Set2.First = 0 Or SubDiff - Set2.Second = 0 Then
                Exit Do
            Else
                Diff1 += 1
            End If
        Loop While Diff1 < 8

        Do
            SumDiff = Base16(Set1.Second + Diff2)
            SubDiff = Base16(Set1.Second - Diff2)
            If SumDiff - Set2.First = 0 Or SumDiff - Set2.Second = 0 Or SubDiff - Set2.First = 0 Or SubDiff - Set2.Second = 0 Then
                Exit Do
            Else
                Diff2 += 1
            End If
        Loop While Diff2 < 8


        If Diff1 > Diff2 Then
            Return Diff1
        Else
            Return Diff2
        End If

    End Function


    'This method is needed to easily stay within the base 16 set, which includes negative values also being modulo properly
    Public Function Base16(ByVal Value As Integer) As Integer
        If Value >= 0 Then
            Return Value Mod 16
        Else
            Return (16 + (Value Mod 16)) Mod 16
        End If
    End Function

    Public Function AbsVal(ByVal val As Integer) As Integer
        If val >= 0 Then
            Return val
        Else
            Return -val
        End If
    End Function

    Public Structure PointSet
        Public First As Integer
        Public Second As Integer
    End Structure





    Sub Main()
        'Dim p1 As PointSet
        'Dim p2 As PointSet

        'p1.First = 3
        'p1.Second = 11

        'p2.First = 14
        'p2.Second = 6

        'Console.WriteLine(PointSetDiff(p1, p2))
        'Console.WriteLine(PointSetDiff(p2, p1))

        Dim index As Integer = 6
        Dim diff As Integer = 0

        For i As Integer = 0 To 15
            index += diff
            Console.WriteLine(Base16(index))

            diff = -diff
            If diff < 0 Then
                diff -= 1
            Else
                diff += 1
            End If
        Next


        Dim z As String = Console.ReadLine
    End Sub

End Module
