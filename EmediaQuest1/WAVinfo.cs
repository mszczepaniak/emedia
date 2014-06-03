using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace EmediaQuest1
{
    public class WAVinfo
    {
        private int chunkSize; // (36 + subChunkSize)
        private int numChannel; // mono/stereo/more
        private int sampleRate;
        private int bitsPerSample;
        private int audioFormatID;
        private long nSamples;
        private string status;
        private List<List<int>> data;

        public WAVinfo(string filePath)
        {
            // parametric constructor, reads all important data from file in given filePath
            int sub1size;
            long sub2size;
            using (FileStream fs = File.OpenRead(filePath))
            {
                try
                {
                    // Seekable for changing position in stream

                    if (!fs.CanSeek) throw new ArgumentException("Stream must be seekable");

                    // Buffors for important data

                    byte[] bu4 = new byte[4];
                    byte[] buffor2 = new byte[2];

                    // Check correct WAV file form
                    // bytes 0-4 'RIFF'
                    fs.Read(bu4, 0, 4);
                    if (!(Encoding.ASCII.GetString(bu4) == "RIFF"))
                    {
                        throw new Exception("No \"RIFF\" in first 4 bytes.");
                    }

                    // bytes 8-12 'WAVE'
                    fs.Seek(4, SeekOrigin.Current);
                    fs.Read(bu4, 0, 4);
                    if (!(Encoding.ASCII.GetString(bu4) == "WAVE"))
                    {
                        throw new Exception("No \"WAVE\" in bytes 8-12.");
                    }
                    // Subchunk1 size(16 for PCM)
                    fs.Seek(16, SeekOrigin.Begin);
                    fs.Read(bu4, 0, 4);
                    sub1size = (((bu4[3] << 8) + bu4[2] << 8) + bu4[1] << 8) + bu4[0];
                    chunkSize = sub1size;
                    // Check audio format, 1 == PCM, other codes unknown
                    fs.Read(buffor2, 0, 2);
                    audioFormatID = (buffor2[1] << 8) + buffor2[0];
                    // Number of Channels
                    fs.Read(buffor2, 0, 2);
                    numChannel = (buffor2[1] << 8) + buffor2[0];
                    // Sample Rate
                    fs.Read(bu4, 0, 4);
                    sampleRate = (bu4[3] << 24) + (bu4[2] << 16) + (bu4[1] << 8) + bu4[0];
                    // Bits per Sample
                    fs.Seek(6, SeekOrigin.Current);
                    fs.Read(buffor2, 0, 2);
                    bitsPerSample = (buffor2[1] << 8) + buffor2[0];
                    // Computing number of samples !
                    fs.Seek((sub1size - 16 + 4), SeekOrigin.Current);
                    fs.Read(bu4, 0, 4);
                    sub2size = (bu4[3] << 24) + (bu4[2] << 16) + (bu4[1] << 8) + bu4[0];
                    nSamples = ((long)sub2size) / (long)(numChannel * 8) / (long)(bitsPerSample);
                    // Getting bytes for FFT algoritm
                    // each sample goes for all channels, so you can get data of one channel by getting data with constant offset equals bitsPerSample*(numChannels-1)
                    data = new List<List<int>>(this.numChannel);
                    // create conteners for all channels
                    for (int i = 0; i < this.numChannel; ++i)
                    {
                        data.Add(new List<int>((int)this.nSamples));
                    }

                    // get sample by reading correct amount of bits, go through endiannes, assign sample to correct channel container 
                    for (long i = 0; i < this.nSamples; ++i)
                    {
                        for (int c = 0; c < this.numChannel; ++c)
                        {
                            fs.Read(bu4, 0, (this.bitsPerSample / 8));
                            data[c].Add(this.endiannesConverter(bu4));
                        }

                    }
                }
                catch (Exception e)
                {
                    status += e.Message + "\n";
                }
            }
        }

        public int ChunkSize
        {
            get { return chunkSize; }
        }

        public int NumChannel
        {
            get { return numChannel; }
        }

        public int SampleRate
        {
            get { return sampleRate; }
        }

        public int BitsPerSample
        {
            get { return bitsPerSample; }
        }

        public int AudioFormatID
        {
            get { return audioFormatID; }
        }

        public long NSamples
        {
            get { return nSamples; }
        }

        public int endiannesConverter(byte[] buffor) // arg bits per sample
        {
            int result = 0;
            for (int i = 0; i * 8 < this.bitsPerSample; ++i)
            {
                result += (buffor[i] << (i * 8));
            }
            return result;
        }

        public double[] dataSamples(uint begin, uint amount, uint channel)
        {
            double[] result = new double[amount];
            result = this.data[(int)(channel-1)].GetRange((int)begin, (int)amount).ConvertAll<double>(new Converter<int, double>(IntToDouble)).ToArray();
            return result;
        }

        public double IntToDouble(int data)
        {
            return (double)data;
        }
    }
}

