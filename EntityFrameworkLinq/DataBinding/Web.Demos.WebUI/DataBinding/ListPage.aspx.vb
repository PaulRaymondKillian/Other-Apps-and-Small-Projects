Partial Public Class ListPage
    Inherits System.Web.UI.Page


    Protected Sub Page_Load( _
        ByVal sender As Object, _
        ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then
            lboxResources.DataSource = ResourceDS.SelectAll()
            lboxResources.SelectedIndex = 0
            lboxResources.DataBind()
        End If
    End Sub


    Private Sub lbtnManualBindingEdit_Click( _
        ByVal sender As Object, _
        ByVal e As System.EventArgs) _
        Handles lbtnManualBindingEdit.Click

        If (lboxResources.SelectedIndex >= 0) Then
            Dim id = lboxResources.SelectedValue
            Session("Id") = id
            Response.Redirect("ManualBindingEditPage.aspx")
        End If
    End Sub

    Private Sub lbtnOneWayBindingEditExample01_Click( _
        ByVal sender As Object, _
        ByVal e As System.EventArgs) _
        Handles lbtnOneWayBindingEditExample01.Click

        If (lboxResources.SelectedIndex >= 0) Then
            Dim id = lboxResources.SelectedValue
            Session("Id") = id
            Response.Redirect("OneWayBindingEditPageExample01.aspx")
        End If
    End Sub

    Private Sub lbtnOneWayBindingEditExample02_Click( _
        ByVal sender As Object, _
        ByVal e As System.EventArgs) _
        Handles lbtnOneWayBindingEditExample02.Click

        If (lboxResources.SelectedIndex >= 0) Then
            Dim id = lboxResources.SelectedValue
            Session("Id") = id
            Response.Redirect("OneWayBindingEditPageExample02.aspx")
        End If
    End Sub

    Private Sub lbtnTwoWayBindingEdit_Click( _
        ByVal sender As Object, _
        ByVal e As System.EventArgs) _
        Handles lbtnTwoWayBindingEdit.Click

        If (lboxResources.SelectedIndex >= 0) Then
            Dim id = lboxResources.SelectedValue
            Session("Id") = id
            Response.Redirect("TwoWayBindingEditPage.aspx")
        End If
    End Sub
End Class