using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //{ValidateNames = true, Filter = "WMV|*.wmv|WAV|*.wav|MP3|*.mp3|MP4|*.mp4|MKP|*mkp"}
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string file = openFileDialog1.FileName;
            Text = file;

            axWindowsMediaPlayer1.URL = file;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
