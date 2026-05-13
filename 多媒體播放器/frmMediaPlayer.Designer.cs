namespace 多媒體播放器
{
    partial class frmMediaPlayer
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMediaPlayer));
            this.palButton = new System.Windows.Forms.Panel();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.wmpVideo = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnBack = new System.Windows.Forms.Button();
            this.tkbSpeed = new System.Windows.Forms.TrackBar();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.palButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // palButton
            // 
            this.palButton.Controls.Add(this.lbl4);
            this.palButton.Controls.Add(this.lbl3);
            this.palButton.Controls.Add(this.lbl1);
            this.palButton.Controls.Add(this.lbl2);
            this.palButton.Controls.Add(this.tkbSpeed);
            this.palButton.Controls.Add(this.btnBack);
            this.palButton.Controls.Add(this.btnForward);
            this.palButton.Controls.Add(this.btnStop);
            this.palButton.Controls.Add(this.btnPause);
            this.palButton.Controls.Add(this.btnPlay);
            this.palButton.Controls.Add(this.btnBrowser);
            this.palButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.palButton.Location = new System.Drawing.Point(0, 353);
            this.palButton.Margin = new System.Windows.Forms.Padding(2);
            this.palButton.Name = "palButton";
            this.palButton.Size = new System.Drawing.Size(612, 82);
            this.palButton.TabIndex = 1;
            // 
            // btnForward
            // 
            this.btnForward.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnForward.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnForward.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnForward.Location = new System.Drawing.Point(291, 26);
            this.btnForward.Margin = new System.Windows.Forms.Padding(2);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(65, 31);
            this.btnForward.TabIndex = 4;
            this.btnForward.Text = "快進5秒";
            this.btnForward.UseVisualStyleBackColor = false;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStop.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStop.ForeColor = System.Drawing.SystemColors.Window;
            this.btnStop.Location = new System.Drawing.Point(511, 26);
            this.btnStop.Margin = new System.Windows.Forms.Padding(2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(79, 31);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "結束播放";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPause
            // 
            this.btnPause.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPause.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPause.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPause.Location = new System.Drawing.Point(164, 26);
            this.btnPause.Margin = new System.Windows.Forms.Padding(2);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(54, 31);
            this.btnPause.TabIndex = 2;
            this.btnPause.Text = "暫停";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPlay.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPlay.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPlay.Location = new System.Drawing.Point(106, 26);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(54, 31);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "播放";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnBrowser
            // 
            this.btnBrowser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBrowser.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowser.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBrowser.ForeColor = System.Drawing.SystemColors.Window;
            this.btnBrowser.Location = new System.Drawing.Point(19, 26);
            this.btnBrowser.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(79, 31);
            this.btnBrowser.TabIndex = 0;
            this.btnBrowser.Text = "瀏覽檔案";
            this.btnBrowser.UseVisualStyleBackColor = false;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // wmpVideo
            // 
            this.wmpVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wmpVideo.Enabled = true;
            this.wmpVideo.Location = new System.Drawing.Point(0, 0);
            this.wmpVideo.Margin = new System.Windows.Forms.Padding(2);
            this.wmpVideo.Name = "wmpVideo";
            this.wmpVideo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpVideo.OcxState")));
            this.wmpVideo.Size = new System.Drawing.Size(612, 435);
            this.wmpVideo.TabIndex = 0;
            this.wmpVideo.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBack.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBack.Location = new System.Drawing.Point(222, 26);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(65, 31);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "倒退5秒";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tkbSpeed
            // 
            this.tkbSpeed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tkbSpeed.Location = new System.Drawing.Point(362, 17);
            this.tkbSpeed.Maximum = 3;
            this.tkbSpeed.Name = "tkbSpeed";
            this.tkbSpeed.Size = new System.Drawing.Size(139, 45);
            this.tkbSpeed.TabIndex = 5;
            this.tkbSpeed.Value = 1;
            this.tkbSpeed.Scroll += new System.EventHandler(this.tkbSpeed_Scroll);
            // 
            // lbl2
            // 
            this.lbl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl2.Location = new System.Drawing.Point(403, 46);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(30, 15);
            this.lbl2.TabIndex = 7;
            this.lbl2.Text = "x 1.0";
            // 
            // lbl1
            // 
            this.lbl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl1.Location = new System.Drawing.Point(365, 46);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(36, 15);
            this.lbl1.TabIndex = 8;
            this.lbl1.Text = "x 0.75";
            // 
            // lbl3
            // 
            this.lbl3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl3.Location = new System.Drawing.Point(435, 46);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(36, 15);
            this.lbl3.TabIndex = 9;
            this.lbl3.Text = "x 1.25";
            // 
            // lbl4
            // 
            this.lbl4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl4.Location = new System.Drawing.Point(472, 46);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(30, 15);
            this.lbl4.TabIndex = 10;
            this.lbl4.Text = "x 2.0";
            // 
            // frmMediaPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 435);
            this.Controls.Add(this.palButton);
            this.Controls.Add(this.wmpVideo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(600, 250);
            this.Name = "frmMediaPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "多媒體播放器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMediaPlayer_FormClosing);
            this.Load += new System.EventHandler(this.frmMediaPlayer_Load);
            this.palButton.ResumeLayout(false);
            this.palButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tkbSpeed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmpVideo;
        private System.Windows.Forms.Panel palButton;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TrackBar tkbSpeed;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl1;
    }
}

