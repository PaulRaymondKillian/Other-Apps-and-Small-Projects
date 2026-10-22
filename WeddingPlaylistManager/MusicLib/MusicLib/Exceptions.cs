using System;

[Serializable]
public class MusicLibInvalidSongParametersException : Exception 
{
    public MusicLibInvalidSongParametersException(string message, String pSongName, String pFilePath, int pArtistID, int pAlbumID)
        : base(message) 
    {
        SongName = pSongName;
        FilePath = pFilePath;
        ArtistID = pArtistID;
        AlbumID = pAlbumID;
    } 
    
    public String SongName { get; private set; }
    public String FilePath { get; private set; }
    public int ArtistID { get; private set; }
    public int AlbumID { get; private set; }
}

[Serializable]
public class MusicLibAddSongFailedException : Exception
{
    public MusicLibAddSongFailedException(string message, String pSongName, String pFilePath, int pArtistID, int pAlbumID)
        : base(message)
    {
        SongName = pSongName;
        FilePath = pFilePath;
        ArtistID = pArtistID;
        AlbumID = pAlbumID;
    }

    public String SongName { get; private set; }
    public String FilePath { get; private set; }
    public int ArtistID { get; private set; }
    public int AlbumID { get; private set; }
}

[Serializable]
public class MusicLibInvalidMusicFileException : Exception
{
    public MusicLibInvalidMusicFileException(string message, String pFilePath)
        : base(message)
    {
        FilePath = pFilePath;
    }

    public String FilePath { get; private set; }
}

[Serializable]
public class MusicLibFailedToInitTagsException : Exception
{
    public MusicLibFailedToInitTagsException(string message, String pFilePath)
        : base(message)
    {
        FilePath = pFilePath;
    }

    public String FilePath { get; private set; }
}

[Serializable]
public class MusicLibFailedToGetTagsException : Exception
{
    public MusicLibFailedToGetTagsException(string message, String pFilePath, String pTitle, String pArtist, String pAlbum, 
                                                String pGenre, String pDuration, int pYear, String pAlbumArtPath)
        : base(message)
    {
        FilePath = pFilePath;
        Title = pTitle;
        Artist = pArtist;
        Album = pAlbum;
        Genre = pGenre;
        Duration = pDuration;
        Year = pYear;
        AlbumArtPath = pAlbumArtPath;
    }

    public String FilePath { get; private set; }
    public String Title { get; private set; }
    public String Artist { get; private set; }
    public String Album { get; private set; }
    public String Genre { get; private set; }
    public String Duration { get; private set; }
    public int Year { get; private set; }
    public String AlbumArtPath { get; private set; }

}

[Serializable]
public class MusicLibSongAlreadyExistsException : Exception
{
    public MusicLibSongAlreadyExistsException(string message, String pFilePath)
        : base(message)
    {
        FilePath = pFilePath;
    }

    public String FilePath { get; private set; }
}

[Serializable]
public class MusicLibPlaylistAlreadyExistsException : Exception
{
    public MusicLibPlaylistAlreadyExistsException(string message, String pPlaylistName)
        : base(message)
    {
        PlaylistName = pPlaylistName;
    }

    public String PlaylistName { get; private set; }
}

[Serializable]
public class MusicLibPlaylistDoesNotExistException : Exception
{
    public MusicLibPlaylistDoesNotExistException(string message, String pPlaylistName)
        : base(message)
    {
        PlaylistName = pPlaylistName;
    }

    public String PlaylistName { get; private set; }
}

[Serializable]
public class MusicLibFailedPlaylistAddException : Exception
{
    public MusicLibFailedPlaylistAddException(string message, String pPlaylistName, String pSongName)
        : base(message)
    {
        PlaylistName = pPlaylistName;
        SongName = pSongName;
    }

    public String PlaylistName { get; private set; }
    public String SongName { get; private set; }
}

[Serializable]
public class MusicLibSongDoesNotExistInPlaylist : Exception
{
    public MusicLibSongDoesNotExistInPlaylist(string message, String pPlaylistName)
        : base(message)
    {
        PlaylistName = pPlaylistName;
    }

    public String PlaylistName { get; private set; }
}