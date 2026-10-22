Imports System.Configuration

'' 
'' Author: Paul Killian
'' Contact: PaulKillian@DecodedCortex.com
'' Website: www.DecodedCortex.com
'' 
'' Class: Form1 Partial Class
'' Description: This partial-class handles the non-form related methods from the main BeerMe Windows Form.
''
''
'' This application may be modified from its original work as long as credit to the original developer is given
'' and the resulting application or code derived is not used for profit or other commercial purposes without 
'' written consent from the original developer and Decoded Cortex. Please do not remove these header tags. 
'' 
''
Public Partial Class Form1

    'Create new BeerMeLib object and set data sources
    Private Sub LoadBeerData(pFilePath As String, Optional pLoggingEnabled As Boolean = False)
        Dim _METHOD As String = "LoadBeerData(pFilePath, Optional pLoggingEnabled)"
        Try
            BeerData = New BeerMeLib(pFilePath, pLoggingEnabled)
            Dim AllBeers = BeerData.GetAllBeers
            Me.dgvBeerItems.DataSource = AllBeers
            RefreshData
        Catch ex As Exception
            Dim ErrorMsg As String = "Class: " & _CLASS & ", Method: " & _METHOD & "; InnerException: " & ex.Message
            If BeerData IsNot Nothing
                BeerData.Lager(ErrorMsg)
            End If
            Throw New Exception(ErrorMsg)
        End Try
    End Sub
   
    Private Sub OpenNewDataFile()
            Dim _METHOD As String = "OpenNewDataFile(void)"
            Try
                If ofdOpenDataFile.ShowDialog = Windows.Forms.DialogResult.OK
                    Dim LoggingEnabled As Boolean = False
                    If ConfigurationManager.AppSettings("LoggingEnabled") = "True"
                        LoggingEnabled = True
                    End If
                    LoadBeerData(ofdOpenDataFile.FileName, LoggingEnabled)
                End If
            Catch ex As Exception
                Dim ErrorDesc As String = "Error loading data file. Please try opening a different file."
                Dim ErrorMsg As String = "Class: " & _CLASS & ", Method: " & _METHOD & ", Error:  " & ErrorDesc & "; InnerException: " & ex.Message
                MsgBox(ErrorDesc)
                If BeerData IsNot Nothing
                    BeerData.Lager(ErrorMsg)
                End If
                OpenNewDataFile()   'Attempt to open new data file again.
            End Try
    End Sub

    Public Sub CreateNewDataFile
        If sfdCreateNewDataFile.ShowDialog = Windows.Forms.DialogResult.OK
            Dim SaveFileName As String = sfdCreateNewDataFile.FileName
            If BeerData Is Nothing
                BeerData = New BeerMeLib
                BeerData.CreateNewDataFile(SaveFileName)
                Dim Loggingenabled As Boolean = False
                If ConfigurationManager.AppSettings("LoggingEnabled") = "True"
                    LoggingEnabled = True
                End If
                BeerData = New BeerMeLib(SaveFileName, Loggingenabled)
            Else
                BeerData.CreateNewDataFile(sfdCreateNewDataFile.FileName)
                QueryBeers()
            End If
        End If
        RefreshData()
    End Sub

    'Query the linq data object for beers filtered by the selected beer values
    Public Sub QueryBeers()
        Dim _METHOD As String = "QueryBeers(void)"
        Try
            'Gather list of beer names to include in query 
            Dim Names() As String
            If Not cbQueryAllNames.Checked
                ReDim Names(clbQueryName.CheckedItems.Count - 1)
                For i As Integer = 0 to Names.Count - 1
                    Names(i) = clbQueryName.CheckedItems(i).ToString
                Next
            Else
                ReDim Names(clbQueryName.Items.Count - 1)
                For i As Integer = 0 to Names.Count - 1
                    Names(i) = clbQueryName.Items(i).ToString
                Next
            End If

            'Gather list of beer companies to include in query 
            Dim Companies() As String
            If Not cbQueryAllCompanies.Checked
                ReDim Companies(clbQueryCompany.CheckedItems.Count - 1)
                For i As Integer = 0 to Companies.Count - 1
                    Companies(i) = clbQueryCompany.CheckedItems(i).ToString
                Next
            Else
                ReDim Companies(clbQueryCompany.Items.Count - 1)
                For i As Integer = 0 to Companies.Count - 1
                    Companies(i) = clbQueryCompany.Items(i).ToString
                Next
            End If

            'Gather list of beer styles to include in query
            Dim Styles() As String
            If Not cbQueryAllStyles.Checked
                ReDim Styles(clbQueryStyle.CheckedItems.Count - 1)
                For i As Integer = 0 to Styles.Count - 1
                    Styles(i) = clbQueryStyle.CheckedItems(i).ToString
                Next
            Else
                ReDim Styles(clbQueryStyle.Items.Count - 1)
                For i As Integer = 0 to Styles.Count - 1
                    Styles(i) = clbQueryStyle.Items(i).ToString
                Next
            End If

            Dim Beers = BeerData.QueryBeers(Names, Companies, Styles,  _ 
                                            Convert.ToInt32(cbLook1.Text), Convert.ToInt32(cbLook2.Text), _ 
                                            Convert.ToInt32(cbsmell1.Text), Convert.ToInt32(cbSmell2.Text), _ 
                                            Convert.ToInt32(cbTaste1.Text), Convert.ToInt32(cbTaste2.Text), _ 
                                            Convert.ToInt32(cbFeel1.Text), Convert.ToInt32(cbFeel2.Text), _
                                            Convert.ToInt32(cbOverall1.Text), Convert.ToInt32(cbOverall2.Text), _
                                            cbSortListedBeers.Text, OrderByAscending)
            Me.dgvBeerItems.DataSource = Beers
        Catch ex As Exception
            Dim ErrorDesc As String = "Error querying beer data."
            Dim ErrorMsg As String = "Class: " & _CLASS & ", Method: " & _METHOD & ", Error:  " & ErrorDesc & "; InnerException: " & ex.Message
            MsgBox(ErrorDesc)
            If BeerData IsNot Nothing
                BeerData.Lager(ErrorMsg)
            End If
        End Try
    End Sub

    'Remove the selected beer from the linq data object
    Private Sub RemoveSelectedBeer()
        Dim _METHOD As String = "RemoveSelectedBeer(void)"
        Try
            If dgvBeerItems.SelectedRows.Count = 1
                Dim reply As DialogResult = MessageBox.Show("Are you sure you want to delete the selected beer?", "Confirm Remove Beer", _
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
                If reply = DialogResult.Yes Then
                    BeerData.RemoveBeer(dgvBeerItems.SelectedRows.Item(0).Cells.Item(0).Value) 
                    QueryBeers()
                Else
                    Exit Sub
                End If
            Else
                MsgBox("Cannot Remove Beer - No Beer Selected.")
            End If
        Catch ex As Exception
            Dim ErrorDesc As String = "Error removing selected beer."
            Dim ErrorMsg As String = "Class: " & _CLASS & ", Method: " & _METHOD & ", Error:  " & ErrorDesc & "; InnerException: " & ex.Message
            MsgBox(ErrorDesc)
            If BeerData IsNot Nothing
                BeerData.Lager(ErrorMsg)
            End If
        End Try
    End Sub

    'Show the form to add a beer
    Public Sub AddBeer()
        Dim _METHOD As String = "AddBeer(void)"
        Try
            frmAddBeer.ShowDialog
        Catch ex As Exception
            Dim ErrorDesc As String = "Unable to open Add Beer Windows form"
            Dim ErrorMsg As String = "Class: " & _CLASS & ", Method: " & _METHOD & ", Error:  " & ErrorDesc & "; InnerException: " & ex.Message
            MsgBox(ErrorDesc)
            If BeerData IsNot Nothing
                BeerData.Lager(ErrorMsg)
            End If
        End Try
    End Sub
    
    'Show the form to edit the selected beer
    Public Sub EditSelectedBeer()
        Dim _METHOD As String = "EditSelectedBeer(void)"
        Try
            frmEditBeer.ShowDialog
        Catch ex As Exception
            Dim ErrorDesc As String = "Unable to open Edit Beer Windows Form"
            Dim ErrorMsg As String = "Class: " & _CLASS & ", Method: " & _METHOD & ", Error:  " & ErrorDesc & "; InnerException: " & ex.Message
            MsgBox(ErrorDesc)
            If BeerData IsNot Nothing
                BeerData.Lager(ErrorMsg)
            End If
        End Try
    End Sub
    
    'Refresh all data elements on the form with current data
    Public Sub RefreshData()
        Dim _METHOD As String = "RefreshData(void)"
        Try
            dgvBeerItems.Refresh

            clbQueryName.Items.Clear
            clbQueryCompany.Items.Clear
            clbQueryStyle.Items.Clear
            Dim AllBeers = BeerData.GetAllBeers
            For Each Beer In AllBeers
                clbQueryName.Items.Add(Beer.Name)
                If IsUniqueStyleInListBox(Beer.Style)
                   clbQueryStyle.Items.Add(Beer.Style)
                End If
                If IsUniqueCompanyInListBox(Beer.Company)
                    clbQueryCompany.Items.Add(Beer.Company)
                End If
            Next
        Catch ex As Exception
            Dim ErrorDesc As String = "Error refreshing beer data."
            Dim ErrorMsg As String = "Class: " & _CLASS & ", Method: " & _METHOD & ", Error:  " & ErrorDesc & "; InnerException: " & ex.Message
            MsgBox(ErrorDesc)
            If BeerData IsNot Nothing
                BeerData.Lager(ErrorMsg)
            End If
        End Try
    End Sub

    'Check if style is unique in the beer filter style list box
    Private Function IsUniqueStyleInListBox(pStyle As String) As Boolean
        Dim _METHOD As String = "IsUniqueStyleInListBox(pStyle)"
        Try
            Dim IsUnique As Boolean = True
            For Each item In clbQueryStyle.Items
                If item.ToString = pStyle
                    IsUnique = False
                End If
            Next
            Return IsUnique
        Catch ex As Exception
            Dim ErrorDesc As String = "Error verifying style list box content."
            Dim ErrorMsg As String = "Class: " & _CLASS & ", Method: " & _METHOD & ", Error:  " & ErrorDesc & "; InnerException: " & ex.Message
            MsgBox(ErrorDesc)
            If BeerData IsNot Nothing
                BeerData.Lager(ErrorMsg)
            End If
        End Try
    End Function

    'Check if company is unique in the beer filter company list box
    Private Function IsUniqueCompanyInListBox(pCompany As String) As Boolean
        Dim _METHOD As String = "IsUniqueCompanyInListBox(pCompany)"
        Try
            Dim IsUnique As Boolean = True
            For Each item In clbQueryCompany.Items
                If item.ToString = pCompany
                    IsUnique = False
                End If
            Next
            Return IsUnique
        Catch ex As Exception
            Dim ErrorDesc As String = "Error verifying company list box content."
            Dim ErrorMsg As String = "Class: " & _CLASS & ", Method: " & _METHOD & ", Error:  " & ErrorDesc & "; InnerException: " & ex.Message
            MsgBox(ErrorDesc)
            If BeerData IsNot Nothing
                BeerData.Lager(ErrorMsg)
            End If
        End Try
    End Function

    'Re-arrange window items for new window size
    Public Sub ResizeItems()
        Dim _METHOD As String = "ResizeItems(void)"
        Try
            If ShowBeerFilter
                dgvBeerItems.Top = gbFilterListedBeers.Top + gbFilterListedBeers.Height + BufferGUI
                dgvBeerItems.Height = Me.Height - dgvBeerItems.Top - (5*BufferGUI)
            Else
                dgvBeerItems.Top = MenuStrip1.Top + MenuStrip1.Height + BufferGUI
                dgvBeerItems.Height = Me.Height - dgvBeerItems.Top - (5*BufferGUI)
            End If
    
            gbRightSide.Left = Me.Width - gbRightSide.Width - (2.5*BufferGUI)
            If ShowRightSide
                dgvBeerItems.Width = gbRightSide.Left - (2*BufferGUI)
                gbRightSide.Height = Me.Height - MenuStrip1.Height - gbRightSide.Top - (2*BufferGUI)
                gbBeerDetails.Height = Me.Height - MenuStrip1.Height - gbBeerDetails.Top - (5*BufferGUI) +3
                TabControl1.Height = Me.Height - MenuStrip1.Height - TabControl1.Top - (10*BufferGUI)
                txtBeerComments.Height = Me.Height - MenuStrip1.Height - txtBeerComments.Top - (15*BufferGUI)
                txtBeerCommentsEnlarged.Height = Me.Height - MenuStrip1.Height - txtBeerCommentsEnlarged.Top - (15*BufferGUI)
            Else
                dgvBeerItems.Width = Me.Width - (3*BufferGUI)
            End If
            If dgvBeerItems.Columns.Count > 0
                For i = 0 to dgvBeerItems.ColumnCount-1
                    If i < 3
                        dgvBeerItems.Columns.Item(i).Width = (3 * (dgvBeerItems.Width / (dgvBeerItems.ColumnCount + 6.5)))
                    ElseIf i = dgvBeerItems.Columns.Count-1
                        dgvBeerItems.Columns.Item(i).Width = (1.5 * (dgvBeerItems.Width / (dgvBeerItems.ColumnCount + 6.5)))
                    Else
                        dgvBeerItems.Columns.Item(i).Width = (dgvBeerItems.Width / (dgvBeerItems.ColumnCount + 6.5))
                    End If
                Next
            End If
        Catch ex As Exception
            Dim ErrorDesc As String = "Error resizing Windows Form items."
            Dim ErrorMsg As String = "Class: " & _CLASS & ", Method: " & _METHOD & ", Error:  " & ErrorDesc & "; InnerException: " & ex.Message
            MsgBox(ErrorDesc)
            If BeerData IsNot Nothing
                BeerData.Lager(ErrorMsg)
            End If
        End Try
    End Sub

    'Update the application configuration file so current values remain next time app is opened
    Public Sub UpdateConfigurationFile()
        Dim _METHOD As String = "UpdateConfigurationFile(void)"
        Try
            'Create instance of the configuration file
            Dim config As System.Configuration.Configuration = _
                ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
        
            'Update the configuration settings
            With config.AppSettings
                If .Settings("BeerDataPath") IsNot Nothing Then
                        If .Settings("BeerDataPath").Value <> BeerData.XMLFilePath Then
                            .Settings("BeerDataPath").Value = BeerData.XMLFilePath
                        End If
                End If
                If .Settings("WindowMaximized") IsNot Nothing Then 
                    If Me.WindowState = FormWindowState.Maximized Then
                        .Settings("WindowMaximized").Value = "True"
                    Else
                        .Settings("WindowMaximized").Value = "False"
                    End If
                End If

                If .Settings("WindowWidth").Value IsNot Nothing Then
                    .Settings("WindowWidth").Value = Me.Width
                End If

                If .Settings("WindowHeight").Value IsNot Nothing Then
                    .Settings("WindowHeight").Value = Me.Height
                End If
            End With

        
            'Save the updated configuration file
            config.Save(ConfigurationSaveMode.Modified)
        Catch ex As Exception
            Dim ErrorDesc As String = "Error updating configuration file"
            Dim ErrorMsg As String = "Class: " & _CLASS & ", Method: " & _METHOD & ", Error:  " & ErrorDesc & "; InnerException: " & ex.Message
            MsgBox(ErrorDesc)
            If BeerData IsNot Nothing
                BeerData.Lager(ErrorMsg)
            End If
        End Try
    End Sub

    'Verify lower numeric filter values are valid
    Public Sub VerifyLowerRangeValid(ByRef pString1, ByVal pString2)
        Dim _METHOD As String = "VerifyLowerRangeValid(pString1, pString2)"
        Try
            If (IsNumeric(pString1) AndAlso IsNumeric(pString2))
                If(Convert.ToInt32(pString1) > Convert.ToInt32(pString2))
                    MsgBox("Error - Lower range value cannot be above upper range value")
                    pString1 = (Convert.ToInt32(pString2)).ToString
                End If
            End If
        Catch ex As Exception
            Dim ErrorDesc As String = "Error verifying trackbar lower range valid."
            Dim ErrorMsg As String = "Class: " & _CLASS & ", Method: " & _METHOD & ", Error:  " & ErrorDesc & "; InnerException: " & ex.Message
            MsgBox(ErrorDesc)
            If BeerData IsNot Nothing
                BeerData.Lager(ErrorMsg)
            End If
        End Try
    End Sub

    'Verify upper numeric filter values are valid
    Public Sub VerifyUpperRangeValid(ByVal pString1, ByRef pString2)
        Dim _METHOD As String = "VerifyUpperRangeValid, pString1, pString2)"
        Try
            If (IsNumeric(pString1) AndAlso IsNumeric(pString2))
                If(Convert.ToInt32(pString1) > Convert.ToInt32(pString2))
                    MsgBox("Error - Upper range value cannot be below lower range value")
                    pString2 = (Convert.ToInt32(pString1)).ToString
                End If
            End If
        Catch ex As Exception
            Dim ErrorDesc As String = "Error verifying trackbar upper range valid."
            Dim ErrorMsg As String = "Class: " & _CLASS & ", Method: " & _METHOD & ", Error:  " & ErrorDesc & "; InnerException: " & ex.Message
            MsgBox(ErrorDesc)
            If BeerData IsNot Nothing
                BeerData.Lager(ErrorMsg)
            End If
        End Try
    End Sub
End Class


