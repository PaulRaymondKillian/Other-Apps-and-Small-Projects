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
        private void ResizeControls()
        {

        }//ResizeControls

        private void InitPartyMusicManagerControls()
        {
            _PartyMusicManagerLib.SetControlGenres(lbGenres);
            _PartyMusicManagerLib.SetControlArtists(lbArtists, lbGenres);
            _PartyMusicManagerLib.SetControlPlaylists(cbPlaylists);
            MusicMonitorTimer.Enabled = true;

            //lbGenres.DataSource = _PartyMusicManagerLib.GetGenres();
            //lbArtists.DataSource = _PartyMusicManagerLib.GetArtists();
            //lbAlbums.DataSource = _PartyMusicManagerLib.GetAlbums();
            //lbSongs.DataSource = _PartyMusicManagerLib.GetSongs();
            //lbGenres.Refresh();
            //lbArtists.Refresh();
        }//InitPartyMusicManagerControls();
    }
}