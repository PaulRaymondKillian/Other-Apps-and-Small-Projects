using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace PartyMusicManager
{
    public partial class MainForm : Form
    {
        private PartyMusicManagerLib _PartyMusicManagerLib;

        public MainForm()
        {
            String ConnString = ConfigurationManager.ConnectionStrings["MusicDBConnString"].ConnectionString;
            _PartyMusicManagerLib = new PartyMusicManagerLib(ConnString);

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResizeControls();
            InitPartyMusicManagerControls();
        }

        private void lbGenres_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbArtists.SelectedIndex = -1;
            lbAlbums.SelectedIndex = -1;
            //lbSongs.SelectedIndex = -1;
            dgvSongs.ClearSelection();
            lbAlbums.Items.Clear();
            //lbSongs.Items.Clear();
            dgvSongs.Rows.Clear();
            _PartyMusicManagerLib.SetControlArtists(lbArtists, lbGenres);
        }

        private void lbArtists_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbAlbums.SelectedIndex = -1;
            //lbSongs.SelectedIndex = -1;
            dgvSongs.ClearSelection();
            _PartyMusicManagerLib.SetControlAlbums(lbAlbums, lbArtists);
            _PartyMusicManagerLib.SetControlSongs(dgvSongs, lbAlbums, lbArtists);
        }

        private void lbAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lbSongs.SelectedIndex = -1;
            dgvSongs.ClearSelection();
            _PartyMusicManagerLib.SetControlSongs(dgvSongs, lbAlbums, lbArtists);
        }

        private void dgvSongs_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int DoubleClickedIndex = dgvSongs.SelectedRows[0].Index;
            _PartyMusicManagerLib.AddToRequestPlaylist(DoubleClickedIndex);
            _PartyMusicManagerLib.RefreshRequestPlaylistListBox(lbRequestPlaylist);
        }

        private void MusicMonitorTimer_Tick(object sender, EventArgs e)
        {
            MusicMonitorTimer.Stop();
            _PartyMusicManagerLib.MonitorMusicManagerStatus();
            _PartyMusicManagerLib.RefreshRequestPlaylistListBox(lbRequestPlaylist);
            lblSongTimePlayed.Text = _PartyMusicManagerLib.PlayingSongTimePlayed();
            pbSongDuration.Text = _PartyMusicManagerLib.PlayingSongTimePercent();
            lblSongTimeDuration.Text = _PartyMusicManagerLib.PlayingSongTimeDuration();
            lblCurrentSongName.Text = _PartyMusicManagerLib.PlayingSongName();
            lblCurrentSongArtist.Text = _PartyMusicManagerLib.PlayingSongArtist();
            lblCurrentSongAlbum.Text = _PartyMusicManagerLib.PlayingSongAlbum();
            if (lboxCurrentPlaylist.Items.Count > 0)
                lboxCurrentPlaylist.SelectedIndex = _PartyMusicManagerLib.GetCurrentPlaylistSongIndex();
            if (_PartyMusicManagerLib.PlayingPlaylistSong() == true)
            {
                lboxCurrentPlaylist.Enabled = true;
                lboxCurrentPlaylist.BackColor = Color.FromArgb(255, 255, 128);
                lbRequestPlaylist.BackColor = Color.White;
            }
            else if (_PartyMusicManagerLib.PlayingRequestSong() == true)
            {
                lboxCurrentPlaylist.Enabled = false;
                lboxCurrentPlaylist.BackColor = Color.White;
                lbRequestPlaylist.BackColor = Color.FromArgb(255, 255, 128);
                lbRequestPlaylist.SelectedIndex = 0;
            }
            lboxCurrentPlaylist.Refresh();
            lbRequestPlaylist.Refresh();
            pbSongDuration.Value = Convert.ToInt32(100 * (_PartyMusicManagerLib.GetTotalPlayedSeconds() / _PartyMusicManagerLib.GetTotalCurrentSongSeconds()));
            starCurrentSongRating.Rating = _PartyMusicManagerLib.GetCurrentSongStarRating(5);
            MusicMonitorTimer.Start();
        }

        private void modifyPlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManagePlaylists newManagePlaylistsForm = new frmManagePlaylists(_PartyMusicManagerLib);
            //frmManagePlaylists newManagePlaylistsForm = new frmManagePlaylists();
            newManagePlaylistsForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cbPlaylists.Text != "")
            {
                _PartyMusicManagerLib.AddSongToPlaylist(cbPlaylists.Text, dgvSongs.SelectedRows[0].Index);
                _PartyMusicManagerLib.SetControlCurrentPlaylistListBox(cbPlaylists.Text, lboxCurrentPlaylist);
             }
        }

        private void cbPlaylists_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lboxCurrentPlaylist_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSkipToNextSong_Click(object sender, EventArgs e)
        {
            _PartyMusicManagerLib.SkipToNextSong();
        }

        private void lboxCurrentPlaylist_DoubleClick(object sender, EventArgs e)
        {
            _PartyMusicManagerLib.PlaySongFromPlaylistIndex(lboxCurrentPlaylist.SelectedIndex);
        }

        private void btnMusicPause_Click(object sender, EventArgs e)
        {
            _PartyMusicManagerLib.PauseMusic();
        }

        private void btnMusicStop_Click(object sender, EventArgs e)
        {
            _PartyMusicManagerLib.StopMusic();
        }

        private void btnMusicPlay_Click(object sender, EventArgs e)
        {
            _PartyMusicManagerLib.PlayMusic();
        }

        private void cbPlaylists_DropDown(object sender, EventArgs e)
        {
            _PartyMusicManagerLib.SetControlPlaylists(cbPlaylists);
        }

        private void cbPlaylists_DropDownClosed(object sender, EventArgs e)
        {
            _PartyMusicManagerLib.SetControlCurrentPlaylistListBox(cbPlaylists.Text, lboxCurrentPlaylist);
        }

        private void cbPlaylists_TextChanged(object sender, EventArgs e)
        {
            _PartyMusicManagerLib.SetControlCurrentPlaylistListBox(cbPlaylists.Text, lboxCurrentPlaylist);
        }

        private void pbSongDuration_Click(object sender, EventArgs e)
        {
            int Width = pbSongDuration.Width;
            int Start = pbSongDuration.Left + this.Left; ;
            int MouseX = System.Windows.Forms.Cursor.Position.X;
            int Distance = MouseX - Start;
            double Percent = Convert.ToDouble(Distance) / Convert.ToDouble(Width);
            //int Value = Convert.ToInt32(100 * Percent);
            pbSongDuration.Value = Convert.ToInt32(100 * Percent); ;

            _PartyMusicManagerLib.SetCurrentSongPosition(Percent);
        }

        private void knobVolume_ValueChanged(object sender, DevComponents.Instrumentation.ValueChangedEventArgs e)
        {
            _PartyMusicManagerLib.SetVolume(Convert.ToInt32(knobVolume.Value));
        }

        private void starCurrentSongRating_RatingChanged(object sender, EventArgs e)
        {
            
        }

        private void starCurrentSongRating_Click(object sender, EventArgs e)
        {
            _PartyMusicManagerLib.UpdateCurrentSongRating(starCurrentSongRating.Rating);
        }

        private void switchButton1_ValueChanged(object sender, EventArgs e)
        {
            if (switchVolumeMute.Value == true)
                _PartyMusicManagerLib.UnMuteMusic();
            else
                _PartyMusicManagerLib.MuteMusic();
        }

        private void stepIndicator1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAddSongToRequest_Click(object sender, EventArgs e)
        {
            int SelectedIndex = dgvSongs.SelectedRows[0].Index;
            _PartyMusicManagerLib.AddToRequestPlaylist(SelectedIndex);
            _PartyMusicManagerLib.RefreshRequestPlaylistListBox(lbRequestPlaylist);
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            _PartyMusicManagerLib.SkipToNextSong();
        }

        private void btnxRequestSong_Click(object sender, EventArgs e)
        {
            if (dgvSongs.SelectedRows.Count > 0)
            {
                int SelectedIndex = dgvSongs.SelectedRows[0].Index;
                _PartyMusicManagerLib.AddToRequestPlaylist(SelectedIndex);
                _PartyMusicManagerLib.RefreshRequestPlaylistListBox(lbRequestPlaylist);
            }
        }



 

    }
}
