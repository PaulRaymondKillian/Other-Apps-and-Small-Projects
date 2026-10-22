using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using TagLib;
using System.Data;


namespace MusicLib
{
    public class MusicLib
    {
        private List<MusicFile> _Songs;  //Keep list of all songs
        private List<String> _Artists;   //Keep list of all artists
        private List<String> _Genres;    //Keep list of all genres
        private List<String> _AlbumNames;    //Keep list of all album names
        private List<MusicAlbum> _Albums;    //Keep list of all album information

        private List<String> _FailedSongList;
        private List<String> _SongAlreadyExistsList;

        private MusicDBUtility _MusicDBUtility;
        private String _ConnectionString;

        public MusicLib(String pSqlServerCeConnectionString)
        {
            _ConnectionString = pSqlServerCeConnectionString;
            _MusicDBUtility = new MusicDBUtility(_ConnectionString);
            Init();
        }//Constructor

        public void Init()
        {
            _Songs = new List<MusicFile>();
            _Artists = new List<String>();
            _Genres = new List<String>();
            _AlbumNames = new List<String>();
            _Albums = new List<MusicAlbum>();
            _FailedSongList = new List<String>();
            _SongAlreadyExistsList = new List<String>();
        }//Init

#region Manage Add Music Files

        public void AddFile(String pFilePath)
        {
            try
            {
                MusicFile File = new MusicFile(pFilePath);
                _Songs.Add(File);

                if (!_Artists.Contains(File.Artist))
                    _Artists.Add(File.Artist);

                if (!_Genres.Contains(File.Genre))
                    _Genres.Add(File.Genre);

                //Use a concatenation of Artist + Album + Year to identify a specific album with periods as delimiters (Artst.Album.Year)
                //(because some albums may have the same name but from a different artist)
                //The AlbumNames list is merely used as a simply way to keep track of added albums
                if (!_AlbumNames.Contains(File.Artist + "." + File.Album + "." + File.Year))
                {
                    //Add the new album name to the list to identify the album has been added to the list
                    _AlbumNames.Add(File.Artist + "." + File.Album + "." + File.Year);

                    //Add the album info the the album info list
                    MusicAlbum NewAlbum = new MusicAlbum(File.Album, File.AlbumArtPath, File.Year, "");
                    if (NewAlbum != null)
                        _Albums.Add(NewAlbum);
                }
            }
            catch (MusicLibFailedToInitTagsException ex)
            { AddFailedSong(ex.FilePath, "Failed to Init Tags: " + ex.Message); }
            catch (MusicLibFailedToGetTagsException ex)
            { AddFailedSong(ex.FilePath, "Failed to Get Tags: " + ex.Message); }
            catch (Exception ex)
            { AddFailedSong(pFilePath, "General Exception: " + ex.Message); }

        }//AddFile

        public void AddDirectory(String pDirPath, Boolean pIncludeSubDirs)
        {
            String[] FilePaths;
            if (pIncludeSubDirs)
                FilePaths = Directory.GetFiles(pDirPath, "*.mp3", SearchOption.AllDirectories);
            else
                FilePaths = Directory.GetFiles(pDirPath, "*.mp3");

            //DEBUG
            Console.WriteLine("Files: " + FilePaths.Length);

            foreach (String FilePath in FilePaths)
                AddFile(FilePath.ToLower());

        }//AddDirectory

        //Actually store the information gathered from the music files and insert new data into the database.
        public void CommitMusicLibToDatabase()
        {
            //DEBUG
            //Console.WriteLine("Genres: " + _Genres.Count);
            //Console.WriteLine("Artists: " + _Artists.Count);
            //Console.WriteLine("Albums: " + _Albums.Count);
            //Console.WriteLine("Songs: " + _Songs.Count);

            //Add the new Genres first (Do not add already existing genres)
            foreach (String Genre in _Genres)
                _MusicDBUtility.AddGenre(Genre);

            //Add the new Artists second (dependant on the Genres existing) (Do not add already existing artists)
            foreach (String Artist in _Artists)
                _MusicDBUtility.AddArtist(Artist);

            //Add the new Albums third (dependant on the Artists existing) (Do not add already existing albums)
            foreach (MusicAlbum Album in _Albums)
                _MusicDBUtility.AddAlbum(Album.Name, Album.Year, Album.AlbumArtPath, Album.AlbumDescription);

            //Finally, add the Songs last (dependant on all existing) (Do not add already existing songs)
            foreach (MusicFile Song in _Songs)
            {
                try { _MusicDBUtility.AddSong(Song.Name, Song.FilePath, Song.Track, Song.Artist, Song.Album, Song.Genre, Song.Duration, 0); }
                catch (MusicLibSongAlreadyExistsException ex)
                { AddAlreadyExistsSong(Song.FilePath, "Song already exists in database: " + ex.Message);  }
                catch (MusicLibAddSongFailedException ex)
                { AddFailedSong(Song.FilePath, "Failed to commit song to database: " + ex.Message); }
                catch (Exception ex)
                { AddFailedSong(Song.FilePath, "General Exception - Failed to commit song to database: " + ex.Message); }
            }

        }//CommitMusicLibToDatabase

        private void AddFailedSong(String pSongString, String pFailedReason)
        {
            _FailedSongList.Add("Failed Song: " + pSongString + ", Failed Reason: " + pFailedReason);
        }//AddFailedSong

        private void AddAlreadyExistsSong(String pSongString, String pFailedReason)
        {
            _SongAlreadyExistsList.Add("Song: " + pSongString + ", Reason: " + pFailedReason);
        }//AddFailedSong

        public void RequalifyMusicLibrary()
        {
            RequalifyMusicLibrary_Songs();
            //RequalifyMusicLibrary_Albums();
            //RequalifyMusicLibrary_Artists();
            //RequalifyMusicLibrary_Genres();

        }//RequalifyMusicLibrary

        private void RequalifyMusicLibrary_Songs()
        {
            //This method checks through all the music files in the library and determines if the filepath is still valid/exists.
            //If it does not exist, it removes the song from the library/database.
            List<MusicFile> AllSongs = GetSongs();

            foreach (MusicFile CurrentSong in AllSongs)
            {
                if (System.IO.File.Exists(CurrentSong.FilePath) == false)
                {
                    RemoveSongFromLibrary(CurrentSong.ID);
                }
            }
        }//RequalifyMusicLibrary_Songs

        public void RemoveSongFromLibrary(int pSongID)
        {
            //Steps to remove a song from the library
            //#1: Get list of all playlists the songs exists within
            //#2: Remove the song from the list of playlists
            //#3: Remove the song row from the tSongs table
        }//RemoveSongFromLibrary

#endregion

#region Get Music Info From Database

        public List<String> GetGenres(bool pOrderNameAscending = true)
        {
            List<String> Genres = new List<String>();
            DataTable dt;

            dt = _MusicDBUtility.GetGenres(pOrderNameAscending);

            foreach (DataRow Row in dt.Rows)
                Genres.Add(Row.ItemArray[0].ToString());

            return Genres;
        }//GetGenres

        public List<String> GetArtists(bool pOrderNameAscending = true)
        {
            List<String> Artists = new List<String>();
            DataTable dt;

            dt = _MusicDBUtility.GetArtists(pOrderNameAscending);

            foreach (DataRow Row in dt.Rows)
                Artists.Add(Row.ItemArray[0].ToString());

            return Artists;
        }//GetArists

        public List<String> GetArtists(String pGenre, bool pOrderNameAscending = true)
        {
            List<String> Artists = new List<String>();
            DataTable dt;

            dt = _MusicDBUtility.GetArtists(pGenre, pOrderNameAscending);

            foreach (DataRow Row in dt.Rows)
                Artists.Add(Row.ItemArray[0].ToString());

            return Artists;
        }//GetArists

        public List<MusicAlbum> GetAlbums(bool pOrderNameAscending = true)
        {
            List<MusicAlbum> Albums = new List<MusicAlbum>();
            DataTable dt;

            dt = _MusicDBUtility.GetAlbums(pOrderNameAscending);

            foreach (DataRow Row in dt.Rows)
            {
                if (Row.ItemArray.Length == 4)
                {
                    MusicAlbum NewAlbum = new MusicAlbum();
                    NewAlbum.Name = Row.ItemArray[0].ToString();
                    NewAlbum.Year = Convert.ToInt32(Row.ItemArray[1].ToString());
                    NewAlbum.AlbumArtPath = Row.ItemArray[2].ToString();
                    NewAlbum.AlbumDescription = Row.ItemArray[3].ToString();

                    Albums.Add(NewAlbum);
                }
            }

            return Albums;
        }//GetAlbums

        public List<MusicAlbum> GetAlbums(String pArtist, bool pOrderNameAscending = true)
        {
            List<MusicAlbum> Albums = new List<MusicAlbum>();
            DataTable dt;

            dt = _MusicDBUtility.GetAlbums(pArtist, pOrderNameAscending);

            foreach (DataRow Row in dt.Rows)
            {
                if (Row.ItemArray.Length == 4)
                {
                    MusicAlbum NewAlbum = new MusicAlbum();
                    NewAlbum.Name = Row.ItemArray[0].ToString();
                    NewAlbum.Year = Convert.ToInt32(Row.ItemArray[1].ToString());
                    NewAlbum.AlbumArtPath = Row.ItemArray[2].ToString();
                    NewAlbum.AlbumDescription = Row.ItemArray[3].ToString();

                    Albums.Add(NewAlbum);
                }
            }

            return Albums;
        }//GetArists

        public List<MusicFile> GetSongs(bool pOrderNameAscending = true)
        {
            List<MusicFile> Songs = new List<MusicFile>();
            DataTable dt;

            dt = _MusicDBUtility.GetSongs(pOrderNameAscending);

            foreach (DataRow Row in dt.Rows)
            {
                if (Row.ItemArray.Length == 9)
                {
                    MusicFile NewFile = new MusicFile();
                    NewFile.ID = Convert.ToInt32(Row.ItemArray[0]);
                    NewFile.Name = Row.ItemArray[1].ToString();
                    NewFile.FilePath = Row.ItemArray[2].ToString();
                    NewFile.Track = Convert.ToInt32(Row.ItemArray[3]);
                    NewFile.Artist = Row.ItemArray[4].ToString();
                    NewFile.Album = Row.ItemArray[5].ToString();
                    NewFile.Genre = Row.ItemArray[6].ToString();
                    NewFile.Duration = Row.ItemArray[7].ToString();
                    NewFile.Rating = Convert.ToInt32(Row.ItemArray[8]);

                    Songs.Add(NewFile);
                }

            }

            return Songs;
        }//GetSongs

        public List<MusicFile> GetSongs(String pArtistName, bool pOrderNameAscending = true)
        {
            List<MusicFile> Songs = new List<MusicFile>();
            DataTable dt;

            dt = _MusicDBUtility.GetSongs(pArtistName, pOrderNameAscending);

            foreach (DataRow Row in dt.Rows)
            {
                if (Row.ItemArray.Length == 9)
                {
                    MusicFile NewFile = new MusicFile();
                    NewFile.ID = Convert.ToInt32(Row.ItemArray[0]);
                    NewFile.Name = Row.ItemArray[1].ToString();
                    NewFile.FilePath = Row.ItemArray[2].ToString();
                    NewFile.Track = Convert.ToInt32(Row.ItemArray[3]);
                    NewFile.Artist = Row.ItemArray[4].ToString();
                    NewFile.Album = Row.ItemArray[5].ToString();
                    NewFile.Genre = Row.ItemArray[6].ToString();
                    NewFile.Duration = Row.ItemArray[7].ToString();
                    NewFile.Rating = Convert.ToInt32(Row.ItemArray[8]);

                    Songs.Add(NewFile);
                }

            }

            return Songs;
        }//GetSongs

        public List<MusicFile> GetSongs(String pArtistName, String pAlbumName, bool pOrderNameAscending = true)
        {
            List<MusicFile> Songs = new List<MusicFile>();
            DataTable dt;

            dt = _MusicDBUtility.GetSongs(pArtistName, pAlbumName, pOrderNameAscending);

            foreach (DataRow Row in dt.Rows)
            {
                if (Row.ItemArray.Length == 9)
                {
                    MusicFile NewFile = new MusicFile();
                    NewFile.ID = Convert.ToInt32(Row.ItemArray[0]);
                    NewFile.Name = Row.ItemArray[1].ToString();
                    NewFile.FilePath = Row.ItemArray[2].ToString();
                    NewFile.Track = Convert.ToInt32(Row.ItemArray[3]);
                    NewFile.Artist = Row.ItemArray[4].ToString();
                    NewFile.Album = Row.ItemArray[5].ToString();
                    NewFile.Genre = Row.ItemArray[6].ToString();
                    NewFile.Duration = Row.ItemArray[7].ToString();
                    NewFile.Rating = Convert.ToInt32(Row.ItemArray[8]);

                    Songs.Add(NewFile);
                }

            }

            return Songs;
        }//GetSongs

        public List<MusicFile> GetSongsPerAlbum(String pAlbumName, bool pOrderNameAscending = true)
        {
            List<MusicFile> Songs = new List<MusicFile>();
            DataTable dt;

            dt = _MusicDBUtility.GetSongsPerAlbum(pAlbumName, pOrderNameAscending);

            foreach (DataRow Row in dt.Rows)
            {
                if (Row.ItemArray.Length == 9)
                {
                    MusicFile NewFile = new MusicFile();
                    NewFile.ID = Convert.ToInt32(Row.ItemArray[0]);
                    NewFile.Name = Row.ItemArray[1].ToString();
                    NewFile.FilePath = Row.ItemArray[2].ToString();
                    NewFile.Track = Convert.ToInt32(Row.ItemArray[3]);
                    NewFile.Artist = Row.ItemArray[4].ToString();
                    NewFile.Album = Row.ItemArray[5].ToString();
                    NewFile.Genre = Row.ItemArray[6].ToString();
                    NewFile.Duration = Row.ItemArray[7].ToString();
                    NewFile.Rating = Convert.ToInt32(Row.ItemArray[8]);

                    Songs.Add(NewFile);
                }

            }

            return Songs;
        }//GetSongs

#endregion

#region Playlist Management

        public void CreatePlaylist(String pNewPlaylistName)
        {
            _MusicDBUtility.CreatePlaylist(pNewPlaylistName);
        }//CreatePlaylist

        public void DeletePlaylist(String pPlaylistName)
        {
            _MusicDBUtility.DeletePlaylist(pPlaylistName);
        }//DeletePlaylist

        public List<String> GetPlaylists(bool pOrderNameAscending = true)
        {
            List<String> Playlists = new List<String>();
            DataTable dt;

            dt = _MusicDBUtility.GetPlaylists(pOrderNameAscending);

            foreach (DataRow Row in dt.Rows)
            {
                Playlists.Add(Row.ItemArray[0].ToString());
            }

            return Playlists;
        }//GetPlaylists

        public String GetDefaultPlaylist()
        {
            String DefaultPlaylist;

            DefaultPlaylist = _MusicDBUtility.GetDefaultPlaylist();

            return DefaultPlaylist;
        }//GetDefaultPlaylist

        public void SetDefaultPlaylist(String pPlaylistName)
        {
            _MusicDBUtility.SetDefaultPlaylist(pPlaylistName);
        }//SetDefaultPlaylist

        public void AddSongToPlaylist(String pPlaylistName, MusicFile SelectedSong)
        {
            _MusicDBUtility.AddSongToPlaylist(pPlaylistName, SelectedSong);
        }

        public List<MusicPlaylistFile> GetPlaylistPlaylistFiles(String pPlaylistName)
        {
            List<MusicPlaylistFile> Songs = new List<MusicPlaylistFile>();
            DataTable dt;

            dt = _MusicDBUtility.GetPlaylistSongs(pPlaylistName);

            foreach (DataRow Row in dt.Rows)
            {
                if (Row.ItemArray.Length == 9)
                {
                    MusicPlaylistFile NewFile = new MusicPlaylistFile();
                    NewFile.Order = Convert.ToInt32(Row.ItemArray[0]);
                    NewFile.SongID = Convert.ToInt32(Row.ItemArray[1]);
                    NewFile.Name = Row.ItemArray[2].ToString();
                    NewFile.FilePath = Row.ItemArray[3].ToString();
                    NewFile.Duration = Row.ItemArray[4].ToString();
                    NewFile.Rating = Convert.ToInt32(Row.ItemArray[5].ToString());
                    NewFile.Artist = Row.ItemArray[6].ToString();
                    NewFile.Album = Row.ItemArray[7].ToString();
                    NewFile.Genre = Row.ItemArray[8].ToString();

                    Songs.Add(NewFile);
                }

            }

            return Songs;
        }//GetPlaylistSongs

        public int GetPlaylistIndexSongID(String pPlaylistName, double pSongIndex)
        {
            int SongID = -1;

            SongID = _MusicDBUtility.GetPlaylistIndexSongID(pPlaylistName, pSongIndex);

            return SongID;
        }//GetPlaylistIndexsongID

        public void RemoveSongFromPlaylist(String pPlaylistName, int pSelectedSongID, int pSelectedSongOrderIndex)
        {
            _MusicDBUtility.RemoveSongFromPlaylist(pPlaylistName, pSelectedSongID, pSelectedSongOrderIndex);
        }//RemoveSongFromPlaylist

        public void ManagePlaylistMoveSongOrderUp(String pPlaylistName, int pSongID, double pCurrentSongOrder)
        {
            if (pCurrentSongOrder >= 2)
            {
                _MusicDBUtility.UpdatePlaylistSongOrder(pPlaylistName, pSongID, pCurrentSongOrder - 1.5, pCurrentSongOrder);
                _MusicDBUtility.RequalifyPlaylistSongOrdering(pPlaylistName);
            }
        }//UpdatePlaylistSongOrder

        public void ManagePlaylistMoveSongOrderDown(String pPlaylistName, int pSongID, double pCurrentSongOrder)
        {
            _MusicDBUtility.UpdatePlaylistSongOrder(pPlaylistName, pSongID, pCurrentSongOrder + 1.5, pCurrentSongOrder);
            _MusicDBUtility.RequalifyPlaylistSongOrdering(pPlaylistName);
        }//UpdatePlaylistSongOrder

        public void ManagePlaylistMoveSongToOrder(String pPlaylistName, int pSongID, double pCurrentSongOrder, double pNewSongOrder)
        {
            _MusicDBUtility.UpdatePlaylistSongOrder(pPlaylistName, pSongID, pNewSongOrder - 0.5, pCurrentSongOrder);
            _MusicDBUtility.RequalifyPlaylistSongOrdering(pPlaylistName);
        }//UpdatePlaylistSongOrder

        public List<MusicFile> GetPlaylistMusicFiles(String pPlaylistName)
        {
            List<MusicFile> Songs = new List<MusicFile>();

            DataTable dt;

            dt = _MusicDBUtility.GetPlaylistSongs(pPlaylistName);

            foreach (DataRow Row in dt.Rows)
            {
                if (Row.ItemArray.Length == 9)
                {
                    MusicFile NewFile = new MusicFile();
                    NewFile.ID = Convert.ToInt32(Row.ItemArray[1]);
                    NewFile.Name = Row.ItemArray[2].ToString();
                    NewFile.FilePath = Row.ItemArray[3].ToString();
                    NewFile.Track = -1;
                    NewFile.Artist = Row.ItemArray[6].ToString();
                    NewFile.Album = Row.ItemArray[7].ToString();
                    NewFile.Genre = Row.ItemArray[8].ToString();
                    NewFile.Duration = Row.ItemArray[4].ToString();
                    NewFile.Rating = Convert.ToInt32(Row.ItemArray[5]);


                    //MusicPlaylistFile NewFile = new MusicPlaylistFile();
                    //NewFile.Order = Convert.ToInt32(Row.ItemArray[0]);
                    //NewFile.SongID = Convert.ToInt32(Row.ItemArray[1]);
                    //NewFile.Name = Row.ItemArray[2].ToString();
                    //NewFile.FilePath = Row.ItemArray[3].ToString();
                    //NewFile.Duration = Row.ItemArray[4].ToString();
                    //NewFile.Rating = Convert.ToInt32(Row.ItemArray[5].ToString());
                    //NewFile.Artist = Row.ItemArray[6].ToString();
                    //NewFile.Album = Row.ItemArray[7].ToString();
                    //NewFile.Genre = Row.ItemArray[8].ToString();

                    Songs.Add(NewFile);
                }

            }

            return Songs;
        }//GetPlaylistMusicFiles

        

        public void UpdateSongRating(int pSongID, int pRating)
        {
            _MusicDBUtility.UpdateSongRating(pSongID, pRating);
        }//UpdateSongRating

#endregion

    }
}
