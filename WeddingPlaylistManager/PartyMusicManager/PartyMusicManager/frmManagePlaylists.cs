using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PartyMusicManager
{
    public partial class frmManagePlaylists : Form
    {
        private PartyMusicManagerLib _PartyMusicManagerLib;

        public frmManagePlaylists(PartyMusicManagerLib pPartyMusicManagerLib)
        {
            InitializeComponent();
            _PartyMusicManagerLib = pPartyMusicManagerLib;
        }

        private void btnCreatePlaylist_Click(object sender, EventArgs e)
        {
            if (txtCreatePlaylist.Text != "")
                _PartyMusicManagerLib.CreatePlaylist(txtCreatePlaylist.Text);

            
            _PartyMusicManagerLib.SetControlPlaylists(cbPlaylists);
            _PartyMusicManagerLib.SetControlPlaylists(cbPlaylists2);
            _PartyMusicManagerLib.SetPlaylistDGV(cbPlaylists.Text, dgvPlaylistSongs);

            cbPlaylists.Text = txtCreatePlaylist.Text;
            SetManagePlaylistsForm_ModifyPlaylist();
            cbPlaylists2.Text = txtCreatePlaylist.Text;
        }

        private void frmManagePlaylists_Load(object sender, EventArgs e)
        {
            _PartyMusicManagerLib.SetControlPlaylists(cbPlaylists);
            _PartyMusicManagerLib.SetControlPlaylists(cbPlaylists2);
            _PartyMusicManagerLib.SetPlaylistDGV(cbPlaylists.Text, dgvPlaylistSongs);
            _PartyMusicManagerLib.SetControlGenres(lbGenres);
            _PartyMusicManagerLib.SetControlArtists(lbArtists, lbGenres);
        }

        private void btnSetDefaultPlaylist_Click(object sender, EventArgs e)
        {
            if (cbPlaylists.Text != "")
                try
                {
                    _PartyMusicManagerLib.SetDefaultPlaylist(cbPlaylists.Text);
                }
                catch (MusicLibPlaylistDoesNotExistException)
                { MessageBox.Show("Cannot set default playlist. The playlist '" + cbPlaylists.Text + "' does not exist."); }
                catch (Exception ex)
                { MessageBox.Show("Unable to set default playlist - Error: " + ex.Message); }
            else
                MessageBox.Show("No playlist name entered.");
        }

        private void rdoCreatePlaylist_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCreatePlaylist.Checked)
            {
                gbCreatePlaylist.Enabled = true;
                gbModifyPlaylist.Enabled = false;
            }
        }

        private void rdoModifyPlaylist_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoModifyPlaylist.Checked)
            {
                gbCreatePlaylist.Enabled = false;
                gbModifyPlaylist.Enabled = true;
            }
        }

        private void txtMoveSongToOrder_Leave(object sender, EventArgs e)
        {
            //Check if the entered value is a number (integer specifically), if not, empty string
            int temp;
            bool IsNumeric = int.TryParse(txtMoveSongToOrder.Text, out temp);
            if (!IsNumeric || temp < 1)
                txtMoveSongToOrder.Text = "";
        }

        private void cbPlaylists_SelectedIndexChanged(object sender, EventArgs e)
        {
            //_PartyMusicManagerLib.SetControlPlaylists(cbPlaylists);
            _PartyMusicManagerLib.SetPlaylistDGV(cbPlaylists.Text, dgvPlaylistSongs);
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

        private void btnxAddSongToPlaylist_Click(object sender, EventArgs e)
        {
            if (cbPlaylists.Text != "")
            {
                _PartyMusicManagerLib.AddSongToPlaylist(cbPlaylists.Text, dgvSongs.SelectedRows[0].Index);
                _PartyMusicManagerLib.SetPlaylistDGV(cbPlaylists2.Text, dgvPlaylistSongs2);
                cbPlaylists.Text = cbPlaylists2.Text;
                _PartyMusicManagerLib.SetPlaylistDGV(cbPlaylists.Text, dgvPlaylistSongs);
            }
        }

        private void cbPlaylists2_SelectedIndexChanged(object sender, EventArgs e)
        {
            _PartyMusicManagerLib.SetPlaylistDGV(cbPlaylists2.Text, dgvPlaylistSongs2);
        }

        private void btnDeletePlaylist_Click(object sender, EventArgs e)
        {
            //Remove playlist

            //refresh controls
            _PartyMusicManagerLib.SetControlPlaylists(cbPlaylists);
            _PartyMusicManagerLib.SetControlPlaylists(cbPlaylists2);
        }

        private void dgvSongs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cbPlaylists.Text != "")
            {
                _PartyMusicManagerLib.AddSongToPlaylist(cbPlaylists.Text, dgvSongs.SelectedRows[0].Index);
                _PartyMusicManagerLib.SetPlaylistDGV(cbPlaylists2.Text, dgvPlaylistSongs2);
            }
        }

        public void SetManagePlaylistsForm_CreateNewPlaylist()
        {
            SetPlaylistTab(0);
            SetCreatePlaylistRadioButtonChecked();
        }

        public void SetManagePlaylistForm_ManagePlaylists()
        {
            SetPlaylistTab(0);
            SetModifyPlaylistRadioButtonChecked();
        }

        public void SetManagePlaylistsForm_ModifyPlaylist()
        {
            SetPlaylistTab(1);
            SetModifyPlaylistRadioButtonChecked();
        }

        private void SetPlaylistTab(int pTabIndex)
        {
            tabManagePlaylists.SelectedTabIndex = pTabIndex;
        }

        private void SetCreatePlaylistRadioButtonChecked()
        {
            rdoCreatePlaylist.Checked = true;
        }

        private void SetModifyPlaylistRadioButtonChecked()
        {
            rdoModifyPlaylist.Checked = true;
        }

        private void btnxSetDefaultPlaylist_Click(object sender, EventArgs e)
        {
            if (cbPlaylists.Text != "")
                try
                {
                    _PartyMusicManagerLib.SetDefaultPlaylist(cbPlaylists.Text);
                }
                catch (MusicLibPlaylistDoesNotExistException)
                { MessageBox.Show("Cannot set default playlist. The playlist '" + cbPlaylists.Text + "' does not exist."); }
                catch (Exception ex)
                { MessageBox.Show("Unable to set default playlist - Error: " + ex.Message); }
            else
                MessageBox.Show("No playlist name entered.");
        }

        private void btnxDeletePlaylist_Click(object sender, EventArgs e)
        {
            //Remove playlist
            _PartyMusicManagerLib.DeletePlaylist(cbPlaylists.Text);

            //refresh controls
            _PartyMusicManagerLib.SetControlPlaylists(cbPlaylists);
            _PartyMusicManagerLib.SetControlPlaylists(cbPlaylists2);
        }

        private void btnRemoveSong_Click(object sender, EventArgs e)
        {

        }

        private void btnMoveSongUp_Click(object sender, EventArgs e)
        {

        }

        private void btnMoveSongDown_Click(object sender, EventArgs e)
        {

        }

        private void btnMoveSongToOrder_Click(object sender, EventArgs e)
        {

        }

        private void btnxRemoveSong_Click(object sender, EventArgs e)
        {
            int SelectedSongID = -1;

            if (dgvPlaylistSongs.SelectedRows.Count == 1)
            {
                //First get the SongID of the selected song from the datagridview
                int SelectedSongOrderIndex;// = dgvPlaylistSongs.SelectedRows[0].Index + 1;
                SelectedSongOrderIndex = Convert.ToInt32(dgvPlaylistSongs.SelectedRows[0].Cells[0].Value);
                SelectedSongID = _PartyMusicManagerLib.GetPlaylistIndexSongID(cbPlaylists.Text, SelectedSongOrderIndex);

                //Now remove the song with the song ID and order number from the playlist
                //Note: include order index because song could be on playlist multiple times and only want to delete this instance
                _PartyMusicManagerLib.RemoveSongFromPlaylist(cbPlaylists.Text, SelectedSongID, SelectedSongOrderIndex);

                //Make sure to refresh the datagridview control whenever playlist is modified
                _PartyMusicManagerLib.SetPlaylistDGV(cbPlaylists.Text, dgvPlaylistSongs);
            }
            else
                MessageBox.Show("Unable to remove song. No song selected");
        }

        private void dgvPlaylistSongs_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPlaylistSongs.SelectedRows.Count > 0)
            {
                int SelectedIndex = dgvPlaylistSongs.SelectedRows[0].Index + 1;
                SelectedIndex = Convert.ToInt32(dgvPlaylistSongs.SelectedRows[0].Cells[0].Value);
                MessageBox.Show(_PartyMusicManagerLib.GetPlaylistIndexSongID(cbPlaylists.Text, SelectedIndex).ToString());
            }

        }

        private void dgvPlaylistSongs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnxMoveSongUp_Click(object sender, EventArgs e)
        {
            try
            {
                int SelectedSongID = -1;

                if (dgvPlaylistSongs.SelectedRows.Count == 1)
                {
                    if (dgvPlaylistSongs.SelectedRows[0].Index > 0)
                    {
                        //First get the SongID of the selected song from the datagridview
                        double SelectedSongOrderIndex;// = dgvPlaylistSongs.SelectedRows[0].Index + 1;
                        SelectedSongOrderIndex = Convert.ToDouble(dgvPlaylistSongs.SelectedRows[0].Cells[0].Value);
                        SelectedSongID = _PartyMusicManagerLib.GetPlaylistIndexSongID(cbPlaylists.Text, SelectedSongOrderIndex);

                        //Now remove the song with the song ID and order number from the playlist
                        //Note: include order index because song could be on playlist multiple times and only want to delete this instance
                        _PartyMusicManagerLib.ManagePlaylistMoveSongOrderUp(cbPlaylists.Text, SelectedSongID, SelectedSongOrderIndex);

                        //Make sure to refresh the datagridview control whenever playlist is modified
                        _PartyMusicManagerLib.SetPlaylistDGV(cbPlaylists.Text, dgvPlaylistSongs);
                        dgvPlaylistSongs.ClearSelection();
                        if (SelectedSongOrderIndex > 1)
                            dgvPlaylistSongs.Rows[Convert.ToInt32(SelectedSongOrderIndex) - 2].Selected = true;
                        else
                            dgvPlaylistSongs.Rows[0].Selected = true;
                    }
                }
                else
                    MessageBox.Show("Unable to change playlist order of song. No song selected");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btnxMoveSongDown_Click(object sender, EventArgs e)
        {
            try
            {
                int SelectedSongID = -1;

                if (dgvPlaylistSongs.SelectedRows.Count == 1)
                {
                    if (dgvPlaylistSongs.SelectedRows[0].Index + 1 < dgvPlaylistSongs.Rows.Count)
                    {
                        //First get the SongID of the selected song from the datagridview
                        double SelectedSongOrderIndex;// = dgvPlaylistSongs.SelectedRows[0].Index + 1;
                        SelectedSongOrderIndex = Convert.ToDouble(dgvPlaylistSongs.SelectedRows[0].Cells[0].Value);
                        SelectedSongID = _PartyMusicManagerLib.GetPlaylistIndexSongID(cbPlaylists.Text, SelectedSongOrderIndex);

                        //Now remove the song with the song ID and order number from the playlist
                        //Note: include order index because song could be on playlist multiple times and only want to delete this instance
                        _PartyMusicManagerLib.ManagePlaylistMoveSongOrderDown(cbPlaylists.Text, SelectedSongID, SelectedSongOrderIndex);

                        //Make sure to refresh the datagridview control whenever playlist is modified
                        _PartyMusicManagerLib.SetPlaylistDGV(cbPlaylists.Text, dgvPlaylistSongs);
                        dgvPlaylistSongs.ClearSelection();
                        if (SelectedSongOrderIndex + 1 < dgvPlaylistSongs.Rows.Count)
                            dgvPlaylistSongs.Rows[Convert.ToInt32(SelectedSongOrderIndex)].Selected = true;//0-based index
                        else
                            dgvPlaylistSongs.Rows[Convert.ToInt32(SelectedSongOrderIndex) - 1].Selected = true;//0-based index

                    }
                }
                else
                    MessageBox.Show("Unable to change playlist order of song. No song selected");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btnxMoveSongToOrder_Click(object sender, EventArgs e)
        {
            try
            {
                int SelectedSongID = -1;
                int NewIndex = -1;

                if (dgvPlaylistSongs.SelectedRows.Count == 1)
                {
                    if (Int32.TryParse(txtMoveSongToOrder.Text, out NewIndex) && NewIndex > 0)
                    {
                        //If the moved index is higher than the number of rows, just move it to the end of the playlist
                        if (NewIndex > dgvPlaylistSongs.Rows.Count)
                            NewIndex = dgvPlaylistSongs.Rows.Count - 1;

                        //First get the SongID of the selected song from the datagridview
                        double SelectedSongOrderIndex;// = dgvPlaylistSongs.SelectedRows[0].Index + 1;
                        SelectedSongOrderIndex = Convert.ToDouble(dgvPlaylistSongs.SelectedRows[0].Cells[0].Value);
                        SelectedSongID = _PartyMusicManagerLib.GetPlaylistIndexSongID(cbPlaylists.Text, SelectedSongOrderIndex);

                        //Now remove the song with the song ID and order number from the playlist
                        //Note: include order index because song could be on playlist multiple times and only want to delete this instance
                        _PartyMusicManagerLib.ManagePlaylistMoveSongToOrder(cbPlaylists.Text, SelectedSongID, SelectedSongOrderIndex, NewIndex);

                        //Make sure to refresh the datagridview control whenever playlist is modified
                        _PartyMusicManagerLib.SetPlaylistDGV(cbPlaylists.Text, dgvPlaylistSongs);
                        dgvPlaylistSongs.ClearSelection();
                        dgvPlaylistSongs.Rows[NewIndex - 1].Selected = true;
                    }
                    else
                        MessageBox.Show("Unable to change playlist order of song. Invalid new order index inputted");
                }
                else
                    MessageBox.Show("Unable to change playlist order of song. No song selected");
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

    }
}
