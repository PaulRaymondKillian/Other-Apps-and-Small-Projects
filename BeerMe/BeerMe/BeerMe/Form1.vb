Imports System.Configuration
Imports System.Xml

''' <summary>
''' Author: Paul Killian
''' Contact: PaulKillian@DecodedCortex.com
''' Website: www.DecodedCortex.com
''' 
''' Class: Form1 Window Class
''' Description: This class handles the main Windows Form of the BeerMe Application
''' </summary>
''' <remarks>
''' This application may be modified from its original work as long as credit to the original developer is given
''' and the resulting application or code derived is not used for profit or other commercial purposes without 
''' written consent from the original developer and Decoded Cortex. Please do not remove these header tags. 
''' </remarks>

Public Class Form1
    Private Const _CLASS As String = "Form1"

    Friend BeerData As BeerMeLib
    Private ShowBeerFilter As Boolean = True
    Private ShowRightSide As Boolean = True
    Private BeerImagePath As String = ""
    Private OrderByAscending As Boolean = True
    Private BufferGUI As Integer = 10

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        UpdateConfigurationFile
        'If BeerData IsNot Nothing
        '    BeerData.Lager("BeerMe Closing")
        'End If
    End Sub

Private Sub Form1_Load( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles MyBase.Load
    Dim _METHOD As String = "Form1_Load"
    Try
        Dim BeerDataPath As String

        BeerDataPath = ConfigurationManager.AppSettings("BeerDataPath")

        If ConfigurationManager.AppSettings("WindowMaximized") = "True"
            Me.WindowState = FormWindowState.Maximized
        Else
            Dim Width, Height As String
            Width = ConfigurationManager.AppSettings("WindowWidth")
            Height = ConfigurationManager.AppSettings("WindowHeight")
            If IsNumeric(Width) Andalso IsNumeric(Height)
                Me.Width = Width
                Me.Height = Height
            End If
        End If

        If ConfigurationManager.AppSettings("CenterWindow") = "True"
            Me.StartPosition = FormStartPosition.CenterScreen
        Else
            Me.StartPosition = FormStartPosition.WindowsDefaultLocation
        End If
            
        Dim LoggingEnabled As Boolean = False
        If ConfigurationManager.AppSettings("LoggingEnabled") = "True"
            LoggingEnabled = True
        End If

        Try
            If BeerDataPath is Nothing
                Throw New Exception("Invalid Configuration File - Possibly Corrupt. Unable to find 'BeerDataPath' key. Recreate data file or open a different one.")
            Else
                LoadBeerData(BeerDataPath, LoggingEnabled)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            'Dim reply As DialogResult = 
            If MessageBox.Show("Would you like to try to open another existing BeerMe data file?", "Would you like to try to open another existing BeerMe data file?", _
              MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                OpenNewDataFile
            Else
                If MessageBox.Show("Would you like to try to create a new BeerMe data file?", "Would you like to try to open another existing BeerMe data file?", _
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                    CreateNewDataFile
                Else
                    Me.Close
                End If   
            End If
        End Try
        BeerData.Lager("BeerMe Started; BeerData Successfully Loaded.")

        'Manually set the default values because the control wont accept inputted default values for drop-down-lists for some reason...
        cbLook1.Text = "0"
        cbLook2.Text = "10"
        cbSmell1.Text = "0"
        cbSmell2.Text = "10"
        cbTaste1.Text = "0"
        cbTaste2.Text = "10"
        cbFeel1.Text = "0"
        cbFeel2.Text = "10"
        cbOverall1.Text = "0"
        cbOverall2.Text = "10"
        cbSortListedBeers.Text = "Name"

        dgvBeerItems.Top = 135
        dgvBeerItems.Height = Me.Height - 180
        ResizeItems()
    Catch ex As Exception
            Dim ErrorDesc As String = "Error loading application."
            Dim ErrorMsg As String = "Class: " & _CLASS & ", Method: " & _METHOD & ", Error:  " & ErrorDesc & "; InnerException: " & ex.Message
            MsgBox(ErrorDesc)
            If BeerData IsNot Nothing
                BeerData.Lager(ErrorMsg)
            End If
        End Try
End Sub

Private Sub dgvBeerItems_CellContentClick( ByVal sender As System.Object,  ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvBeerItems.RowEnter
    Dim Beer As Beer
    If dgvBeerItems.SelectedRows.Count = 1 
        Beer = BeerData.GetBeer(dgvBeerItems.SelectedRows.Item(0).Cells.Item(0).Value)

        BeerImagePath = Beer.Image
        pbSelectedBeerImage.ImageLocation = BeerImagePath
        txtBeerImage.Text = BeerImagePath
        txtBeerName.Text = Beer.Name
        txtBeerCompany.Text = Beer.Company
        txtBeerStyle.Text = Beer.Style
        txtBeerSmell.Text = Beer.Smell
        txtBeerTaste.Text = Beer.Taste
        txtBeerLook.Text = Beer.Look
        txtBeerFeel.Text = Beer.Feel
        txtBeerOverall.Text = Beer.Overall
        txtBeerComments.Text = Beer.Comments
        txtBeerCommentsEnlarged.Text = Beer.Comments
    End If
End Sub

Private Sub AddBeerToolStripMenuItem1_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles AddBeerToolStripMenuItem1.Click
    AddBeer()
End Sub

Private Sub DeleteSelectedBeerToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles DeleteSelectedBeerToolStripMenuItem.Click
    RemoveSelectedBeer
End Sub

Private Sub cbQueryAllNames_CheckedChanged( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles cbQueryAllNames.CheckedChanged
    If cbQueryAllNames.Checked
        clbQueryName.Enabled = False
    Else
        clbQueryName.Enabled = True
    End If
End Sub

Private Sub bListBeers_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles bListBeers.Click
    QueryBeers()
End Sub

Private Sub MenuItemBeerFilter_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles MenuItemBeerFilter.Click
    If ShowBeerFilter
            gbFilterListedBeers.Visible = False
            MenuItemBeerFilter.Text = "Show Beer Filter"
            ShowBeerFilter = False
    Else
            gbFilterListedBeers.Visible = True
            MenuItemBeerFilter.Text = "Hide Beer Filter"
            ShowBeerFilter = True
    End If
    ResizeItems
End Sub

Private Sub cbLook1_SelectedIndexChanged( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles cbLook1.SelectedIndexChanged
        VerifyLowerRangeValid(cbLook1.Text, cbLook2.Text)
End Sub

Private Sub cbLook2_SelectedIndexChanged( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles cbLook2.SelectedIndexChanged
        VerifyUpperRangeValid(cbLook1.Text, cbLook2.Text)
End Sub

Private Sub cbSmell1_SelectedIndexChanged( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles cbSmell1.SelectedIndexChanged
        VerifyLowerRangeValid(cbSmell1.Text, cbSmell2.Text)
End Sub

Private Sub cbSmell2_SelectedIndexChanged( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles cbSmell2.SelectedIndexChanged
        VerifyUpperRangeValid(cbSmell1.Text, cbSmell2.Text)
End Sub

Private Sub cbTaste1_SelectedIndexChanged( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles cbTaste1.SelectedIndexChanged
        VerifyLowerRangeValid(cbTaste1.Text, cbTaste2.Text)
End Sub

Private Sub cbTaste2_SelectedIndexChanged( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles cbTaste2.SelectedIndexChanged
        VerifyUpperRangeValid(cbTaste1.Text, cbTaste2.Text)
End Sub

Private Sub cbFeel1_SelectedIndexChanged( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles cbFeel1.SelectedIndexChanged
        VerifyLowerRangeValid(cbFeel1.Text, cbFeel2.Text)
End Sub

Private Sub cbFeel2_SelectedIndexChanged( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles cbFeel2.SelectedIndexChanged
        VerifyUpperRangeValid(cbFeel1.Text, cbFeel2.Text)
End Sub

Private Sub cbOverall1_SelectedIndexChanged( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles cbOverall1.SelectedIndexChanged
        VerifyLowerRangeValid(cbOverall1.Text, cbOverall2.Text)
End Sub

Private Sub cbOverall2_SelectedIndexChanged( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles cbOverall2.SelectedIndexChanged
        VerifyUpperRangeValid(cbOverall1.Text, cbOverall2.Text)
End Sub

Private Sub rdoSortAscending_CheckedChanged( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles rdoSortAscending.CheckedChanged
    If rdoSortAscending.Checked
        OrderByAscending = True
    End If
End Sub

Private Sub rdoSortDescending_CheckedChanged( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles rdoSortDescending.CheckedChanged
    If rdoSortDescending.Checked
        OrderByAscending = False
    End If
End Sub

Private Sub cbQueryAllStyles_CheckedChanged( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles cbQueryAllStyles.CheckedChanged
    If cbQueryAllStyles.Checked
        clbQueryStyle.Enabled = False
    Else
        clbQueryStyle.Enabled = True
    End If
End Sub

Private Sub btnDeleteBeer_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles btnDeleteBeer.Click
    RemoveSelectedBeer
End Sub

Private Sub btnAddBeer_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles btnAddBeer.Click
    AddBeer
    RefreshData()
    QueryBeers()
End Sub

Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
    ResizeItems()
End Sub

Private Sub MenuItemHideRightSide_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles MenuItemHideRightSide.Click
        If ShowRightSide
            gbRightSide.Visible = False
            ShowRightSide = False
            MenuItemHideRightSide.Text = "Show Right Side"
            Me.MinimumSize = New System.Drawing.Size(700,400)
            dgvBeerItems.Width += 200
            ResizeItems()
            'Me.Width -= 200
        Else
            gbRightSide.Visible = True
            ShowRightSide = True
            MenuItemHideRightSide.Text = "Hide Right Side"
            'Me.Width += 200
            Me.MinimumSize = New System.Drawing.Size(900,400)
            dgvBeerItems.Width -= 200
            ResizeItems()
        End If
End Sub

Private Sub btnEditBeer_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles btnEditBeer.Click
        If dgvBeerItems.SelectedRows.Count = 1 
            Dim SelectedBeer As Beer
            SelectedBeer = BeerData.GetBeer(dgvBeerItems.SelectedRows.Item(0).Cells.Item(0).Value)
            frmEditBeer.EditSelectedBeer(SelectedBeer)
        Else
            MsgBox("Error - Cannot edit beer. No beer is selected.")
        End If
End Sub

Private Sub EditSelectedBeerToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles EditSelectedBeerToolStripMenuItem.Click
        If dgvBeerItems.SelectedRows.Count = 1 
            Dim SelectedBeer As Beer
            SelectedBeer = BeerData.GetBeer(dgvBeerItems.SelectedRows.Item(0).Cells.Item(0).Value)
            frmEditBeer.EditSelectedBeer(SelectedBeer)
        Else
            MsgBox("Error - Cannot edit beer. No beer is selected.")
        End If
End Sub

Private Sub AboutToolStripMenuItem1_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles AboutToolStripMenuItem1.Click
        frmAbout.ShowDialog
End Sub

Private Sub linkEnlargeImage_LinkClicked( ByVal sender As System.Object,  ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkEnlargeImage.LinkClicked
        frmImage.LoadImage(BeerImagePath)
        frmImage.ShowDialog
End Sub

Private Sub ExitToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click    
    Application.Exit
End Sub

Private Sub OpenDataFileToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles OpenDataFileToolStripMenuItem.Click
        OpenNewDataFile()
End Sub

Private Sub cbQueryAllCompanies_CheckedChanged( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles cbQueryAllCompanies.CheckedChanged
        If cbQueryAllCompanies.Checked
            clbQueryCompany.Enabled = False
        Else
            clbQueryCompany.Enabled = True
        End If
End Sub

Private Sub SaveAsDataFileToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles SaveAsDataFileToolStripMenuItem.Click
        CreateNewDataFile
End Sub

Private Sub AboutTheAuthorToolStripMenuItem_Click( ByVal sender As System.Object,  ByVal e As System.EventArgs) Handles AboutTheAuthorToolStripMenuItem.Click
        MsgBox("BeerMe was developed by Paul Killian - www.DecodedCortex.com" & vbCrLf & vbCrLf _ 
               & "Paul likes to study neurology, artificial intelligence, and neocortical emulation and enjoys developing applications of such research. He also enjoys programming simple applications just for fun, and learning new technologies. He is also not great about writing about himself." _ 
               & "He, by which I mean I, can be contacted at PaulKillian@DecodedCortex.com for awesome job offers, free money giveaways, ideas of projects to work on, random things, spam mail, and whatever else." _ 
               & vbCrLf & vbCrLf _
               & "'If you want to set off and go develop some grand new thing, you don't need millions of dollars of capitalization. You need enough pizza and Diet Coke to stick in your refrigerator, a cheap PC to work on, and the dedication to go through with it.'" _ 
               & vbCrLf _ 
                & "- John Carmack")
               
End Sub
End Class
