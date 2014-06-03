using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace EmediaQuest1
{
    public partial class FormWAVE : Form
    {
        string filePath;
        SoundPlayer Player;
        WAVinfo fileInfo;
        FFT2 freq;
        double[] fftResult;
        double[] imgZero;
        List<double> dBmag;
        List<double> frequencies;
        List<double> magnitude;

        public FormWAVE()
        {
            InitializeComponent();
            fftResult = new double[0];
            imgZero = new double[0];
            frequencies = new List<double>(0);
            dBmag = new List<double>(0);
            magnitude = new List<double>(0);
            freq = new FFT2();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            //string[] fileType = new string[0];
            //fileType = labelMedia.Text.Split('.');
            //string type = fileType.LastOrDefault();
            //if((type != null) && (type.Trim() == "wav"))
            if (labelMedia.Text.EndsWith("wav"))
            {
                Player = new SoundPlayer(filePath);
                try
                {
                    Player.Play();
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show("Check file existance.");
                }
            }
            else labelMedia.Text = "Incorrect file or no media";
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            Player.Stop();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog())
            {
                open.Filter = "Wav Files|*.wav";
                open.Title = "Select \"WAV\" file.";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    filePath = open.FileName;
                    labelMedia.Text = filePath.Split('\\').LastOrDefault();
                    fileInfo = new WAVinfo(filePath);
                    labelAudioFormatID.Text = fileInfo.AudioFormatID.ToString();
                    labelBPS.Text = fileInfo.BitsPerSample.ToString();
                    labelChannels.Text = fileInfo.NumChannel.ToString();
                    labelChunkSize.Text = fileInfo.ChunkSize.ToString();
                    labelNSamples.Text = fileInfo.NSamples.ToString();
                    labelSampleRate.Text = fileInfo.SampleRate.ToString();
                }
            }
        }

        private void buttonFFT_Click(object sender, EventArgs e)
        {
            uint nLog=10;
            uint sp = 0;
            uint ch = 1;

            try
            {
                nLog = uint.Parse(textBoxNLog.Text);
            }
            catch(Exception)
            {
                return;
            }

            if(nLog < 2)
            {
                MessageBox.Show("Provide more FFT points!");
                return;
            }

            try
            {
                sp = uint.Parse(textBoxSP.Text);
            }
            catch (Exception)
            {
                return;
            }

            if (sp + Math.Pow(2, (double)nLog) > uint.Parse(labelNSamples.Text))
            {
                MessageBox.Show("Set earlier Start Point or less FFT points");
                return;
            }

            try
            {
                ch = uint.Parse(textBoxChannel.Text);
            }
            catch
            {
                MessageBox.Show("Invailid number of channels");
                return;
            }

            freq.init(nLog);
            // cut samples to specific lenght
            fftResult = fileInfo.dataSamples(sp, (uint)Math.Pow(2, (double)nLog), ch);
            imgZero = new double[(int)Math.Pow(2, (double)nLog)];
            // run fft
            freq.run(fftResult, imgZero, false);
            dBmag = compMagDB(fftResult, imgZero, (int)Math.Pow(2.0, (double)nLog));
            magnitude = compMagnitude(fftResult, imgZero, (int)Math.Pow(2.0, (double)nLog));
            chartFreq.Series["FFT"].Points.Clear();
            if (checkBoxDB.Checked)
            {
                for (int i = 1; i <= (int)Math.Pow(2, (double)nLog); ++i)
                {
                    chartFreq.Series["FFT"].Points.AddXY((double)i, dBmag[i - 1]);
                }
                //chartFreq.ChartAreas[0].AxisY.Maximum = (int)(dBmag.Max() / 2 * 3);
                //chartFreq.ChartAreas[0].AxisY.Minimum = 0;
            }
            else
            {
                for (int i = 1; i <= (int)Math.Pow(2, (double)nLog); ++i)
                {
                    chartFreq.Series["FFT"].Points.AddXY((double)i, magnitude[i - 1]);
                }
                //chartFreq.ChartAreas[0].AxisY.Maximum = (int)(magnitude.Max() / 5 * 6);
                //chartFreq.ChartAreas[0].AxisY.Minimum = 0;
            }
            return;
        }

        public List<double> compMagnitude(double[] re, double[] im, int amount)
        {
            List<double> result = new List<double>(amount);
            for (int i = 0; i < amount; ++i)
            {
                result.Add(Math.Sqrt(re[i] * re[i] + im[i] * im[i]));
            }
            return result;
        }

        public List<double> compMagDB(double[] re, double[] im, int amount)
        {
            List<double> result = new List<double>(amount);
            for (int i = 0; i < amount; ++i)
            {
                result.Add(((re[i] == 0) && (im[i] == 0)) ? (0.0) : (10.0 * Math.Log10((double)(re[i] * re[i] + im[i] * im[i]))));
            }
            return result;
        }
    }
}
