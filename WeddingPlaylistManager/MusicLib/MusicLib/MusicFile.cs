using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TagLib;

namespace MusicLib
{
    public struct MusicPlaylistFile
    {
        public int SongID;
        public int Order;
        public String FilePath;
        public String Name;
        public int Track;
        public String Artist;
        public String Album;
        public String Genre;
        public String Duration;
        public int Year;
        public String AlbumArtPath;
        public int Rating;
    }//STRUCT MusicPlaylistFile


    public class MusicFile
    {
        public int ID;
        public String FilePath;
        public String Name;
        public int Track;
        public String Artist;
        public String Album;
        public String Genre;
        public String Duration;
        public int Year;
        public String AlbumArtPath;
        public int Rating;

        public MusicFile()
        {
        }//Default Constructor

        public MusicFile(String pFilePath)
        {
            TagLib.File f;
            try
            { f = TagLib.File.Create(pFilePath); }
            catch (Exception ex)
            { throw new MusicLibFailedToInitTagsException(ex.Message, pFilePath); }

            try
            {
                FilePath = pFilePath;
                Name = GetTitle(f);
                Track = GetTrack(f);
                Artist = GetArtist(f);
                Album = GetAlbum(f);
                Genre = GetGenre(f);
                Duration = GetDuration(f);
                Year = GetYear(f);
                AlbumArtPath = GetAlbumArtPath(f);
            }
            catch (Exception ex)
            { throw new MusicLibFailedToGetTagsException(ex.Message, FilePath, Name, Artist, Album, Genre, Duration, Year, AlbumArtPath); }

            if (f == null || Name == null || Album == null || Genre == null || Duration == null || Year == null) //Year == null is always false.... look into this again or something I guess....XXXXXXX
                Console.WriteLine("!!!!!!");
        }//Constructor

        ~MusicFile()
        {
        }//Destructor

        private String GetTitle(TagLib.File pTagLibFile)
        {
            String Title;

            Title = pTagLibFile.Tag.Title;
            if (Title == null)
                Title = ParseSongNameFromFilePath(pTagLibFile);

            return Title;
        }//GetTitle

        private String ParseSongNameFromFilePath(TagLib.File pTagLibFile)
        {
            String SongName = "Unknown";
            String[] Split;

            Split = pTagLibFile.Name.Split('\\');
            if (Split.Length > 0)
            {
                Split = Split[Split.Length - 1].Split('.');
                if (Split.Length > 0)
                    SongName = Split[0];
            }
            

            return SongName;
        }//ParseSongNameFromFilePath

        private int GetTrack(TagLib.File pTagLibFile)
        {
            int Track;

            if (pTagLibFile.Tag.Track > 0)
                Track = Convert.ToInt32(pTagLibFile.Tag.Track);
            else
                Track = -1;

            return Track;
        }//GetTrack

        //Get the artist of the song, using different methods if the main fields are blank
        private String GetArtist(TagLib.File pTagLibFile)
        {
            String Artist;
            if (pTagLibFile.Tag.AlbumArtists.Length > 0)
                Artist = pTagLibFile.Tag.AlbumArtists[0];
            else if (pTagLibFile.Tag.Performers.Length > 0)
                Artist = pTagLibFile.Tag.Performers[0];
            else if (pTagLibFile.Tag.Artists.Length > 0)
                Artist = pTagLibFile.Tag.Artists[0];
            else
                Artist = "Unknown";

            return Artist;
        }//GetArtist

        private String GetGenre(TagLib.File pTagLibFile)
        {
            String Genre;
            if (pTagLibFile.Tag.Genres.Length > 0)
                Genre = pTagLibFile.Tag.Genres[0];
            else
                Genre = "Unknown";

            return Genre;
        }//GetGenre

        private String GetAlbum(TagLib.File pTagLibFile)
        {
            String Album = "";

            if (pTagLibFile.Tag.Album != null && pTagLibFile.Tag.Album.Length > 0)
                Album = pTagLibFile.Tag.Album;
            else
                Album = "None";

            return Album;
        }//GetAlbum

        private String GetDuration(TagLib.File pTagLibFile)
        {
            String Duration;

            try
            {
                Duration = pTagLibFile.Properties.Duration.Minutes + ":" + pTagLibFile.Properties.Duration.Seconds.ToString().PadLeft(2, '0');
            }
            catch
            {
                Duration = "";
            }

            return Duration;
        }//GetDuration

        private int GetYear(TagLib.File pTagLibFile)
        {
            int Year = Convert.ToInt32(pTagLibFile.Tag.Year);
            return Year;
        }//GetDuration

        private String GetAlbumArtPath(TagLib.File pTagLibFile)
        {
            String AlbumArtPath = "";

            //if (pTagLibFile.Tag.Pictures.Length > 0)
            //    AlbumArtPath = pTagLibFile.Tag.Pictures[0];

            return AlbumArtPath;
        }//GetAlbum
    }
}
