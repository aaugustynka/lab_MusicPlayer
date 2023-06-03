namespace MusicPlayer
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnOpen = new System.Windows.Forms.Button();
            this.BtnPlay = new System.Windows.Forms.Button();
            this.BtnPause = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.BtnForward = new System.Windows.Forms.Button();
            this.BtnBackward = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.BtnPlayPlaylist = new System.Windows.Forms.Button();
            this.ListViewPlaylist = new System.Windows.Forms.ListView();
            this.TrackBarVolume = new System.Windows.Forms.TrackBar();
            this.TrackBarProgress = new System.Windows.Forms.TrackBar();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.LblStatus = new System.Windows.Forms.Label();
            this.LblTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarProgress)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnOpen
            // 
            this.BtnOpen.BackColor = System.Drawing.Color.Pink;
            this.BtnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnOpen.Location = new System.Drawing.Point(12, 402);
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Size = new System.Drawing.Size(99, 61);
            this.BtnOpen.TabIndex = 0;
            this.BtnOpen.Text = "LOAD";
            this.BtnOpen.UseVisualStyleBackColor = false;
            // 
            // BtnPlay
            // 
            this.BtnPlay.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnPlay.BackColor = System.Drawing.Color.Black;
            this.BtnPlay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPlay.BackgroundImage")));
            this.BtnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPlay.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnPlay.Location = new System.Drawing.Point(551, 422);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(62, 61);
            this.BtnPlay.TabIndex = 1;
            this.BtnPlay.UseVisualStyleBackColor = false;
            // 
            // BtnPause
            // 
            this.BtnPause.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPause.BackgroundImage")));
            this.BtnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnPause.ForeColor = System.Drawing.Color.Coral;
            this.BtnPause.Location = new System.Drawing.Point(480, 422);
            this.BtnPause.Name = "BtnPause";
            this.BtnPause.Size = new System.Drawing.Size(65, 61);
            this.BtnPause.TabIndex = 2;
            this.BtnPause.UseVisualStyleBackColor = true;
            // 
            // BtnStop
            // 
            this.BtnStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnStop.BackgroundImage")));
            this.BtnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnStop.Location = new System.Drawing.Point(619, 422);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(79, 61);
            this.BtnStop.TabIndex = 3;
            this.BtnStop.UseVisualStyleBackColor = true;
            // 
            // BtnForward
            // 
            this.BtnForward.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnForward.BackgroundImage")));
            this.BtnForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnForward.Location = new System.Drawing.Point(704, 422);
            this.BtnForward.Name = "BtnForward";
            this.BtnForward.Size = new System.Drawing.Size(72, 61);
            this.BtnForward.TabIndex = 4;
            this.BtnForward.UseVisualStyleBackColor = true;
            // 
            // BtnBackward
            // 
            this.BtnBackward.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnBackward.BackgroundImage")));
            this.BtnBackward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnBackward.Location = new System.Drawing.Point(404, 422);
            this.BtnBackward.Name = "BtnBackward";
            this.BtnBackward.Size = new System.Drawing.Size(70, 61);
            this.BtnBackward.TabIndex = 5;
            this.BtnBackward.UseVisualStyleBackColor = true;
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.Pink;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnAdd.Location = new System.Drawing.Point(117, 402);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(95, 61);
            this.BtnAdd.TabIndex = 6;
            this.BtnAdd.Text = "ADD";
            this.BtnAdd.UseVisualStyleBackColor = false;
            // 
            // BtnRemove
            // 
            this.BtnRemove.BackColor = System.Drawing.Color.Pink;
            this.BtnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnRemove.Location = new System.Drawing.Point(218, 402);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(127, 61);
            this.BtnRemove.TabIndex = 7;
            this.BtnRemove.Text = "REMOVE";
            this.BtnRemove.UseVisualStyleBackColor = false;
            // 
            // BtnPlayPlaylist
            // 
            this.BtnPlayPlaylist.BackColor = System.Drawing.Color.Pink;
            this.BtnPlayPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtnPlayPlaylist.Location = new System.Drawing.Point(32, 478);
            this.BtnPlayPlaylist.Name = "BtnPlayPlaylist";
            this.BtnPlayPlaylist.Size = new System.Drawing.Size(284, 61);
            this.BtnPlayPlaylist.TabIndex = 8;
            this.BtnPlayPlaylist.Text = "CONFIRM AND PLAY";
            this.BtnPlayPlaylist.UseVisualStyleBackColor = false;
            // 
            // ListViewPlaylist
            // 
            this.ListViewPlaylist.HideSelection = false;
            this.ListViewPlaylist.Location = new System.Drawing.Point(32, 150);
            this.ListViewPlaylist.Name = "ListViewPlaylist";
            this.ListViewPlaylist.Size = new System.Drawing.Size(284, 246);
            this.ListViewPlaylist.TabIndex = 9;
            this.ListViewPlaylist.UseCompatibleStateImageBehavior = false;
            // 
            // TrackBarVolume
            // 
            this.TrackBarVolume.BackColor = System.Drawing.Color.Pink;
            this.TrackBarVolume.Location = new System.Drawing.Point(624, 520);
            this.TrackBarVolume.Name = "TrackBarVolume";
            this.TrackBarVolume.Size = new System.Drawing.Size(195, 56);
            this.TrackBarVolume.TabIndex = 10;
            // 
            // TrackBarProgress
            // 
            this.TrackBarProgress.BackColor = System.Drawing.Color.Pink;
            this.TrackBarProgress.Location = new System.Drawing.Point(361, 360);
            this.TrackBarProgress.Name = "TrackBarProgress";
            this.TrackBarProgress.Size = new System.Drawing.Size(488, 56);
            this.TrackBarProgress.TabIndex = 11;
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(551, 520);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 56);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.BackColor = System.Drawing.Color.Pink;
            this.LblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblStatus.Location = new System.Drawing.Point(356, 313);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(165, 25);
            this.LblStatus.TabIndex = 12;
            this.LblStatus.Text = "MUSICPLAYER";
            // 
            // LblTime
            // 
            this.LblTime.AutoSize = true;
            this.LblTime.BackColor = System.Drawing.Color.Pink;
            this.LblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LblTime.Location = new System.Drawing.Point(786, 425);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(0, 25);
            this.LblTime.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(929, 588);
            this.Controls.Add(this.LblTime);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.TrackBarProgress);
            this.Controls.Add(this.TrackBarVolume);
            this.Controls.Add(this.ListViewPlaylist);
            this.Controls.Add(this.BtnPlayPlaylist);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnBackward);
            this.Controls.Add(this.BtnForward);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.BtnPause);
            this.Controls.Add(this.BtnPlay);
            this.Controls.Add(this.BtnOpen);
            this.Name = "Form1";
            this.Text = "MUSICPLAYER";
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarProgress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOpen;
        private System.Windows.Forms.Button BtnPlay;
        private System.Windows.Forms.Button BtnPause;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button BtnForward;
        private System.Windows.Forms.Button BtnBackward;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button BtnPlayPlaylist;
        private System.Windows.Forms.ListView ListViewPlaylist;
        private System.Windows.Forms.TrackBar TrackBarVolume;
        private System.Windows.Forms.TrackBar TrackBarProgress;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.Label LblTime;
    }
}

