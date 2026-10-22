Partial Public Class OneWayBindingEditPageExample01
    Inherits System.Web.UI.Page


    Protected Sub Page_Load( _
        ByVal sender As Object, _
        ByVal e As System.EventArgs) Handles Me.Load

        If Not Page.IsPostBack Then
            Dim id = DirectCast(Session("Id"), String)
            Dim r = ResourceDS.SelectOne(id)

            ' Bind data to form...
            BoundResource = r
            DataBind()
        End If
    End Sub

    Private Sub btnSave_Click( _
        ByVal sender As Object, _
        ByVal e As System.EventArgs) Handles btnSave.Click

        ' Get key from form
        Dim id = GetIdFromForm(pnlEditPanel, "Id")

        ' Get the resource to update. 
        Dim r = ResourceDS.SelectOne(id)

        ' Move form data to Resource object - we must still do this because
        ' binding is 1-way...
        FormToViewModel(pnlEditPanel, r)
        ResourceDS.Update(r)

        ' Synchronize the form with any data updated by database
        BoundResource = r
        DataBind()
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
    End Sub

#Region "<< Members Bound to Page >>"
    Protected Function GetHeader() As String
        Return "Binding With Binding Expressions"
    End Function

    Dim _boundResource As Resource
    Protected Property BoundResource() As Resource
        Get
            Return _boundResource
        End Get
        Set(ByVal value As Resource)
            _boundResource = value
        End Set
    End Property
#End Region

End Class