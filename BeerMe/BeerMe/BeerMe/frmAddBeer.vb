''' <summary>
''' Author: Paul Killian
''' Contact: PaulKillian@DecodedCortex.com
''' Website: www.DecodedCortex.com
''' 
''' Description: This class handles the Windows Form that enables a user to add a beer item to the Linq Data Object
''' </summary>
''' <remarks>
''' This application may be modified from its original work as long as credit to the original developer is given
''' and the resulting application or code derived is not used for profit or other commercial purposes without 
''' written consent from the original developer and Decoded Cortex. Please do not remove these header tags. 
''' </remarks>

Public Class frmAddBeer

Private Sub btnAddBeer_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles btnAddBeer.Click
        If txtName.Text = "" Then
            MsgBox("Error - Cannot add beer. Please enter a name.")
        ElseIf Not Form1.BeerData.UniqueName(txtName.Text) Then
            MsgBox("Error - Cannot add beer. Beer name already exists.")
        ElseIf txtStyle.Text = "" Then
            MsgBox("Error - Cannot add beer. Please enter style.")
        Else
            Try
                Form1.BeerData.AddBeer(txtName.Text, txtCompany.Text, txtStyle.Text, tbLook.Value, tbSmell.Value, tbTaste.Value, tbFeel.Value, txtImage.Text, txtComments.Text) 
                Form1.QueryBeers()
                ClearFormValues()
                Me.Close 
            Catch ex As Exception
                MsgBox("Error - Cannot add beer." & ex.Message)
            End Try
        End If
End Sub

Private Sub tbLook_Scroll( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles tbLook.Scroll
        lblLook.Text = tbLook.Value
End Sub

Private Sub tbSmell_Scroll( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles tbSmell.Scroll
        lblSmell.Text = tbSmell.Value
End Sub

Private Sub tbTaste_Scroll( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles tbTaste.Scroll
        lblTaste.Text = tbTaste.Value
End Sub

Private Sub tbFeel_Scroll( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles tbFeel.Scroll
        lblFeel.Text = tbFeel.Value
End Sub

Private Sub btnImage_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles btnImage.Click
        If ofdImage.ShowDialog = DialogResult.OK
            txtImage.Text = ofdImage.FileName
        End If
End Sub

Public Sub ClearFormValues()
        txtComments.Text = ""
        txtImage.Text = ""
        txtName.Text = ""
        txtStyle.Text = ""
        txtCompany.Text = ""
        tbFeel.Value = 0
        tbTaste.Value = 0
        tbSmell.Value = 0
        tbLook.Value = 0
        lblFeel.Text = "0"
        lblTaste.Text = "0"
        lblSmell.Text = "0"
        lblLook.Text = "0"
End Sub

Private Sub txtStyle_TextChanged( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles txtStyle.TextChanged

End Sub

Private Sub frmAddBeer_Load( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles MyBase.Load

End Sub
End Class