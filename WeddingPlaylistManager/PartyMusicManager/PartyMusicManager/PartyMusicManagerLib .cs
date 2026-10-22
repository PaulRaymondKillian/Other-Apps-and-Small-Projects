using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PartyMusicManager
{
    public class PartyMusicManagerLib
    {
        private MusicLib.MusicLib _MusicLibrary;
        private MusicPlayerLib.MusicPlayerLib _MusicPlayer;

        private List<MusicLib.MusicAlbum> _CurrentListedAlbums;
        private List<MusicLib.MusicFile> _CurrentListedSongs;

        private MusicLib.MusicFile _PlayingSong;
        private List<MusicLib.MusicFile> _CurrentPlaylist;
        private int _CurrentPlaylistSongIndex;
        private List<MusicLib.MusicFile> _RequestPlaylist;
        private bool _CurrentSongRequest;
        private bool _SkipToNextSong;

        public PartyMusicManagerLib(String pConnectionString)
        {
            _MusicLibrary = new MusicLib.MusicLib(pConnectionString);
            _MusicPlayer = new MusicPlayerLib.MusicPlayerLib();

            //Instatiate empty objects to prevent possible null ref
            _CurrentListedAlbums = new List<MusicLib.MusicAlbum>();
            _CurrentListedSongs = new List<MusicLib.MusicFile>();
            _CurrentPlaylist = new List<MusicLib.MusicFile>();
            _RequestPlaylist = new List<MusicLib.MusicFile>();
            _CurrentPlaylistSongIndex = -1;
            _CurrentSongRequest = false;
            _SkipToNextSong = false;

        }//Constructor

        ~PartyMusicManagerLib()
        {
        }//Destructor

#region "Manage Music Library"
        
        public void AddMusicFileToLibrary(String pFilePath)
        {
            try
            {
                _MusicLibrary.AddFile(pFilePath);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }//AddMusicFileToLibrary

        public void AddMusicDirectoryToLibrary(String pDirectoryPath)
        {
            try
            {
                _MusicLibrary.AddDirectory(pDirectoryPath, true);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }//AddMusicDirectoryToLibrary

#endregion

#region Set Controls

        public void SetControlGenres(System.Windows.Forms.ListBox pGenreListBox)
        {
            List<String> Genres = _MusicLibrary.GetGenres();
            pGenreListBox.Items.Clear();
            pGenreListBox.Items.Add("(All Genres)");
            for (int i = 0; i <= Genres.Count - 1; i++)
                pGenreListBox.Items.Add(Genres[i]);
            pGenreListBox.Refresh();

        }//SetControlGenres

        public void SetControlArtists(System.Windows.Forms.ListBox pArtistListBox, System.Windows.Forms.ListBox pGenreListBox)
        {
            List<String> Artists;
            //Determine if a Genre row is selected, or no row selected at all
            if (pGenreListBox.SelectedIndex <= 0)   //No row selected (=-1), or first row selected (=0), so return all Artists
            { 
                Artists = _MusicLibrary.GetArtists(); 
            }
            else //A row is selected, so find the genre, and find the related artists
            {
                //Get the selected genre value
                String SelectedGenre = pGenreListBox.SelectedItem.ToString();
                Artists = _MusicLibrary.GetArtists(SelectedGenre);
            }
            pArtistListBox.Items.Clear();
            pArtistListBox.Items.Add("(All Artists)");
            for (int i = 0; i <= Artists.Count - 1; i++)
                pArtistListBox.Items.Add(Artists[i]);
            pArtistListBox.Refresh();
        }//SetControlGenres

        public void SetControlAlbums(System.Windows.Forms.ListBox pAlbumListBox, System.Windows.Forms.ListBox pArtistListBox)
        {
            List<MusicLib.MusicAlbum> Albums = new List<MusicLib.MusicAlbum>();
            //Determine if a Genre row is selected, or no row selected at all
            if (pArtistListBox.SelectedIndex == 0)   //No row selected (=-1), or first row selected (=0), so return all Artists
            {
                Albums = _MusicLibrary.GetAlbums();
            }
            else if (pArtistListBox.SelectedIndex > 0) //A row is selected, so find the genre, and find the related artists
            {
                //Get the selected genre value
                String SelectedArtist = pArtistListBox.SelectedItem.ToString();
                Albums = _MusicLibrary.GetAlbums(SelectedArtist);
            }

            pAlbumListBox.Items.Clear();
            pAlbumListBox.Items.Add("(All Albums)");
            for (int i = 0; i <= Albums.Count - 1; i++)
            {
                String AlbumYear;
                if (Albums[i].Year > 0)
                    AlbumYear = " (" + Albums[i].Year.ToString() + ")";
                else
                    AlbumYear = "";

                pAlbumListBox.Items.Add(Albums[i].Name + AlbumYear);
            }
            pAlbumListBox.Refresh();

            //Set the current Album list to keep a persistent record of selected album info
            _CurrentListedAlbums = Albums;

        }//SetControlGenres

        public void SetControlSongs(System.Windows.Forms.DataGridView pSongsDGV, System.Windows.Forms.ListBox pAlbumListBox, 
                                            System.Windows.Forms.ListBox pArtistListBox)
        {
            List<MusicLib.MusicFile> Songs = new List<MusicLib.MusicFile>();
            //Determine if a Genre row is selected, or no row selected at all
            if (pArtistListBox.SelectedIndex == 0 && pAlbumListBox.SelectedIndex == 0)   //No row selected (=-1), or first row selected (=0), so return all Artists
            {
                Songs = _MusicLibrary.GetSongs();
            }
            else if (pArtistListBox.SelectedIndex > 0 && pAlbumListBox.SelectedIndex > 0)
            {
                String SelectedArtist = pArtistListBox.SelectedItem.ToString();
                String SelectedAlbum = _CurrentListedAlbums[pAlbumListBox.SelectedIndex - 1].Name;
                Songs = _MusicLibrary.GetSongs(SelectedArtist, SelectedAlbum);
            }
            else if (pArtistListBox.SelectedIndex == 0 && pAlbumListBox.SelectedIndex > 0)
            {
                String SelectedAlbum = _CurrentListedAlbums[pAlbumListBox.SelectedIndex - 1].Name;
                Songs = _MusicLibrary.GetSongsPerAlbum(SelectedAlbum);
            }
            else if (pArtistListBox.SelectedIndex > 0)
            {
                String SelectedArtist = pArtistListBox.SelectedItem.ToString();
                Songs = _MusicLibrary.GetSongs(SelectedArtist);
            }
            else
            {
                //Songs = _MusicLibrary.GetSongs();
            }

            //pSongListBox.Items.Clear();
            //for (int i = 0; i <= Songs.Count - 1; i++)
            //    pSongListBox.Items.Add(Songs[i].Name);
            //pSongListBox.Refresh();


            //
            //
            //
            pSongsDGV.Rows.Clear();
            for (int i = 0; i <= Songs.Count - 1; i++)
            {
                String Track;
                if (Songs[i].Track == -1)
                    Track = "";
                else
                    Track = Songs[i].Track.ToString();

                //pSongsDGV.Rows.Add(Track, Songs[i].Name, Songs[i].Duration, Songs[i].Artist, Songs[i].Album, Songs[i].Genre, Songs[i].Rating);
                pSongsDGV.Rows.Add(Track, Songs[i].Name, Songs[i].Artist, Songs[i].Album);
            }
            pSongsDGV.Refresh();

            //Set the current Album list to keep a persistent record of selected album info
            _CurrentListedSongs = Songs;

        }//SetControlGenres

#endregion

#region Play Music Management

        public void PlaySong(int pDoubleClickedIndex)
        {
            PlaySong(_CurrentListedSongs[pDoubleClickedIndex]);
        }//PlaySong

        public void PlaySong(MusicLib.MusicFile pMusicFile)
        {
            _PlayingSong = pMusicFile;
            String MusicFilePath = _PlayingSong.FilePath;
            _MusicPlayer.Play(MusicFilePath);
        }//PlaySong

        public void StopMusic()
        { _MusicPlayer.Stop(); }

        public void PauseMusic()
        { _MusicPlayer.Pause(); }

        public void PlayMusic()
        { _MusicPlayer.Play(); }

        public void SetVolume(int pVolume)
        { _MusicPlayer.SetVolume(pVolume); }

        public void MuteMusic()
        { _MusicPlayer.Mute(); }

        public void UnMuteMusic()
        { _MusicPlayer.UnMute(); }

        public void AddToRequestPlaylist(int pDoubleClickedIndex)
        {
            _RequestPlaylist.Add(_CurrentListedSongs[pDoubleClickedIndex]);

            //If the Request Playlist was previously empty, and therefore the main playlist was playing
            //then immediately skip to the next song, which should be this new added song.
            if (_RequestPlaylist.Count == 1)
                _SkipToNextSong = true;

        }//AddToRequestPlaylist

        public void RefreshRequestPlaylistListBox(System.Windows.Forms.ListBox pRequestPlaylistListBox)
        {
            pRequestPlaylistListBox.Items.Clear();
            for (int i = 0; i <= _RequestPlaylist.Count - 1; i++)
            {
                pRequestPlaylistListBox.Items.Add(_RequestPlaylist[i].Name + " - " + _RequestPlaylist[i].Artist);
            }
        }//RefreshRequestPlaylistListBox

        public void MonitorMusicManagerStatus()
        {

            if ((_CurrentPlaylist.Count() > 0 || _RequestPlaylist.Count() > 0) && 
                        _MusicPlayer.SongEnded() || _SkipToNextSong == true)
            {
                //Remove the current song from the request playlist if requested song
                //if current song is playlist song, advance to next index
                if (_CurrentSongRequest)
                {
                    if (_RequestPlaylist.Contains(_PlayingSong))
                        _RequestPlaylist.Remove(_PlayingSong);
                }
                else
                {
                    if (_CurrentPlaylistSongIndex >= _CurrentPlaylist.Count - 1)
                        _CurrentPlaylistSongIndex = 0;
                    else
                        _CurrentPlaylistSongIndex += 1;
                }

                //Check for requested songs
                if (_RequestPlaylist.Count > 0)
                {   //Play next request song
                    _PlayingSong = _RequestPlaylist[0];
                    _CurrentSongRequest = true;
                }
                else if (_CurrentPlaylist.Count > 0)
                {   //Play next playlist song
                    if (_CurrentPlaylistSongIndex > _CurrentPlaylist.Count-1)
                        _CurrentPlaylistSongIndex = 0;

                    _PlayingSong = _CurrentPlaylist[_CurrentPlaylistSongIndex];
                    _CurrentSongRequest = false;
                }
                PlaySong(_PlayingSong);



            }
            _SkipToNextSong = false;    //Reset this to false each time




            ////If there are songs in the request playlist
            //if (_RequestPlaylist.Count > 0)
            //{
            //    if (_MusicPlayer.SongEnded())
            //    {
            //        MusicLib.MusicFile NextSong = _RequestPlaylist[0];
            //        PlaySong(NextSong);
            //        _RequestPlaylist.Remove(NextSong);
            //    }
            //}
            //else //Play songs from the main playlist
            //{
            //    //Validate the current playlist song index
            //    if (_CurrentPlaylist.Count > 0 && (_CurrentPlaylistSongIndex == -1 || _CurrentPlaylistSongIndex == _CurrentPlaylist.Count-1))
            //        _CurrentPlaylistSongIndex = 0;
            //    else if (_CurrentPlaylist.Count == 0)
            //        _CurrentPlaylistSongIndex = -1;

            //    if (_CurrentPlaylistSongIndex >= 0)
            //    {
            //        if (_MusicPlayer.SongEnded())
            //        {
            //            MusicLib.MusicFile NextSong = _CurrentPlaylist[_CurrentPlaylistSongIndex];
            //            PlaySong(NextSong);
            //        }
            //    }
                
            //}
        }//MonitorMusicManagerStatus

        public String PlayingSongTimePlayed()
        { return _MusicPlayer.GetSongTimePlayed(); }//PlayingSongTimePlayed

        public String PlayingSongTimeDuration()
        { return _MusicPlayer.GetSongTimeDuration(); }//PlayingSongTimeDuration

        public String PlayingSongTimePercent()
        { return _MusicPlayer.GetSongTimePercent(); }

        public String PlayingSongName()
        {
            String Name = "";
            if (_PlayingSong != null)
                Name = _PlayingSong.Name;
            
            return Name;
        }//PlayingSongName

        public String PlayingSongArtist()
        {
            String Artist = "";
            if (_PlayingSong != null)
                Artist = _PlayingSong.Artist;

            return Artist;
        }//PlayingSongArtist

        public String PlayingSongAlbum()
        {
            String Album = "";
            if (_PlayingSong != null)
                Album = _PlayingSong.Album;

            return Album;
        }//PlayingSongTimeDuration

        public bool PlayingRequestSong()
        {
            bool IsRequest = false;
            if (_CurrentSongRequest == true && _PlayingSong != null)
                IsRequest = true;

            return IsRequest;
        }//PlayingRequestSong

        public bool PlayingPlaylistSong()
        {
            bool IsPlaylist = false;
            if (_CurrentSongRequest == false && _PlayingSong != null)
                IsPlaylist = true;

            return IsPlaylist;
        }//PlayingPlaylistSong

        public double GetTotalPlayedSeconds()
        { return _MusicPlayer.GetTotalPlayedSeconds(); }

        public double GetTotalCurrentSongSeconds()
        { return _MusicPlayer.GetTotalCurrentSongSeconds(); }

        public void SetCurrentSongPosition(double pPercentOfSong)
        {
            _MusicPlayer.SetCurrentSongPosition(pPercentOfSong);
        }//SetCurrentSongPosition

        public bool IsPaused()
        {
            return _MusicPlayer.IsPaused();
        }

        public bool IsStopped()
        {
            return _MusicPlayer.IsStopped();
        }

        public bool IsPlaying()
        {
            return _MusicPlayer.IsPlaying();
        }

        public bool IsMuted()
        {
            return _MusicPlayer.IsMuted();
        }

#endregion

#region Playlist Management

        public void CreatePlaylist(String pNewPlaylistName)
        {
            try
            {
                _MusicLibrary.CreatePlaylist(pNewPlaylistName);
            }
            catch (MusicLibPlaylistAlreadyExistsException)
            {
                MessageBox.Show("Cannot create playlist. Playlist '" + pNewPlaylistName + "' already exists!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to create playlist. Error: " + ex.Message);
            }
        }//CreatePlaylist

        public void DeletePlaylist(String pPlaylistName)
        {
            try
            {
                _MusicLibrary.DeletePlaylist(pPlaylistName);
            }
            catch (MusicLibPlaylistDoesNotExistException)
            {
                MessageBox.Show("Cannot delete playlist. Playlist '" + pPlaylistName + "' does not exist.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to delete playlist. Error: " + ex.Message);
            }
        }//DeletePlaylist

        public List<String> GetPlaylists()
        {
            return _MusicLibrary.GetPlaylists();
        }//GetPlaylists

        public int GetPlaylistIndexSongID(String pPlaylistName, double pSongIndex)
        {
            int SongID = -1;

            SongID = _MusicLibrary.GetPlaylistIndexSongID(pPlaylistName, pSongIndex);

            return SongID;
        }//GetPlaylistIndexSongID

        public void RemoveSongFromPlaylist(String pPlaylistName, int pSelectedSongID, int pSelectedSongOrderIndex)
        {
            _MusicLibrary.RemoveSongFromPlaylist(pPlaylistName, pSelectedSongID, pSelectedSongOrderIndex);
        }//RemoveSongFromPlaylist

        public void ManagePlaylistMoveSongOrderUp(String pPlaylistName, int pSongID, double pCurrentSongOrder)
        {
            _MusicLibrary.ManagePlaylistMoveSongOrderUp(pPlaylistName, pSongID, pCurrentSongOrder);
        }//UpdatePlaylistSongOrder

        public void ManagePlaylistMoveSongOrderDown(String pPlaylistName, int pSongID, double pCurrentSongOrder)
        {
            _MusicLibrary.ManagePlaylistMoveSongOrderDown(pPlaylistName, pSongID, pCurrentSongOrder);
        }//UpdatePlaylistSongOrder

        public void ManagePlaylistMoveSongToOrder(String pPlaylistName, int pSongID, double pCurrentSongOrder, double pNewSongOrder)
        {
            _MusicLibrary.ManagePlaylistMoveSongToOrder(pPlaylistName, pSongID, pCurrentSongOrder, pNewSongOrder);
        }//UpdatePlaylistSongOrder

        public void SetControlPlaylists(System.Windows.Forms.ComboBox pPlaylistComboBox)
        {
            //Set Playlist ComboBox
            List<String> Playlists = _MusicLibrary.GetPlaylists();
            pPlaylistComboBox.Items.Clear();
            for (int i = 0; i <= Playlists.Count - 1; i++)
                pPlaylistComboBox.Items.Add(Playlists[i]);

            String DefaultPlaylist = _MusicLibrary.GetDefaultPlaylist();
            pPlaylistComboBox.Text = DefaultPlaylist;

            pPlaylistComboBox.Refresh();
        }

        public void SetPlaylistDGV( String pPlaylistName, System.Windows.Forms.DataGridView pPlaylistSongsDGV)
        {
            //Set Playlist Songs DataGridView
            if (pPlaylistName != "")
            {
                List<MusicLib.MusicPlaylistFile> PlaylistSongs = _MusicLibrary.GetPlaylistPlaylistFiles(pPlaylistName);

                pPlaylistSongsDGV.Rows.Clear();
                for (int i = 0; i <= PlaylistSongs.Count - 1; i++)
                {
                    pPlaylistSongsDGV.Rows.Add(PlaylistSongs[i].Order, PlaylistSongs[i].Name, PlaylistSongs[i].Duration, PlaylistSongs[i].Rating);
                    //pPlaylistSongsDGV.Rows.Add(Track, Songs[i].Name, Songs[i].Duration, Songs[i].Artist, Songs[i].Album, Songs[i].Genre, Songs[i].Rating);
                }
                pPlaylistSongsDGV.Refresh();


            }
        }//SetPlaylistDGV

        public void SetDefaultPlaylist(String pPlaylistName)
        {
            _MusicLibrary.SetDefaultPlaylist(pPlaylistName);
        }//SetDefaultPlaylist

        public void SetPlaylistControl(System.Windows.Forms.DataGridView pPlayListDGV)
        {

        }//SetPlaylistControl

        public void AddSongToPlaylist(String pPlaylistName, int pSelectedSongIndex)
        {
            if (pSelectedSongIndex >= 0)
            {
                MusicLib.MusicFile SelectedSong = _CurrentListedSongs[pSelectedSongIndex];
                _MusicLibrary.AddSongToPlaylist(pPlaylistName, SelectedSong);
                
            }
            else
                MessageBox.Show("No song selected to add to playlist.");
        }//AddSongToPlaylist

        public void SetControlCurrentPlaylistListBox(String pPlaylistName, System.Windows.Forms.ListBox pPlaylistListBox)
        {
            _CurrentPlaylist = _MusicLibrary.GetPlaylistMusicFiles(pPlaylistName);

            pPlaylistListBox.Items.Clear();
            for (int i = 0; i <= _CurrentPlaylist.Count - 1; i++)
            {
                pPlaylistListBox.Items.Add(_CurrentPlaylist[i].Name + " - " + _CurrentPlaylist[i].Artist);
                PlayPlaylistSong(0);
            }
            

        }//SetControlCurrentPlaylistListBox

        public void PlayPlaylistSong(int pCurrentPlaylistIndex)
        {

        }//PlayPlaylistSong

        public int GetCurrentPlaylistSongIndex()
        { return _CurrentPlaylistSongIndex; }

        public void PlaySongFromPlaylistIndex(int pPlaylistSongIndex)
        {
            _CurrentPlaylistSongIndex = pPlaylistSongIndex-1;

            //If there are no requested songs, immediately play this new song.
            //Else, play the song after requests are played.
            if (_RequestPlaylist.Count == 0)
            {
                _SkipToNextSong = true;
                MonitorMusicManagerStatus();
            }



        }

        public void SkipToNextSong()
        { _SkipToNextSong = true; }

        public int GetCurrentSongStarRating(int pMaxValue)
        {
            int StarRating = 0;

            if (_PlayingSong != null)
                StarRating = _PlayingSong.Rating;

            if (StarRating > pMaxValue)
                StarRating = 5;

            return StarRating;
        }//GetCurrentSongStarRating

        public void UpdateCurrentSongRating(int pRating)
        {
            _PlayingSong.Rating = pRating;
            _MusicLibrary.UpdateSongRating(_PlayingSong.ID, pRating);
        }
#endregion

    }
}
