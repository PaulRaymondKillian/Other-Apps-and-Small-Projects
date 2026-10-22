<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditBeer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditBeer))
        Me.btnSaveChanges = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCompany = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtComments = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblFeel = New System.Windows.Forms.Label()
        Me.lblTaste = New System.Windows.Forms.Label()
        Me.lblSmell = New System.Windows.Forms.Label()
        Me.lblLook = New System.Windows.Forms.Label()
        Me.btnImage = New System.Windows.Forms.Button()
        Me.txtImage = New System.Windows.Forms.TextBox()
        Me.tbFeel = New System.Windows.Forms.TrackBar()
        Me.tbTaste = New System.Windows.Forms.TrackBar()
        Me.tbSmell = New System.Windows.Forms.TrackBar()
        Me.tbLook = New System.Windows.Forms.TrackBar()
        Me.txtStyle = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ofdImage = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        CType(Me.tbFeel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbTaste, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbSmell, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbLook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSaveChanges
        '
        Me.btnSaveChanges.Location = New System.Drawing.Point(50, 338)
        Me.btnSaveChanges.Name = "btnSaveChanges"
        Me.btnSaveChanges.Size = New System.Drawing.Size(162, 26)
        Me.btnSaveChanges.TabIndex = 9
        Me.btnSaveChanges.Text = "Save Changes"
        Me.btnSaveChanges.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCompany)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.btnSaveChanges)
        Me.GroupBox1.Controls.Add(Me.txtComments)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lblFeel)
        Me.GroupBox1.Controls.Add(Me.lblTaste)
        Me.GroupBox1.Controls.Add(Me.lblSmell)
        Me.GroupBox1.Controls.Add(Me.lblLook)
        Me.GroupBox1.Controls.Add(Me.btnImage)
        Me.GroupBox1.Controls.Add(Me.txtImage)
        Me.GroupBox1.Controls.Add(Me.tbFeel)
        Me.GroupBox1.Controls.Add(Me.tbTaste)
        Me.GroupBox1.Controls.Add(Me.tbSmell)
        Me.GroupBox1.Controls.Add(Me.tbLook)
        Me.GroupBox1.Controls.Add(Me.txtStyle)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(266, 371)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Edit Beer Details"
        '
        'txtCompany
        '
        Me.txtCompany.Location = New System.Drawing.Point(71, 48)
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Size = New System.Drawing.Size(189, 20)
        Me.txtCompany.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Company:"
        '
        'txtComments
        '
        Me.txtComments.Location = New System.Drawing.Point(8, 284)
        Me.txtComments.Multiline = True
        Me.txtComments.Name = "txtComments"
        Me.txtComments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtComments.Size = New System.Drawing.Size(252, 48)
        Me.txtComments.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 268)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Comments:"
        '
        'lblFeel
        '
        Me.lblFeel.AutoSize = True
        Me.lblFeel.Location = New System.Drawing.Point(247, 203)
        Me.lblFeel.Name = "lblFeel"
        Me.lblFeel.Size = New System.Drawing.Size(13, 13)
        Me.lblFeel.TabIndex = 18
        Me.lblFeel.Text = "0"
        '
        'lblTaste
        '
        Me.lblTaste.AutoSize = True
        Me.lblTaste.Location = New System.Drawing.Point(247, 172)
        Me.lblTaste.Name = "lblTaste"
        Me.lblTaste.Size = New System.Drawing.Size(13, 13)
        Me.lblTaste.TabIndex = 17
        Me.lblTaste.Text = "0"
        '
        'lblSmell
        '
        Me.lblSmell.AutoSize = True
        Me.lblSmell.Location = New System.Drawing.Point(247, 138)
        Me.lblSmell.Name = "lblSmell"
        Me.lblSmell.Size = New System.Drawing.Size(13, 13)
        Me.lblSmell.TabIndex = 16
        Me.lblSmell.Text = "0"
        '
        'lblLook
        '
        Me.lblLook.AutoSize = True
        Me.lblLook.Location = New System.Drawing.Point(247, 109)
        Me.lblLook.Name = "lblLook"
        Me.lblLook.Size = New System.Drawing.Size(13, 13)
        Me.lblLook.TabIndex = 15
        Me.lblLook.Text = "0"
        '
        'btnImage
        '
        Me.btnImage.Location = New System.Drawing.Point(196, 232)
        Me.btnImage.Name = "btnImage"
        Me.btnImage.Size = New System.Drawing.Size(64, 23)
        Me.btnImage.TabIndex = 7
        Me.btnImage.Text = "Browse"
        Me.btnImage.UseVisualStyleBackColor = True
        '
        'txtImage
        '
        Me.txtImage.Location = New System.Drawing.Point(50, 234)
        Me.txtImage.Name = "txtImage"
        Me.txtImage.Size = New System.Drawing.Size(140, 20)
        Me.txtImage.TabIndex = 10
        '
        'tbFeel
        '
        Me.tbFeel.Location = New System.Drawing.Point(50, 203)
        Me.tbFeel.Name = "tbFeel"
        Me.tbFeel.Size = New System.Drawing.Size(191, 45)
        Me.tbFeel.TabIndex = 6
        '
        'tbTaste
        '
        Me.tbTaste.Location = New System.Drawing.Point(50, 171)
        Me.tbTaste.Name = "tbTaste"
        Me.tbTaste.Size = New System.Drawing.Size(191, 45)
        Me.tbTaste.TabIndex = 5
        '
        'tbSmell
        '
        Me.tbSmell.Location = New System.Drawing.Point(50, 138)
        Me.tbSmell.Name = "tbSmell"
        Me.tbSmell.Size = New System.Drawing.Size(191, 45)
        Me.tbSmell.TabIndex = 4
        '
        'tbLook
        '
        Me.tbLook.Location = New System.Drawing.Point(50, 106)
        Me.tbLook.Name = "tbLook"
        Me.tbLook.Size = New System.Drawing.Size(191, 45)
        Me.tbLook.TabIndex = 3
        '
        'txtStyle
        '
        Me.txtStyle.Location = New System.Drawing.Point(71, 76)
        Me.txtStyle.Name = "txtStyle"
        Me.txtStyle.Size = New System.Drawing.Size(189, 20)
        Me.txtStyle.TabIndex = 2
        '
        'txtName
        '
        Me.txtName.Enabled = False
        Me.txtName.Location = New System.Drawing.Point(71, 22)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(189, 20)
        Me.txtName.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 237)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Image:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 203)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Feel:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Taste:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Smell:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Look:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Style:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        '
        'ofdImage
        '
        Me.ofdImage.Filter = """Image Files""|*.gif,*.png,*.jpg,*.jpeg,*.bmp|""All Files""|*.*"
        '
        'frmEditBeer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 395)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmEditBeer"
        Me.Text = "Edit Beer"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.tbFeel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbTaste, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbSmell, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbLook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSaveChanges As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtComments As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblFeel As System.Windows.Forms.Label
    Friend WithEvents lblTaste As System.Windows.Forms.Label
    Friend WithEvents lblSmell As System.Windows.Forms.Label
    Friend WithEvents lblLook As System.Windows.Forms.Label
    Friend WithEvents btnImage As System.Windows.Forms.Button
    Friend WithEvents txtImage As System.Windows.Forms.TextBox
    Friend WithEvents tbFeel As System.Windows.Forms.TrackBar
    Friend WithEvents tbTaste As System.Windows.Forms.TrackBar
    Friend WithEvents tbSmell As System.Windows.Forms.TrackBar
    Friend WithEvents tbLook As System.Windows.Forms.TrackBar
    Friend WithEvents txtStyle As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ofdImage As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtCompany As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
