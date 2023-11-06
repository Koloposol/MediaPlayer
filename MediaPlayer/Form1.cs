using AxWMPLib;
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
        About about = new About();

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            string file = openFileDialog1.FileName;
            Text = file;

            axWindowsMediaPlayer1.URL = file;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void оПрограммеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(about is null || about.IsDisposed)
            {
                about = new About();
                about.Show();
            }
            else
            {
                about.Show();
                about.Focus();
            }
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume += 5;
            if(toolStripProgressBar1.Value != 100)
            {
                toolStripProgressBar1.Value += 5;
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume -= 5;
            if (toolStripProgressBar1.Value != 0)
            {
                toolStripProgressBar1.Value -= 5;
            }
        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            
        }
    }
}
