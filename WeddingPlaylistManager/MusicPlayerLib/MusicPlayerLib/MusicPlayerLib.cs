using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using WMPLib;   //This is from the COM Reference WMPLib, located at System32\WMPLib.dll

namespace MusicPlayerLib
{
    public class MusicPlayerLib
    {
        private WMPLib.WindowsMediaPlayer _WMPlayer;
        private bool _PlayerStopped;

        public MusicPlayerLib()
        {
            _WMPlayer = new WMPLib.WindowsMediaPlayer();
            _WMPlayer.settings.autoStart = false;
            _WMPlayer.settings.volume = 100;
            _PlayerStopped = false;
            _WMPlayer.controls.stop();
        }//Constructor

        ~MusicPlayerLib()
        {
            _WMPlayer = null;
        }//Deconstructor


        //Plays the song. Returns true or false for if attempt to play was successful
        public bool Play(String pSongFilePath)
        {
            _WMPlayer.URL = pSongFilePath;
            return Play();
        }//PlaySong

        //Plays the song. Returns true or false for if attempt to play was successful
        public bool Play()
        {
            bool PlaySuccessful = true;
            try 
            { 
                _WMPlayer.controls.play();
                _PlayerStopped = false;
            }
            catch { PlaySuccessful = false; }
            
            return PlaySuccessful;
        }//Play

        public void Pause()
        {
            _WMPlayer.controls.pause();
        }//Pause

        public void Stop()
        {
            _WMPlayer.controls.stop();
            _PlayerStopped = true;
        }//Stop

        public void SetVolume(int pVolume)
        {
            _WMPlayer.settings.volume = pVolume;
        }//SetVolume

        public void Mute()
        {
            _WMPlayer.settings.mute = true;
        }

        public void UnMute()
        {
            _WMPlayer.settings.mute = false;
        }

        public String GetStatus()
        {
            return _WMPlayer.status;
        }//GetStatus

        public bool SongEnded()
        {
            bool SongEnded = false;
            if ((_WMPlayer.playState == WMPPlayState.wmppsStopped || _WMPlayer.playState == WMPPlayState.wmppsUndefined) && _PlayerStopped == false)
                SongEnded = true;

            return SongEnded;
        }//SongEnded

        public String GetSongTimePlayed()
        {
            String TimePlayed = "00:00";

            TimePlayed = _WMPlayer.controls.currentPositionString;

            if (TimePlayed == "")
                TimePlayed = "00:00";

            return TimePlayed;
        }//GetSongTimePlayed

        public String GetSongTimeDuration()
        {
            String TimeDuration = "00:00";

            if (_WMPlayer.currentMedia != null)
            {
                TimeDuration = _WMPlayer.currentMedia.durationString;
            }

            return TimeDuration;
        }//GetSongTimeDuration

        public String GetSongTimePercent()
        {
            String TimePercent = "0%";

            if (_WMPlayer.currentMedia.duration > 0)
                TimePercent = Convert.ToInt32(100 * (_WMPlayer.controls.currentPosition / _WMPlayer.currentMedia.duration)) + "%";

            return TimePercent;
        }//GetSongTimePercent

        public double GetTotalPlayedSeconds()
        {
            double TotalPlayedSeconds = 0;

            if (_WMPlayer.currentMedia != null)
                TotalPlayedSeconds = _WMPlayer.controls.currentPosition;

            return TotalPlayedSeconds;
        }

        public double GetTotalCurrentSongSeconds()
        {
            double TotalSeconds = 1;   //Set to 1 to prevent divide by zero if calculate (Total Played)/(Total Duration)

            if (_WMPlayer.currentMedia != null)
                TotalSeconds = _WMPlayer.currentMedia.duration;

            if(TotalSeconds == 0)
                TotalSeconds = 1;   //Set to 1 to prevent divide by zero if calculate (Total Played)/(Total Duration)

            return TotalSeconds;
        }

        public void SetCurrentSongPosition(double pPercentOfSong)
        {
            double SecondsPosition = pPercentOfSong * _WMPlayer.currentMedia.duration;
            _WMPlayer.controls.currentPosition = SecondsPosition;
        }//SetCurrentSongPosition

        public bool IsPaused()
        {
            bool IsPaused = false;
            if (_WMPlayer.playState == WMPPlayState.wmppsPaused)
                IsPaused = true;

            return IsPaused;
        }

        public bool IsStopped()
        {
            bool IsStopped = false;
            if (_WMPlayer.playState == WMPPlayState.wmppsStopped)
                IsStopped = true;

            return IsStopped;
        }

        public bool IsPlaying()
        {
            bool IsPlaying = false;
            if (_WMPlayer.playState == WMPPlayState.wmppsPlaying)
                IsPlaying = true;

            return IsPlaying;
        }

        public bool IsMuted()
        {
            bool IsMuted = false;
            if (_WMPlayer.settings.mute == true)
                IsMuted = true;

            return IsMuted;
        }
    }
}
