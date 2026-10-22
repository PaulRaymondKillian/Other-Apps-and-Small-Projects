Imports System.Text

Public Class ParameterDictionary
    Inherits StringDictionary

    Public Sub New()

    End Sub

    Public Sub New(ByVal packedContents As String)
        Dim nameValuePairs = packedContents.Split(","c)
        For Each nameValuePair As String In nameValuePairs
            Dim ary = nameValuePair.Split("="c)
            Me.Add(ary(0), ary(1))
        Next
    End Sub

    Public Function Pack() As String
        Dim sb = New StringBuilder()

        For Each k As String In Me.Keys
            sb.Append(String.Format("{0}={1},", k, Me.Item(k)))
        Next
        If sb.Length > 0 Then
            sb.Length -= 1
        End If
        Return sb.ToString()
    End Function

End Class
