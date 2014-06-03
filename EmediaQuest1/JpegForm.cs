using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace EmediaQuest1
{
    public partial class JpegForm : Form
    {
        int x, y, width, height;
        public int WindowSize = 256;
        Bitmap InputImage;
        Bitmap tmpBmp;
         Bitmap bmp;
        public Point current;
        public int scale = 50;
        FFT ImgFFT;
        public int rec_width, rec_height;
        string path;
        public JpegForm()
        {
            
            InitializeComponent();
            current.X = 1;
            current.Y = 1;
            OpenFileDialog od = new OpenFileDialog();
            od.ShowDialog();
            path = od.FileName;
            var bytes = File.ReadAllBytes(path);
            var ms = new MemoryStream(bytes);
            GetJpegData(ms);
            InputImage = new Bitmap(path);
            InputPicture.SizeMode = PictureBoxSizeMode.Zoom;
            InputPicture.Image = (Image)InputImage;

            Bitmap temp = (Bitmap)InputImage.Clone();
            width = height = (int)(WindowSize * 50) / 100;
            tmpBmp = new Bitmap(width, height, InputImage.PixelFormat);
            x = (int)((float)current.X * (100 / Convert.ToDouble(50)));
            y = (int)((float)current.Y * (100 / Convert.ToDouble(50)));
            width = height = 200;
            if (width > WindowSize)
            {
                width = height = WindowSize;
            }
            int testWidth = InputImage.Width;
            int testHeight = InputImage.Height;
            int shorter = 0;
                int  longer = 0;
            if (testHeight <= testWidth)
            {
                shorter = testHeight;
                longer = testWidth;
            }
            else
            {
                longer = testHeight;
                shorter = testWidth;
            }
            Rectangle area = new Rectangle(1,1, 256, 256);
            tmpBmp = (Bitmap)InputImage.Clone();
            bmp = cropImage(tmpBmp,area);
            //InputPicture.Image = (Image)bmp;
            //1. Create FFT Object
            ImgFFT = new FFT(bmp);
            ImgFFT.ForwardFFT(); // Finding 2D FFT of Image
            ImgFFT.FFTShift();
            ImgFFT.FFTPlot(ImgFFT.FFTShifted);
            FourierMag.Image = (Image)ImgFFT.FourierPlot;
            FourierPhase.Image = (Image)ImgFFT.PhasePlot; 
        }


         // funkcja ktora zwraca nam wymiary 
        private  Bitmap cropImage(Image img, Rectangle cropArea)
        {
            Bitmap bmpImage = new Bitmap(img);
            Bitmap bmpCrop = bmpImage.Clone(cropArea,
            bmpImage.PixelFormat);
            return (Bitmap)(bmpCrop);
        }
        public void GetJpegData(Stream fs)
        {
            // trzeba moc przeszukac strumien
            if (!fs.CanSeek) throw new ArgumentException("Stream must be seekable");
            long blockStart;
            var buf = new byte[4];
            fs.Read(buf, 0, 4); // czytamy 4 bajty i zapisujemy je do bufora z 0 offsetem
            if (buf.SequenceEqual(new byte[] {0xff, 0xd8, 0xff, 0xe0})) // sprawdzamy, czy to segment 0
            {
                labelStart.Text = "FFD8 Entering jpeg APP0 start of segment marker...";

                blockStart = fs.Position;
                fs.Read(buf, 0, 2);

                var blockLength = ((buf[0] << 8) + buf[1]);
                labelStartLength.Text = ("FFD8 marker lenght" + blockLength);
                Console.WriteLine();
                fs.Read(buf, 0, 4);
                if (Encoding.ASCII.GetString(buf, 0, 4) == "JFIF" && fs.ReadByte() == 0) // tutaj trzeba dorobic
                {
                    var FFD8Buf = new byte[9];
                    fs.Read(FFD8Buf, 0, 9);
                    labelMajorId.Text = ("Major version id" + FFD8Buf[0]);
                    labelMinorId.Text = ("Minor version id" + FFD8Buf[1]);
                    switch (FFD8Buf[2])
                    {
                        case 0:
                            
                            labelDensity.Text = "Density Units: No units, aspect ratio only specified";                            
                            break;
                        case 1:
                            labelDensity.Text = "Density Units: Pixels per inch ";
                            break;
                        case 2:
                            labelDensity.Text = "Density Units: Pixels per centimetre ";
                            break;

                    }
                    labelXDensity.Text = "X density: " + ((FFD8Buf[3] << 8) + FFD8Buf[4]);
                    labelYDensity.Text = "Y density: " + ((FFD8Buf[5] << 8) + FFD8Buf[6]);
                    labelThumbnailH.Text = "Thumbnail height: " + FFD8Buf[7];
                    labelThumbnailW.Text = "Thumbnail width: " + FFD8Buf[8];
                    labelFileFormat.Text = "Image file format standard: JFIF";
                    
                    blockStart += blockLength; //przesuwamy o 16 bajtow, czyli stringa jfif

                    while (blockStart < fs.Length)
                    {
                        fs.Position = blockStart;
                        fs.Read(buf, 0, 4);
                        if (buf[0] == 0xff && buf[1] == 0xfe) // jezeli mamy jakis komentarz
                        {
                            blockLength = ((buf[2] << 8) + buf[3]);
                            var biggerBuf = new byte[blockLength];
                            fs.Read(biggerBuf, 0, blockLength);

                            labelComment.Text = "Comment marker FFFE:";
                            labelCommentLength.Text = ("Comment length: " + blockLength);
                            labelCommentTxt.Text = Encoding.ASCII.GetString(biggerBuf);
                            blockStart += blockLength;
                        }
                        blockLength = ((buf[2] << 8) + buf[3]);
                        if (blockLength >= 7 && buf[0] == 0xff && buf[1] == 0xc0) // jak dotrzemy do segmentu ffc0
                        {
                            labelMarkerFFC0.Text = "Marker FFC0 - the start of frame segment";
                            labelMarkerLength.Text = "Marker length: " + blockLength;
                            var biggerBuf = new byte[6];
                            fs.Read(biggerBuf, 0, 6);
                            var samplePrecision = biggerBuf[0];
                            labelSamplePrecision.Text = "Sample precision in bits: " + samplePrecision;
                            var height = (biggerBuf[1] << 8) + biggerBuf[2];
                            var width = (biggerBuf[3] << 8) + biggerBuf[4];
                            labelWidth.Text = "Width: " + width;
                            labelHeight.Text = "Height: " + height;
                            var components = biggerBuf[5];
                            labelRGB.Text = "Number of components (RGB): " + components;
                        }
                        blockStart += blockLength + 2;
                    }
                }
            }
        }

     
    }
}
