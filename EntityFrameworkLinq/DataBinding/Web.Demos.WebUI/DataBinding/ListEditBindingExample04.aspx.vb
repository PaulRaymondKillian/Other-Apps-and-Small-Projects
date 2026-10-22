Partial Public Class ListEditBindingExample04
    Inherits System.Web.UI.Page

    Private _mode As String = Constants.TypeOfEditOperation.EditItem

    Protected Sub Page_Load( _
        ByVal sender As Object, _
        ByVal e As System.EventArgs) Handles Me.Load

        'NOTE:  Do not close the ListView edit or insert windows here... The
        '       control must pull information from these windows first.  The
        '       proper place to close these windows is after in the updated,
        '       inserted, deleted events...
    End Sub

#Region "<< Button, LinkButton, etc. Handlers >>"
    Private Sub btnSearch_Click( _
        ByVal sender As Object, _
        ByVal e As System.EventArgs) Handles btnSearch.Click

        gvwResources.Sort(UIUtility.PackParameters(txtTitleFilter.Text), SortDirection.Ascending)
        HideEditWindow()
    End Sub

    Private Sub lnkOpenInsertWindow_Click( _
        ByVal sender As Object, _
        ByVal e As System.EventArgs) Handles lnkOpenInsertWindow.Click

        _mode = Constants.TypeOfEditOperation.NewItem

        ' Pack the parameters for the select methond in ResourceDS
        Dim parms As New ParameterDictionary()
        parms.Add("typeOfSelectToPerform", Constants.TypeOfEditOperation.CloneItem)
        parms.Add("id", String.Empty)

        ' Add the parameter to the ODS select parameters collection...
        Dim modeParm = New Parameter("editMode", TypeCode.String, _mode)
        Dim idParm = New Parameter("id", TypeCode.String, parms("id"))

        odsResourceEdit.SelectParameters.Clear()
        odsResourceEdit.SelectParameters.Add(modeParm)
        odsResourceEdit.SelectParameters.Add(idParm)

        ' This causes a rebind which will call the ODS select to be invoked...
        ShowEditWindow()
    End Sub
#End Region

#Region "<< gvwResources Handlers >>"
    Private Sub gvwResources_RowCommand( _
        ByVal sender As Object, _
        ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) _
        Handles gvwResources.RowCommand

        If e.CommandName = "Select" Then
            Dim args = e.CommandArgument.ToString()
            Dim parms = New ParameterDictionary(args)

            _mode = parms(Constants.EditOperation)

            ' Add the parameter to the ODS select parameters collection...
            Dim modeParm = New Parameter("editMode", TypeCode.String, _mode)
            Dim idParm = New Parameter("id", TypeCode.String, parms("id"))

            odsResourceEdit.SelectParameters.Clear()
            odsResourceEdit.SelectParameters.Add(modeParm)
            odsResourceEdit.SelectParameters.Add(idParm)

            ' This causes a rebind which will call the ODS select to be invoked...
            ShowEditWindow()
        End If
    End Sub

    Private Sub gvwResources_ItemDeleted( _
        ByVal sender As Object, _
        ByVal e As System.Web.UI.WebControls.GridViewDeletedEventArgs) _
        Handles gvwResources.RowDeleted

        HideEditWindow()
        gvwResources.DataBind()
    End Sub

#End Region

#Region "<< fvwEditResource Handlers >>"

    Private Sub fvwEditResource_ItemUpdated( _
        ByVal sender As Object, _
        ByVal e As System.Web.UI.WebControls.FormViewUpdatedEventArgs) _
        Handles fvwEditResource.ItemUpdated

        HideEditWindow()
        gvwResources.DataBind()
    End Sub

    Private Sub fvwEditResource_ItemCommand( _
        ByVal sender As Object, _
        ByVal e As System.Web.UI.WebControls.FormViewCommandEventArgs) _
        Handles fvwEditResource.ItemCommand

        If e.CommandName = "Cancel" Then
            HideEditWindow()
        End If
    End Sub
#End Region

#Region "<< Members Bound to Page >>"
    Protected Function GetEditPageSaveButtonText() As String
        Dim s = String.Empty
        If _mode = Constants.TypeOfEditOperation.EditItem Then
            s = "Update"
        ElseIf _mode = Constants.TypeOfEditOperation.CloneItem Then
            s = "Clone"
        ElseIf _mode = Constants.TypeOfEditOperation.NewItem Then
            s = "Insert"
        End If
        Return s
    End Function

    Protected Function GetOdsEditArgs(ByVal item As Object) As String
        Dim resource = TryCast(item, Resource)

        ' Prepare parms that will be passed to GridView row command handler and
        ' then only ResourceDS select method...
        Dim parms As New ParameterDictionary()
        parms.Add(Constants.EditOperation, Constants.TypeOfEditOperation.EditItem)
        parms.Add("id", resource.Id)

        Return parms.Pack()
    End Function

    Protected Function GetOdsCloneArgs(ByVal item As Object) As String
        Dim resource = TryCast(item, Resource)

        ' Prepare parms that will be passed to GridView row command handler and
        ' then only ResourceDS select method...
        Dim parms As New ParameterDictionary()
        parms.Add(Constants.EditOperation, Constants.TypeOfEditOperation.CloneItem)
        parms.Add("id", resource.Id)

        Return parms.Pack()
    End Function


#End Region

#Region "<< Helpers >>"

    Private Sub ShowEditWindow()
        fvwEditResource.Visible = True
    End Sub

    Private Sub HideEditWindow()
        fvwEditResource.Visible = False
    End Sub

    Private Sub AddOdsSelectParameters( _
        ByVal parameters As ParameterCollection, _
        ByVal selectOption As String, _
        ByVal id As String)

        odsResourceEdit.SelectParameters.Clear()
        Dim parm1 = New Parameter("selectOption", TypeCode.String, selectOption)
        odsResourceEdit.SelectParameters.Add(parm1)

        Dim parm2 = New Parameter("id", TypeCode.String, id)
        odsResourceEdit.SelectParameters.Add(parm2)
    End Sub

#End Region

End Class