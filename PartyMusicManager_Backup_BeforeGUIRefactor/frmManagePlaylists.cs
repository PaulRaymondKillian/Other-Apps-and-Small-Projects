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
            _PartyMusicManagerLib.SetPlaylistDGV(cbPlaylists.Text, dgvPlaylistSongs);
        }

        private void frmManagePlaylists_Load(object sender, EventArgs e)
        {
            _PartyMusicManagerLib.SetControlPlaylists(cbPlaylists);
            _PartyMusicManagerLib.SetPlaylistDGV(cbPlaylists.Text, dgvPlaylistSongs);
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
    }
}
