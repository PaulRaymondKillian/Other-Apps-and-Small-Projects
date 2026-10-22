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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageMusicToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addDirectoryToMusicDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFileToMusicDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageMusicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSongsToPlaylistsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setDefaultPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelRight = new System.Windows.Forms.Panel();
            this.gbRequestedSongs = new System.Windows.Forms.GroupBox();
            this.lbRequestPlaylist = new System.Windows.Forms.ListBox();
            this.gbPlaylistSongs = new System.Windows.Forms.GroupBox();
            this.lblPlaylist = new System.Windows.Forms.Label();
            this.cbPlaylists = new System.Windows.Forms.ComboBox();
            this.lboxCurrentPlaylist = new System.Windows.Forms.ListBox();
            this.PanelLeft = new System.Windows.Forms.Panel();
            this.PanelSongMisc = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.knobVolume = new DevComponents.Instrumentation.KnobControl();
            this.lblBasicHowToRequest = new DevComponents.DotNetBar.LabelX();
            this.gbChooseAlbum = new System.Windows.Forms.GroupBox();
            this.lbAlbums = new System.Windows.Forms.ListBox();
            this.gbChooseArtist = new System.Windows.Forms.GroupBox();
            this.lbArtists = new System.Windows.Forms.ListBox();
            this.gbChooseGenre = new System.Windows.Forms.GroupBox();
            this.lbGenres = new System.Windows.Forms.ListBox();
            this.gbCurrentPlayingSong = new System.Windows.Forms.GroupBox();
            this.lblCurrentSongName = new System.Windows.Forms.Label();
            this.lblSongTimePlayed = new System.Windows.Forms.Label();
            this.lblSongTimeDuration = new System.Windows.Forms.Label();
            this.lblCurrentSongArtist = new System.Windows.Forms.Label();
            this.lblCurrentSongAlbum = new System.Windows.Forms.Label();
            this.pbSongDuration = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.starCurrentSongRating = new DevComponents.DotNetBar.Controls.RatingStar();
            this.lblrefRequestYourSong = new DevComponents.DotNetBar.Controls.ReflectionLabel();
            this.dgvSongs = new System.Windows.Forms.DataGridView();
            this.dgvSongs_colTrack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSongs_colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSongs_colArtist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSongs_colAlbum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbChooseSong = new System.Windows.Forms.GroupBox();
            this.MusicMonitorTimer = new System.Windows.Forms.Timer(this.components);
            this.btnxSkipToNextSong = new DevComponents.DotNetBar.ButtonX();
            this.galleryContainer1 = new DevComponents.DotNetBar.GalleryContainer();
            this.btnxRequestSong = new DevComponents.DotNetBar.ButtonX();
            this.btnxPlayStop = new DevComponents.DotNetBar.ButtonX();
            this.btnxPause = new DevComponents.DotNetBar.ButtonX();
            this.btnxMute = new DevComponents.DotNetBar.ButtonX();
            this.PanelMiddle = new System.Windows.Forms.Panel();
            this.bubbleButton20 = new DevComponents.DotNetBar.BubbleButton();
            this.menuStrip1.SuspendLayout();
            this.PanelRight.SuspendLayout();
            this.gbRequestedSongs.SuspendLayout();
            this.gbPlaylistSongs.SuspendLayout();
            this.PanelLeft.SuspendLayout();
            this.PanelSongMisc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbChooseAlbum.SuspendLayout();
            this.gbChooseArtist.SuspendLayout();
            this.gbChooseGenre.SuspendLayout();
            this.gbCurrentPlayingSong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongs)).BeginInit();
            this.gbChooseSong.SuspendLayout();
            this.PanelMiddle.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.manageMusicToolStripMenuItem1,
            this.manageMusicToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1226, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // manageMusicToolStripMenuItem1
            // 
            this.manageMusicToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDirectoryToMusicDatabaseToolStripMenuItem,
            this.addFileToMusicDatabaseToolStripMenuItem});
            this.manageMusicToolStripMenuItem1.Name = "manageMusicToolStripMenuItem1";
            this.manageMusicToolStripMenuItem1.Size = new System.Drawing.Size(97, 20);
            this.manageMusicToolStripMenuItem1.Text = "Manage Music";
            // 
            // addDirectoryToMusicDatabaseToolStripMenuItem
            // 
            this.addDirectoryToMusicDatabaseToolStripMenuItem.Name = "addDirectoryToMusicDatabaseToolStripMenuItem";
            this.addDirectoryToMusicDatabaseToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.addDirectoryToMusicDatabaseToolStripMenuItem.Text = "Add &Directory to Music Database";
            this.addDirectoryToMusicDatabaseToolStripMenuItem.Click += new System.EventHandler(this.addDirectoryToMusicDatabaseToolStripMenuItem_Click);
            // 
            // addFileToMusicDatabaseToolStripMenuItem
            // 
            this.addFileToMusicDatabaseToolStripMenuItem.Name = "addFileToMusicDatabaseToolStripMenuItem";
            this.addFileToMusicDatabaseToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.addFileToMusicDatabaseToolStripMenuItem.Text = "Add &File to Music Database";
            this.addFileToMusicDatabaseToolStripMenuItem.Click += new System.EventHandler(this.addFileToMusicDatabaseToolStripMenuItem_Click);
            // 
            // manageMusicToolStripMenuItem
            // 
            this.manageMusicToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createPlaylistToolStripMenuItem,
            this.addSongsToPlaylistsToolStripMenuItem,
            this.modifyPlaylistToolStripMenuItem,
            this.setDefaultPlaylistToolStripMenuItem});
            this.manageMusicToolStripMenuItem.Name = "manageMusicToolStripMenuItem";
            this.manageMusicToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.manageMusicToolStripMenuItem.Text = "Manage Playlists";
            // 
            // createPlaylistToolStripMenuItem
            // 
            this.createPlaylistToolStripMenuItem.Name = "createPlaylistToolStripMenuItem";
            this.createPlaylistToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.createPlaylistToolStripMenuItem.Text = "&Create Playlist";
            this.createPlaylistToolStripMenuItem.Click += new System.EventHandler(this.createPlaylistToolStripMenuItem_Click);
            // 
            // addSongsToPlaylistsToolStripMenuItem
            // 
            this.addSongsToPlaylistsToolStripMenuItem.Name = "addSongsToPlaylistsToolStripMenuItem";
            this.addSongsToPlaylistsToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.addSongsToPlaylistsToolStripMenuItem.Text = "&Add Songs to Playlists";
            this.addSongsToPlaylistsToolStripMenuItem.Click += new System.EventHandler(this.addSongsToPlaylistsToolStripMenuItem_Click);
            // 
            // modifyPlaylistToolStripMenuItem
            // 
            this.modifyPlaylistToolStripMenuItem.Name = "modifyPlaylistToolStripMenuItem";
            this.modifyPlaylistToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.modifyPlaylistToolStripMenuItem.Text = "&Manage Playlists";
            this.modifyPlaylistToolStripMenuItem.Click += new System.EventHandler(this.modifyPlaylistToolStripMenuItem_Click);
            // 
            // setDefaultPlaylistToolStripMenuItem
            // 
            this.setDefaultPlaylistToolStripMenuItem.Name = "setDefaultPlaylistToolStripMenuItem";
            this.setDefaultPlaylistToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.setDefaultPlaylistToolStripMenuItem.Text = "&Set Default Playlist";
            this.setDefaultPlaylistToolStripMenuItem.Click += new System.EventHandler(this.setDefaultPlaylistToolStripMenuItem_Click);
            // 
            // PanelRight
            // 
            this.PanelRight.BackColor = System.Drawing.SystemColors.Control;
            this.PanelRight.Controls.Add(this.gbRequestedSongs);
            this.PanelRight.Controls.Add(this.gbPlaylistSongs);
            this.PanelRight.Location = new System.Drawing.Point(995, 27);
            this.PanelRight.Name = "PanelRight";
            this.PanelRight.Size = new System.Drawing.Size(221, 512);
            this.PanelRight.TabIndex = 2;
            this.PanelRight.Resize += new System.EventHandler(this.PanelRight_Resize);
            // 
            // gbRequestedSongs
            // 
            this.gbRequestedSongs.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbRequestedSongs.Controls.Add(this.lbRequestPlaylist);
            this.gbRequestedSongs.Location = new System.Drawing.Point(3, 284);
            this.gbRequestedSongs.Name = "gbRequestedSongs";
            this.gbRequestedSongs.Size = new System.Drawing.Size(215, 218);
            this.gbRequestedSongs.TabIndex = 8;
            this.gbRequestedSongs.TabStop = false;
            this.gbRequestedSongs.Text = "Requested Songs";
            // 
            // lbRequestPlaylist
            // 
            this.lbRequestPlaylist.FormattingEnabled = true;
            this.lbRequestPlaylist.IntegralHeight = false;
            this.lbRequestPlaylist.Location = new System.Drawing.Point(6, 19);
            this.lbRequestPlaylist.Name = "lbRequestPlaylist";
            this.lbRequestPlaylist.Size = new System.Drawing.Size(203, 186);
            this.lbRequestPlaylist.TabIndex = 0;
            // 
            // gbPlaylistSongs
            // 
            this.gbPlaylistSongs.Controls.Add(this.lblPlaylist);
            this.gbPlaylistSongs.Controls.Add(this.cbPlaylists);
            this.gbPlaylistSongs.Controls.Add(this.lboxCurrentPlaylist);
            this.gbPlaylistSongs.Location = new System.Drawing.Point(3, 3);
            this.gbPlaylistSongs.Name = "gbPlaylistSongs";
            this.gbPlaylistSongs.Size = new System.Drawing.Size(215, 275);
            this.gbPlaylistSongs.TabIndex = 7;
            this.gbPlaylistSongs.TabStop = false;
            this.gbPlaylistSongs.Text = "Playlist Songs";
            // 
            // lblPlaylist
            // 
            this.lblPlaylist.AutoSize = true;
            this.lblPlaylist.Location = new System.Drawing.Point(3, 21);
            this.lblPlaylist.Name = "lblPlaylist";
            this.lblPlaylist.Size = new System.Drawing.Size(42, 13);
            this.lblPlaylist.TabIndex = 18;
            this.lblPlaylist.Text = "Playlist:";
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
            this.lboxCurrentPlaylist.IntegralHeight = false;
            this.lboxCurrentPlaylist.Location = new System.Drawing.Point(6, 45);
            this.lboxCurrentPlaylist.Name = "lboxCurrentPlaylist";
            this.lboxCurrentPlaylist.Size = new System.Drawing.Size(203, 224);
            this.lboxCurrentPlaylist.TabIndex = 0;
            this.lboxCurrentPlaylist.SelectedIndexChanged += new System.EventHandler(this.lboxCurrentPlaylist_SelectedIndexChanged);
            this.lboxCurrentPlaylist.DoubleClick += new System.EventHandler(this.lboxCurrentPlaylist_DoubleClick);
            // 
            // PanelLeft
            // 
            this.PanelLeft.BackColor = System.Drawing.SystemColors.Control;
            this.PanelLeft.Controls.Add(this.PanelSongMisc);
            this.PanelLeft.Controls.Add(this.lblBasicHowToRequest);
            this.PanelLeft.Controls.Add(this.gbChooseAlbum);
            this.PanelLeft.Controls.Add(this.gbChooseArtist);
            this.PanelLeft.Controls.Add(this.gbChooseGenre);
            this.PanelLeft.Controls.Add(this.gbCurrentPlayingSong);
            this.PanelLeft.Controls.Add(this.lblrefRequestYourSong);
            this.PanelLeft.Location = new System.Drawing.Point(12, 27);
            this.PanelLeft.Name = "PanelLeft";
            this.PanelLeft.Size = new System.Drawing.Size(483, 512);
            this.PanelLeft.TabIndex = 2;
            this.PanelLeft.Resize += new System.EventHandler(this.PanelLeft_Resize);
            // 
            // PanelSongMisc
            // 
            this.PanelSongMisc.Controls.Add(this.pictureBox1);
            this.PanelSongMisc.Controls.Add(this.knobVolume);
            this.PanelSongMisc.Location = new System.Drawing.Point(287, 10);
            this.PanelSongMisc.Name = "PanelSongMisc";
            this.PanelSongMisc.Size = new System.Drawing.Size(188, 125);
            this.PanelSongMisc.TabIndex = 35;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 62);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // knobVolume
            // 
            this.knobVolume.KnobStyle = DevComponents.Instrumentation.eKnobStyle.Style4;
            this.knobVolume.Location = new System.Drawing.Point(31, 0);
            this.knobVolume.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.knobVolume.Name = "knobVolume";
            this.knobVolume.ShowTickLabels = false;
            this.knobVolume.Size = new System.Drawing.Size(131, 133);
            this.knobVolume.TabIndex = 27;
            this.knobVolume.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.knobVolume.ValueChanged += new System.EventHandler<DevComponents.Instrumentation.ValueChangedEventArgs>(this.knobVolume_ValueChanged);
            // 
            // lblBasicHowToRequest
            // 
            this.lblBasicHowToRequest.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblBasicHowToRequest.BackgroundStyle.Class = "";
            this.lblBasicHowToRequest.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblBasicHowToRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasicHowToRequest.ForeColor = System.Drawing.Color.Red;
            this.lblBasicHowToRequest.Location = new System.Drawing.Point(38, 172);
            this.lblBasicHowToRequest.Name = "lblBasicHowToRequest";
            this.lblBasicHowToRequest.Size = new System.Drawing.Size(396, 43);
            this.lblBasicHowToRequest.TabIndex = 34;
            this.lblBasicHowToRequest.Text = "To request a song, filter the songs by genre, artist, and album. Then select your" +
                " song and hit request!";
            this.lblBasicHowToRequest.TextAlignment = System.Drawing.StringAlignment.Center;
            this.lblBasicHowToRequest.WordWrap = true;
            // 
            // gbChooseAlbum
            // 
            this.gbChooseAlbum.BackColor = System.Drawing.SystemColors.Control;
            this.gbChooseAlbum.Controls.Add(this.lbAlbums);
            this.gbChooseAlbum.Location = new System.Drawing.Point(281, 221);
            this.gbChooseAlbum.Name = "gbChooseAlbum";
            this.gbChooseAlbum.Size = new System.Drawing.Size(200, 268);
            this.gbChooseAlbum.TabIndex = 6;
            this.gbChooseAlbum.TabStop = false;
            this.gbChooseAlbum.Text = "Choose Album";
            // 
            // lbAlbums
            // 
            this.lbAlbums.FormattingEnabled = true;
            this.lbAlbums.IntegralHeight = false;
            this.lbAlbums.Location = new System.Drawing.Point(6, 18);
            this.lbAlbums.Name = "lbAlbums";
            this.lbAlbums.Size = new System.Drawing.Size(188, 238);
            this.lbAlbums.TabIndex = 3;
            this.lbAlbums.SelectedIndexChanged += new System.EventHandler(this.lbAlbums_SelectedIndexChanged);
            // 
            // gbChooseArtist
            // 
            this.gbChooseArtist.BackColor = System.Drawing.SystemColors.Control;
            this.gbChooseArtist.Controls.Add(this.lbArtists);
            this.gbChooseArtist.Location = new System.Drawing.Point(131, 221);
            this.gbChooseArtist.Name = "gbChooseArtist";
            this.gbChooseArtist.Size = new System.Drawing.Size(150, 268);
            this.gbChooseArtist.TabIndex = 5;
            this.gbChooseArtist.TabStop = false;
            this.gbChooseArtist.Text = "Choose Artist";
            // 
            // lbArtists
            // 
            this.lbArtists.FormattingEnabled = true;
            this.lbArtists.IntegralHeight = false;
            this.lbArtists.Location = new System.Drawing.Point(6, 19);
            this.lbArtists.Name = "lbArtists";
            this.lbArtists.Size = new System.Drawing.Size(138, 238);
            this.lbArtists.TabIndex = 2;
            this.lbArtists.SelectedIndexChanged += new System.EventHandler(this.lbArtists_SelectedIndexChanged);
            // 
            // gbChooseGenre
            // 
            this.gbChooseGenre.BackColor = System.Drawing.SystemColors.Control;
            this.gbChooseGenre.Controls.Add(this.lbGenres);
            this.gbChooseGenre.Location = new System.Drawing.Point(6, 221);
            this.gbChooseGenre.Name = "gbChooseGenre";
            this.gbChooseGenre.Size = new System.Drawing.Size(125, 268);
            this.gbChooseGenre.TabIndex = 4;
            this.gbChooseGenre.TabStop = false;
            this.gbChooseGenre.Text = "Choose Genre";
            // 
            // lbGenres
            // 
            this.lbGenres.FormattingEnabled = true;
            this.lbGenres.IntegralHeight = false;
            this.lbGenres.Location = new System.Drawing.Point(6, 19);
            this.lbGenres.Name = "lbGenres";
            this.lbGenres.Size = new System.Drawing.Size(113, 238);
            this.lbGenres.TabIndex = 1;
            this.lbGenres.SelectedIndexChanged += new System.EventHandler(this.lbGenres_SelectedIndexChanged);
            // 
            // gbCurrentPlayingSong
            // 
            this.gbCurrentPlayingSong.Controls.Add(this.lblCurrentSongName);
            this.gbCurrentPlayingSong.Controls.Add(this.lblSongTimePlayed);
            this.gbCurrentPlayingSong.Controls.Add(this.lblSongTimeDuration);
            this.gbCurrentPlayingSong.Controls.Add(this.lblCurrentSongArtist);
            this.gbCurrentPlayingSong.Controls.Add(this.lblCurrentSongAlbum);
            this.gbCurrentPlayingSong.Controls.Add(this.pbSongDuration);
            this.gbCurrentPlayingSong.Controls.Add(this.starCurrentSongRating);
            this.gbCurrentPlayingSong.Location = new System.Drawing.Point(3, 3);
            this.gbCurrentPlayingSong.Name = "gbCurrentPlayingSong";
            this.gbCurrentPlayingSong.Size = new System.Drawing.Size(278, 132);
            this.gbCurrentPlayingSong.TabIndex = 33;
            this.gbCurrentPlayingSong.TabStop = false;
            this.gbCurrentPlayingSong.Text = "Current Playing Song";
            // 
            // lblCurrentSongName
            // 
            this.lblCurrentSongName.AutoSize = true;
            this.lblCurrentSongName.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentSongName.Location = new System.Drawing.Point(6, 17);
            this.lblCurrentSongName.Name = "lblCurrentSongName";
            this.lblCurrentSongName.Size = new System.Drawing.Size(181, 18);
            this.lblCurrentSongName.TabIndex = 10;
            this.lblCurrentSongName.Text = "Current Song Name";
            // 
            // lblSongTimePlayed
            // 
            this.lblSongTimePlayed.AutoSize = true;
            this.lblSongTimePlayed.Location = new System.Drawing.Point(6, 79);
            this.lblSongTimePlayed.Name = "lblSongTimePlayed";
            this.lblSongTimePlayed.Size = new System.Drawing.Size(34, 13);
            this.lblSongTimePlayed.TabIndex = 7;
            this.lblSongTimePlayed.Text = "00:00";
            // 
            // lblSongTimeDuration
            // 
            this.lblSongTimeDuration.AutoSize = true;
            this.lblSongTimeDuration.Location = new System.Drawing.Point(238, 79);
            this.lblSongTimeDuration.Name = "lblSongTimeDuration";
            this.lblSongTimeDuration.Size = new System.Drawing.Size(34, 13);
            this.lblSongTimeDuration.TabIndex = 8;
            this.lblSongTimeDuration.Text = "00:00";
            // 
            // lblCurrentSongArtist
            // 
            this.lblCurrentSongArtist.AutoSize = true;
            this.lblCurrentSongArtist.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblCurrentSongArtist.ForeColor = System.Drawing.Color.Black;
            this.lblCurrentSongArtist.Location = new System.Drawing.Point(6, 36);
            this.lblCurrentSongArtist.Name = "lblCurrentSongArtist";
            this.lblCurrentSongArtist.Size = new System.Drawing.Size(177, 18);
            this.lblCurrentSongArtist.TabIndex = 12;
            this.lblCurrentSongArtist.Text = "Current Song Artist";
            // 
            // lblCurrentSongAlbum
            // 
            this.lblCurrentSongAlbum.AutoSize = true;
            this.lblCurrentSongAlbum.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.lblCurrentSongAlbum.Location = new System.Drawing.Point(6, 54);
            this.lblCurrentSongAlbum.Name = "lblCurrentSongAlbum";
            this.lblCurrentSongAlbum.Size = new System.Drawing.Size(184, 18);
            this.lblCurrentSongAlbum.TabIndex = 14;
            this.lblCurrentSongAlbum.Text = "Current Song Album";
            // 
            // pbSongDuration
            // 
            // 
            // 
            // 
            this.pbSongDuration.BackgroundStyle.Class = "";
            this.pbSongDuration.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.pbSongDuration.Location = new System.Drawing.Point(7, 95);
            this.pbSongDuration.Name = "pbSongDuration";
            this.pbSongDuration.Size = new System.Drawing.Size(265, 23);
            this.pbSongDuration.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
            this.pbSongDuration.TabIndex = 21;
            this.pbSongDuration.Text = "00:00";
            this.pbSongDuration.TextVisible = true;
            this.pbSongDuration.Click += new System.EventHandler(this.pbSongDuration_Click);
            // 
            // starCurrentSongRating
            // 
            // 
            // 
            // 
            this.starCurrentSongRating.BackgroundStyle.Class = "";
            this.starCurrentSongRating.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.starCurrentSongRating.Location = new System.Drawing.Point(105, 75);
            this.starCurrentSongRating.Name = "starCurrentSongRating";
            this.starCurrentSongRating.Size = new System.Drawing.Size(68, 23);
            this.starCurrentSongRating.TabIndex = 20;
            this.starCurrentSongRating.TextColor = System.Drawing.Color.Empty;
            this.starCurrentSongRating.RatingChanged += new System.EventHandler(this.starCurrentSongRating_RatingChanged);
            this.starCurrentSongRating.Click += new System.EventHandler(this.starCurrentSongRating_Click);
            // 
            // lblrefRequestYourSong
            // 
            // 
            // 
            // 
            this.lblrefRequestYourSong.BackgroundStyle.Class = "";
            this.lblrefRequestYourSong.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblrefRequestYourSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrefRequestYourSong.Location = new System.Drawing.Point(108, 134);
            this.lblrefRequestYourSong.Name = "lblrefRequestYourSong";
            this.lblrefRequestYourSong.Size = new System.Drawing.Size(263, 61);
            this.lblrefRequestYourSong.TabIndex = 32;
            this.lblrefRequestYourSong.Text = "<b><font size=\"+8\"><i>Request</i><font color=\"#B02B2C\"> Your Song!</font></font><" +
                "/b>";
            // 
            // dgvSongs
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DimGray;
            this.dgvSongs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSongs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSongs.BackgroundColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSongs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSongs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSongs_colTrack,
            this.dgvSongs_colName,
            this.dgvSongs_colArtist,
            this.dgvSongs_colAlbum});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSongs.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvSongs.Location = new System.Drawing.Point(6, 21);
            this.dgvSongs.MultiSelect = false;
            this.dgvSongs.Name = "dgvSongs";
            this.dgvSongs.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSongs.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvSongs.RowHeadersVisible = false;
            this.dgvSongs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSongs.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvSongs.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSongs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSongs.Size = new System.Drawing.Size(465, 370);
            this.dgvSongs.TabIndex = 0;
            this.dgvSongs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSongs_CellContentClick);
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
            // gbChooseSong
            // 
            this.gbChooseSong.Controls.Add(this.dgvSongs);
            this.gbChooseSong.Location = new System.Drawing.Point(2, 113);
            this.gbChooseSong.Name = "gbChooseSong";
            this.gbChooseSong.Size = new System.Drawing.Size(480, 400);
            this.gbChooseSong.TabIndex = 6;
            this.gbChooseSong.TabStop = false;
            this.gbChooseSong.Text = "Choose Song";
            // 
            // MusicMonitorTimer
            // 
            this.MusicMonitorTimer.Interval = 500;
            this.MusicMonitorTimer.Tick += new System.EventHandler(this.MusicMonitorTimer_Tick);
            // 
            // btnxSkipToNextSong
            // 
            this.btnxSkipToNextSong.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnxSkipToNextSong.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnxSkipToNextSong.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.btnxSkipToNextSong.Location = new System.Drawing.Point(243, 10);
            this.btnxSkipToNextSong.Name = "btnxSkipToNextSong";
            this.btnxSkipToNextSong.Size = new System.Drawing.Size(230, 70);
            this.btnxSkipToNextSong.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnxSkipToNextSong.TabIndex = 23;
            this.btnxSkipToNextSong.Text = "Skip To Next Song";
            this.btnxSkipToNextSong.Click += new System.EventHandler(this.buttonX1_Click);
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
            // btnxRequestSong
            // 
            this.btnxRequestSong.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnxRequestSong.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnxRequestSong.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.btnxRequestSong.Location = new System.Drawing.Point(8, 10);
            this.btnxRequestSong.Name = "btnxRequestSong";
            this.btnxRequestSong.Size = new System.Drawing.Size(230, 70);
            this.btnxRequestSong.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnxRequestSong.TabIndex = 31;
            this.btnxRequestSong.Text = "Request Selected Song";
            this.btnxRequestSong.Click += new System.EventHandler(this.btnxRequestSong_Click);
            // 
            // btnxPlayStop
            // 
            this.btnxPlayStop.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnxPlayStop.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnxPlayStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnxPlayStop.Location = new System.Drawing.Point(8, 86);
            this.btnxPlayStop.Name = "btnxPlayStop";
            this.btnxPlayStop.Size = new System.Drawing.Size(151, 21);
            this.btnxPlayStop.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnxPlayStop.TabIndex = 34;
            this.btnxPlayStop.Text = "Stop";
            this.btnxPlayStop.Click += new System.EventHandler(this.btnxPlayStop_Click);
            // 
            // btnxPause
            // 
            this.btnxPause.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnxPause.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnxPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnxPause.Location = new System.Drawing.Point(165, 86);
            this.btnxPause.Name = "btnxPause";
            this.btnxPause.Size = new System.Drawing.Size(154, 21);
            this.btnxPause.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnxPause.TabIndex = 35;
            this.btnxPause.Text = "Pause";
            this.btnxPause.Click += new System.EventHandler(this.btnxPause_Click);
            // 
            // btnxMute
            // 
            this.btnxMute.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnxMute.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnxMute.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnxMute.Location = new System.Drawing.Point(325, 86);
            this.btnxMute.Name = "btnxMute";
            this.btnxMute.Size = new System.Drawing.Size(148, 21);
            this.btnxMute.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnxMute.TabIndex = 36;
            this.btnxMute.Text = "Mute";
            this.btnxMute.Click += new System.EventHandler(this.btnxMute_Click);
            // 
            // PanelMiddle
            // 
            this.PanelMiddle.BackColor = System.Drawing.SystemColors.Control;
            this.PanelMiddle.Controls.Add(this.gbChooseSong);
            this.PanelMiddle.Controls.Add(this.btnxSkipToNextSong);
            this.PanelMiddle.Controls.Add(this.btnxMute);
            this.PanelMiddle.Controls.Add(this.btnxRequestSong);
            this.PanelMiddle.Controls.Add(this.btnxPause);
            this.PanelMiddle.Controls.Add(this.btnxPlayStop);
            this.PanelMiddle.Location = new System.Drawing.Point(498, 27);
            this.PanelMiddle.Name = "PanelMiddle";
            this.PanelMiddle.Size = new System.Drawing.Size(485, 512);
            this.PanelMiddle.TabIndex = 37;
            this.PanelMiddle.Resize += new System.EventHandler(this.PanelMiddle_Resize);
            // 
            // bubbleButton20
            // 
            this.bubbleButton20.Image = ((System.Drawing.Image)(resources.GetObject("bubbleButton20.Image")));
            this.bubbleButton20.ImageLarge = ((System.Drawing.Image)(resources.GetObject("bubbleButton20.ImageLarge")));
            this.bubbleButton20.Name = "bubbleButton20";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 550);
            this.Controls.Add(this.PanelMiddle);
            this.Controls.Add(this.PanelLeft);
            this.Controls.Add(this.PanelRight);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(650, 400);
            this.Name = "MainForm";
            this.Text = "Party Music Manager";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.PanelRight.ResumeLayout(false);
            this.gbRequestedSongs.ResumeLayout(false);
            this.gbPlaylistSongs.ResumeLayout(false);
            this.gbPlaylistSongs.PerformLayout();
            this.PanelLeft.ResumeLayout(false);
            this.PanelSongMisc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbChooseAlbum.ResumeLayout(false);
            this.gbChooseArtist.ResumeLayout(false);
            this.gbChooseGenre.ResumeLayout(false);
            this.gbCurrentPlayingSong.ResumeLayout(false);
            this.gbCurrentPlayingSong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSongs)).EndInit();
            this.gbChooseSong.ResumeLayout(false);
            this.PanelMiddle.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Panel PanelRight;
        private System.Windows.Forms.Panel PanelLeft;
        private System.Windows.Forms.ListBox lbGenres;
        private System.Windows.Forms.ListBox lbAlbums;
        private System.Windows.Forms.ListBox lbArtists;
        private System.Windows.Forms.DataGridView dgvSongs;
        private System.Windows.Forms.GroupBox gbChooseAlbum;
        private System.Windows.Forms.GroupBox gbChooseArtist;
        private System.Windows.Forms.GroupBox gbChooseGenre;
        private System.Windows.Forms.GroupBox gbChooseSong;
        private System.Windows.Forms.ListBox lboxCurrentPlaylist;
        private System.Windows.Forms.GroupBox gbRequestedSongs;
        private System.Windows.Forms.ListBox lbRequestPlaylist;
        private System.Windows.Forms.GroupBox gbPlaylistSongs;
        private System.Windows.Forms.Timer MusicMonitorTimer;
        private System.Windows.Forms.Label lblSongTimePlayed;
        private System.Windows.Forms.Label lblSongTimeDuration;
        private System.Windows.Forms.ToolStripMenuItem manageMusicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createPlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifyPlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setDefaultPlaylistToolStripMenuItem;
        private System.Windows.Forms.Label lblCurrentSongName;
        private System.Windows.Forms.Label lblCurrentSongArtist;
        private System.Windows.Forms.Label lblCurrentSongAlbum;
        private System.Windows.Forms.Label lblPlaylist;
        private DevComponents.DotNetBar.Controls.RatingStar starCurrentSongRating;
        private DevComponents.DotNetBar.Controls.ProgressBarX pbSongDuration;
        private DevComponents.DotNetBar.ButtonX btnxSkipToNextSong;
        private DevComponents.Instrumentation.KnobControl knobVolume;
        private System.Windows.Forms.ComboBox cbPlaylists;
        private DevComponents.DotNetBar.GalleryContainer galleryContainer1;
        private DevComponents.DotNetBar.ButtonX btnxRequestSong;
        private DevComponents.DotNetBar.Controls.ReflectionLabel lblrefRequestYourSong;
        private System.Windows.Forms.GroupBox gbCurrentPlayingSong;
        private DevComponents.DotNetBar.ButtonX btnxPlayStop;
        private DevComponents.DotNetBar.ButtonX btnxPause;
        private DevComponents.DotNetBar.ButtonX btnxMute;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSongs_colTrack;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSongs_colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSongs_colArtist;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSongs_colAlbum;
        private System.Windows.Forms.ToolStripMenuItem addSongsToPlaylistsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageMusicToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addDirectoryToMusicDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFileToMusicDatabaseToolStripMenuItem;
        private System.Windows.Forms.Panel PanelMiddle;
        private DevComponents.DotNetBar.BubbleButton bubbleButton20;
        private DevComponents.DotNetBar.LabelX lblBasicHowToRequest;
        private System.Windows.Forms.Panel PanelSongMisc;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

