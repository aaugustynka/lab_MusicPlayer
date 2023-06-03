using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        private IWavePlayer waveOutDevice;
        private AudioFileReader audioFileReader;
        private List<string> playlist;
        private int currentTrackIndex;
        private Timer timer;

        public Form1()
        {
            InitializeComponent();

            waveOutDevice = new WaveOut();
            playlist = new List<string>();
            currentTrackIndex = -1;

            BtnOpen.Click += BtnOpen_Click;
            BtnPlay.Click += BtnPlay_Click;
            BtnPause.Click += BtnPause_Click;
            BtnStop.Click += BtnStop_Click;
            TrackBarProgress.MouseDown += TrackBarProgress_MouseDown;
            TrackBarProgress.MouseUp += TrackBarProgress_MouseUp;
            TrackBarVolume.Scroll += TrackBarVolume_Scroll;
            BtnForward.Click += BtnForward_Click;
            BtnBackward.Click += BtnBackward_Click;
            BtnAdd.Click += BtnAdd_Click;
            BtnRemove.Click += BtnRemove_Click;
            BtnPlayPlaylist.Click += BtnPlayPlaylist_Click;
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Pliki dźwiękowe|*.wav;*.mp3";
            openFileDialog.Title = "Wybierz plik dźwiękowy";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFile = openFileDialog.FileName;
                playlist.Add(selectedFile);
                ListViewItem item = new ListViewItem(Path.GetFileName(selectedFile));
                ListViewPlaylist.Items.Add(item);
            }
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            if (waveOutDevice != null && waveOutDevice.PlaybackState != PlaybackState.Playing)
            {
                waveOutDevice.Play();
                LblStatus.Text = "Odtwarzanie";
            }
        }

        private void BtnPause_Click(object sender, EventArgs e)
        {
            if (waveOutDevice != null && waveOutDevice.PlaybackState == PlaybackState.Playing)
            {
                waveOutDevice.Pause();
                LblStatus.Text = "Zatrzymanie";
            }
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            if (waveOutDevice != null)
            {
                waveOutDevice.Stop();
                LblStatus.Text = "Zatrzymano odtwarzanie";
                TrackBarProgress.Value = 0;
            }
        }

        private void TrackBarProgress_MouseDown(object sender, MouseEventArgs e)
        {
            if (waveOutDevice != null && waveOutDevice.PlaybackState == PlaybackState.Playing)
            {
                waveOutDevice.Pause();
            }
        }

        private void TrackBarProgress_MouseUp(object sender, MouseEventArgs e)
        {
            if (waveOutDevice != null)
            {
                double newPosition = (double)TrackBarProgress.Value / TrackBarProgress.Maximum;
                audioFileReader.Position = (long)(newPosition * audioFileReader.Length);

                if (waveOutDevice.PlaybackState == PlaybackState.Paused)
                {
                    waveOutDevice.Play();
                }
            }
        }

        private void TrackBarVolume_Scroll(object sender, EventArgs e)
        {
            if (waveOutDevice != null)
            {
                waveOutDevice.Volume = (float)TrackBarVolume.Value / TrackBarVolume.Maximum;
            }
        }

        private void BtnForward_Click(object sender, EventArgs e)
        {
            if (waveOutDevice != null && waveOutDevice.PlaybackState == PlaybackState.Playing)
            {
                double newPosition = audioFileReader.CurrentTime.TotalSeconds + 10;
                if (newPosition > audioFileReader.TotalTime.TotalSeconds)
                {
                    newPosition = audioFileReader.TotalTime.TotalSeconds;
                }
                audioFileReader.CurrentTime = TimeSpan.FromSeconds(newPosition);
            }
        }

        private void BtnBackward_Click(object sender, EventArgs e)
        {
            if (waveOutDevice != null && waveOutDevice.PlaybackState == PlaybackState.Playing)
            {
                double newPosition = audioFileReader.CurrentTime.TotalSeconds - 10;
                if (newPosition < 0)
                {
                    newPosition = 0;
                }
                audioFileReader.CurrentTime = TimeSpan.FromSeconds(newPosition);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Pliki dźwiękowe|*.wav;*.mp3";
            openFileDialog.Title = "Wybierz plik dźwiękowy";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFile = openFileDialog.FileName;
                playlist.Add(selectedFile);
                ListViewItem item = new ListViewItem(Path.GetFileName(selectedFile));
                ListViewPlaylist.Items.Add(item);
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (ListViewPlaylist.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = ListViewPlaylist.SelectedItems[0];
                int selectedIndex = ListViewPlaylist.Items.IndexOf(selectedItem);
                ListViewPlaylist.Items.Remove(selectedItem);
                playlist.RemoveAt(selectedIndex);
            }
        }

        private void BtnPlayPlaylist_Click(object sender, EventArgs e)
        {
            if (playlist.Count > 0)
            {
                currentTrackIndex = 0;
                PlayTrack(playlist[currentTrackIndex]);
            }
        }

        private void PlayTrack(string filePath)
        {
            if (File.Exists(filePath))
            {
                if (waveOutDevice != null)
                {
                    waveOutDevice.Stop();
                    waveOutDevice.Dispose();
                }

                waveOutDevice = new WaveOut();
                audioFileReader = new AudioFileReader(filePath);

                waveOutDevice.Init(audioFileReader);
                waveOutDevice.Play();

                LblStatus.Text = "Odtwarzanie: " + Path.GetFileName(filePath);
                TrackBarProgress.Value = 0;
                TrackBarProgress.Maximum = (int)audioFileReader.TotalTime.TotalSeconds;
                TrackBarVolume.Value = (int)(waveOutDevice.Volume * TrackBarVolume.Maximum);

                waveOutDevice.PlaybackStopped += WaveOutDevice_PlaybackStopped;


                Timer timer = new Timer();
                timer.Interval = 1000; 
                timer.Tick += Timer_Tick;
                timer.Start();
            }
        }

        private void WaveOutDevice_PlaybackStopped(object sender, StoppedEventArgs e)
        {
            if (currentTrackIndex < playlist.Count - 1)
            {
                currentTrackIndex++;
                PlayTrack(playlist[currentTrackIndex]);
            }
            else
            {
                LblStatus.Text = "Zakończono odtwarzanie";
                TrackBarProgress.Value = 0;
                currentTrackIndex = -1;
                waveOutDevice.Dispose();
                waveOutDevice = null;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (audioFileReader != null && waveOutDevice != null && waveOutDevice.PlaybackState == PlaybackState.Playing)
            {
                TimeSpan currentTime = audioFileReader.CurrentTime;
                LblTime.Text = currentTime.ToString(@"mm\:ss");
            }
        }
    }
}
