''' <summary>
''' Author: Paul Killian
''' Contact: PaulKillian@DecodedCortex.com
''' Website: www.DecodedCortex.com
''' 
''' Description: This class handles the Windows Form to edit an existing beer in the BeerMe Linq Data Object
''' </summary>
''' <remarks>
''' This application may be modified from its original work as long as credit to the original developer is given
''' and the resulting application or code derived is not used for profit or other commercial purposes without 
''' written consent from the original developer and Decoded Cortex. Please do not remove these header tags. 
''' </remarks>

Public Class frmEditBeer

    Public Sub EditSelectedBeer(pSelectedBeer As Beer)
        LoadBeerData(pSelectedBeer)
        Me.ShowDialog
    End Sub

    Private Sub LoadBeerData(pSelectedBeer As Beer)
        txtName.Text = pSelectedBeer.Name
        txtCompany.Text = pSelectedBeer.Company
        txtStyle.Text = pSelectedBeer.Style
        tbLook.Value = pSelectedBeer.Look
        tbSmell.Value = pSelectedBeer.Smell
        tbTaste.Value = pSelectedBeer.Taste
        tbFeel.Value = pSelectedBeer.Feel
        txtImage.Text = pSelectedBeer.Image
        txtComments.Text = pSelectedBeer.Comments
        lblFeel.Text = tbFeel.Value
        lblLook.Text = tbLook.Value
        lblSmell.Text = tbSmell.Value
        lblTaste.Text = tbTaste.Value
    End Sub

    Private Sub btnSaveChanges_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles btnSaveChanges.Click
        Dim UpdateBeer As Beer
        UpdateBeer.Name = txtName.Text
        UpdateBeer.Company = txtCompany.Text
        UpdateBeer.Style = txtStyle.Text
        UpdateBeer.Look = tbLook.Value
        UpdateBeer.Smell = tbSmell.Value
        UpdateBeer.Taste = tbTaste.Value
        UpdateBeer.Feel = tbFeel.Value
        UpdateBeer.Image = txtImage.Text
        UpdateBeer.Comments = txtComments.Text
        UpdateBeer.Overall = Form1.BeerData.OverallBeerValue(tbLook.Value,tbSmell.Value,tbTaste.Value,tbFeel.Value)
        Form1.BeerData.UpdateBeer(UpdateBeer)
        Form1.RefreshData
        Form1.QueryBeers
        Form1.dgvBeerItems.ClearSelection
        Me.Close
    End Sub

    Private Sub btnImage_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles btnImage.Click
        If ofdImage.ShowDialog = DialogResult.OK
            txtImage.Text = ofdImage.FileName
        End If
    End Sub
End Class