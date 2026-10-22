namespace PartyMusicManager
{
    partial class frmManagePlaylists
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
            this.gbCreatePlaylist = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreatePlaylist = new System.Windows.Forms.Button();
            this.txtCreatePlaylist = new System.Windows.Forms.TextBox();
            this.cbPlaylists = new System.Windows.Forms.ComboBox();
            this.btnSetDefaultPlaylist = new System.Windows.Forms.Button();
            this.dgvPlaylistSongs = new System.Windows.Forms.DataGridView();
            this.dgvSongs_colOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSongs_colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSongs_colDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSongs_colRating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbModifyPlaylist = new System.Windows.Forms.GroupBox();
            this.txtMoveSongToOrder = new System.Windows.Forms.TextBox();
            this.btnMoveSongToOrder = new System.Windows.Forms.Button();
            this.btnMoveSongDown = new System.Windows.Forms.Button();
            this.btnMoveSongUp = new System.Windows.Forms.Button();
            this.btnRemoveSong = new System.Windows.Forms.Button();
            this.btnDeletePlaylist = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rdoCreatePlaylist = new System.Windows.Forms.RadioButton();
            this.rdoModifyPlaylist = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.gbCreatePlaylist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaylistSongs)).BeginInit();
            this.gbModifyPlaylist.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCreatePlaylist
            // 
            this.gbCreatePlaylist.Controls.Add(this.label1);
            this.gbCreatePlaylist.Controls.Add(this.btnCreatePlaylist);
            this.gbCreatePlaylist.Controls.Add(this.txtCreatePlaylist);
            this.gbCreatePlaylist.Enabled = false;
            this.gbCreatePlaylist.Location = new System.Drawing.Point(41, 30);
            this.gbCreatePlaylist.Name = "gbCreatePlaylist";
            this.gbCreatePlaylist.Size = new System.Drawing.Size(287, 60);
            this.gbCreatePlaylist.TabIndex = 0;
            this.gbCreatePlaylist.TabStop = false;
            this.gbCreatePlaylist.Text = "Create Playlist";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // btnCreatePlaylist
            // 
            this.btnCreatePlaylist.Location = new System.Drawing.Point(184, 16);
            this.btnCreatePlaylist.Name = "btnCreatePlaylist";
            this.btnCreatePlaylist.Size = new System.Drawing.Size(92, 23);
            this.btnCreatePlaylist.TabIndex = 1;
            this.btnCreatePlaylist.Text = "Create Playlist";
            this.btnCreatePlaylist.UseVisualStyleBackColor = true;
            this.btnCreatePlaylist.Click += new System.EventHandler(this.btnCreatePlaylist_Click);
            // 
            // txtCreatePlaylist
            // 
            this.txtCreatePlaylist.Location = new System.Drawing.Point(50, 16);
            this.txtCreatePlaylist.Name = "txtCreatePlaylist";
            this.txtCreatePlaylist.Size = new System.Drawing.Size(128, 20);
            this.txtCreatePlaylist.TabIndex = 0;
            // 
            // cbPlaylists
            // 
            this.cbPlaylists.FormattingEnabled = true;
            this.cbPlaylists.Location = new System.Drawing.Point(50, 23);
            this.cbPlaylists.Name = "cbPlaylists";
            this.cbPlaylists.Size = new System.Drawing.Size(186, 21);
            this.cbPlaylists.TabIndex = 1;
            this.cbPlaylists.SelectedIndexChanged += new System.EventHandler(this.cbPlaylists_SelectedIndexChanged);
            // 
            // btnSetDefaultPlaylist
            // 
            this.btnSetDefaultPlaylist.Location = new System.Drawing.Point(50, 95);
            this.btnSetDefaultPlaylist.Name = "btnSetDefaultPlaylist";
            this.btnSetDefaultPlaylist.Size = new System.Drawing.Size(186, 23);
            this.btnSetDefaultPlaylist.TabIndex = 2;
            this.btnSetDefaultPlaylist.Text = "Set As Default Playlist";
            this.btnSetDefaultPlaylist.UseVisualStyleBackColor = true;
            this.btnSetDefaultPlaylist.Click += new System.EventHandler(this.btnSetDefaultPlaylist_Click);
            // 
            // dgvPlaylistSongs
            // 
            this.dgvPlaylistSongs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlaylistSongs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSongs_colOrder,
            this.dgvSongs_colName,
            this.dgvSongs_colDuration,
            this.dgvSongs_colRating});
            this.dgvPlaylistSongs.Location = new System.Drawing.Point(9, 19);
            this.dgvPlaylistSongs.Name = "dgvPlaylistSongs";
            this.dgvPlaylistSongs.ReadOnly = true;
            this.dgvPlaylistSongs.RowHeadersVisible = false;
            this.dgvPlaylistSongs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPlaylistSongs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlaylistSongs.Size = new System.Drawing.Size(370, 399);
            this.dgvPlaylistSongs.TabIndex = 3;
            // 
            // dgvSongs_colOrder
            // 
            this.dgvSongs_colOrder.HeaderText = "Order";
            this.dgvSongs_colOrder.Name = "dgvSongs_colOrder";
            this.dgvSongs_colOrder.ReadOnly = true;
            this.dgvSongs_colOrder.Width = 50;
            // 
            // dgvSongs_colName
            // 
            this.dgvSongs_colName.HeaderText = "Name";
            this.dgvSongs_colName.Name = "dgvSongs_colName";
            this.dgvSongs_colName.ReadOnly = true;
            this.dgvSongs_colName.Width = 200;
            // 
            // dgvSongs_colDuration
            // 
            this.dgvSongs_colDuration.HeaderText = "Duration";
            this.dgvSongs_colDuration.Name = "dgvSongs_colDuration";
            this.dgvSongs_colDuration.ReadOnly = true;
            this.dgvSongs_colDuration.Width = 60;
            // 
            // dgvSongs_colRating
            // 
            this.dgvSongs_colRating.HeaderText = "Rating";
            this.dgvSongs_colRating.Name = "dgvSongs_colRating";
            this.dgvSongs_colRating.ReadOnly = true;
            this.dgvSongs_colRating.Width = 50;
            // 
            // gbModifyPlaylist
            // 
            this.gbModifyPlaylist.Controls.Add(this.txtMoveSongToOrder);
            this.gbModifyPlaylist.Controls.Add(this.btnMoveSongToOrder);
            this.gbModifyPlaylist.Controls.Add(this.btnMoveSongDown);
            this.gbModifyPlaylist.Controls.Add(this.btnMoveSongUp);
            this.gbModifyPlaylist.Controls.Add(this.btnRemoveSong);
            this.gbModifyPlaylist.Controls.Add(this.btnDeletePlaylist);
            this.gbModifyPlaylist.Controls.Add(this.label2);
            this.gbModifyPlaylist.Controls.Add(this.cbPlaylists);
            this.gbModifyPlaylist.Controls.Add(this.btnSetDefaultPlaylist);
            this.gbModifyPlaylist.Location = new System.Drawing.Point(41, 104);
            this.gbModifyPlaylist.Name = "gbModifyPlaylist";
            this.gbModifyPlaylist.Size = new System.Drawing.Size(287, 326);
            this.gbModifyPlaylist.TabIndex = 4;
            this.gbModifyPlaylist.TabStop = false;
            this.gbModifyPlaylist.Text = "Modify Playlist";
            // 
            // txtMoveSongToOrder
            // 
            this.txtMoveSongToOrder.Location = new System.Drawing.Point(196, 277);
            this.txtMoveSongToOrder.Name = "txtMoveSongToOrder";
            this.txtMoveSongToOrder.Size = new System.Drawing.Size(40, 20);
            this.txtMoveSongToOrder.TabIndex = 9;
            this.txtMoveSongToOrder.Leave += new System.EventHandler(this.txtMoveSongToOrder_Leave);
            // 
            // btnMoveSongToOrder
            // 
            this.btnMoveSongToOrder.Enabled = false;
            this.btnMoveSongToOrder.Location = new System.Drawing.Point(50, 274);
            this.btnMoveSongToOrder.Name = "btnMoveSongToOrder";
            this.btnMoveSongToOrder.Size = new System.Drawing.Size(140, 23);
            this.btnMoveSongToOrder.TabIndex = 8;
            this.btnMoveSongToOrder.Text = "Move Song To Order:";
            this.btnMoveSongToOrder.UseVisualStyleBackColor = true;
            // 
            // btnMoveSongDown
            // 
            this.btnMoveSongDown.Location = new System.Drawing.Point(50, 245);
            this.btnMoveSongDown.Name = "btnMoveSongDown";
            this.btnMoveSongDown.Size = new System.Drawing.Size(186, 23);
            this.btnMoveSongDown.TabIndex = 7;
            this.btnMoveSongDown.Text = "Move Selected Song Down";
            this.btnMoveSongDown.UseVisualStyleBackColor = true;
            // 
            // btnMoveSongUp
            // 
            this.btnMoveSongUp.Location = new System.Drawing.Point(50, 216);
            this.btnMoveSongUp.Name = "btnMoveSongUp";
            this.btnMoveSongUp.Size = new System.Drawing.Size(186, 23);
            this.btnMoveSongUp.TabIndex = 6;
            this.btnMoveSongUp.Text = "Move Selected Song Up";
            this.btnMoveSongUp.UseVisualStyleBackColor = true;
            // 
            // btnRemoveSong
            // 
            this.btnRemoveSong.Location = new System.Drawing.Point(50, 187);
            this.btnRemoveSong.Name = "btnRemoveSong";
            this.btnRemoveSong.Size = new System.Drawing.Size(186, 23);
            this.btnRemoveSong.TabIndex = 5;
            this.btnRemoveSong.Text = "Remove Selected Song";
            this.btnRemoveSong.UseVisualStyleBackColor = true;
            // 
            // btnDeletePlaylist
            // 
            this.btnDeletePlaylist.Location = new System.Drawing.Point(50, 124);
            this.btnDeletePlaylist.Name = "btnDeletePlaylist";
            this.btnDeletePlaylist.Size = new System.Drawing.Size(186, 23);
            this.btnDeletePlaylist.TabIndex = 4;
            this.btnDeletePlaylist.Text = "Delete Playlist";
            this.btnDeletePlaylist.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name:";
            // 
            // rdoCreatePlaylist
            // 
            this.rdoCreatePlaylist.AutoSize = true;
            this.rdoCreatePlaylist.Location = new System.Drawing.Point(21, 49);
            this.rdoCreatePlaylist.Name = "rdoCreatePlaylist";
            this.rdoCreatePlaylist.Size = new System.Drawing.Size(14, 13);
            this.rdoCreatePlaylist.TabIndex = 5;
            this.rdoCreatePlaylist.UseVisualStyleBackColor = true;
            this.rdoCreatePlaylist.CheckedChanged += new System.EventHandler(this.rdoCreatePlaylist_CheckedChanged);
            // 
            // rdoModifyPlaylist
            // 
            this.rdoModifyPlaylist.AutoSize = true;
            this.rdoModifyPlaylist.Checked = true;
            this.rdoModifyPlaylist.Location = new System.Drawing.Point(21, 130);
            this.rdoModifyPlaylist.Name = "rdoModifyPlaylist";
            this.rdoModifyPlaylist.Size = new System.Drawing.Size(14, 13);
            this.rdoModifyPlaylist.TabIndex = 6;
            this.rdoModifyPlaylist.TabStop = true;
            this.rdoModifyPlaylist.UseVisualStyleBackColor = true;
            this.rdoModifyPlaylist.CheckedChanged += new System.EventHandler(this.rdoModifyPlaylist_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvPlaylistSongs);
            this.groupBox4.Location = new System.Drawing.Point(334, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(385, 424);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Playlist Song Management";
            // 
            // frmManagePlaylists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 448);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.rdoModifyPlaylist);
            this.Controls.Add(this.rdoCreatePlaylist);
            this.Controls.Add(this.gbModifyPlaylist);
            this.Controls.Add(this.gbCreatePlaylist);
            this.Name = "frmManagePlaylists";
            this.Text = "Manage Playlists";
            this.Load += new System.EventHandler(this.frmManagePlaylists_Load);
            this.gbCreatePlaylist.ResumeLayout(false);
            this.gbCreatePlaylist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaylistSongs)).EndInit();
            this.gbModifyPlaylist.ResumeLayout(false);
            this.gbModifyPlaylist.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCreatePlaylist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreatePlaylist;
        private System.Windows.Forms.TextBox txtCreatePlaylist;
        private System.Windows.Forms.ComboBox cbPlaylists;
        private System.Windows.Forms.Button btnSetDefaultPlaylist;
        private System.Windows.Forms.DataGridView dgvPlaylistSongs;
        private System.Windows.Forms.GroupBox gbModifyPlaylist;
        private System.Windows.Forms.RadioButton rdoCreatePlaylist;
        private System.Windows.Forms.RadioButton rdoModifyPlaylist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSongs_colOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSongs_colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSongs_colDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSongs_colRating;
        private System.Windows.Forms.TextBox txtMoveSongToOrder;
        private System.Windows.Forms.Button btnMoveSongToOrder;
        private System.Windows.Forms.Button btnMoveSongDown;
        private System.Windows.Forms.Button btnMoveSongUp;
        private System.Windows.Forms.Button btnRemoveSong;
        private System.Windows.Forms.Button btnDeletePlaylist;
    }
}