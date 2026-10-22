using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace TestHarness
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            //stopwatch.Start();
            
            String ConnString = ConfigurationManager.ConnectionStrings["MusicDBConnString"].ConnectionString;
            MusicLib.MusicLib Library = new MusicLib.MusicLib(ConnString);

            //Library.GetSongs("Avenged Sevenfold", "Waking the Fallen");
            //Library.GetSongs("Avenged Sevenfold");
            //Library.GetSongs();
            //Library.GetAlbums();
            //Library.GetAlbums("Avenged Sevenfold");
            //Library.GetArtists();
            //Library.GetArtists("NewMusic");
            //Library.GetGenres();

            //Library.AddDirectory("C:\\Killian Intelligence Systems\\WeddingPlaylistManager\\TestMusicFiles", true);
            ////Library.AddDirectory("F:\\_Music\\iTunes Formatted Music", true);

            ////stopwatch.Stop();
            ////System.Console.WriteLine(stopwatch.Elapsed.Minutes + "m, " + stopwatch.Elapsed.Seconds + "s");
            ////stopwatch.Reset();
            ////stopwatch.Start();
            //Library.CommitMusicLibToDatabase();
            ////stopwatch.Stop();
            ////System.Console.WriteLine(stopwatch.Elapsed.Minutes + "m, " + stopwatch.Elapsed.Seconds + "s");

            Console.WriteLine("Press enter to exit...");
            String x = Console.ReadLine();
        }
    }
}
