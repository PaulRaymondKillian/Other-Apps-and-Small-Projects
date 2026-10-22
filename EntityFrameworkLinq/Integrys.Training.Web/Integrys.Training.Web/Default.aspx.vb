Imports Integrys.Training.Domain

Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Dim repository As New CustomerRepository()
        'Dim customerFindResults = repository.FindCustomersPaul()

        'Dim contractsByRegionCd = repository.FindActiveContractsInRegionCd("010")

        'Dim contractIdsbyZipcode = repository.FindActiveContractsInZipcode(54302)
        'Dim contractIdsbyZipcode2 = repository.FindActiveContractsInZipcode2(54302)

        'GridView1.DataSource = customerFindResults
        'GridView1.DataSource = contractIdsbyZipcode
        'GridView1.DataBind()

        'repository.AddCustomer()
        'repository.ModifyCustomer()
        'repository.DeleteCustomer()

        'GridView2.DataSource = repository.CallStoredProcExample()
        'GridView2.DataBind()

        'GridView2.DataSource = repository.CallEntitySQLExample()
        'GridView2.DataBind()

        'repository.CompiledQueryExample()

        Me.LiteralExampleUsage.Text = "<b> Howdy World! </b> <p> Welcome </p>"

        'The below will add "window.open()" to the page... I guess....
        ClientScript.RegisterClientScriptBlock("".GetType, "js1", "window.open()")

    End Sub

End Class