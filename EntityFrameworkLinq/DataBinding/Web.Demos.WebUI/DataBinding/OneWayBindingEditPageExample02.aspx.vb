Imports System.Reflection

Partial Public Class OneWayBindingEditPageExample02
    Inherits System.Web.UI.Page

    Protected Sub Page_Load( _
        ByVal sender As Object, _
        ByVal e As System.EventArgs) Handles Me.Load

        If Not Page.IsPostBack Then

            'Get id from QueryString
            Dim id = DirectCast(Session("Id"), String)

            ' Use 1-way databinding in ASP.NET to move data from Resource to form.
            fvwResource.DataSource = ResourceDS.SelectAll()
            dlTest.DataSource = ResourceDS.SelectAll()
            DataBind()
        End If
    End Sub

    Private Sub btnSave_Click( _
        ByVal sender As Object, _
        ByVal e As System.EventArgs) Handles btnSave.Click

        ' Get key from form
        Dim id = GetIdFromForm(fvwResource, "Id")

        ' Get the resource to update.
        Dim resource = ResourceDS.SelectOne(id)

        ' Move form data to Resource object - we must still do this because
        ' binding is 1-way...
        FormToViewModel(fvwResource, resource)
        ResourceDS.Update(resource)

        ' Synchronize the form with any data updated by database
        fvwResource.DataSource = ResourceDS.SelectOneAsList(id)
        DataBind()
    End Sub

    Private Function GetIdFromForm(ByVal form As Control, ByVal key As String) As String
        Dim hdnId = TryCast(form.FindControl("hdnId"), HiddenField)
        Return hdnId.Value
    End Function

    Private Sub FormToViewModel( _
        ByVal form As Control, _
        ByVal resource As Resource)

        Dim txtTitle = TryCast(form.FindControl("txtTitle"), TextBox)
        resource.Title = txtTitle.Text

        Dim txtAssetNumber = TryCast(form.FindControl("txtAssetNumber"), TextBox)
        resource.AssetNumber = txtAssetNumber.Text

        Dim txtPublisher = TryCast(form.FindControl("txtPublisher"), TextBox)
        resource.Publisher = txtPublisher.Text
    End Sub
End Class