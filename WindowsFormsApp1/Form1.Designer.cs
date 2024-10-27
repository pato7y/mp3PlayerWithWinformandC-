namespace WindowsFormsApp1
{
    partial class Sero
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sero));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SeroMp3 = new System.Windows.Forms.Label();
            this.MusicList = new System.Windows.Forms.ListBox();
            this.Select = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.TopPanel.Controls.Add(this.pictureBox1);
            this.TopPanel.Controls.Add(this.SeroMp3);
            this.TopPanel.Location = new System.Drawing.Point(1, 1);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(820, 56);
            this.TopPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(759, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // SeroMp3
            // 
            this.SeroMp3.AutoSize = true;
            this.SeroMp3.Font = new System.Drawing.Font("Jokerman", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeroMp3.Location = new System.Drawing.Point(323, 7);
            this.SeroMp3.Name = "SeroMp3";
            this.SeroMp3.Size = new System.Drawing.Size(144, 41);
            this.SeroMp3.TabIndex = 0;
            this.SeroMp3.Text = "SeroMp3";
            this.SeroMp3.Click += new System.EventHandler(this.SeroMp3_Click);
            // 
            // MusicList
            // 
            this.MusicList.FormattingEnabled = true;
            this.MusicList.ItemHeight = 16;
            this.MusicList.Location = new System.Drawing.Point(685, 79);
            this.MusicList.Name = "MusicList";
            this.MusicList.Size = new System.Drawing.Size(136, 372);
            this.MusicList.TabIndex = 2;
            this.MusicList.SelectedIndexChanged += new System.EventHandler(this.MusicList_SelectedIndexChanged);
            // 
            // Select
            // 
            this.Select.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Select.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Select.Font = new System.Drawing.Font("Viner Hand ITC", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select.Location = new System.Drawing.Point(685, 457);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(136, 46);
            this.Select.TabIndex = 3;
            this.Select.Text = "Select \r\n";
            this.Select.UseVisualStyleBackColor = false;
            this.Select.Click += new System.EventHandler(this.Select_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(1, 63);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(511, 345);
            this.axWindowsMediaPlayer1.TabIndex = 4;
            // 
            // Sero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(903, 496);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.Select);
            this.Controls.Add(this.MusicList);
            this.Controls.Add(this.TopPanel);
            this.Name = "Sero";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sero";
            this.Load += new System.EventHandler(this.Sero_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label SeroMp3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox MusicList;
        private System.Windows.Forms.Button Select;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

