using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace PartyMusicManager
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageMusicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setDefaultPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lbRequestPlaylist = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPlaylists = new System.Windows.Forms.ComboBox();
            this.lboxCurrentPlaylist = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbAlbums = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbArtists = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbGenres = new System.Windows.Forms.ListBox();
            this.dgvSongs = new System.Windows.Forms.DataGridView();
            this.dgvSongs_colTrack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSongs_colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSongs_colDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSongs_colArtist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSongs_colAlbum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSongs_colGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSongs_colRating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.MusicMonitorTimer = new System.Windows.Forms.Timer(this.components);
            this.lblSongTimePlayed = new System.Windows.Forms.Label();
            this.lblSongTimeDuration = new System.Windows.Forms.Label();
            this.btnSkipToNextSong = new System.Windows.Forms.Button();
            this.lblCurrentSongName = new System.Windows.Forms.Label();
            this.lblCurrentSongArtist = new System.Windows.Forms.Label();
            this.lblCurrentSongAlbum = new System.Windows.Forms.Label();
            this.btnAddSongToPlaylist = new System.Windows.Forms.Button();
            this.btnMusicStop = new System.Windows.Forms.Button();
            this.btnMusicPause = new System.Windows.Forms.Button();
            this.btnMusicPlay = new System.Windows.Forms.Button();
            this.starCurrentSongRating = new DevComponents.DotNetBar.Controls.RatingStar();
            this.pbSongDuration = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.switchVolumeMute = new DevComponents.DotNetBar.Controls.SwitchButton();
            this.knobVolume = new DevComponents.Instrumentation.KnobControl();
            this.galleryContainer1 = new DevComponents.DotNetBar.GalleryContainer();
            this.btnAddSongToRequest = new System.Windows.Forms.Button();
            this.btnxRequestSong = new DevComponents.DotNetBar.ButtonX();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongs)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.manageMusicToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1228, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // manageMusicToolStripMenuItem
            // 
            this.manageMusicToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDirectoryToolStripMenuItem,
            this.addFileToolStripMenuItem,
            this.createPlaylistToolStripMenuItem,
            this.modifyPlaylistToolStripMenuItem,
            this.setDefaultPlaylistToolStripMenuItem});
            this.manageMusicToolStripMenuItem.Name = "manageMusicToolStripMenuItem";
            this.manageMusicToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.manageMusicToolStripMenuItem.Text = "Manage Music";
            // 
            // addDirectoryToolStripMenuItem
            // 
            this.addDirectoryToolStripMenuItem.Name = "addDirectoryToolStripMenuItem";
            this.addDirectoryToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.addDirectoryToolStripMenuItem.Text = "Add &Directory to Music Database";
            // 
            // addFileToolStripMenuItem
            // 
            this.addFileToolStripMenuItem.Name = "addFileToolStripMenuItem";
            this.addFileToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.addFileToolStripMenuItem.Text = "Add &File to Music Database";
            // 
            // createPlaylistToolStripMenuItem
            // 
            this.createPlaylistToolStripMenuItem.Name = "createPlaylistToolStripMenuItem";
            this.createPlaylistToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.createPlaylistToolStripMenuItem.Text = "&Create Playlist";
            // 
            // modifyPlaylistToolStripMenuItem
            // 
            this.modifyPlaylistToolStripMenuItem.Name = "modifyPlaylistToolStripMenuItem";
            this.modifyPlaylistToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.modifyPlaylistToolStripMenuItem.Text = "&Manage Playlists";
            this.modifyPlaylistToolStripMenuItem.Click += new System.EventHandler(this.modifyPlaylistToolStripMenuItem_Click);
            // 
            // setDefaultPlaylistToolStripMenuItem
            // 
            this.setDefaultPlaylistToolStripMenuItem.Name = "setDefaultPlaylistToolStripMenuItem";
            this.setDefaultPlaylistToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.setDefaultPlaylistToolStripMenuItem.Text = "&Set Default Playlist";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox6);
            this.panel2.Controls.Add(this.groupBox5);
            this.panel2.Location = new System.Drawing.Point(995, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 488);
            this.panel2.TabIndex = 2;
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
            this.groupBox6.Text = "Request Songs";
            // 
            // lbRequestPlaylist
            // 
            this.lbRequestPlaylist.FormattingEnabled = true;
            this.lbRequestPlaylist.Location = new System.Drawing.Point(6, 19);
            this.lbRequestPlaylist.Name = "lbRequestPlaylist";
            this.lbRequestPlaylist.Size = new System.Drawing.Size(203, 173);
            this.lbRequestPlaylist.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.cbPlaylists);
            this.groupBox5.Controls.Add(this.lboxCurrentPlaylist);
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(215, 275);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Playlist Songs";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Playlist:";
            // 
            // cbPlaylists
            // 
            this.cbPlaylists.FormattingEnabled = true;
            this.cbPlaylists.Location = new System.Drawing.Point(51, 18);
            this.cbPlaylists.Name = "cbPlaylists";
            this.cbPlaylists.Size = new System.Drawing.Size(158, 21);
            this.cbPlaylists.TabIndex = 17;
            this.cbPlaylists.DropDown += new System.EventHandler(this.cbPlaylists_DropDown);
            this.cbPlaylists.SelectedIndexChanged += new System.EventHandler(this.cbPlaylists_SelectedIndexChanged);
            this.cbPlaylists.DropDownClosed += new System.EventHandler(this.cbPlaylists_DropDownClosed);
            this.cbPlaylists.TextChanged += new System.EventHandler(this.cbPlaylists_TextChanged);
            // 
            // lboxCurrentPlaylist
            // 
            this.lboxCurrentPlaylist.BackColor = System.Drawing.SystemColors.Window;
            this.lboxCurrentPlaylist.FormattingEnabled = true;
            this.lboxCurrentPlaylist.Location = new System.Drawing.Point(6, 45);
            this.lboxCurrentPlaylist.Name = "lboxCurrentPlaylist";
            this.lboxCurrentPlaylist.Size = new System.Drawing.Size(203, 225);
            this.lboxCurrentPlaylist.TabIndex = 0;
            this.lboxCurrentPlaylist.SelectedIndexChanged += new System.EventHandler(this.lboxCurrentPlaylist_SelectedIndexChanged);
            this.lboxCurrentPlaylist.DoubleClick += new System.EventHandler(this.lboxCurrentPlaylist_DoubleClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox3);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Location = new System.Drawing.Point(15, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(483, 216);
            this.panel3.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbAlbums);
            this.groupBox3.Location = new System.Drawing.Point(278, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 210);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Albums";
            // 
            // lbAlbums
            // 
            this.lbAlbums.FormattingEnabled = true;
            this.lbAlbums.Location = new System.Drawing.Point(6, 18);
            this.lbAlbums.Name = "lbAlbums";
            this.lbAlbums.Size = new System.Drawing.Size(188, 186);
            this.lbAlbums.TabIndex = 3;
            this.lbAlbums.SelectedIndexChanged += new System.EventHandler(this.lbAlbums_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbArtists);
            this.groupBox2.Location = new System.Drawing.Point(128, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 210);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Artists";
            // 
            // lbArtists
            // 
            this.lbArtists.FormattingEnabled = true;
            this.lbArtists.Location = new System.Drawing.Point(6, 19);
            this.lbArtists.Name = "lbArtists";
            this.lbArtists.Size = new System.Drawing.Size(138, 186);
            this.lbArtists.TabIndex = 2;
            this.lbArtists.SelectedIndexChanged += new System.EventHandler(this.lbArtists_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbGenres);
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 210);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Genres";
            // 
            // lbGenres
            // 
            this.lbGenres.FormattingEnabled = true;
            this.lbGenres.Location = new System.Drawing.Point(6, 19);
            this.lbGenres.Name = "lbGenres";
            this.lbGenres.Size = new System.Drawing.Size(113, 186);
            this.lbGenres.TabIndex = 1;
            this.lbGenres.SelectedIndexChanged += new System.EventHandler(this.lbGenres_SelectedIndexChanged);
            // 
            // dgvSongs
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            this.dgvSongs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSongs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSongs.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgvSongs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSongs_colTrack,
            this.dgvSongs_colName,
            this.dgvSongs_colDuration,
            this.dgvSongs_colArtist,
            this.dgvSongs_colAlbum,
            this.dgvSongs_colGenre,
            this.dgvSongs_colRating});
            this.dgvSongs.Location = new System.Drawing.Point(6, 18);
            this.dgvSongs.MultiSelect = false;
            this.dgvSongs.Name = "dgvSongs";
            this.dgvSongs.ReadOnly = true;
            this.dgvSongs.RowHeadersVisible = false;
            this.dgvSongs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSongs.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvSongs.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSongs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSongs.Size = new System.Drawing.Size(962, 245);
            this.dgvSongs.TabIndex = 0;
            this.dgvSongs.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSongs_CellContentDoubleClick);
            // 
            // dgvSongs_colTrack
            // 
            this.dgvSongs_colTrack.HeaderText = "Track";
            this.dgvSongs_colTrack.Name = "dgvSongs_colTrack";
            this.dgvSongs_colTrack.ReadOnly = true;
            // 
            // dgvSongs_colName
            // 
            this.dgvSongs_colName.HeaderText = "Name";
            this.dgvSongs_colName.Name = "dgvSongs_colName";
            this.dgvSongs_colName.ReadOnly = true;
            // 
            // dgvSongs_colDuration
            // 
            this.dgvSongs_colDuration.HeaderText = "Duration";
            this.dgvSongs_colDuration.Name = "dgvSongs_colDuration";
            this.dgvSongs_colDuration.ReadOnly = true;
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
            // dgvSongs_colGenre
            // 
            this.dgvSongs_colGenre.HeaderText = "Genre";
            this.dgvSongs_colGenre.Name = "dgvSongs_colGenre";
            this.dgvSongs_colGenre.ReadOnly = true;
            // 
            // dgvSongs_colRating
            // 
            this.dgvSongs_colRating.HeaderText = "Rating";
            this.dgvSongs_colRating.Name = "dgvSongs_colRating";
            this.dgvSongs_colRating.ReadOnly = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvSongs);
            this.groupBox4.Location = new System.Drawing.Point(15, 249);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(974, 272);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Songs";
            // 
            // MusicMonitorTimer
            // 
            this.MusicMonitorTimer.Interval = 500;
            this.MusicMonitorTimer.Tick += new System.EventHandler(this.MusicMonitorTimer_Tick);
            // 
            // lblSongTimePlayed
            // 
            this.lblSongTimePlayed.AutoSize = true;
            this.lblSongTimePlayed.Location = new System.Drawing.Point(517, 108);
            this.lblSongTimePlayed.Name = "lblSongTimePlayed";
            this.lblSongTimePlayed.Size = new System.Drawing.Size(34, 13);
            this.lblSongTimePlayed.TabIndex = 7;
            this.lblSongTimePlayed.Text = "00:00";
            // 
            // lblSongTimeDuration
            // 
            this.lblSongTimeDuration.AutoSize = true;
            this.lblSongTimeDuration.Location = new System.Drawing.Point(686, 108);
            this.lblSongTimeDuration.Name = "lblSongTimeDuration";
            this.lblSongTimeDuration.Size = new System.Drawing.Size(34, 13);
            this.lblSongTimeDuration.TabIndex = 8;
            this.lblSongTimeDuration.Text = "00:00";
            // 
            // btnSkipToNextSong
            // 
            this.btnSkipToNextSong.Location = new System.Drawing.Point(725, 56);
            this.btnSkipToNextSong.Name = "btnSkipToNextSong";
            this.btnSkipToNextSong.Size = new System.Drawing.Size(121, 23);
            this.btnSkipToNextSong.TabIndex = 9;
            this.btnSkipToNextSong.Text = "Skip To Next Song";
            this.btnSkipToNextSong.UseVisualStyleBackColor = true;
            this.btnSkipToNextSong.Click += new System.EventHandler(this.btnSkipToNextSong_Click);
            // 
            // lblCurrentSongName
            // 
            this.lblCurrentSongName.AutoSize = true;
            this.lblCurrentSongName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentSongName.Location = new System.Drawing.Point(517, 46);
            this.lblCurrentSongName.Name = "lblCurrentSongName";
            this.lblCurrentSongName.Size = new System.Drawing.Size(181, 18);
            this.lblCurrentSongName.TabIndex = 10;
            this.lblCurrentSongName.Text = "Current Song Name";
            // 
            // lblCurrentSongArtist
            // 
            this.lblCurrentSongArtist.AutoSize = true;
            this.lblCurrentSongArtist.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblCurrentSongArtist.ForeColor = System.Drawing.Color.Black;
            this.lblCurrentSongArtist.Location = new System.Drawing.Point(517, 65);
            this.lblCurrentSongArtist.Name = "lblCurrentSongArtist";
            this.lblCurrentSongArtist.Size = new System.Drawing.Size(177, 18);
            this.lblCurrentSongArtist.TabIndex = 12;
            this.lblCurrentSongArtist.Text = "Current Song Artist";
            // 
            // lblCurrentSongAlbum
            // 
            this.lblCurrentSongAlbum.AutoSize = true;
            this.lblCurrentSongAlbum.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblCurrentSongAlbum.Location = new System.Drawing.Point(517, 83);
            this.lblCurrentSongAlbum.Name = "lblCurrentSongAlbum";
            this.lblCurrentSongAlbum.Size = new System.Drawing.Size(184, 18);
            this.lblCurrentSongAlbum.TabIndex = 14;
            this.lblCurrentSongAlbum.Text = "Current Song Album";
            // 
            // btnAddSongToPlaylist
            // 
            this.btnAddSongToPlaylist.Location = new System.Drawing.Point(725, 27);
            this.btnAddSongToPlaylist.Name = "btnAddSongToPlaylist";
            this.btnAddSongToPlaylist.Size = new System.Drawing.Size(115, 23);
            this.btnAddSongToPlaylist.TabIndex = 16;
            this.btnAddSongToPlaylist.Text = "Add Song To Playlist";
            this.btnAddSongToPlaylist.UseVisualStyleBackColor = true;
            this.btnAddSongToPlaylist.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMusicStop
            // 
            this.btnMusicStop.Location = new System.Drawing.Point(518, 153);
            this.btnMusicStop.Name = "btnMusicStop";
            this.btnMusicStop.Size = new System.Drawing.Size(56, 23);
            this.btnMusicStop.TabIndex = 17;
            this.btnMusicStop.Text = "Stop";
            this.btnMusicStop.UseVisualStyleBackColor = true;
            this.btnMusicStop.Click += new System.EventHandler(this.btnMusicStop_Click);
            // 
            // btnMusicPause
            // 
            this.btnMusicPause.Location = new System.Drawing.Point(597, 153);
            this.btnMusicPause.Name = "btnMusicPause";
            this.btnMusicPause.Size = new System.Drawing.Size(59, 23);
            this.btnMusicPause.TabIndex = 18;
            this.btnMusicPause.Text = "Pause";
            this.btnMusicPause.UseVisualStyleBackColor = true;
            this.btnMusicPause.Click += new System.EventHandler(this.btnMusicPause_Click);
            // 
            // btnMusicPlay
            // 
            this.btnMusicPlay.Location = new System.Drawing.Point(664, 153);
            this.btnMusicPlay.Name = "btnMusicPlay";
            this.btnMusicPlay.Size = new System.Drawing.Size(56, 23);
            this.btnMusicPlay.TabIndex = 19;
            this.btnMusicPlay.Text = "Play";
            this.btnMusicPlay.UseVisualStyleBackColor = true;
            this.btnMusicPlay.Click += new System.EventHandler(this.btnMusicPlay_Click);
            // 
            // starCurrentSongRating
            // 
            // 
            // 
            // 
            this.starCurrentSongRating.BackgroundStyle.Class = "";
            this.starCurrentSongRating.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.starCurrentSongRating.Location = new System.Drawing.Point(580, 104);
            this.starCurrentSongRating.Name = "starCurrentSongRating";
            this.starCurrentSongRating.Size = new System.Drawing.Size(76, 23);
            this.starCurrentSongRating.TabIndex = 20;
            this.starCurrentSongRating.TextColor = System.Drawing.Color.Empty;
            this.starCurrentSongRating.RatingChanged += new System.EventHandler(this.starCurrentSongRating_RatingChanged);
            this.starCurrentSongRating.Click += new System.EventHandler(this.starCurrentSongRating_Click);
            // 
            // pbSongDuration
            // 
            // 
            // 
            // 
            this.pbSongDuration.BackgroundStyle.Class = "";
            this.pbSongDuration.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pbSongDuration.Location = new System.Drawing.Point(518, 124);
            this.pbSongDuration.Name = "pbSongDuration";
            this.pbSongDuration.Size = new System.Drawing.Size(202, 23);
            this.pbSongDuration.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.pbSongDuration.TabIndex = 21;
            this.pbSongDuration.Text = "00:00";
            this.pbSongDuration.TextVisible = true;
            this.pbSongDuration.Click += new System.EventHandler(this.pbSongDuration_Click);
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.buttonX1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.buttonX1.Location = new System.Drawing.Point(753, 182);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(230, 70);
            this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX1.TabIndex = 23;
            this.buttonX1.Text = "Skip To Next Song";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // switchVolumeMute
            // 
            // 
            // 
            // 
            this.switchVolumeMute.BackgroundStyle.Class = "";
            this.switchVolumeMute.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.switchVolumeMute.Location = new System.Drawing.Point(895, 138);
            this.switchVolumeMute.Name = "switchVolumeMute";
            this.switchVolumeMute.OffText = "UnMute";
            this.switchVolumeMute.OnText = "Mute";
            this.switchVolumeMute.Size = new System.Drawing.Size(72, 22);
            this.switchVolumeMute.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.switchVolumeMute.TabIndex = 26;
            this.switchVolumeMute.Value = true;
            this.switchVolumeMute.ValueChanged += new System.EventHandler(this.switchButton1_ValueChanged);
            // 
            // knobVolume
            // 
            this.knobVolume.KnobStyle = DevComponents.Instrumentation.eKnobStyle.Style4;
            this.knobVolume.Location = new System.Drawing.Point(868, 27);
            this.knobVolume.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.knobVolume.Name = "knobVolume";
            this.knobVolume.ShowTickLabels = false;
            this.knobVolume.Size = new System.Drawing.Size(121, 120);
            this.knobVolume.TabIndex = 27;
            this.knobVolume.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.knobVolume.ValueChanged += new System.EventHandler<DevComponents.Instrumentation.ValueChangedEventArgs>(this.knobVolume_ValueChanged);
            // 
            // galleryContainer1
            // 
            // 
            // 
            // 
            this.galleryContainer1.BackgroundStyle.Class = "";
            this.galleryContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.galleryContainer1.EnableGalleryPopup = false;
            this.galleryContainer1.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.galleryContainer1.MinimumSize = new System.Drawing.Size(150, 200);
            this.galleryContainer1.MultiLine = false;
            this.galleryContainer1.Name = "galleryContainer1";
            this.galleryContainer1.PopupUsesStandardScrollbars = false;
            // 
            // btnAddSongToRequest
            // 
            this.btnAddSongToRequest.Location = new System.Drawing.Point(725, 83);
            this.btnAddSongToRequest.Name = "btnAddSongToRequest";
            this.btnAddSongToRequest.Size = new System.Drawing.Size(124, 23);
            this.btnAddSongToRequest.TabIndex = 30;
            this.btnAddSongToRequest.Text = "Add Song To Request";
            this.btnAddSongToRequest.UseVisualStyleBackColor = true;
            this.btnAddSongToRequest.Click += new System.EventHandler(this.btnAddSongToRequest_Click);
            // 
            // btnxRequestSong
            // 
            this.btnxRequestSong.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnxRequestSong.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnxRequestSong.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.btnxRequestSong.Location = new System.Drawing.Point(518, 182);
            this.btnxRequestSong.Name = "btnxRequestSong";
            this.btnxRequestSong.Size = new System.Drawing.Size(230, 70);
            this.btnxRequestSong.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnxRequestSong.TabIndex = 31;
            this.btnxRequestSong.Text = "Request Selected Song";
            this.btnxRequestSong.Click += new System.EventHandler(this.btnxRequestSong_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 520);
            this.Controls.Add(this.btnxRequestSong);
            this.Controls.Add(this.btnAddSongToRequest);
            this.Controls.Add(this.switchVolumeMute);
            this.Controls.Add(this.knobVolume);
            this.Controls.Add(this.buttonX1);
            this.Controls.Add(this.pbSongDuration);
            this.Controls.Add(this.starCurrentSongRating);
            this.Controls.Add(this.btnMusicPlay);
            this.Controls.Add(this.btnMusicPause);
            this.Controls.Add(this.btnMusicStop);
            this.Controls.Add(this.btnAddSongToPlaylist);
            this.Controls.Add(this.lblCurrentSongAlbum);
            this.Controls.Add(this.lblCurrentSongArtist);
            this.Controls.Add(this.lblCurrentSongName);
            this.Controls.Add(this.btnSkipToNextSong);
            this.Controls.Add(this.lblSongTimeDuration);
            this.Controls.Add(this.lblSongTimePlayed);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Party Music Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongs)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox lbGenres;
        private System.Windows.Forms.ListBox lbAlbums;
        private System.Windows.Forms.ListBox lbArtists;
        private System.Windows.Forms.DataGridView dgvSongs;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSongs_colTrack;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSongs_colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSongs_colDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSongs_colArtist;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSongs_colAlbum;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSongs_colGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSongs_colRating;
        private System.Windows.Forms.ListBox lboxCurrentPlaylist;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListBox lbRequestPlaylist;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Timer MusicMonitorTimer;
        private System.Windows.Forms.Label lblSongTimePlayed;
        private System.Windows.Forms.Label lblSongTimeDuration;
        private System.Windows.Forms.Button btnSkipToNextSong;
        private System.Windows.Forms.ToolStripMenuItem manageMusicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createPlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyPlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setDefaultPlaylistToolStripMenuItem;
        private System.Windows.Forms.Label lblCurrentSongName;
        private System.Windows.Forms.Label lblCurrentSongArtist;
        private System.Windows.Forms.Label lblCurrentSongAlbum;
        private System.Windows.Forms.Button btnAddSongToPlaylist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMusicStop;
        private System.Windows.Forms.Button btnMusicPause;
        private System.Windows.Forms.Button btnMusicPlay;
        private DevComponents.DotNetBar.Controls.RatingStar starCurrentSongRating;
        private DevComponents.DotNetBar.Controls.ProgressBarX pbSongDuration;
        private DevComponents.DotNetBar.ButtonX buttonX1;
        private DevComponents.DotNetBar.Controls.SwitchButton switchVolumeMute;
        private DevComponents.Instrumentation.KnobControl knobVolume;
        private System.Windows.Forms.ComboBox cbPlaylists;
        private DevComponents.DotNetBar.GalleryContainer galleryContainer1;
        private System.Windows.Forms.Button btnAddSongToRequest;
        private DevComponents.DotNetBar.ButtonX btnxRequestSong;
    }
}

