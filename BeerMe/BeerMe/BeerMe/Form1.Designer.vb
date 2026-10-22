<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.dgvBeerItems = New System.Windows.Forms.DataGridView()
        Me.pbSelectedBeerImage = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsDataFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenDataFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddBeerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddBeerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditSelectedBeerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteSelectedBeerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetDataFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemBeerFilter = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemHideRightSide = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtBeerName = New System.Windows.Forms.TextBox()
        Me.clbQueryName = New System.Windows.Forms.CheckedListBox()
        Me.cbQueryAllNames = New System.Windows.Forms.CheckBox()
        Me.bListBeers = New System.Windows.Forms.Button()
        Me.gbFilterListedBeers = New System.Windows.Forms.GroupBox()
        Me.cbQueryAllCompanies = New System.Windows.Forms.CheckBox()
        Me.clbQueryCompany = New System.Windows.Forms.CheckedListBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cbOverall2 = New System.Windows.Forms.ComboBox()
        Me.cbOverall1 = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.gbSortListedBeers = New System.Windows.Forms.GroupBox()
        Me.rdoSortDescending = New System.Windows.Forms.RadioButton()
        Me.rdoSortAscending = New System.Windows.Forms.RadioButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbSortListedBeers = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbFeel2 = New System.Windows.Forms.ComboBox()
        Me.cbFeel1 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbTaste2 = New System.Windows.Forms.ComboBox()
        Me.cbTaste1 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbSmell2 = New System.Windows.Forms.ComboBox()
        Me.cbSmell1 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbLook2 = New System.Windows.Forms.ComboBox()
        Me.cbLook1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbQueryAllStyles = New System.Windows.Forms.CheckBox()
        Me.clbQueryStyle = New System.Windows.Forms.CheckedListBox()
        Me.gbBeerDetails = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtBeerOverall = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtBeerCompany = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtBeerComments = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtBeerStyle = New System.Windows.Forms.TextBox()
        Me.txtBeerFeel = New System.Windows.Forms.TextBox()
        Me.txtBeerTaste = New System.Windows.Forms.TextBox()
        Me.txtBeerSmell = New System.Windows.Forms.TextBox()
        Me.txtBeerLook = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblBeerStyle = New System.Windows.Forms.Label()
        Me.lblBeerName = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.linkEnlargeImage = New System.Windows.Forms.LinkLabel()
        Me.txtBeerImage = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.txtBeerCommentsEnlarged = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.btnAddBeer = New System.Windows.Forms.Button()
        Me.btnDeleteBeer = New System.Windows.Forms.Button()
        Me.gbRightSide = New System.Windows.Forms.GroupBox()
        Me.btnEditBeer = New System.Windows.Forms.Button()
        Me.ofdOpenDataFile = New System.Windows.Forms.OpenFileDialog()
        Me.sfdSaveDataFile = New System.Windows.Forms.SaveFileDialog()
        Me.sfdCreateNewDataFile = New System.Windows.Forms.SaveFileDialog()
        Me.AboutTheAuthorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgvBeerItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbSelectedBeerImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.gbFilterListedBeers.SuspendLayout()
        Me.gbSortListedBeers.SuspendLayout()
        Me.gbBeerDetails.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.gbRightSide.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvBeerItems
        '
        Me.dgvBeerItems.AllowUserToAddRows = False
        Me.dgvBeerItems.AllowUserToDeleteRows = False
        Me.dgvBeerItems.AllowUserToResizeRows = False
        Me.dgvBeerItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBeerItems.Location = New System.Drawing.Point(12, 160)
        Me.dgvBeerItems.MultiSelect = False
        Me.dgvBeerItems.Name = "dgvBeerItems"
        Me.dgvBeerItems.ReadOnly = True
        Me.dgvBeerItems.RowHeadersWidth = 10
        Me.dgvBeerItems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvBeerItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBeerItems.Size = New System.Drawing.Size(655, 219)
        Me.dgvBeerItems.TabIndex = 0
        '
        'pbSelectedBeerImage
        '
        Me.pbSelectedBeerImage.Location = New System.Drawing.Point(6, 6)
        Me.pbSelectedBeerImage.Name = "pbSelectedBeerImage"
        Me.pbSelectedBeerImage.Size = New System.Drawing.Size(168, 207)
        Me.pbSelectedBeerImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbSelectedBeerImage.TabIndex = 1
        Me.pbSelectedBeerImage.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AddBeerToolStripMenuItem, Me.MenuItemBeerFilter, Me.MenuItemHideRightSide, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(909, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveAsDataFileToolStripMenuItem, Me.OpenDataFileToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'SaveAsDataFileToolStripMenuItem
        '
        Me.SaveAsDataFileToolStripMenuItem.Name = "SaveAsDataFileToolStripMenuItem"
        Me.SaveAsDataFileToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.SaveAsDataFileToolStripMenuItem.Text = "&Create New Data File"
        '
        'OpenDataFileToolStripMenuItem
        '
        Me.OpenDataFileToolStripMenuItem.Name = "OpenDataFileToolStripMenuItem"
        Me.OpenDataFileToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.OpenDataFileToolStripMenuItem.Text = "&Open Data File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'AddBeerToolStripMenuItem
        '
        Me.AddBeerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddBeerToolStripMenuItem1, Me.EditSelectedBeerToolStripMenuItem, Me.DeleteSelectedBeerToolStripMenuItem, Me.AdministrationToolStripMenuItem})
        Me.AddBeerToolStripMenuItem.Name = "AddBeerToolStripMenuItem"
        Me.AddBeerToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.AddBeerToolStripMenuItem.Text = "&Commands"
        '
        'AddBeerToolStripMenuItem1
        '
        Me.AddBeerToolStripMenuItem1.Name = "AddBeerToolStripMenuItem1"
        Me.AddBeerToolStripMenuItem1.Size = New System.Drawing.Size(190, 22)
        Me.AddBeerToolStripMenuItem1.Text = "&Add Beer"
        '
        'EditSelectedBeerToolStripMenuItem
        '
        Me.EditSelectedBeerToolStripMenuItem.Name = "EditSelectedBeerToolStripMenuItem"
        Me.EditSelectedBeerToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.EditSelectedBeerToolStripMenuItem.Text = "&Edit Selected Beer"
        '
        'DeleteSelectedBeerToolStripMenuItem
        '
        Me.DeleteSelectedBeerToolStripMenuItem.Name = "DeleteSelectedBeerToolStripMenuItem"
        Me.DeleteSelectedBeerToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.DeleteSelectedBeerToolStripMenuItem.Text = "&Remove Selected Beer"
        '
        'AdministrationToolStripMenuItem
        '
        Me.AdministrationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetDataFileToolStripMenuItem})
        Me.AdministrationToolStripMenuItem.Name = "AdministrationToolStripMenuItem"
        Me.AdministrationToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.AdministrationToolStripMenuItem.Text = "&Administration"
        '
        'ResetDataFileToolStripMenuItem
        '
        Me.ResetDataFileToolStripMenuItem.Name = "ResetDataFileToolStripMenuItem"
        Me.ResetDataFileToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.ResetDataFileToolStripMenuItem.Text = "&Reset Data File"
        '
        'MenuItemBeerFilter
        '
        Me.MenuItemBeerFilter.Name = "MenuItemBeerFilter"
        Me.MenuItemBeerFilter.Size = New System.Drawing.Size(99, 20)
        Me.MenuItemBeerFilter.Text = "Hide Beer Filter"
        '
        'MenuItemHideRightSide
        '
        Me.MenuItemHideRightSide.Name = "MenuItemHideRightSide"
        Me.MenuItemHideRightSide.Size = New System.Drawing.Size(100, 20)
        Me.MenuItemHideRightSide.Text = "Hide Right Side"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem1, Me.AboutTheAuthorToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(191, 22)
        Me.AboutToolStripMenuItem1.Text = "&About the Application"
        '
        'txtBeerName
        '
        Me.txtBeerName.Location = New System.Drawing.Point(48, 14)
        Me.txtBeerName.Name = "txtBeerName"
        Me.txtBeerName.ReadOnly = True
        Me.txtBeerName.Size = New System.Drawing.Size(126, 20)
        Me.txtBeerName.TabIndex = 2
        '
        'clbQueryName
        '
        Me.clbQueryName.CheckOnClick = True
        Me.clbQueryName.FormattingEnabled = True
        Me.clbQueryName.Location = New System.Drawing.Point(6, 40)
        Me.clbQueryName.Name = "clbQueryName"
        Me.clbQueryName.Size = New System.Drawing.Size(110, 79)
        Me.clbQueryName.TabIndex = 2
        '
        'cbQueryAllNames
        '
        Me.cbQueryAllNames.AutoSize = True
        Me.cbQueryAllNames.Checked = True
        Me.cbQueryAllNames.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbQueryAllNames.Location = New System.Drawing.Point(6, 19)
        Me.cbQueryAllNames.Name = "cbQueryAllNames"
        Me.cbQueryAllNames.Size = New System.Drawing.Size(73, 17)
        Me.cbQueryAllNames.TabIndex = 1
        Me.cbQueryAllNames.Text = "All Names"
        Me.cbQueryAllNames.UseVisualStyleBackColor = True
        '
        'bListBeers
        '
        Me.bListBeers.Location = New System.Drawing.Point(518, 89)
        Me.bListBeers.Name = "bListBeers"
        Me.bListBeers.Size = New System.Drawing.Size(155, 34)
        Me.bListBeers.TabIndex = 1
        Me.bListBeers.Text = "List Beers"
        Me.bListBeers.UseVisualStyleBackColor = True
        '
        'gbFilterListedBeers
        '
        Me.gbFilterListedBeers.Controls.Add(Me.cbQueryAllCompanies)
        Me.gbFilterListedBeers.Controls.Add(Me.clbQueryCompany)
        Me.gbFilterListedBeers.Controls.Add(Me.Label15)
        Me.gbFilterListedBeers.Controls.Add(Me.cbOverall2)
        Me.gbFilterListedBeers.Controls.Add(Me.cbOverall1)
        Me.gbFilterListedBeers.Controls.Add(Me.Label16)
        Me.gbFilterListedBeers.Controls.Add(Me.gbSortListedBeers)
        Me.gbFilterListedBeers.Controls.Add(Me.Label8)
        Me.gbFilterListedBeers.Controls.Add(Me.cbFeel2)
        Me.gbFilterListedBeers.Controls.Add(Me.cbFeel1)
        Me.gbFilterListedBeers.Controls.Add(Me.Label7)
        Me.gbFilterListedBeers.Controls.Add(Me.cbTaste2)
        Me.gbFilterListedBeers.Controls.Add(Me.bListBeers)
        Me.gbFilterListedBeers.Controls.Add(Me.cbTaste1)
        Me.gbFilterListedBeers.Controls.Add(Me.Label6)
        Me.gbFilterListedBeers.Controls.Add(Me.cbSmell2)
        Me.gbFilterListedBeers.Controls.Add(Me.cbSmell1)
        Me.gbFilterListedBeers.Controls.Add(Me.Label5)
        Me.gbFilterListedBeers.Controls.Add(Me.cbLook2)
        Me.gbFilterListedBeers.Controls.Add(Me.cbLook1)
        Me.gbFilterListedBeers.Controls.Add(Me.Label4)
        Me.gbFilterListedBeers.Controls.Add(Me.Label3)
        Me.gbFilterListedBeers.Controls.Add(Me.Label2)
        Me.gbFilterListedBeers.Controls.Add(Me.Label1)
        Me.gbFilterListedBeers.Controls.Add(Me.cbQueryAllStyles)
        Me.gbFilterListedBeers.Controls.Add(Me.clbQueryStyle)
        Me.gbFilterListedBeers.Controls.Add(Me.cbQueryAllNames)
        Me.gbFilterListedBeers.Controls.Add(Me.clbQueryName)
        Me.gbFilterListedBeers.Location = New System.Drawing.Point(12, 27)
        Me.gbFilterListedBeers.Name = "gbFilterListedBeers"
        Me.gbFilterListedBeers.Size = New System.Drawing.Size(679, 128)
        Me.gbFilterListedBeers.TabIndex = 10
        Me.gbFilterListedBeers.TabStop = False
        Me.gbFilterListedBeers.Text = "  Filter Listed Beers"
        '
        'cbQueryAllCompanies
        '
        Me.cbQueryAllCompanies.AutoSize = True
        Me.cbQueryAllCompanies.Checked = True
        Me.cbQueryAllCompanies.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbQueryAllCompanies.Location = New System.Drawing.Point(122, 17)
        Me.cbQueryAllCompanies.Name = "cbQueryAllCompanies"
        Me.cbQueryAllCompanies.Size = New System.Drawing.Size(92, 17)
        Me.cbQueryAllCompanies.TabIndex = 3
        Me.cbQueryAllCompanies.Text = "All Companies"
        Me.cbQueryAllCompanies.UseVisualStyleBackColor = True
        '
        'clbQueryCompany
        '
        Me.clbQueryCompany.CheckOnClick = True
        Me.clbQueryCompany.Enabled = False
        Me.clbQueryCompany.FormattingEnabled = True
        Me.clbQueryCompany.Location = New System.Drawing.Point(122, 38)
        Me.clbQueryCompany.Name = "clbQueryCompany"
        Me.clbQueryCompany.Size = New System.Drawing.Size(110, 79)
        Me.clbQueryCompany.TabIndex = 4
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(443, 106)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(16, 13)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "to"
        '
        'cbOverall2
        '
        Me.cbOverall2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbOverall2.FormattingEnabled = True
        Me.cbOverall2.Items.AddRange(New Object() {"10", "9", "8", "7", "6", "5", "4", "3", "2", "1", "0"})
        Me.cbOverall2.Location = New System.Drawing.Point(465, 104)
        Me.cbOverall2.Name = "cbOverall2"
        Me.cbOverall2.Size = New System.Drawing.Size(38, 21)
        Me.cbOverall2.TabIndex = 16
        '
        'cbOverall1
        '
        Me.cbOverall1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbOverall1.FormattingEnabled = True
        Me.cbOverall1.Items.AddRange(New Object() {"10", "9", "8", "7", "6", "5", "4", "3", "2", "1", "0"})
        Me.cbOverall1.Location = New System.Drawing.Point(403, 103)
        Me.cbOverall1.Name = "cbOverall1"
        Me.cbOverall1.Size = New System.Drawing.Size(34, 21)
        Me.cbOverall1.TabIndex = 15
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(354, 107)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(43, 13)
        Me.Label16.TabIndex = 29
        Me.Label16.Text = "Overall:"
        '
        'gbSortListedBeers
        '
        Me.gbSortListedBeers.Controls.Add(Me.rdoSortDescending)
        Me.gbSortListedBeers.Controls.Add(Me.rdoSortAscending)
        Me.gbSortListedBeers.Controls.Add(Me.Label9)
        Me.gbSortListedBeers.Controls.Add(Me.cbSortListedBeers)
        Me.gbSortListedBeers.Location = New System.Drawing.Point(509, 1)
        Me.gbSortListedBeers.Name = "gbSortListedBeers"
        Me.gbSortListedBeers.Size = New System.Drawing.Size(170, 82)
        Me.gbSortListedBeers.TabIndex = 28
        Me.gbSortListedBeers.TabStop = False
        Me.gbSortListedBeers.Text = "Sort Listed Beers"
        '
        'rdoSortDescending
        '
        Me.rdoSortDescending.AutoSize = True
        Me.rdoSortDescending.Location = New System.Drawing.Point(81, 43)
        Me.rdoSortDescending.Name = "rdoSortDescending"
        Me.rdoSortDescending.Size = New System.Drawing.Size(82, 17)
        Me.rdoSortDescending.TabIndex = 3
        Me.rdoSortDescending.Text = "Descending"
        Me.rdoSortDescending.UseVisualStyleBackColor = True
        '
        'rdoSortAscending
        '
        Me.rdoSortAscending.AutoSize = True
        Me.rdoSortAscending.Checked = True
        Me.rdoSortAscending.Location = New System.Drawing.Point(9, 42)
        Me.rdoSortAscending.Name = "rdoSortAscending"
        Me.rdoSortAscending.Size = New System.Drawing.Size(75, 17)
        Me.rdoSortAscending.TabIndex = 2
        Me.rdoSortAscending.TabStop = True
        Me.rdoSortAscending.Text = "Ascending"
        Me.rdoSortAscending.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Order By:"
        '
        'cbSortListedBeers
        '
        Me.cbSortListedBeers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSortListedBeers.FormattingEnabled = True
        Me.cbSortListedBeers.Items.AddRange(New Object() {"Name", "Company", "Style", "Look", "Smell", "Taste", "Feel", "Overall"})
        Me.cbSortListedBeers.Location = New System.Drawing.Point(63, 20)
        Me.cbSortListedBeers.Name = "cbSortListedBeers"
        Me.cbSortListedBeers.Size = New System.Drawing.Size(90, 21)
        Me.cbSortListedBeers.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(443, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(16, 13)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "to"
        '
        'cbFeel2
        '
        Me.cbFeel2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFeel2.FormattingEnabled = True
        Me.cbFeel2.Items.AddRange(New Object() {"10", "9", "8", "7", "6", "5", "4", "3", "2", "1", "0"})
        Me.cbFeel2.Location = New System.Drawing.Point(465, 82)
        Me.cbFeel2.Name = "cbFeel2"
        Me.cbFeel2.Size = New System.Drawing.Size(38, 21)
        Me.cbFeel2.TabIndex = 14
        '
        'cbFeel1
        '
        Me.cbFeel1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbFeel1.FormattingEnabled = True
        Me.cbFeel1.Items.AddRange(New Object() {"10", "9", "8", "7", "6", "5", "4", "3", "2", "1", "0"})
        Me.cbFeel1.Location = New System.Drawing.Point(403, 81)
        Me.cbFeel1.Name = "cbFeel1"
        Me.cbFeel1.Size = New System.Drawing.Size(34, 21)
        Me.cbFeel1.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(443, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(16, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "to"
        '
        'cbTaste2
        '
        Me.cbTaste2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTaste2.FormattingEnabled = True
        Me.cbTaste2.Items.AddRange(New Object() {"10", "9", "8", "7", "6", "5", "4", "3", "2", "1", "0"})
        Me.cbTaste2.Location = New System.Drawing.Point(465, 61)
        Me.cbTaste2.Name = "cbTaste2"
        Me.cbTaste2.Size = New System.Drawing.Size(38, 21)
        Me.cbTaste2.TabIndex = 12
        '
        'cbTaste1
        '
        Me.cbTaste1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbTaste1.FormattingEnabled = True
        Me.cbTaste1.Items.AddRange(New Object() {"10", "9", "8", "7", "6", "5", "4", "3", "2", "1", "0"})
        Me.cbTaste1.Location = New System.Drawing.Point(403, 60)
        Me.cbTaste1.Name = "cbTaste1"
        Me.cbTaste1.Size = New System.Drawing.Size(34, 21)
        Me.cbTaste1.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(443, 41)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "to"
        '
        'cbSmell2
        '
        Me.cbSmell2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSmell2.FormattingEnabled = True
        Me.cbSmell2.Items.AddRange(New Object() {"10", "9", "8", "7", "6", "5", "4", "3", "2", "1", "0"})
        Me.cbSmell2.Location = New System.Drawing.Point(465, 39)
        Me.cbSmell2.Name = "cbSmell2"
        Me.cbSmell2.Size = New System.Drawing.Size(38, 21)
        Me.cbSmell2.TabIndex = 10
        '
        'cbSmell1
        '
        Me.cbSmell1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbSmell1.FormattingEnabled = True
        Me.cbSmell1.Items.AddRange(New Object() {"10", "9", "8", "7", "6", "5", "4", "3", "2", "1", "0"})
        Me.cbSmell1.Location = New System.Drawing.Point(403, 38)
        Me.cbSmell1.Name = "cbSmell1"
        Me.cbSmell1.Size = New System.Drawing.Size(34, 21)
        Me.cbSmell1.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(443, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "to"
        '
        'cbLook2
        '
        Me.cbLook2.DisplayMember = "0"
        Me.cbLook2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLook2.FormattingEnabled = True
        Me.cbLook2.Items.AddRange(New Object() {"10", "9", "8", "7", "6", "5", "4", "3", "2", "1", "0"})
        Me.cbLook2.Location = New System.Drawing.Point(465, 17)
        Me.cbLook2.Name = "cbLook2"
        Me.cbLook2.Size = New System.Drawing.Size(38, 21)
        Me.cbLook2.TabIndex = 8
        '
        'cbLook1
        '
        Me.cbLook1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbLook1.FormattingEnabled = True
        Me.cbLook1.Items.AddRange(New Object() {"10", "9", "8", "7", "6", "5", "4", "3", "2", "1", "0"})
        Me.cbLook1.Location = New System.Drawing.Point(403, 16)
        Me.cbLook1.Name = "cbLook1"
        Me.cbLook1.Size = New System.Drawing.Size(34, 21)
        Me.cbLook1.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(367, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Feel:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(360, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Taste:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(362, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Smell:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(363, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Look:"
        '
        'cbQueryAllStyles
        '
        Me.cbQueryAllStyles.AutoSize = True
        Me.cbQueryAllStyles.Checked = True
        Me.cbQueryAllStyles.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbQueryAllStyles.Location = New System.Drawing.Point(238, 19)
        Me.cbQueryAllStyles.Name = "cbQueryAllStyles"
        Me.cbQueryAllStyles.Size = New System.Drawing.Size(68, 17)
        Me.cbQueryAllStyles.TabIndex = 5
        Me.cbQueryAllStyles.Text = "All Styles"
        Me.cbQueryAllStyles.UseVisualStyleBackColor = True
        '
        'clbQueryStyle
        '
        Me.clbQueryStyle.CheckOnClick = True
        Me.clbQueryStyle.FormattingEnabled = True
        Me.clbQueryStyle.Location = New System.Drawing.Point(238, 40)
        Me.clbQueryStyle.Name = "clbQueryStyle"
        Me.clbQueryStyle.Size = New System.Drawing.Size(110, 79)
        Me.clbQueryStyle.TabIndex = 6
        '
        'gbBeerDetails
        '
        Me.gbBeerDetails.Controls.Add(Me.TabControl1)
        Me.gbBeerDetails.Location = New System.Drawing.Point(0, 43)
        Me.gbBeerDetails.Name = "gbBeerDetails"
        Me.gbBeerDetails.Size = New System.Drawing.Size(200, 309)
        Me.gbBeerDetails.TabIndex = 11
        Me.gbBeerDetails.TabStop = False
        Me.gbBeerDetails.Text = "Beer Details"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(6, 19)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(188, 284)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtBeerOverall)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.txtBeerCompany)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.txtBeerComments)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.txtBeerStyle)
        Me.TabPage1.Controls.Add(Me.txtBeerFeel)
        Me.TabPage1.Controls.Add(Me.txtBeerTaste)
        Me.TabPage1.Controls.Add(Me.txtBeerSmell)
        Me.TabPage1.Controls.Add(Me.txtBeerLook)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.lblBeerStyle)
        Me.TabPage1.Controls.Add(Me.txtBeerName)
        Me.TabPage1.Controls.Add(Me.lblBeerName)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(180, 258)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Information"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtBeerOverall
        '
        Me.txtBeerOverall.Location = New System.Drawing.Point(127, 150)
        Me.txtBeerOverall.Name = "txtBeerOverall"
        Me.txtBeerOverall.ReadOnly = True
        Me.txtBeerOverall.Size = New System.Drawing.Size(47, 20)
        Me.txtBeerOverall.TabIndex = 22
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(78, 153)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(43, 13)
        Me.Label18.TabIndex = 21
        Me.Label18.Text = "Overall:"
        '
        'txtBeerCompany
        '
        Me.txtBeerCompany.Location = New System.Drawing.Point(48, 40)
        Me.txtBeerCompany.Name = "txtBeerCompany"
        Me.txtBeerCompany.ReadOnly = True
        Me.txtBeerCompany.Size = New System.Drawing.Size(126, 20)
        Me.txtBeerCompany.TabIndex = 20
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(19, 43)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(23, 13)
        Me.Label17.TabIndex = 19
        Me.Label17.Text = "Co:"
        '
        'txtBeerComments
        '
        Me.txtBeerComments.Location = New System.Drawing.Point(9, 184)
        Me.txtBeerComments.Multiline = True
        Me.txtBeerComments.Name = "txtBeerComments"
        Me.txtBeerComments.ReadOnly = True
        Me.txtBeerComments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtBeerComments.Size = New System.Drawing.Size(165, 70)
        Me.txtBeerComments.TabIndex = 18
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(9, 168)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(59, 13)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "Comments:"
        '
        'txtBeerStyle
        '
        Me.txtBeerStyle.Location = New System.Drawing.Point(48, 66)
        Me.txtBeerStyle.Name = "txtBeerStyle"
        Me.txtBeerStyle.ReadOnly = True
        Me.txtBeerStyle.Size = New System.Drawing.Size(126, 20)
        Me.txtBeerStyle.TabIndex = 16
        '
        'txtBeerFeel
        '
        Me.txtBeerFeel.Location = New System.Drawing.Point(127, 121)
        Me.txtBeerFeel.Name = "txtBeerFeel"
        Me.txtBeerFeel.ReadOnly = True
        Me.txtBeerFeel.Size = New System.Drawing.Size(30, 20)
        Me.txtBeerFeel.TabIndex = 15
        '
        'txtBeerTaste
        '
        Me.txtBeerTaste.Location = New System.Drawing.Point(127, 92)
        Me.txtBeerTaste.Name = "txtBeerTaste"
        Me.txtBeerTaste.ReadOnly = True
        Me.txtBeerTaste.Size = New System.Drawing.Size(30, 20)
        Me.txtBeerTaste.TabIndex = 14
        '
        'txtBeerSmell
        '
        Me.txtBeerSmell.Location = New System.Drawing.Point(48, 121)
        Me.txtBeerSmell.Name = "txtBeerSmell"
        Me.txtBeerSmell.ReadOnly = True
        Me.txtBeerSmell.Size = New System.Drawing.Size(30, 20)
        Me.txtBeerSmell.TabIndex = 13
        '
        'txtBeerLook
        '
        Me.txtBeerLook.Location = New System.Drawing.Point(48, 92)
        Me.txtBeerLook.Name = "txtBeerLook"
        Me.txtBeerLook.ReadOnly = True
        Me.txtBeerLook.Size = New System.Drawing.Size(30, 20)
        Me.txtBeerLook.TabIndex = 12
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(91, 124)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(30, 13)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Feel:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(84, 95)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 13)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Taste:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 124)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 13)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Smell:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 95)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Look:"
        '
        'lblBeerStyle
        '
        Me.lblBeerStyle.AutoSize = True
        Me.lblBeerStyle.Location = New System.Drawing.Point(11, 69)
        Me.lblBeerStyle.Name = "lblBeerStyle"
        Me.lblBeerStyle.Size = New System.Drawing.Size(33, 13)
        Me.lblBeerStyle.TabIndex = 7
        Me.lblBeerStyle.Text = "Style:"
        '
        'lblBeerName
        '
        Me.lblBeerName.AutoSize = True
        Me.lblBeerName.Location = New System.Drawing.Point(6, 17)
        Me.lblBeerName.Name = "lblBeerName"
        Me.lblBeerName.Size = New System.Drawing.Size(38, 13)
        Me.lblBeerName.TabIndex = 6
        Me.lblBeerName.Text = "Name:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.linkEnlargeImage)
        Me.TabPage2.Controls.Add(Me.txtBeerImage)
        Me.TabPage2.Controls.Add(Me.pbSelectedBeerImage)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(180, 258)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Image"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'linkEnlargeImage
        '
        Me.linkEnlargeImage.AutoSize = True
        Me.linkEnlargeImage.Location = New System.Drawing.Point(55, 242)
        Me.linkEnlargeImage.Name = "linkEnlargeImage"
        Me.linkEnlargeImage.Size = New System.Drawing.Size(75, 13)
        Me.linkEnlargeImage.TabIndex = 6
        Me.linkEnlargeImage.TabStop = True
        Me.linkEnlargeImage.Text = "Enlarge Image"
        '
        'txtBeerImage
        '
        Me.txtBeerImage.Location = New System.Drawing.Point(6, 219)
        Me.txtBeerImage.Name = "txtBeerImage"
        Me.txtBeerImage.ReadOnly = True
        Me.txtBeerImage.Size = New System.Drawing.Size(168, 20)
        Me.txtBeerImage.TabIndex = 5
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.txtBeerCommentsEnlarged)
        Me.TabPage3.Controls.Add(Me.Label19)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(180, 258)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Comments"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'txtBeerCommentsEnlarged
        '
        Me.txtBeerCommentsEnlarged.Location = New System.Drawing.Point(6, 31)
        Me.txtBeerCommentsEnlarged.Multiline = True
        Me.txtBeerCommentsEnlarged.Name = "txtBeerCommentsEnlarged"
        Me.txtBeerCommentsEnlarged.ReadOnly = True
        Me.txtBeerCommentsEnlarged.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtBeerCommentsEnlarged.Size = New System.Drawing.Size(165, 213)
        Me.txtBeerCommentsEnlarged.TabIndex = 20
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(3, 15)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(59, 13)
        Me.Label19.TabIndex = 19
        Me.Label19.Text = "Comments:"
        '
        'btnAddBeer
        '
        Me.btnAddBeer.Location = New System.Drawing.Point(6, 18)
        Me.btnAddBeer.Name = "btnAddBeer"
        Me.btnAddBeer.Size = New System.Drawing.Size(60, 23)
        Me.btnAddBeer.TabIndex = 1
        Me.btnAddBeer.Text = "Add"
        Me.btnAddBeer.UseVisualStyleBackColor = True
        '
        'btnDeleteBeer
        '
        Me.btnDeleteBeer.Location = New System.Drawing.Point(130, 18)
        Me.btnDeleteBeer.Name = "btnDeleteBeer"
        Me.btnDeleteBeer.Size = New System.Drawing.Size(60, 23)
        Me.btnDeleteBeer.TabIndex = 3
        Me.btnDeleteBeer.Text = "Remove"
        Me.btnDeleteBeer.UseVisualStyleBackColor = True
        '
        'gbRightSide
        '
        Me.gbRightSide.Controls.Add(Me.btnEditBeer)
        Me.gbRightSide.Controls.Add(Me.gbBeerDetails)
        Me.gbRightSide.Controls.Add(Me.btnDeleteBeer)
        Me.gbRightSide.Controls.Add(Me.btnAddBeer)
        Me.gbRightSide.Location = New System.Drawing.Point(697, 28)
        Me.gbRightSide.Name = "gbRightSide"
        Me.gbRightSide.Size = New System.Drawing.Size(200, 352)
        Me.gbRightSide.TabIndex = 14
        Me.gbRightSide.TabStop = False
        Me.gbRightSide.Text = "List Actions"
        '
        'btnEditBeer
        '
        Me.btnEditBeer.Location = New System.Drawing.Point(68, 18)
        Me.btnEditBeer.Name = "btnEditBeer"
        Me.btnEditBeer.Size = New System.Drawing.Size(60, 23)
        Me.btnEditBeer.TabIndex = 2
        Me.btnEditBeer.Text = "Edit"
        Me.btnEditBeer.UseVisualStyleBackColor = True
        '
        'ofdOpenDataFile
        '
        Me.ofdOpenDataFile.Filter = """XML Beer Data File""|*.xml"
        '
        'sfdSaveDataFile
        '
        Me.sfdSaveDataFile.Filter = """XML Beer Data File""|*.xml"
        '
        'sfdCreateNewDataFile
        '
        Me.sfdCreateNewDataFile.Filter = """XML Beer Data File""|*.xml"
        '
        'AboutTheAuthorToolStripMenuItem
        '
        Me.AboutTheAuthorToolStripMenuItem.Name = "AboutTheAuthorToolStripMenuItem"
        Me.AboutTheAuthorToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.AboutTheAuthorToolStripMenuItem.Text = "A&bout the Author"
        '
        'Form1
        '
        Me.AcceptButton = Me.bListBeers
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(909, 392)
        Me.Controls.Add(Me.gbRightSide)
        Me.Controls.Add(Me.gbFilterListedBeers)
        Me.Controls.Add(Me.dgvBeerItems)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(925, 430)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BeerMe - The Beer Organizor"
        CType(Me.dgvBeerItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbSelectedBeerImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.gbFilterListedBeers.ResumeLayout(False)
        Me.gbFilterListedBeers.PerformLayout()
        Me.gbSortListedBeers.ResumeLayout(False)
        Me.gbSortListedBeers.PerformLayout()
        Me.gbBeerDetails.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.gbRightSide.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvBeerItems As System.Windows.Forms.DataGridView
    Friend WithEvents pbSelectedBeerImage As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddBeerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddBeerToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteSelectedBeerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtBeerName As System.Windows.Forms.TextBox
    Friend WithEvents clbQueryName As System.Windows.Forms.CheckedListBox
    Friend WithEvents cbQueryAllNames As System.Windows.Forms.CheckBox
    Friend WithEvents bListBeers As System.Windows.Forms.Button
    Friend WithEvents gbFilterListedBeers As System.Windows.Forms.GroupBox
    Friend WithEvents MenuItemBeerFilter As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cbQueryAllStyles As System.Windows.Forms.CheckBox
    Friend WithEvents clbQueryStyle As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbFeel2 As System.Windows.Forms.ComboBox
    Friend WithEvents cbFeel1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbTaste2 As System.Windows.Forms.ComboBox
    Friend WithEvents cbTaste1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbSmell2 As System.Windows.Forms.ComboBox
    Friend WithEvents cbSmell1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cbLook2 As System.Windows.Forms.ComboBox
    Friend WithEvents cbLook1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbSortListedBeers As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbSortListedBeers As System.Windows.Forms.ComboBox
    Friend WithEvents rdoSortDescending As System.Windows.Forms.RadioButton
    Friend WithEvents rdoSortAscending As System.Windows.Forms.RadioButton
    Friend WithEvents gbBeerDetails As System.Windows.Forms.GroupBox
    Friend WithEvents btnAddBeer As System.Windows.Forms.Button
    Friend WithEvents btnDeleteBeer As System.Windows.Forms.Button
    Friend WithEvents gbRightSide As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents lblBeerStyle As System.Windows.Forms.Label
    Friend WithEvents lblBeerName As System.Windows.Forms.Label
    Friend WithEvents txtBeerFeel As System.Windows.Forms.TextBox
    Friend WithEvents txtBeerTaste As System.Windows.Forms.TextBox
    Friend WithEvents txtBeerSmell As System.Windows.Forms.TextBox
    Friend WithEvents txtBeerLook As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtBeerImage As System.Windows.Forms.TextBox
    Friend WithEvents txtBeerStyle As System.Windows.Forms.TextBox
    Friend WithEvents txtBeerComments As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents MenuItemHideRightSide As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnEditBeer As System.Windows.Forms.Button
    Friend WithEvents EditSelectedBeerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents linkEnlargeImage As System.Windows.Forms.LinkLabel
    Friend WithEvents AdministrationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResetDataFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenDataFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveAsDataFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ofdOpenDataFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents sfdSaveDataFile As System.Windows.Forms.SaveFileDialog
    Friend WithEvents sfdCreateNewDataFile As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cbOverall2 As System.Windows.Forms.ComboBox
    Friend WithEvents cbOverall1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cbQueryAllCompanies As System.Windows.Forms.CheckBox
    Friend WithEvents clbQueryCompany As System.Windows.Forms.CheckedListBox
    Friend WithEvents txtBeerOverall As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtBeerCompany As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents txtBeerCommentsEnlarged As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents AboutTheAuthorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
