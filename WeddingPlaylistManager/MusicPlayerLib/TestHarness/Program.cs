using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestHarness
{
    class Program
    {
        static void Main(string[] args)
        {
            MusicPlayerLib.MusicPlayerLib Player = new MusicPlayerLib.MusicPlayerLib();
            Player.Play("C:\\Killian Intelligence Systems\\WeddingPlaylistManager\\TestMusicFiles\\Breaking Benjamin - Dear Agony [CD] [320K]\\01.Fade Away.mp3");
            Player.Pause();
            Player.Play();
            Player.Stop();
            Player.Play();
        }
    }
}
