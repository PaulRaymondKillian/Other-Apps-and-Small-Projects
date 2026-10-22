using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicLib
{
    public class MusicAlbum
    {
        public String Name;
        public String AlbumArtPath;
        public int Year;
        public String AlbumDescription;

        public MusicAlbum()
        {
        }//Default Constructor

        public MusicAlbum(String pName, String pAlbumArtPath="", int pYear=0, String pAlbumDescription="")
        {
            Name = pName;
            AlbumArtPath = pAlbumArtPath;
            Year = pYear;
            AlbumDescription = pAlbumDescription;
            
        }//Constructor

        ~MusicAlbum()
        {
        }//Destructor
    }
}
