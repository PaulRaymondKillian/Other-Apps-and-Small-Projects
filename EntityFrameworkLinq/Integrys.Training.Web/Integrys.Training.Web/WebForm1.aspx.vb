Imports Integrys.Training.Domain

Public Class WebForm1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim repository As New CustomerRepository()

        If Not Page.IsPostBack Then
            Dim p = repository.FindCustomer(402086622)

            'Move the resource data to the form...
            ViewModelToForm(p, pnlEditPanel)
        End If

    End Sub

    Private Sub ViewModelToForm(ByVal resource As Customer, ByVal form As Control)

        txtCustId.Text = resource.CustId
        txtName.Text = resource.CustFullNm

    End Sub

    Private Sub btnSave_Click( _
    ByVal sender As Object, _
    ByVal e As System.EventArgs) Handles btnSave.Click

        ' Get key from form
        Dim id = GetIdFromForm(pnlEditPanel, "Id")

        ' Get the resource to update. 
        'Dim resource = ResourceDS.SelectOne(id)

        ' Move form data to resource object
        Dim p = FormToViewModel(pnlEditPanel)
        'ResourceDS.Update(resource)

        ' Synchronize the form with any data updated by database
        ViewModelToForm(p, pnlEditPanel)

        DataBind()



    End Sub

    Private Function FormToViewModel(ByVal form As Control) As Customer
        'Dim txtTitle = TryCast(form.FindControl("txtTitle"), TextBox)
        Dim repository As New CustomerRepository()
        'Dim customerFindResults = repository.FindCustomersPaul()
        Dim p = repository.FindCustomer(402086622)

        'Dim txtAssetNumber = TryCast(form.FindControl("txtAssetNumber"), TextBox)
        p.CustFullNm = txtName.Text

        Return p
    End Function

    Private Function GetIdFromForm(ByVal form As Control, ByVal key As String) As String
        Dim hdnId = TryCast(form.FindControl("hdnId"), HiddenField)
        Return hdnId.Value
    End Function

End Class