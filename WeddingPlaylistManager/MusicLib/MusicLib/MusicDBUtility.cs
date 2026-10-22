using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using System.Data;

namespace MusicLib
{
    class MusicDBUtility
    {

        public const int INVALIDVALUE = -1;
        public const String INVALIDSTRING = "";

        private DBCeUtility _DBCeUtility;
        //Note: SQL Compact does not support stored procedures.
        //Note: This is a simple program. We will ignore SQL injection prevention.

        public MusicDBUtility(String pSqlCeConnectionString)
        {
            _DBCeUtility = new DBCeUtility(pSqlCeConnectionString);
        }//Constructor

#region Add Components

        public void AddSong(String pName, String pFilePath, int pTrack, String pArtistName, String pAlbumName = INVALIDSTRING,
                            String pGenreName = INVALIDSTRING, String pDuration = INVALIDSTRING, int pRating = 0)
        {
            if (!ExistsSong(pName, pArtistName, pAlbumName))    //Only add the song if it doesnt already exist
            {
                int ArtistID = INVALIDVALUE;
                int AlbumID = INVALIDVALUE;
                int GenreID = INVALIDVALUE;
                bool FilePathValid = false;

                //Get the ArtistID from the Artist Name
                if (pArtistName != INVALIDSTRING)
                    ArtistID = GetArtistID(pArtistName);
                else
                    AlbumID = GetArtistID("Unknown");   //If does not exist, ArtistID = INVALIDVALUE still, can be checked later

                //Get the AlbumID from the Album Name
                if (pAlbumName != INVALIDSTRING)
                    AlbumID = GetAlbumID(pAlbumName);
                else
                    AlbumID = GetAlbumID("Unknown");    //If does not exist, AlbumID = INVALIDVALUE still, can be checked later

                //Get the GenreID from the Genre Name
                if (pGenreName != INVALIDSTRING)
                    GenreID = GetGenreID(pGenreName);
                else
                    GenreID = GetGenreID("Unknown");    //If does not exist, AlbumID = INVALIDVALUE still, can be checked later

                //Check that the file path is valid
                if (System.IO.File.Exists(pFilePath))
                    if (pFilePath.ToLower().Contains(".mp3"))
                        FilePathValid = true;
                    else
                        throw new MusicLibInvalidMusicFileException("Invalid music file inputted - Desc: Not an MP3 file.", pFilePath);
                else
                    throw new MusicLibInvalidSongParametersException("Song parameters are invalid", pName, pFilePath, ArtistID, AlbumID);

                //Verify all required values exist before we try to add the song. If not, do not add and throw exception
                if (pName != INVALIDSTRING && FilePathValid == true && ArtistID != INVALIDVALUE && AlbumID != INVALIDVALUE)
                    AddSong(pName, pFilePath, pTrack, ArtistID, AlbumID, GenreID, pDuration, pRating);
                else
                    throw new MusicLibInvalidSongParametersException("Song parameters are invalid", pName, pFilePath, ArtistID, AlbumID);
            }
            else
                throw new MusicLibSongAlreadyExistsException("Song already exists", pFilePath);
        }//AddSong

        public void AddSong(String pName, String pFilePath, int pTrack, int pArtistID, int pAlbumID,
                                int pGenreID, String pDuration, int pRating)
        {
            bool FilePathValid = false;

            //Check that the file path is valid
            if (System.IO.File.Exists(pFilePath))
                if (pFilePath.ToLower().Contains(".mp3"))
                    FilePathValid = true;
                else
                    throw new MusicLibInvalidMusicFileException("Invalid music file inputted - Desc: Not an MP3 file.", pFilePath);

            //Verify all song parameters are valid before we try to add it to the database
            if (pName == INVALIDSTRING || !FilePathValid || pArtistID == INVALIDVALUE || pAlbumID == INVALIDVALUE)
                throw new MusicLibInvalidSongParametersException("Song parameters are invalid", pName, pFilePath, pArtistID, pAlbumID);

            try
            {
                //Sanitize the strings to make sure they are valid for SQL syntax
                pName = _DBCeUtility.SantizeForSQL(pName);
                pFilePath = _DBCeUtility.SantizeForSQL(pFilePath);
                pDuration = _DBCeUtility.SantizeForSQL(pDuration);

                String SQL = "INSERT INTO tSongs (Name, FilePath, Track, ArtistID, AlbumID, GenreID, Duration, Rating) VALUES ('" +
                                pName + "','" + pFilePath + "'," + pTrack + "," + pArtistID + "," + pAlbumID + "," + pGenreID + ",'" + pDuration + "'," + pRating + ")";
                //_DBCeUtility.GetSqlCeCommand(SQL).ExecuteNonQuery();
                _DBCeUtility.ExecuteNonQuerySQL(SQL);
            }
            catch (Exception ex)
            {
                throw new MusicLibAddSongFailedException("Failed to add song to database - Desc: " + ex.Message, pName, pFilePath, pArtistID, pAlbumID);
            }
        }//AddSong


        public void AddArtist(String pArtistName)
        {
            if (!ExistsArtist(pArtistName)) //Only add the artist if it doesnt already exist
            {
                pArtistName = _DBCeUtility.SantizeForSQL(pArtistName);

                String SQL = "INSERT INTO tArtists (Name) VALUES ('" + pArtistName + "')";
                //_DBCeUtility.GetSqlCeCommand(SQL).ExecuteNonQuery();
                _DBCeUtility.ExecuteNonQuerySQL(SQL);
            }
        }//AddArtist

        public void AddGenre(String pGenreName, String pGenreDescription = "")
        {
            if (!ExistsGenre(pGenreName))   //Only add the genre if it doesnt already exist
            {
                pGenreName = _DBCeUtility.SantizeForSQL(pGenreName);
                pGenreDescription = _DBCeUtility.SantizeForSQL(pGenreDescription);

                String SQL = "INSERT INTO tGenres (Name, Description) VALUES ('" + pGenreName + "', '" + pGenreDescription + "')";
                //_DBCeUtility.GetSqlCeCommand(SQL).ExecuteNonQuery();
                _DBCeUtility.ExecuteNonQuerySQL(SQL);
            }
        }//AddGenre

        public void AddAlbum(String pAlbumName, int pAlbumYear = INVALIDVALUE, String pAlbumArtPath = INVALIDSTRING, String pAlbumDescription = INVALIDSTRING)
        {
            if (!ExistsAlbum(pAlbumName))   //Only add the album if it doesnt already exist
            {
                pAlbumName = _DBCeUtility.SantizeForSQL(pAlbumName);
                pAlbumArtPath = _DBCeUtility.SantizeForSQL(pAlbumArtPath);
                pAlbumDescription = _DBCeUtility.SantizeForSQL(pAlbumDescription);

                String SQL = "INSERT INTO tAlbums (Name, AlbumYear, AlbumArtPath, Description) VALUES ('" + pAlbumName + "'," + pAlbumYear + ",'" + pAlbumArtPath + "','" + pAlbumDescription + "')";
                //_DBCeUtility.GetSqlCeCommand(SQL).ExecuteNonQuery();
                _DBCeUtility.ExecuteNonQuerySQL(SQL);
            }
        }//AddGenre

#endregion

#region Get Components

        private int GetPlaylistID(String pPlaylistName)
        {
            int PlaylistID = INVALIDVALUE;

            pPlaylistName = _DBCeUtility.SantizeForSQL(pPlaylistName);

            String SQL = "SELECT ID FROM tPlaylists WHERE Name = '" + pPlaylistName + "'";
            //SqlCeResultSet rs = _DBCeUtility.GetSqlCeCommand(SQL).ExecuteResultSet(ResultSetOptions.Scrollable);
            SqlCeResultSet rs = _DBCeUtility.ExecuteQuerySQL(SQL);
            if (rs.HasRows)
            {
                rs.ReadFirst();
                PlaylistID = rs.GetInt32(0);
            }
            rs.Close();

            return PlaylistID;
        }//GetArtistID

        private int GetArtistID(String pArtistName)
        {
            int ArtistID = INVALIDVALUE;

            pArtistName = _DBCeUtility.SantizeForSQL(pArtistName);

            String SQL = "SELECT ID FROM tArtists WHERE Name = '" + pArtistName + "'";
            //SqlCeResultSet rs = _DBCeUtility.GetSqlCeCommand(SQL).ExecuteResultSet(ResultSetOptions.Scrollable);
            SqlCeResultSet rs = _DBCeUtility.ExecuteQuerySQL(SQL);
            if (rs.HasRows)
            {
                rs.ReadFirst();
                ArtistID = rs.GetInt32(0);
            }
            rs.Close();

            return ArtistID;
        }//GetArtistID

        public DataTable GetArtists(bool pOrderNameAscending = true)
        {
            DataTable dt = new DataTable();
            String SQLOrder;

            if (pOrderNameAscending)
                SQLOrder = "ASC";
            else
                SQLOrder = "DESC";

            String SQL = "SELECT Name FROM tArtists ORDER BY Name " + SQLOrder;
            SqlCeResultSet rs = _DBCeUtility.ExecuteQuerySQL(SQL);
            if (rs.HasRows)
            {
                dt.Load(rs);
            }
            rs.Close();

            return dt;
        }//GetArtists

        public DataTable GetArtists(String pGenreName, bool pOrderNameAscending = true)
        {
            DataTable dt = new DataTable();
            String SQLOrder;
            int GenreID = GetGenreID(pGenreName);

            if (pOrderNameAscending)
                SQLOrder = "ASC";
            else
                SQLOrder = "DESC";

            String SQL = "SELECT Name FROM tArtists WHERE ID IN(SELECT DISTINCT(ArtistID) FROM tSongs WHERE GenreID = " + GenreID + ")"
                                + " ORDER BY Name " + SQLOrder;
            SqlCeResultSet rs = _DBCeUtility.ExecuteQuerySQL(SQL);
            if (rs.HasRows)
            {
                dt.Load(rs);
            }
            rs.Close();

            return dt;
        }//GetArtists

        private int GetGenreID(String pGenreName)
        {
            int GenreID = INVALIDVALUE;

            pGenreName = _DBCeUtility.SantizeForSQL(pGenreName);

            String SQL = "SELECT ID FROM tGenres WHERE Name='" + pGenreName + "'";
            //SqlCeResultSet rs = _DBCeUtility.GetSqlCeCommand(SQL).ExecuteResultSet(ResultSetOptions.Scrollable);
            SqlCeResultSet rs = _DBCeUtility.ExecuteQuerySQL(SQL);
            if (rs.HasRows)
            {
                rs.ReadFirst();
                GenreID = rs.GetInt32(0);
            }
            rs.Close();

            return GenreID;
        }//GetGenreID

        public DataTable GetGenres(bool pOrderNameAscending = true)
        {
            DataTable dt = new DataTable();
            String SQLOrder;

            if (pOrderNameAscending)
                SQLOrder = "ASC";
            else
                SQLOrder = "DESC";

            String SQL = "SELECT Name FROM tGenres ORDER BY Name " + SQLOrder;
            SqlCeResultSet rs = _DBCeUtility.ExecuteQuerySQL(SQL);
            if (rs.HasRows)
            {
                dt.Load(rs);
            }
            rs.Close();

            return dt;
        }//GetGenres

        private int GetAlbumID(String pAlbumName)
        {
            int AlbumID = INVALIDVALUE;

            pAlbumName = _DBCeUtility.SantizeForSQL(pAlbumName);

            String SQL = "SELECT ID FROM tAlbums WHERE Name='" + pAlbumName + "'";
            //SqlCeResultSet rs = _DBCeUtility.GetSqlCeCommand(SQL).ExecuteResultSet(ResultSetOptions.Scrollable);
            SqlCeResultSet rs = _DBCeUtility.ExecuteQuerySQL(SQL);
            if (rs.HasRows)
            {
                rs.ReadFirst();
                AlbumID = rs.GetInt32(0);
            }
            rs.Close();

            return AlbumID;
        }//GetGenreID


        public DataTable GetAlbums(bool pOrderNameAscending = true)
        {
            DataTable dt = new DataTable();
            String SQLOrder;

            if (pOrderNameAscending)
                SQLOrder = "ASC";
            else
                SQLOrder = "DESC";

            String SQL = "SELECT Name, AlbumYear, AlbumArtPath, Description FROM tAlbums ORDER BY AlbumYear " + SQLOrder;
            SqlCeResultSet rs = _DBCeUtility.ExecuteQuerySQL(SQL);
            if (rs.HasRows)
            {
                dt.Load(rs);
            }
            rs.Close();

            return dt;
        }//GetAlbums

        public DataTable GetAlbums(String pArtistName, bool pOrderNameAscending = true)
        {
            DataTable dt = new DataTable();
            String SQLOrder;
            int ArtistID = GetArtistID(pArtistName);

            if (pOrderNameAscending)
                SQLOrder = "ASC";
            else
                SQLOrder = "DESC";

            String SQL = "SELECT Name, AlbumYear, AlbumArtPath, Description FROM tAlbums WHERE ID IN(SELECT DISTINCT(AlbumID) FROM tSongs WHERE ArtistID = " + ArtistID + ")"
                                + " ORDER BY AlbumYear " + SQLOrder;
            SqlCeResultSet rs = _DBCeUtility.ExecuteQuerySQL(SQL);
            if (rs.HasRows)
            {
                dt.Load(rs);
            }
            rs.Close();

            return dt;
        }//GetAlbums

        private int GetSongID(String pSongName, String pArtistName, String pAlbumName)
        {
            int SongID = INVALIDVALUE;
            int ArtistID = INVALIDVALUE;
            int AlbumID = INVALIDVALUE;

            ArtistID = GetArtistID(pArtistName);
            AlbumID = GetAlbumID(pAlbumName);

            pSongName = _DBCeUtility.SantizeForSQL(pSongName);

            String SQL = "SELECT ID FROM tSongs WHERE Name='" + pSongName + "' AND ArtistID=" + ArtistID + " AND AlbumID=" + AlbumID;
            //SqlCeResultSet rs = _DBCeUtility.GetSqlCeCommand(SQL).ExecuteResultSet(ResultSetOptions.Scrollable);
            SqlCeResultSet rs = _DBCeUtility.ExecuteQuerySQL(SQL);
            if (rs.HasRows)
            {
                rs.ReadFirst();
                SongID = rs.GetInt32(0);
            }
            rs.Close();

            return SongID;
        }//GetSongID

        public DataTable GetSongs(bool pOrderNameAscending = true)
        {
            DataTable dt = new DataTable();
            String SQLOrder;

            if (pOrderNameAscending)
                SQLOrder = "ASC";
            else
                SQLOrder = "DESC";

            //String SQL = "SELECT ID, Name, FilePath, Track, ArtistID, AlbumID, GenreID, Duration, Rating FROM tSongs ORDER BY Track " + SQLOrder;
            String SQL = "SELECT a.ID, a.Name, a.FilePath, a.Track, b.Name, c.Name, d.Name, a.Duration, a.Rating " +
                            "FROM tSongs a " +
                            "LEFT JOIN tArtists b " +
                            "ON a.ArtistID = b.ID " +
                            "LEFT JOIN tAlbums c " +
                            "ON a.AlbumID = c.ID " +
                            "LEFT JOIN tGenres d " +
                            "ON a.GenreID = d.ID " +
                            "ORDER BY a.ArtistID " + SQLOrder + ", a.AlbumID " + SQLOrder + ", a.Track " + SQLOrder;
            SqlCeResultSet rs = _DBCeUtility.ExecuteQuerySQL(SQL);
            if (rs.HasRows)
            {
                dt.Load(rs);
            }
            rs.Close();

            return dt;
        }//GetSongs

        public DataTable GetSongs(String pArtistName, bool pOrderNameAscending = true)
        {
            DataTable dt = new DataTable();
            String SQLOrder;
            int ArtistID = GetArtistID(pArtistName);

            if (pOrderNameAscending)
                SQLOrder = "ASC";
            else
                SQLOrder = "DESC";

            //String SQL = "SELECT ID, Name, FilePath, Track, ArtistID, AlbumID, GenreID, Duration, Rating FROM tSongs WHERE ArtistID = " + ArtistID + " ORDER BY Track " + SQLOrder;
            String SQL = "SELECT a.ID, a.Name, a.FilePath, a.Track, b.Name, c.Name, d.Name, a.Duration, a.Rating " +
                            "FROM tSongs a " +
                            "LEFT JOIN tArtists b " +
                            "ON a.ArtistID = b.ID " +
                            "LEFT JOIN tAlbums c " +
                            "ON a.AlbumID = c.ID " +
                            "LEFT JOIN tGenres d " +
                            "ON a.GenreID = d.ID " +
                            "WHERE a.ArtistID = " + ArtistID + " ORDER BY a.AlbumID " + SQLOrder + ", a.Track " + SQLOrder;
            
            
            
            SqlCeResultSet rs = _DBCeUtility.ExecuteQuerySQL(SQL);
            if (rs.HasRows)
            {
                dt.Load(rs);
            }
            rs.Close();

            return dt;
        }//GetSongs

        public DataTable GetSongs(String pArtistName, String pAlbumName, bool pOrderNameAscending = true)
        {
            DataTable dt = new DataTable();
            String SQLOrder;
            int ArtistID = GetArtistID(pArtistName);
            int AlbumID = GetAlbumID(pAlbumName);

            if (pOrderNameAscending)
                SQLOrder = "ASC";
            else
                SQLOrder = "DESC";

            //String SQL = "SELECT ID, Name, FilePath, Track, ArtistID, AlbumID, GenreID, Duration, Rating FROM tSongs WHERE ArtistID = " + ArtistID + 
            //                    " AND AlbumID = " + AlbumID + " ORDER BY Track " + SQLOrder;
            String SQL = "SELECT a.ID, a.Name, a.FilePath, a.Track, b.Name, c.Name, d.Name, a.Duration, a.Rating " +
                            "FROM tSongs a " +
                            "LEFT JOIN tArtists b " +
                            "ON a.ArtistID = b.ID " +
                            "LEFT JOIN tAlbums c " +
                            "ON a.AlbumID = c.ID " +
                            "LEFT JOIN tGenres d " +
                            "ON a.GenreID = d.ID " +
                            "WHERE a.ArtistID = " + ArtistID + " AND a.AlbumID = " + AlbumID + " ORDER BY a.AlbumID " + SQLOrder + ", a.Track " + SQLOrder;
            SqlCeResultSet rs = _DBCeUtility.ExecuteQuerySQL(SQL);
            if (rs.HasRows)
            {
                dt.Load(rs);
            }
            rs.Close();

            return dt;
        }//GetSongs

        public DataTable GetSongsPerAlbum(String pAlbumName, bool pOrderNameAscending = true)
        {
            DataTable dt = new DataTable();
            String SQLOrder;
            int AlbumID = GetAlbumID(pAlbumName);

            if (pOrderNameAscending)
                SQLOrder = "ASC";
            else
                SQLOrder = "DESC";

            //String SQL = "SELECT ID, Name, FilePath, Track, ArtistID, AlbumID, GenreID, Duration, Rating FROM tSongs WHERE AlbumID = " + AlbumID + " ORDER BY ArtistID " + SQLOrder + ", Track " + SQLOrder;
            String SQL = "SELECT a.ID, a.Name, a.FilePath, a.Track, b.Name, c.Name, d.Name, a.Duration, a.Rating " +
                            "FROM tSongs a " +
                            "LEFT JOIN tArtists b " +
                            "ON a.ArtistID = b.ID " +
                            "LEFT JOIN tAlbums c " +
                            "ON a.AlbumID = c.ID " +
                            "LEFT JOIN tGenres d " +
                            "ON a.GenreID = d.ID " +
                            "WHERE a.AlbumID = " + AlbumID + " ORDER BY a.ArtistID " + SQLOrder + ", a.AlbumID " + SQLOrder + ", a.Track " + SQLOrder;
            SqlCeResultSet rs = _DBCeUtility.ExecuteQuerySQL(SQL);
            if (rs.HasRows)
            {
                dt.Load(rs);
            }
            rs.Close();

            return dt;
        }//GetSongs

#endregion

#region Exists Components

        public bool ExistsPlaylist(String pPlaylistName)
        {
            bool Exists = false;

            int ID = GetPlaylistID(pPlaylistName);
            if (ID != INVALIDVALUE)
                Exists = true;

            return Exists;
        }//ExistsGenre

        public bool ExistsGenre(String pGenreName)
        {
            bool Exists = false;

            int ID = GetGenreID(pGenreName);
            if (ID != INVALIDVALUE)
                Exists = true;

            return Exists;
        }//ExistsGenre

        public bool ExistsArtist(String pArtistName)
        {
            bool Exists = false;

            int ID = GetArtistID(pArtistName);
            if (ID != INVALIDVALUE)
                Exists = true;

            return Exists;
        }//ExistsArtist

        public bool ExistsAlbum(String pAlbumName)
        {
            bool Exists = false;

            int ID = GetAlbumID(pAlbumName);
            if (ID != INVALIDVALUE)
                Exists = true;

            return Exists;
        }//ExistsAlbum


        public bool ExistsSong(String pSongName, String pArtistName, String pAlbumName)
        {
            bool Exists = false;

            int ID = GetSongID(pSongName, pArtistName, pAlbumName);
            if (ID != INVALIDVALUE)
                Exists = true;

            return Exists;
        }//ExistsGenre

#endregion

#region Playlist Management

        public void CreatePlaylist(String pNewPlaylistName)
        {
            if (!ExistsPlaylist(pNewPlaylistName))   //Only add the playlist if it doesnt already exist
            {
                pNewPlaylistName = _DBCeUtility.SantizeForSQL(pNewPlaylistName);

                String SQL = "INSERT INTO tPlaylists (Name) VALUES ('" + pNewPlaylistName + "')";
                _DBCeUtility.ExecuteNonQuerySQL(SQL);
            }
            else
                throw new MusicLibPlaylistAlreadyExistsException("Playlist already exists.", pNewPlaylistName);
        }//CreatePlaylist

        public void DeletePlaylist(String pPlaylistName)
        {
            if (ExistsPlaylist(pPlaylistName))  //Only attempt to delete the playlist if it exists
            {
                pPlaylistName = _DBCeUtility.SantizeForSQL(pPlaylistName);

                //First delete all songs of the playlist from tPlaylistSongs
                int PlaylistID = GetPlaylistID(pPlaylistName);
                String SQL = "DELETE FROM tPlaylistSongs WHERE PlaylistID = " + PlaylistID;
                _DBCeUtility.ExecuteNonQuerySQL(SQL);

                //Then delete the playlist itself from tPlaylists
                SQL = "DELETE FROM tPlaylists WHERE ID = " + PlaylistID;
                _DBCeUtility.ExecuteNonQuerySQL(SQL);
            }
            else
                throw new MusicLibPlaylistDoesNotExistException("Playlist does not exist.", pPlaylistName);
        }//DeletePlaylist

        public DataTable GetPlaylists(bool pOrderNameAscending)
        {
            DataTable dt = new DataTable();
            String SQLOrder;

            if (pOrderNameAscending)
                SQLOrder = "ASC";
            else
                SQLOrder = "DESC";

            String SQL = "SELECT Name FROM tPlaylists ORDER BY Name " + SQLOrder;
            SqlCeResultSet rs = _DBCeUtility.ExecuteQuerySQL(SQL);
            if (rs.HasRows)
            {
                dt.Load(rs);
            }
            rs.Close();

            return dt;
        }//GetPlaylists

        public String GetDefaultPlaylist()
        {
            String DefaultPlaylist = INVALIDSTRING;
            try
            {
                String SQL = "SELECT Name FROM tPlaylists WHERE DefaultList = 1";
                //SqlCeResultSet rs = _DBCeUtility.GetSqlCeCommand(SQL).ExecuteResultSet(ResultSetOptions.Scrollable);
                SqlCeResultSet rs = _DBCeUtility.ExecuteQuerySQL(SQL);
                if (rs.HasRows)
                {
                    rs.ReadFirst();
                    DefaultPlaylist = rs.GetString(0);
                }
                else
                {
                    SQL = "SELECT Name FROM tPlaylists";
                    //SqlCeResultSet rs = _DBCeUtility.GetSqlCeCommand(SQL).ExecuteResultSet(ResultSetOptions.Scrollable);
                    rs = _DBCeUtility.ExecuteQuerySQL(SQL);
                    if (rs.HasRows)
                    {
                        rs.ReadFirst();
                        DefaultPlaylist = rs.GetString(0);
                    }
                    else
                        DefaultPlaylist = "";
                }
                rs.Close();
            }
            catch (Exception)
            {
                DefaultPlaylist = "";
            }

            return DefaultPlaylist;
        }//GetDefaultPlaylist

        public void SetDefaultPlaylist(String pPlaylistName)
        {
            if (ExistsPlaylist(pPlaylistName))   //Only add the genre if it doesnt already exist
            {
                pPlaylistName = _DBCeUtility.SantizeForSQL(pPlaylistName);

                //Update the current default playlist to no longer be the default playlist
                String SQL = "UPDATE tPlaylists SET DefaultList=0 WHERE DefaultList=1";
                _DBCeUtility.ExecuteNonQuerySQL(SQL);

                //Update the inputted playlist to be the current default playlist
                SQL = "UPDATE tPlaylists SET DefaultList=1 WHERE Name='" + pPlaylistName + "'";
                _DBCeUtility.ExecuteNonQuerySQL(SQL);
            }
            else
                throw new MusicLibPlaylistDoesNotExistException("Playlist does not exist.", pPlaylistName);
        }//SetDefaultPlaylist

        public void AddSongToPlaylist(String pPlaylistName, MusicFile pSelectedSong)
        {
            int PlaylistID = GetPlaylistID(pPlaylistName);
            int SongID, OrderNum = 0;

            //Get the song ID, if no song ID exists in music file object, go get it from the database
            if (pSelectedSong.ID > 0)
                SongID = pSelectedSong.ID;
            else
                SongID = GetSongID(pSelectedSong.Name, pSelectedSong.Artist, pSelectedSong.Album);

            if (PlaylistID > 0 && SongID > 0)
            {

                OrderNum = GetNextPlaylistOrderNum(PlaylistID);

                String SQL = "INSERT INTO tPlaylistSongs (PlaylistID, OrderNum, SongID) VALUES (" + PlaylistID + "," + OrderNum + "," + SongID + ")";
                _DBCeUtility.ExecuteNonQuerySQL(SQL);
            }
            else
                throw new MusicLibFailedPlaylistAddException("Failed to add song to playlist.", pPlaylistName, pSelectedSong.Name);
        }

        public int GetPlaylistIndexSongID(String pPlaylistName, double pSongIndex)
        {
            int SongID = -1;
            int PlaylistID = -1;

            pPlaylistName = _DBCeUtility.SantizeForSQL(pPlaylistName);

            PlaylistID = GetPlaylistID(pPlaylistName);

            String SQL = "SELECT SongID FROM tPlaylistSongs WHERE PlaylistID = " + PlaylistID + " AND OrderNum = " + pSongIndex;
            //SongID = _DBCeUtility.ExecuteQuerySQL(SQL);
            SqlCeResultSet rs = _DBCeUtility.ExecuteQuerySQL(SQL);
            if (rs.HasRows)
            {
                rs.ReadFirst();
                SongID = rs.GetInt32(0);
            }
            else
                throw new MusicLibSongDoesNotExistInPlaylist("Song index does not exist in playlist: " + pSongIndex, pPlaylistName);
            rs.Close();

            return SongID;
        }//GetPlaylistIndexsongID

        public void RemoveSongFromPlaylist(String pPlaylistName, int pSelectedSongID, int pSelectedSongOrderIndex)
        {
            int PlaylistID = -1;

            pPlaylistName = _DBCeUtility.SantizeForSQL(pPlaylistName);

            PlaylistID = GetPlaylistID(pPlaylistName);

            //First remove the song from the playlist
            String SQL = "DELETE FROM tPlaylistSongs WHERE PlaylistID = " + PlaylistID + " AND SongID = " + pSelectedSongID + " AND OrderNum = " + pSelectedSongOrderIndex;
            _DBCeUtility.ExecuteNonQuerySQL(SQL);

            //Then decrement all songs in the playlist after the removed song so the playlist order IDs are still sequential
            //This will be done by "ReQualifying" the PlaylistOrdering to make sure the ordering is sequential and in good standing
            RequalifyPlaylistSongOrdering(pPlaylistName);

        }//RemoveSongFromPlaylist

        public void UpdatePlaylistSongOrder(String pPlaylistName, int pSongID, double pNewSongOrder, double pCurrentSongOrder)
        {
            int PlaylistID = -1;

            pPlaylistName = _DBCeUtility.SantizeForSQL(pPlaylistName);

            PlaylistID = GetPlaylistID(pPlaylistName);

            //First remove the song from the playlist
            String SQL = "UPDATE tPlaylistSongs SET OrderNum = " + pNewSongOrder + " WHERE PlaylistID = " + PlaylistID + " AND SongID = "
                                + pSongID + " AND OrderNum = " + pCurrentSongOrder;
            _DBCeUtility.ExecuteNonQuerySQL(SQL);

        }//UpdatePlaylistSongOrder

        //Requalifying the song order of a playlist will involve ensuring the ordering number of songs in a playlist are sequential and
        //in 'Good Standing'. This one function will allow easy modification of the song ordering of a playlist.
        public void RequalifyPlaylistSongOrdering(String pPlaylistName)
        {
            int PlaylistID = -1;
            int CurrentSongID = -1;
            double CurrentSongOrderNum = -1;
            int SongCounter = 0;

            pPlaylistName = _DBCeUtility.SantizeForSQL(pPlaylistName);
            PlaylistID = GetPlaylistID(pPlaylistName);

            DataTable dt = GetPlaylistSongs(pPlaylistName);

            foreach (DataRow Row in dt.Rows)
            {
                if (Row.ItemArray.Length == 9)
                {
                    CurrentSongID = Convert.ToInt32(Row.ItemArray[1]);
                    CurrentSongOrderNum = Convert.ToDouble(Row.ItemArray[0]);
                    SongCounter += 1;
                    UpdatePlaylistSongOrderNumber(pPlaylistName, CurrentSongID, CurrentSongOrderNum, SongCounter);
               
                    //MusicFile NewFile = new MusicFile();
                    //NewFile.ID = Convert.ToInt32(Row.ItemArray[1]);
                    //NewFile.Name = Row.ItemArray[2].ToString();
                    //NewFile.FilePath = Row.ItemArray[3].ToString();
                    //NewFile.Track = -1;
                    //NewFile.Artist = Row.ItemArray[6].ToString();
                    //NewFile.Album = Row.ItemArray[7].ToString();
                    //NewFile.Genre = Row.ItemArray[8].ToString();
                    //NewFile.Duration = Row.ItemArray[4].ToString();
                    //NewFile.Rating = Convert.ToInt32(Row.ItemArray[5]);

                }

            }


        }//RequalifyPlaylistSongOrdering

        public void UpdatePlaylistSongOrderNumber(String pPlaylistName, int pSongID, double pSongOrderNum, double pNewSongOrderNum)
        {
            //Only attempt to update the row if the order number is different than current
            if( pSongOrderNum != pNewSongOrderNum)
            {
                int PlaylistID = -1;

                pPlaylistName = _DBCeUtility.SantizeForSQL(pPlaylistName);

                PlaylistID = GetPlaylistID(pPlaylistName);

                //First remove the song from the playlist
                String SQL = "UPDATE tPlaylistSongs SET OrderNum = " + pNewSongOrderNum + " WHERE PlaylistID = " + PlaylistID + 
                                " AND SongID = " + pSongID + " AND OrderNum = " + pSongOrderNum;
                _DBCeUtility.ExecuteNonQuerySQL(SQL);
            }

        }//UpdatePlaylistSongOrderNumber

        public int GetNextPlaylistOrderNum(int PlaylistID)
        {
            int OrderNum = 0;

            String SQL = "SELECT TOP(1) OrderNum FROM tPlaylistSongs WHERE PlaylistID=" + PlaylistID + " ORDER BY OrderNum DESC";
            SqlCeResultSet rs = _DBCeUtility.ExecuteQuerySQL(SQL);
            if (rs.HasRows)
            {
                rs.ReadFirst();
                OrderNum = rs.GetInt32(0);
            }
            rs.Close();

            //Increment OrderNum to get to the next order
            OrderNum += 1;

            return OrderNum;
        }//GetNextPlaylistOrderNum

        public DataTable GetPlaylistSongs(String pPlaylistName)
        {
            DataTable dt = new DataTable();
            int PlaylistID = GetPlaylistID(pPlaylistName);

            String SQL = "SELECT a.OrderNum, b.ID, b.Name, b.FilePath, b.Duration, b.Rating, c.Name, d.Name, e.Name " +
                            "FROM tPlaylistSongs a " +
                            "LEFT JOIN tSongs b " +
                            "ON b.ID = a.SongID " +
                            "LEFT JOIN tArtists c " +
                            "ON c.ID = b.ArtistID " +
                            "LEFT JOIN tAlbums d " +
                            "ON d.ID = b.AlbumID " +
                            "LEFT JOIN tGenres e " +
                            "ON e.ID = b.GenreID " + 
                            "WHERE a.PlaylistID = " + PlaylistID +
                            "ORDER BY a.OrderNum";

            SqlCeResultSet rs = _DBCeUtility.ExecuteQuerySQL(SQL);
            if (rs.HasRows)
            {
                dt.Load(rs);
            }
            rs.Close();

            return dt;
        }//GetSongs

        public void UpdateSongRating(int pSongID, int pRating)
        {
            //if (!ExistsSong(pSongID)) //Only add the artist if it doesnt already exist
            //{

                String SQL = "UPDATE tSongs SET Rating=" + pRating + " WHERE ID=" + pSongID;
                //_DBCeUtility.GetSqlCeCommand(SQL).ExecuteNonQuery();
                _DBCeUtility.ExecuteNonQuerySQL(SQL);
            //}
        }//UpdateSongRating

#endregion

    }
}
