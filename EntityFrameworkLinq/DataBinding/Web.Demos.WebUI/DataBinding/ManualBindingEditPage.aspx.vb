
Partial Public Class ManualBindingEditPage
    Inherits System.Web.UI.Page

    Protected Sub Page_Load( _
        ByVal sender As Object, _
        ByVal e As System.EventArgs) Handles Me.Load

        If Not Page.IsPostBack Then
            Dim id = DirectCast(Session("Id"), String)
            Dim r = ResourceDS.SelectOne(id)

            ' Move the resource data to the form...
            ViewModelToForm(r, pnlEditPanel)
        End If
    End Sub

    Private Sub btnSave_Click( _
        ByVal sender As Object, _
        ByVal e As System.EventArgs) Handles btnSave.Click

        ' Get key from form
        Dim id = GetIdFromForm(pnlEditPanel, "Id")

        ' Get the resource to update. 
        Dim resource = ResourceDS.SelectOne(id)

        ' Move form data to resource object
        FormToViewModel(pnlEditPanel, resource)
        ResourceDS.Update(resource)

        ' Synchronize the form with any data updated by database
        ViewModelToForm(resource, pnlEditPanel)
    End Sub

    Private Sub ViewModelToForm(ByVal resource As Resource, ByVal form As Control)
        Dim hdnId = TryCast(form.FindControl("hdnId"), HiddenField)
        hdnId.Value = resource.Id.ToString()

        Dim txtTitle = TryCast(form.FindControl("txtTitle"), TextBox)
        txtTitle.Text = resource.Title

        Dim txtAssetNumber = TryCast(form.FindControl("txtAssetNumber"), TextBox)
        txtAssetNumber.Text = resource.AssetNumber

        Dim txtPublisher = TryCast(form.FindControl("txtPublisher"), TextBox)
        txtPublisher.Text = resource.Publisher

        Dim lblVersion = TryCast(form.FindControl("lblVersion"), Label)
        lblVersion.Text = resource.Version
    End Sub

    Private Function GetIdFromForm(ByVal form As Control, ByVal key As String) As String
        Dim hdnId = TryCast(form.FindControl("hdnId"), HiddenField)
        Return hdnId.Value
    End Function

    Private Sub FormToViewModel(ByVal form As Control, ByVal resource As Resource)
        Dim txtTitle = TryCast(form.FindControl("txtTitle"), TextBox)
        resource.Title = txtTitle.Text

        Dim txtAssetNumber = TryCast(form.FindControl("txtAssetNumber"), TextBox)
        resource.AssetNumber = txtAssetNumber.Text

        Dim txtPublisher = TryCast(form.FindControl("txtPublisher"), TextBox)
        resource.Publisher = txtPublisher.Text

        Dim lblVersion = TryCast(form.FindControl("lblVersion"), Label)
        resource.Version = lblVersion.Text
    End Sub
End Class