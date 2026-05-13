using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 多媒體播放器
{
    public partial class frmMediaPlayer : Form
    {
        public frmMediaPlayer()
        {
            InitializeComponent();
        }

        private void frmMediaPlayer_Load(object sender, EventArgs e)
        {
            tkbSpeed.Value = 1;
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "WMV files (*.wmv)|*.wmv|MP4 files(*.mp4)|*.mp4|AVI files(*.avi)|*.avi|Allfiles (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                wmpVideo.URL = ofd.FileName;
                wmpVideo.Ctlcontrols.stop(); // 停止
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            wmpVideo.Ctlcontrols.play();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            wmpVideo.Ctlcontrols.pause();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            wmpVideo.Ctlcontrols.stop();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if (wmpVideo.currentMedia != null)
            {
                wmpVideo.Ctlcontrols.currentPosition += 5;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (wmpVideo.currentMedia != null)
            {
                wmpVideo.Ctlcontrols.currentPosition -= 5;
            }
        }

        private double[] playbackSpeeds = { 0.75, 1.0, 1.25, 2.0 };

        private void tkbSpeed_Scroll(object sender, EventArgs e)
        {
            int index = tkbSpeed.Value; // 0,1,2,3
            double selectedSpeed = playbackSpeeds[index]; // 對應 Array

            if (wmpVideo.currentMedia != null)
            {
                wmpVideo.settings.rate = selectedSpeed;
            }
        }

        private void frmMediaPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("確定要關閉應用程式嗎？", "關閉確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true; // 取消關閉
            }
        }
    }
}