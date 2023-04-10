using NAudio.Wave;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class audioCita : Form
    {
        public WaveIn waveSource = null;
        public WaveFileWriter waveFile = null;

        public audioCita()
        {
            InitializeComponent();
        }

        private void empezar_Click(object sender, EventArgs e)
        {
            empezar.Enabled = false;
            pausa.Enabled = true;

            try
            {
                waveSource = new WaveIn();
                waveSource.WaveFormat = new WaveFormat(44100, 1);
                waveSource.DataAvailable += WaveSource_DataAvailable;
                waveSource.RecordingStopped += WaveSource_RecordingStopped;

                waveFile = new WaveFileWriter(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Test0001.wav"), waveSource.WaveFormat);


                waveSource.StartRecording();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return;
            }
        }

        private void pausa_Click(object sender, EventArgs e)
        {
            if (waveSource != null)
            {
                pausa.Enabled = false;
                waveSource.StopRecording();
            }
        }

        private void WaveSource_DataAvailable(object sender, WaveInEventArgs e)
        {
            if (waveFile != null)
            {
                waveFile.Write(e.Buffer, 0, e.BytesRecorded);
                waveFile.Flush();
            }
        }

        private void WaveSource_RecordingStopped(object sender, StoppedEventArgs e)
        {
            if (waveSource != null)
            {
                waveSource.Dispose();
                waveSource = null;
            }

            if (waveFile != null)
            {
                waveFile.Dispose();
                waveFile = null;
            }

            pausa.Enabled = false;
            empezar.Enabled = true;
        }
    }
}
