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
        Me.InputPixels = New System.Windows.Forms.PictureBox
        Me.btnSaveToFile = New System.Windows.Forms.Button
        Me.btnLoadFromFile = New System.Windows.Forms.Button
        CType(Me.InputPixels, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InputPixels
        '
        Me.InputPixels.BackColor = System.Drawing.SystemColors.Control
        Me.InputPixels.Location = New System.Drawing.Point(32, 24)
        Me.InputPixels.Name = "InputPixels"
        Me.InputPixels.Size = New System.Drawing.Size(50, 80)
        Me.InputPixels.TabIndex = 40
        Me.InputPixels.TabStop = False
        '
        'btnSaveToFile
        '
        Me.btnSaveToFile.Location = New System.Drawing.Point(120, 40)
        Me.btnSaveToFile.Name = "btnSaveToFile"
        Me.btnSaveToFile.Size = New System.Drawing.Size(91, 23)
        Me.btnSaveToFile.TabIndex = 41
        Me.btnSaveToFile.Text = "Save To File"
        Me.btnSaveToFile.UseVisualStyleBackColor = True
        '
        'btnLoadFromFile
        '
        Me.btnLoadFromFile.Location = New System.Drawing.Point(120, 72)
        Me.btnLoadFromFile.Name = "btnLoadFromFile"
        Me.btnLoadFromFile.Size = New System.Drawing.Size(91, 23)
        Me.btnLoadFromFile.TabIndex = 42
        Me.btnLoadFromFile.Text = "Load From File"
        Me.btnLoadFromFile.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(245, 149)
        Me.Controls.Add(Me.btnLoadFromFile)
        Me.Controls.Add(Me.btnSaveToFile)
        Me.Controls.Add(Me.InputPixels)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.InputPixels, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents InputPixels As System.Windows.Forms.PictureBox
    Friend WithEvents btnSaveToFile As System.Windows.Forms.Button
    Friend WithEvents btnLoadFromFile As System.Windows.Forms.Button

End Class
