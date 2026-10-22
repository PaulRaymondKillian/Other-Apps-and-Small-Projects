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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbCreatePlaylist = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreatePlaylist = new System.Windows.Forms.Button();
            this.txtCreatePlaylist = new System.Windows.Forms.TextBox();
            this.cbPlaylists = new System.Windows.Forms.ComboBox();
            this.dgvPlaylistSongs = new System.Windows.Forms.DataGridView();
            this.dgvSongs_colOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSongs_colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSongs_colDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSongs_colRating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbModifyPlaylist = new System.Windows.Forms.GroupBox();
            this.btnxMoveSongToOrder = new DevComponents.DotNetBar.ButtonX();
            this.btnxMoveSongDown = new DevComponents.DotNetBar.ButtonX();
            this.btnxMoveSongUp = new DevComponents.DotNetBar.ButtonX();
            this.btnxRemoveSong = new DevComponents.DotNetBar.ButtonX();
            this.btnxDeletePlaylist = new DevComponents.DotNetBar.ButtonX();
            this.btnxSetDefaultPlaylist = new DevComponents.DotNetBar.ButtonX();
            this.txtMoveSongToOrder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdoCreatePlaylist = new System.Windows.Forms.RadioButton();
            this.rdoModifyPlaylist = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tabManagePlaylists = new DevComponents.DotNetBar.SuperTabControl();
            this.superTabControlPanel2 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.tabCreateModifyPlaylists = new DevComponents.DotNetBar.SuperTabItem();
            this.superTabControlPanel1 = new DevComponents.DotNetBar.SuperTabControlPanel();
            this.gbPlaylistControls = new System.Windows.Forms.GroupBox();
            this.btnxAddSongToPlaylist = new DevComponents.DotNetBar.ButtonX();
            this.cbPlaylists2 = new System.Windows.Forms.ComboBox();
            this.dgvPlaylistSongs2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expandablePanel1 = new DevComponents.DotNetBar.ExpandablePanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbAlbums = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbArtists = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbGenres = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvSongs = new System.Windows.Forms.DataGridView();
            this.dgvSongs_colTrack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSongs_colArtist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSongs_colAlbum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lbRequestPlaylist = new System.Windows.Forms.ListBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lboxCurrentPlaylist = new System.Windows.Forms.ListBox();
            this.tabAddSongsPlaylist = new DevComponents.DotNetBar.SuperTabItem();
            this.gbCreatePlaylist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaylistSongs)).BeginInit();
            this.gbModifyPlaylist.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabManagePlaylists)).BeginInit();
            this.tabManagePlaylists.SuspendLayout();
            this.superTabControlPanel2.SuspendLayout();
            this.superTabControlPanel1.SuspendLayout();
            this.gbPlaylistControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaylistSongs2)).BeginInit();
            this.expandablePanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongs)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCreatePlaylist
            // 
            this.gbCreatePlaylist.BackColor = System.Drawing.Color.Transparent;
            this.gbCreatePlaylist.Controls.Add(this.label1);
            this.gbCreatePlaylist.Controls.Add(this.btnCreatePlaylist);
            this.gbCreatePlaylist.Controls.Add(this.txtCreatePlaylist);
            this.gbCreatePlaylist.Enabled = false;
            this.gbCreatePlaylist.Location = new System.Drawing.Point(23, 33);
            this.gbCreatePlaylist.Name = "gbCreatePlaylist";
            this.gbCreatePlaylist.Size = new System.Drawing.Size(298, 60);
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
            // dgvPlaylistSongs
            // 
            this.dgvPlaylistSongs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlaylistSongs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSongs_colOrder,
            this.dgvSongs_colName,
            this.dgvSongs_colDuration,
            this.dgvSongs_colRating});
            this.dgvPlaylistSongs.Location = new System.Drawing.Point(9, 19);
            this.dgvPlaylistSongs.MultiSelect = false;
            this.dgvPlaylistSongs.Name = "dgvPlaylistSongs";
            this.dgvPlaylistSongs.ReadOnly = true;
            this.dgvPlaylistSongs.RowHeadersVisible = false;
            this.dgvPlaylistSongs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPlaylistSongs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlaylistSongs.Size = new System.Drawing.Size(529, 521);
            this.dgvPlaylistSongs.TabIndex = 3;
            this.dgvPlaylistSongs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlaylistSongs_CellContentClick);
            this.dgvPlaylistSongs.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlaylistSongs_CellContentDoubleClick);
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
            this.gbModifyPlaylist.BackColor = System.Drawing.Color.Transparent;
            this.gbModifyPlaylist.Controls.Add(this.btnxMoveSongToOrder);
            this.gbModifyPlaylist.Controls.Add(this.btnxMoveSongDown);
            this.gbModifyPlaylist.Controls.Add(this.btnxMoveSongUp);
            this.gbModifyPlaylist.Controls.Add(this.btnxRemoveSong);
            this.gbModifyPlaylist.Controls.Add(this.btnxDeletePlaylist);
            this.gbModifyPlaylist.Controls.Add(this.btnxSetDefaultPlaylist);
            this.gbModifyPlaylist.Controls.Add(this.txtMoveSongToOrder);
            this.gbModifyPlaylist.Controls.Add(this.label2);
            this.gbModifyPlaylist.Controls.Add(this.cbPlaylists);
            this.gbModifyPlaylist.Location = new System.Drawing.Point(23, 107);
            this.gbModifyPlaylist.Name = "gbModifyPlaylist";
            this.gbModifyPlaylist.Size = new System.Drawing.Size(298, 448);
            this.gbModifyPlaylist.TabIndex = 4;
            this.gbModifyPlaylist.TabStop = false;
            this.gbModifyPlaylist.Text = "Modify Playlist";
            // 
            // btnxMoveSongToOrder
            // 
            this.btnxMoveSongToOrder.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnxMoveSongToOrder.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnxMoveSongToOrder.Location = new System.Drawing.Point(21, 362);
            this.btnxMoveSongToOrder.Name = "btnxMoveSongToOrder";
            this.btnxMoveSongToOrder.Size = new System.Drawing.Size(157, 48);
            this.btnxMoveSongToOrder.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnxMoveSongToOrder.TabIndex = 15;
            this.btnxMoveSongToOrder.Text = "Move Song To Order:";
            this.btnxMoveSongToOrder.Click += new System.EventHandler(this.btnxMoveSongToOrder_Click);
            // 
            // btnxMoveSongDown
            // 
            this.btnxMoveSongDown.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnxMoveSongDown.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnxMoveSongDown.Location = new System.Drawing.Point(21, 307);
            this.btnxMoveSongDown.Name = "btnxMoveSongDown";
            this.btnxMoveSongDown.Size = new System.Drawing.Size(255, 49);
            this.btnxMoveSongDown.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnxMoveSongDown.TabIndex = 14;
            this.btnxMoveSongDown.Text = "Move Selected Song Down";
            this.btnxMoveSongDown.Click += new System.EventHandler(this.btnxMoveSongDown_Click);
            // 
            // btnxMoveSongUp
            // 
            this.btnxMoveSongUp.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnxMoveSongUp.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnxMoveSongUp.Location = new System.Drawing.Point(21, 247);
            this.btnxMoveSongUp.Name = "btnxMoveSongUp";
            this.btnxMoveSongUp.Size = new System.Drawing.Size(255, 54);
            this.btnxMoveSongUp.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnxMoveSongUp.TabIndex = 13;
            this.btnxMoveSongUp.Text = "Move Selected Song Up";
            this.btnxMoveSongUp.Click += new System.EventHandler(this.btnxMoveSongUp_Click);
            // 
            // btnxRemoveSong
            // 
            this.btnxRemoveSong.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnxRemoveSong.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnxRemoveSong.Location = new System.Drawing.Point(21, 191);
            this.btnxRemoveSong.Name = "btnxRemoveSong";
            this.btnxRemoveSong.Size = new System.Drawing.Size(255, 50);
            this.btnxRemoveSong.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnxRemoveSong.TabIndex = 12;
            this.btnxRemoveSong.Text = "Remove Selected Song";
            this.btnxRemoveSong.Click += new System.EventHandler(this.btnxRemoveSong_Click);
            // 
            // btnxDeletePlaylist
            // 
            this.btnxDeletePlaylist.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnxDeletePlaylist.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnxDeletePlaylist.Location = new System.Drawing.Point(21, 103);
            this.btnxDeletePlaylist.Name = "btnxDeletePlaylist";
            this.btnxDeletePlaylist.Size = new System.Drawing.Size(255, 48);
            this.btnxDeletePlaylist.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnxDeletePlaylist.TabIndex = 11;
            this.btnxDeletePlaylist.Text = "Delete Playlist";
            this.btnxDeletePlaylist.Click += new System.EventHandler(this.btnxDeletePlaylist_Click);
            // 
            // btnxSetDefaultPlaylist
            // 
            this.btnxSetDefaultPlaylist.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnxSetDefaultPlaylist.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnxSetDefaultPlaylist.Location = new System.Drawing.Point(21, 50);
            this.btnxSetDefaultPlaylist.Name = "btnxSetDefaultPlaylist";
            this.btnxSetDefaultPlaylist.Size = new System.Drawing.Size(255, 47);
            this.btnxSetDefaultPlaylist.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnxSetDefaultPlaylist.TabIndex = 10;
            this.btnxSetDefaultPlaylist.Text = "Set As Default Playlist";
            this.btnxSetDefaultPlaylist.Click += new System.EventHandler(this.btnxSetDefaultPlaylist_Click);
            // 
            // txtMoveSongToOrder
            // 
            this.txtMoveSongToOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoveSongToOrder.Location = new System.Drawing.Point(196, 374);
            this.txtMoveSongToOrder.Name = "txtMoveSongToOrder";
            this.txtMoveSongToOrder.Size = new System.Drawing.Size(40, 26);
            this.txtMoveSongToOrder.TabIndex = 9;
            this.txtMoveSongToOrder.Leave += new System.EventHandler(this.txtMoveSongToOrder_Leave);
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
            this.rdoCreatePlaylist.BackColor = System.Drawing.Color.Transparent;
            this.rdoCreatePlaylist.Location = new System.Drawing.Point(3, 52);
            this.rdoCreatePlaylist.Name = "rdoCreatePlaylist";
            this.rdoCreatePlaylist.Size = new System.Drawing.Size(14, 13);
            this.rdoCreatePlaylist.TabIndex = 5;
            this.rdoCreatePlaylist.UseVisualStyleBackColor = false;
            this.rdoCreatePlaylist.CheckedChanged += new System.EventHandler(this.rdoCreatePlaylist_CheckedChanged);
            // 
            // rdoModifyPlaylist
            // 
            this.rdoModifyPlaylist.AutoSize = true;
            this.rdoModifyPlaylist.BackColor = System.Drawing.Color.Transparent;
            this.rdoModifyPlaylist.Checked = true;
            this.rdoModifyPlaylist.Location = new System.Drawing.Point(3, 133);
            this.rdoModifyPlaylist.Name = "rdoModifyPlaylist";
            this.rdoModifyPlaylist.Size = new System.Drawing.Size(14, 13);
            this.rdoModifyPlaylist.TabIndex = 6;
            this.rdoModifyPlaylist.TabStop = true;
            this.rdoModifyPlaylist.UseVisualStyleBackColor = false;
            this.rdoModifyPlaylist.CheckedChanged += new System.EventHandler(this.rdoModifyPlaylist_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.dgvPlaylistSongs);
            this.groupBox4.Location = new System.Drawing.Point(327, 9);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(544, 546);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Playlist Song Management";
            // 
            // tabManagePlaylists
            // 
            // 
            // 
            // 
            // 
            // 
            // 
            this.tabManagePlaylists.ControlBox.CloseBox.Name = "";
            // 
            // 
            // 
            this.tabManagePlaylists.ControlBox.MenuBox.Name = "";
            this.tabManagePlaylists.ControlBox.Name = "";
            this.tabManagePlaylists.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.tabManagePlaylists.ControlBox.MenuBox,
            this.tabManagePlaylists.ControlBox.CloseBox});
            this.tabManagePlaylists.Controls.Add(this.superTabControlPanel2);
            this.tabManagePlaylists.Controls.Add(this.superTabControlPanel1);
            this.tabManagePlaylists.Location = new System.Drawing.Point(3, 12);
            this.tabManagePlaylists.Name = "tabManagePlaylists";
            this.tabManagePlaylists.ReorderTabsEnabled = true;
            this.tabManagePlaylists.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabManagePlaylists.SelectedTabIndex = 0;
            this.tabManagePlaylists.Size = new System.Drawing.Size(874, 593);
            this.tabManagePlaylists.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabManagePlaylists.TabIndex = 11;
            this.tabManagePlaylists.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.tabCreateModifyPlaylists,
            this.tabAddSongsPlaylist});
            this.tabManagePlaylists.Text = "superTabControl1";
            // 
            // superTabControlPanel2
            // 
            this.superTabControlPanel2.Controls.Add(this.rdoCreatePlaylist);
            this.superTabControlPanel2.Controls.Add(this.groupBox4);
            this.superTabControlPanel2.Controls.Add(this.gbCreatePlaylist);
            this.superTabControlPanel2.Controls.Add(this.rdoModifyPlaylist);
            this.superTabControlPanel2.Controls.Add(this.gbModifyPlaylist);
            this.superTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel2.Location = new System.Drawing.Point(0, 25);
            this.superTabControlPanel2.Name = "superTabControlPanel2";
            this.superTabControlPanel2.Size = new System.Drawing.Size(874, 568);
            this.superTabControlPanel2.TabIndex = 0;
            this.superTabControlPanel2.TabItem = this.tabCreateModifyPlaylists;
            // 
            // tabCreateModifyPlaylists
            // 
            this.tabCreateModifyPlaylists.AttachedControl = this.superTabControlPanel2;
            this.tabCreateModifyPlaylists.GlobalItem = false;
            this.tabCreateModifyPlaylists.Name = "tabCreateModifyPlaylists";
            this.tabCreateModifyPlaylists.Text = "Create/Modify Playlists";
            // 
            // superTabControlPanel1
            // 
            this.superTabControlPanel1.Controls.Add(this.gbPlaylistControls);
            this.superTabControlPanel1.Controls.Add(this.expandablePanel1);
            this.superTabControlPanel1.Controls.Add(this.groupBox1);
            this.superTabControlPanel1.Controls.Add(this.panel2);
            this.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.superTabControlPanel1.Location = new System.Drawing.Point(0, 0);
            this.superTabControlPanel1.Name = "superTabControlPanel1";
            this.superTabControlPanel1.Size = new System.Drawing.Size(874, 593);
            this.superTabControlPanel1.TabIndex = 0;
            this.superTabControlPanel1.TabItem = this.tabAddSongsPlaylist;
            // 
            // gbPlaylistControls
            // 
            this.gbPlaylistControls.BackColor = System.Drawing.Color.Transparent;
            this.gbPlaylistControls.Controls.Add(this.btnxAddSongToPlaylist);
            this.gbPlaylistControls.Controls.Add(this.cbPlaylists2);
            this.gbPlaylistControls.Controls.Add(this.dgvPlaylistSongs2);
            this.gbPlaylistControls.Location = new System.Drawing.Point(498, 12);
            this.gbPlaylistControls.Name = "gbPlaylistControls";
            this.gbPlaylistControls.Size = new System.Drawing.Size(359, 542);
            this.gbPlaylistControls.TabIndex = 20;
            this.gbPlaylistControls.TabStop = false;
            this.gbPlaylistControls.Text = "Playlist Controls";
            // 
            // btnxAddSongToPlaylist
            // 
            this.btnxAddSongToPlaylist.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnxAddSongToPlaylist.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnxAddSongToPlaylist.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.btnxAddSongToPlaylist.Location = new System.Drawing.Point(6, 48);
            this.btnxAddSongToPlaylist.Name = "btnxAddSongToPlaylist";
            this.btnxAddSongToPlaylist.Size = new System.Drawing.Size(335, 52);
            this.btnxAddSongToPlaylist.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnxAddSongToPlaylist.TabIndex = 12;
            this.btnxAddSongToPlaylist.Text = "Add Song To Playlist";
            this.btnxAddSongToPlaylist.Click += new System.EventHandler(this.btnxAddSongToPlaylist_Click);
            // 
            // cbPlaylists2
            // 
            this.cbPlaylists2.FormattingEnabled = true;
            this.cbPlaylists2.Location = new System.Drawing.Point(73, 19);
            this.cbPlaylists2.Name = "cbPlaylists2";
            this.cbPlaylists2.Size = new System.Drawing.Size(186, 21);
            this.cbPlaylists2.TabIndex = 11;
            this.cbPlaylists2.SelectedIndexChanged += new System.EventHandler(this.cbPlaylists2_SelectedIndexChanged);
            // 
            // dgvPlaylistSongs2
            // 
            this.dgvPlaylistSongs2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlaylistSongs2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvPlaylistSongs2.Location = new System.Drawing.Point(6, 106);
            this.dgvPlaylistSongs2.Name = "dgvPlaylistSongs2";
            this.dgvPlaylistSongs2.ReadOnly = true;
            this.dgvPlaylistSongs2.RowHeadersVisible = false;
            this.dgvPlaylistSongs2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPlaylistSongs2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlaylistSongs2.Size = new System.Drawing.Size(335, 420);
            this.dgvPlaylistSongs2.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Order";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 50;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Duration";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 60;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Rating";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 50;
            // 
            // expandablePanel1
            // 
            this.expandablePanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.expandablePanel1.Controls.Add(this.panel3);
            this.expandablePanel1.ExpandOnTitleClick = true;
            this.expandablePanel1.Location = new System.Drawing.Point(9, 12);
            this.expandablePanel1.Name = "expandablePanel1";
            this.expandablePanel1.Size = new System.Drawing.Size(483, 253);
            this.expandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.expandablePanel1.Style.BackgroundImageAlpha = ((byte)(100));
            this.expandablePanel1.Style.Border = DevComponents.DotNetBar.eBorderType.Bump;
            this.expandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandablePanel1.Style.GradientAngle = 90;
            this.expandablePanel1.TabIndex = 19;
            this.expandablePanel1.TitleHeight = 20;
            this.expandablePanel1.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.TitleStyle.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.expandablePanel1.TitleStyle.BackColor2.Color = System.Drawing.Color.RoyalBlue;
            this.expandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.expandablePanel1.TitleStyle.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.expandablePanel1.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.expandablePanel1.TitleStyle.GradientAngle = 90;
            this.expandablePanel1.TitleText = "Choose Genre/Artist/Album";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.groupBox5);
            this.panel3.Location = new System.Drawing.Point(3, 20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(483, 225);
            this.panel3.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.lbAlbums);
            this.groupBox3.Location = new System.Drawing.Point(278, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 216);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Choose Album";
            // 
            // lbAlbums
            // 
            this.lbAlbums.FormattingEnabled = true;
            this.lbAlbums.Location = new System.Drawing.Point(6, 18);
            this.lbAlbums.Name = "lbAlbums";
            this.lbAlbums.Size = new System.Drawing.Size(188, 173);
            this.lbAlbums.TabIndex = 3;
            this.lbAlbums.SelectedIndexChanged += new System.EventHandler(this.lbAlbums_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lbArtists);
            this.groupBox2.Location = new System.Drawing.Point(128, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 216);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choose Artist";
            // 
            // lbArtists
            // 
            this.lbArtists.FormattingEnabled = true;
            this.lbArtists.Location = new System.Drawing.Point(6, 19);
            this.lbArtists.Name = "lbArtists";
            this.lbArtists.Size = new System.Drawing.Size(138, 173);
            this.lbArtists.TabIndex = 2;
            this.lbArtists.SelectedIndexChanged += new System.EventHandler(this.lbArtists_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.lbGenres);
            this.groupBox5.Location = new System.Drawing.Point(3, 9);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(125, 216);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Choose Genre";
            // 
            // lbGenres
            // 
            this.lbGenres.FormattingEnabled = true;
            this.lbGenres.Location = new System.Drawing.Point(6, 19);
            this.lbGenres.Name = "lbGenres";
            this.lbGenres.Size = new System.Drawing.Size(113, 173);
            this.lbGenres.TabIndex = 1;
            this.lbGenres.SelectedIndexChanged += new System.EventHandler(this.lbGenres_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dgvSongs);
            this.groupBox1.Location = new System.Drawing.Point(9, 271);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 283);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Song";
            // 
            // dgvSongs
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DimGray;
            this.dgvSongs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSongs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSongs.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgvSongs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSongs_colTrack,
            this.dataGridViewTextBoxColumn1,
            this.dgvSongs_colArtist,
            this.dgvSongs_colAlbum});
            this.dgvSongs.Location = new System.Drawing.Point(9, 19);
            this.dgvSongs.MultiSelect = false;
            this.dgvSongs.Name = "dgvSongs";
            this.dgvSongs.ReadOnly = true;
            this.dgvSongs.RowHeadersVisible = false;
            this.dgvSongs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSongs.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvSongs.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSongs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSongs.Size = new System.Drawing.Size(465, 248);
            this.dgvSongs.TabIndex = 0;
            this.dgvSongs.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSongs_CellDoubleClick);
            // 
            // dgvSongs_colTrack
            // 
            this.dgvSongs_colTrack.HeaderText = "Track";
            this.dgvSongs_colTrack.Name = "dgvSongs_colTrack";
            this.dgvSongs_colTrack.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dgvSongs_colArtist
            // 
            this.dgvSongs_colArtist.HeaderText = "Artist";
            this.dgvSongs_colArtist.Name = "dgvSongs_colArtist";
            this.dgvSongs_colArtist.ReadOnly = true;
            // 
            // dgvSongs_colAlbum
            // 
            this.dgvSongs_colAlbum.HeaderText = "Album";
            this.dgvSongs_colAlbum.Name = "dgvSongs_colAlbum";
            this.dgvSongs_colAlbum.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox6);
            this.panel2.Controls.Add(this.groupBox7);
            this.panel2.Location = new System.Drawing.Point(992, -94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 488);
            this.panel2.TabIndex = 7;
            // 
            // groupBox6
            // 
            this.groupBox6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox6.Controls.Add(this.lbRequestPlaylist);
            this.groupBox6.Location = new System.Drawing.Point(3, 284);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(215, 201);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Requested Songs";
            // 
            // lbRequestPlaylist
            // 
            this.lbRequestPlaylist.FormattingEnabled = true;
            this.lbRequestPlaylist.Location = new System.Drawing.Point(6, 19);
            this.lbRequestPlaylist.Name = "lbRequestPlaylist";
            this.lbRequestPlaylist.Size = new System.Drawing.Size(203, 173);
            this.lbRequestPlaylist.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Controls.Add(this.comboBox1);
            this.groupBox7.Controls.Add(this.lboxCurrentPlaylist);
            this.groupBox7.Location = new System.Drawing.Point(3, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(215, 275);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Playlist Songs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Playlist:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(51, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(158, 21);
            this.comboBox1.TabIndex = 17;
            // 
            // lboxCurrentPlaylist
            // 
            this.lboxCurrentPlaylist.BackColor = System.Drawing.SystemColors.Window;
            this.lboxCurrentPlaylist.FormattingEnabled = true;
            this.lboxCurrentPlaylist.Location = new System.Drawing.Point(6, 45);
            this.lboxCurrentPlaylist.Name = "lboxCurrentPlaylist";
            this.lboxCurrentPlaylist.Size = new System.Drawing.Size(203, 225);
            this.lboxCurrentPlaylist.TabIndex = 0;
            // 
            // tabAddSongsPlaylist
            // 
            this.tabAddSongsPlaylist.AttachedControl = this.superTabControlPanel1;
            this.tabAddSongsPlaylist.GlobalItem = false;
            this.tabAddSongsPlaylist.Name = "tabAddSongsPlaylist";
            this.tabAddSongsPlaylist.Text = "Add Songs to Playlists";
            // 
            // frmManagePlaylists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 613);
            this.Controls.Add(this.tabManagePlaylists);
            this.Name = "frmManagePlaylists";
            this.Text = "Manage Playlists";
            this.Load += new System.EventHandler(this.frmManagePlaylists_Load);
            this.gbCreatePlaylist.ResumeLayout(false);
            this.gbCreatePlaylist.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaylistSongs)).EndInit();
            this.gbModifyPlaylist.ResumeLayout(false);
            this.gbModifyPlaylist.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabManagePlaylists)).EndInit();
            this.tabManagePlaylists.ResumeLayout(false);
            this.superTabControlPanel2.ResumeLayout(false);
            this.superTabControlPanel2.PerformLayout();
            this.superTabControlPanel1.ResumeLayout(false);
            this.gbPlaylistControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaylistSongs2)).EndInit();
            this.expandablePanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongs)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCreatePlaylist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreatePlaylist;
        private System.Windows.Forms.TextBox txtCreatePlaylist;
        private System.Windows.Forms.ComboBox cbPlaylists;
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
        private DevComponents.DotNetBar.SuperTabControl tabManagePlaylists;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel2;
        private DevComponents.DotNetBar.SuperTabItem tabCreateModifyPlaylists;
        private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel1;
        private DevComponents.DotNetBar.SuperTabItem tabAddSongsPlaylist;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvSongs;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSongs_colTrack;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSongs_colArtist;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSongs_colAlbum;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListBox lbRequestPlaylist;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox lboxCurrentPlaylist;
        private System.Windows.Forms.DataGridView dgvPlaylistSongs2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DevComponents.DotNetBar.ExpandablePanel expandablePanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbAlbums;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbArtists;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox lbGenres;
        private System.Windows.Forms.GroupBox gbPlaylistControls;
        private DevComponents.DotNetBar.ButtonX btnxAddSongToPlaylist;
        private System.Windows.Forms.ComboBox cbPlaylists2;
        private DevComponents.DotNetBar.ButtonX btnxMoveSongToOrder;
        private DevComponents.DotNetBar.ButtonX btnxMoveSongDown;
        private DevComponents.DotNetBar.ButtonX btnxMoveSongUp;
        private DevComponents.DotNetBar.ButtonX btnxRemoveSong;
        private DevComponents.DotNetBar.ButtonX btnxDeletePlaylist;
        private DevComponents.DotNetBar.ButtonX btnxSetDefaultPlaylist;
    }
}