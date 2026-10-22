namespace PartyMusicManager
{
    partial class frmManageMusicLibrary
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSaveToLibrary = new DevComponents.DotNetBar.ButtonX();
            this.btnxAddFile = new DevComponents.DotNetBar.ButtonX();
            this.rdoAddFile = new System.Windows.Forms.RadioButton();
            this.txtAddFile = new System.Windows.Forms.TextBox();
            this.btnxAddDirectory = new DevComponents.DotNetBar.ButtonX();
            this.rdoAddDirectory = new System.Windows.Forms.RadioButton();
            this.txtAddDirectory = new System.Windows.Forms.TextBox();
            this.fbdAddDirectory = new System.Windows.Forms.FolderBrowserDialog();
            this.ofdAddFile = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSaveToLibrary);
            this.groupBox1.Controls.Add(this.btnxAddFile);
            this.groupBox1.Controls.Add(this.rdoAddFile);
            this.groupBox1.Controls.Add(this.txtAddFile);
            this.groupBox1.Controls.Add(this.btnxAddDirectory);
            this.groupBox1.Controls.Add(this.rdoAddDirectory);
            this.groupBox1.Controls.Add(this.txtAddDirectory);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(608, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Music to Library";
            // 
            // btnSaveToLibrary
            // 
            this.btnSaveToLibrary.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSaveToLibrary.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSaveToLibrary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSaveToLibrary.Location = new System.Drawing.Point(255, 95);
            this.btnSaveToLibrary.Name = "btnSaveToLibrary";
            this.btnSaveToLibrary.Size = new System.Drawing.Size(142, 35);
            this.btnSaveToLibrary.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSaveToLibrary.TabIndex = 39;
            this.btnSaveToLibrary.Text = "Save To Library";
            this.btnSaveToLibrary.Click += new System.EventHandler(this.btnSaveToLibrary_Click);
            // 
            // btnxAddFile
            // 
            this.btnxAddFile.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnxAddFile.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnxAddFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnxAddFile.Location = new System.Drawing.Point(559, 68);
            this.btnxAddFile.Name = "btnxAddFile";
            this.btnxAddFile.Size = new System.Drawing.Size(39, 21);
            this.btnxAddFile.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnxAddFile.TabIndex = 38;
            this.btnxAddFile.Text = "...";
            this.btnxAddFile.Click += new System.EventHandler(this.btnxAddFile_Click);
            // 
            // rdoAddFile
            // 
            this.rdoAddFile.AutoSize = true;
            this.rdoAddFile.Location = new System.Drawing.Point(6, 70);
            this.rdoAddFile.Name = "rdoAddFile";
            this.rdoAddFile.Size = new System.Drawing.Size(66, 17);
            this.rdoAddFile.TabIndex = 37;
            this.rdoAddFile.TabStop = true;
            this.rdoAddFile.Text = "Add File;";
            this.rdoAddFile.UseVisualStyleBackColor = true;
            this.rdoAddFile.CheckedChanged += new System.EventHandler(this.rdoAddFile_CheckedChanged);
            // 
            // txtAddFile
            // 
            this.txtAddFile.Location = new System.Drawing.Point(104, 69);
            this.txtAddFile.Name = "txtAddFile";
            this.txtAddFile.Size = new System.Drawing.Size(449, 20);
            this.txtAddFile.TabIndex = 36;
            // 
            // btnxAddDirectory
            // 
            this.btnxAddDirectory.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnxAddDirectory.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnxAddDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnxAddDirectory.Location = new System.Drawing.Point(559, 32);
            this.btnxAddDirectory.Name = "btnxAddDirectory";
            this.btnxAddDirectory.Size = new System.Drawing.Size(39, 21);
            this.btnxAddDirectory.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnxAddDirectory.TabIndex = 35;
            this.btnxAddDirectory.Text = "...";
            this.btnxAddDirectory.Click += new System.EventHandler(this.btnxAddDirectory_Click);
            // 
            // rdoAddDirectory
            // 
            this.rdoAddDirectory.AutoSize = true;
            this.rdoAddDirectory.Checked = true;
            this.rdoAddDirectory.Location = new System.Drawing.Point(6, 34);
            this.rdoAddDirectory.Name = "rdoAddDirectory";
            this.rdoAddDirectory.Size = new System.Drawing.Size(92, 17);
            this.rdoAddDirectory.TabIndex = 1;
            this.rdoAddDirectory.TabStop = true;
            this.rdoAddDirectory.Text = "Add Directory;";
            this.rdoAddDirectory.UseVisualStyleBackColor = true;
            this.rdoAddDirectory.CheckedChanged += new System.EventHandler(this.rdoAddDirectory_CheckedChanged);
            // 
            // txtAddDirectory
            // 
            this.txtAddDirectory.Location = new System.Drawing.Point(104, 33);
            this.txtAddDirectory.Name = "txtAddDirectory";
            this.txtAddDirectory.Size = new System.Drawing.Size(449, 20);
            this.txtAddDirectory.TabIndex = 0;
            // 
            // ofdAddFile
            // 
            this.ofdAddFile.FileName = "openFileDialog1";
            // 
            // frmManageMusicLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 159);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmManageMusicLibrary";
            this.Text = "frmManageMusicLibrary";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoAddDirectory;
        private System.Windows.Forms.TextBox txtAddDirectory;
        private DevComponents.DotNetBar.ButtonX btnSaveToLibrary;
        private DevComponents.DotNetBar.ButtonX btnxAddFile;
        private System.Windows.Forms.RadioButton rdoAddFile;
        private System.Windows.Forms.TextBox txtAddFile;
        private DevComponents.DotNetBar.ButtonX btnxAddDirectory;
        private System.Windows.Forms.FolderBrowserDialog fbdAddDirectory;
        private System.Windows.Forms.OpenFileDialog ofdAddFile;
    }
}