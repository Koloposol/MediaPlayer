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
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
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

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, _WMPOCXEvents_PlayStateChangeEvent e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            trackBar1.Maximum = Convert.ToInt32(axWindowsMediaPlayer1.currentMedia.duration);
            trackBar1.Value = Convert.ToInt32(axWindowsMediaPlayer1.Ctlcontrols.currentPosition);

            if (axWindowsMediaPlayer1 != null)
            {
                int seconds = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
                int hours = seconds / 3600;
                int minutes = (seconds - (hours * 3600)) / 60;
                seconds = seconds - (hours * 3600 + minutes * 60);
                label1.Text = String.Format($"{hours}:{minutes}:{seconds}");
            }
            else
            {
                label1.Text = "0:00:00";
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = trackBar1.Value;
        }
    }
}
