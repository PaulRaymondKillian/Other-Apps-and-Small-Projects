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
        private void RefreshControls()
        {
            _PartyMusicManagerLib.SetControlGenres(lbGenres);
            _PartyMusicManagerLib.SetControlArtists(lbArtists, lbGenres);
            _PartyMusicManagerLib.SetControlPlaylists(cbPlaylists);
        }
        private void InitPartyMusicManagerControls()
        {
            RefreshControls();
            MusicMonitorTimer.Enabled = true;

            //lbGenres.DataSource = _PartyMusicManagerLib.GetGenres();
            //lbArtists.DataSource = _PartyMusicManagerLib.GetArtists();
            //lbAlbums.DataSource = _PartyMusicManagerLib.GetAlbums();
            //lbSongs.DataSource = _PartyMusicManagerLib.GetSongs();
            //lbGenres.Refresh();
            //lbArtists.Refresh();
        }//InitPartyMusicManagerControls();

        private void ResizeControls()
        {
            int Buffer = 5;
            int PanelLeftPercent = 40;
            int PanelMiddlePercent = 40;
            int PanelRightPercent = 18;
            double Percent = (Convert.ToDouble(this.Width - (4 * Buffer))) / 100;

            PanelLeft.Left = Buffer;
            PanelLeft.Width = Convert.ToInt32(PanelLeftPercent * Percent);
            PanelMiddle.Left = PanelLeft.Right + Buffer;
            PanelMiddle.Width = Convert.ToInt32(PanelMiddlePercent * Percent);
            PanelRight.Left = PanelMiddle.Right + Buffer;
            PanelRight.Width = Convert.ToInt32(PanelRightPercent * Percent);

            PanelLeft.Height = this.Height - menuStrip1.Height - 25 - PanelLeft.Top;
            PanelMiddle.Height = PanelLeft.Height;
            PanelRight.Height = PanelLeft.Height;


        }//ResizeControls

        private void PanelRightResizeControls()
        {
            gbPlaylistSongs.Width = PanelRight.Width - 10;
            lboxCurrentPlaylist.Width = gbPlaylistSongs.Width - 10;
            cbPlaylists.Left = lblPlaylist.Right + 5;
            cbPlaylists.Width = gbPlaylistSongs.Width - cbPlaylists.Left - 10;

            gbPlaylistSongs.Height = Convert.ToInt32(60 * (Convert.ToDouble(PanelRight.Height) / 100));
            lboxCurrentPlaylist.Height = gbPlaylistSongs.Height - lboxCurrentPlaylist.Top - 10;

            gbRequestedSongs.Width = PanelRight.Width - 10;
            lbRequestPlaylist.Width = gbRequestedSongs.Width - 10;

            gbRequestedSongs.Top = gbPlaylistSongs.Bottom + 10;
            gbRequestedSongs.Height = PanelRight.Height - gbRequestedSongs.Top - 10;

            lbRequestPlaylist.Height = gbRequestedSongs.Height - lbRequestPlaylist.Top - 5;

        }//PanelRightResizeControls

        private void PanelMiddleResizeControls()
        {
            btnxRequestSong.Left = 5;
            btnxRequestSong.Width = (PanelMiddle.Width - (3 * 5))/ 2;

            btnxSkipToNextSong.Left = btnxRequestSong.Right + 5;
            btnxSkipToNextSong.Width = btnxRequestSong.Width;

            btnxPlayStop.Left = 5;
            btnxPlayStop.Width = (PanelMiddle.Width - (4 * 5)) / 3;

            btnxPause.Left = btnxPlayStop.Right + 5;
            btnxPause.Width = btnxPlayStop.Width;

            btnxMute.Left = btnxPause.Right + 5;
            btnxMute.Width = btnxPlayStop.Width;

            gbChooseSong.Width = PanelMiddle.Width - (2 * gbChooseSong.Left);
            dgvSongs.Width = gbChooseSong.Width - (2 * dgvSongs.Left);

            dgvSongs.Columns[0].Width = 50;
            dgvSongs.Columns[1].Width = (dgvSongs.Width - dgvSongs.Columns[0].Width) / 3;
            dgvSongs.Columns[2].Width = dgvSongs.Columns[1].Width;
            dgvSongs.Columns[3].Width = dgvSongs.Columns[1].Width;

            gbChooseSong.Height = PanelMiddle.Height - gbChooseSong.Top - 10;
            dgvSongs.Height = gbChooseSong.Height - dgvSongs.Top - 5;

        }//PanelMiddleResizeControls

        private void PanelLeftResizeControls()
        {
            //Resize Widths
            gbChooseGenre.Left = 5;
            gbChooseGenre.Width = (PanelLeft.Width - (2 * 5)) / 3;

            gbChooseArtist.Left = gbChooseGenre.Right;
            gbChooseArtist.Width = gbChooseGenre.Width;

            gbChooseAlbum.Left = gbChooseArtist.Right;
            gbChooseAlbum.Width = gbChooseGenre.Width;

            lbGenres.Left = 5;
            lbGenres.Width = gbChooseGenre.Width - (2 * 5);

            lbArtists.Left = lbGenres.Left;
            lbArtists.Width = lbGenres.Width;

            lbAlbums.Left = lbGenres.Left;
            lbAlbums.Width = lbGenres.Width;


            gbCurrentPlayingSong.Left = 5;
            gbCurrentPlayingSong.Width = 2*((PanelLeft.Width - 5) / 3);

            PanelSongMisc.Left = gbCurrentPlayingSong.Right + 5;
            PanelSongMisc.Width = PanelLeft.Width - gbCurrentPlayingSong.Right - 10;
            knobVolume.Width = PanelSongMisc.Width;
            knobVolume.Left = (PanelSongMisc.Width / 2) - (knobVolume.Width / 2);
            knobVolume.Height = PanelSongMisc.Height;
            if (knobVolume.Height > knobVolume.Width)
            { knobVolume.Height = knobVolume.Width; }
            knobVolume.Top = (PanelSongMisc.Height / 2) - (knobVolume.Height / 2);

            lblCurrentSongName.Left = 5;
            lblCurrentSongArtist.Left = 5;
            lblCurrentSongAlbum.Left = 5;
            pbSongDuration.Left = 5;
            pbSongDuration.Width = gbCurrentPlayingSong.Width - pbSongDuration.Left - 5;
            lblSongTimeDuration.Left = pbSongDuration.Right - 30;
            starCurrentSongRating.Left = ((gbCurrentPlayingSong.Width-10) / 2) - (starCurrentSongRating.Width / 2);

            lblBasicHowToRequest.Left = 5;
            lblBasicHowToRequest.Width = PanelLeft.Width - 10;
            lblrefRequestYourSong.Left = (PanelLeft.Width / 2) - (lblrefRequestYourSong.Width / 2);

            knobVolume.Left = 5;

            //Resize Heights
            gbChooseGenre.Height = PanelLeft.Height - gbChooseGenre.Top - 5;
            gbChooseArtist.Height = gbChooseGenre.Height;
            gbChooseAlbum.Height = gbChooseGenre.Height;

            lbGenres.Height = gbChooseGenre.Height - lbGenres.Top - 5;
            lbArtists.Height = lbGenres.Height;
            lbAlbums.Height = lbGenres.Height;

        }//PanelLeftResizeControls
    }
}