using System;
using NAudio.Wave;

namespace MobileMusic
{
    public class MusicHelper
    {
        private IWavePlayer waveOutDevice;
        private AudioFileReader audioFileReader;

        private static MusicHelper Instance;



        public static MusicHelper getInstance()
        {
            if (Instance == null)
            {
                Instance = new MusicHelper();
            }
            return Instance;
        }
        public bool isPlaying()
        {
            return waveOutDevice != null;
        }
        public void Play(string filePath)
        {
            Stop(); 

            waveOutDevice = new WaveOut();
            audioFileReader = new AudioFileReader(filePath);

            waveOutDevice.Init(audioFileReader);
            waveOutDevice.Play();
        }

        public void Stop()
        {
            if (waveOutDevice != null)
            {
                waveOutDevice.Stop();
                waveOutDevice.Dispose();
                waveOutDevice = null;
            }

            if (audioFileReader != null)
            {
                audioFileReader.Dispose();
                audioFileReader = null;
            }
        }

        public void Pause()
        {
            if (waveOutDevice != null)
            {
                waveOutDevice.Pause();
            }
        }

        public void Resume()
        {
            if (waveOutDevice != null)
            {
                waveOutDevice.Play();
            }
        }

        public TimeSpan GetCurrentTime()
        {
            return audioFileReader?.CurrentTime ?? TimeSpan.Zero;
        }

        public TimeSpan GetTotalTime()
        {
            return audioFileReader?.TotalTime ?? TimeSpan.Zero;
        }
    }
}
