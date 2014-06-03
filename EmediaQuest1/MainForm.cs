using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EmediaQuest1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void btnJpeg_Click(object sender, EventArgs e)
        {
            JpegForm jpegForm = new JpegForm();
            jpegForm.ShowDialog(this);
        }

        private void btnWave_Click(object sender, EventArgs e)
        {
            FormWAVE wavForm = new FormWAVE();
            wavForm.ShowDialog();
        }
    }
}
