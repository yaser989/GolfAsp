namespace golf
{
    partial class Golf
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtScore = new System.Windows.Forms.Label();
            this.Gol = new System.Windows.Forms.PictureBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.ball = new System.Windows.Forms.PictureBox();
            this.forcetxt = new System.Windows.Forms.Label();
            this.meters = new System.Windows.Forms.Label();
            this.gameOver = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Gol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.AllowDrop = true;
            this.txtScore.Font = new System.Drawing.Font("Consolas", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.ForeColor = System.Drawing.Color.Black;
            this.txtScore.Location = new System.Drawing.Point(424, 9);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(306, 151);
            this.txtScore.TabIndex = 0;
            this.txtScore.Text = "Score: 0";
            this.txtScore.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.txtScore.UseMnemonic = false;
            // 
            // Gol
            // 
            this.Gol.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Gol.Location = new System.Drawing.Point(327, 69);
            this.Gol.Name = "Gol";
            this.Gol.Size = new System.Drawing.Size(41, 42);
            this.Gol.TabIndex = 2;
            this.Gol.TabStop = false;
            this.Gol.Tag = "gol";
            this.Gol.Click += new System.EventHandler(this.Gol_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.FloralWhite;
            this.ball.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ball.Location = new System.Drawing.Point(336, 550);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(17, 22);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            this.ball.Tag = "ball";
            this.ball.Click += new System.EventHandler(this.ball_Click);
            // 
            // forcetxt
            // 
            this.forcetxt.AutoSize = true;
            this.forcetxt.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forcetxt.Location = new System.Drawing.Point(292, 588);
            this.forcetxt.Name = "forcetxt";
            this.forcetxt.Size = new System.Drawing.Size(120, 33);
            this.forcetxt.TabIndex = 3;
            this.forcetxt.Tag = "forcetxt";
            this.forcetxt.Text = "force: ";
            this.forcetxt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // meters
            // 
            this.meters.AutoSize = true;
            this.meters.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meters.Location = new System.Drawing.Point(13, 13);
            this.meters.Name = "meters";
            this.meters.Size = new System.Drawing.Size(135, 33);
            this.meters.TabIndex = 4;
            this.meters.Tag = "txtMeters";
            this.meters.Text = "meters: ";
            this.meters.Click += new System.EventHandler(this.label1_Click);
            // 
            // gameOver
            // 
            this.gameOver.AutoSize = true;
            this.gameOver.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOver.ForeColor = System.Drawing.Color.Firebrick;
            this.gameOver.Location = new System.Drawing.Point(244, 297);
            this.gameOver.Name = "gameOver";
            this.gameOver.Size = new System.Drawing.Size(218, 47);
            this.gameOver.TabIndex = 5;
            this.gameOver.Text = "GAME OVER";
            // 
            // Golf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(739, 630);
            this.Controls.Add(this.gameOver);
            this.Controls.Add(this.meters);
            this.Controls.Add(this.forcetxt);
            this.Controls.Add(this.Gol);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.txtScore);
            this.Name = "Golf";
            this.Text = "Golf";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.Gol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.PictureBox Gol;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Label forcetxt;
        private System.Windows.Forms.Label meters;
        private System.Windows.Forms.Label gameOver;
    }
}

