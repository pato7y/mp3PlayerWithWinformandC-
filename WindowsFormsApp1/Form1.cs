using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Sero : Form
    {
        public Sero()
        {
            InitializeComponent();
        }

        string[] paths, files;

        private void Sero_Load(object sender, EventArgs e)
        {
            // Subscribe to PlayStateChange event for autoplay
            axWindowsMediaPlayer1.PlayStateChange += axWindowsMediaPlayer1_PlayStateChange;
        }

        private void Select_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Multiselect = true // Allow selecting multiple files
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                files = ofd.FileNames;
                paths = ofd.FileNames;
                MusicList.Items.Clear();
                foreach (var file in files)
                {
                    MusicList.Items.Add(file);
                }
            }
        }

        private void MusicList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MusicList.SelectedIndex >= 0)
            {
                axWindowsMediaPlayer1.URL = paths[MusicList.SelectedIndex];
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            // Check if the current song has ended
            if (e.newState == 8) // MediaEnded state
            {
                // Move to the next song if there is one
                if (MusicList.SelectedIndex < MusicList.Items.Count - 1)
                {
                    MusicList.SelectedIndex++; // Update the UI to show the next song
                    axWindowsMediaPlayer1.URL = paths[MusicList.SelectedIndex];
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
            }
        }

        private void SeroMp3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
