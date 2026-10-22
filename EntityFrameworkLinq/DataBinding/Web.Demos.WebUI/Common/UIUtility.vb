Module UIUtility

    Public Function PackParameters(ByVal ParamArray parms As String()) As String
        Dim s As New StringBuilder()

        If parms.Count = 0 Then
            Return String.Empty
        Else
            For Each parm As String In parms
                s.Append(String.Format("{0},", HttpUtility.UrlEncode(parm)))
            Next
        End If
        s.Length -= 1
        Return s.ToString()
    End Function

    Public Function UnpackParameters(ByVal packedParms As String) As IList(Of String)
        Dim ary As String() = packedParms.Split(","c)
        Dim parms As New List(Of String)()
        For Each s As String In ary
            parms.Add(HttpUtility.UrlDecode(s))
        Next

        Return parms
    End Function

    Public Function FindControlInListView( _
        ByVal lv As ListView, _
        ByVal controlId As String) As Control

        For Each item In lv.Items
            Dim control = FindControlRecursive(item, controlId)
            If Not control Is Nothing Then
                Return control
            End If
        Next
        Return Nothing
    End Function

    Public Sub WriteOutResources( _
        ByVal lblOutput As Label)

        For Each r In ResourceDS.SelectAll()
            ' Show updated Resource object
            UIUtility.WriteOut(lblOutput, "Title: '{0}'", r.Title)
            UIUtility.WriteOut(lblOutput, "Asset Number: '{0}'", r.AssetNumber)
            UIUtility.WriteOut(lblOutput, "Publisher: '{0}'", r.Publisher)
            UIUtility.WriteOut(lblOutput, "<hr />")
        Next
    End Sub

    Public Sub WriteOut( _
        ByVal control As Label, _
        ByVal formatString As String, _
        ByVal ParamArray parameters() As String)

        control.Text &= String.Format(formatString, parameters)
        control.Text &= "<br />"
    End Sub

    Public Function FindControlRecursive( _
        ByVal container As Control, _
        ByVal ctrlId As String) As Control

        Dim ctrl As Control = Nothing
        For Each c As Control In container.Controls
            ctrl = FindControlRecursive(c, ctrlId)
            If Not ctrl Is Nothing Then
                Return ctrl
            End If
        Next
        Return container.FindControl(ctrlId)
    End Function
End Module
