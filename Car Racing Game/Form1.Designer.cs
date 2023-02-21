namespace Car_Racing_Game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pause = new System.Windows.Forms.PictureBox();
            this.explosion = new System.Windows.Forms.PictureBox();
            this.award = new System.Windows.Forms.PictureBox();
            this.AI2 = new System.Windows.Forms.PictureBox();
            this.AI1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.roadTrack2 = new System.Windows.Forms.PictureBox();
            this.roadTrack1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.txtScore = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.HighScoreTxt = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.award)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.pause);
            this.panel1.Controls.Add(this.explosion);
            this.panel1.Controls.Add(this.award);
            this.panel1.Controls.Add(this.AI2);
            this.panel1.Controls.Add(this.AI1);
            this.panel1.Controls.Add(this.player);
            this.panel1.Controls.Add(this.roadTrack2);
            this.panel1.Controls.Add(this.roadTrack1);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 603);
            this.panel1.TabIndex = 0;
            // 
            // pause
            // 
            this.pause.Image = ((System.Drawing.Image)(resources.GetObject("pause.Image")));
            this.pause.Location = new System.Drawing.Point(137, 173);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(236, 86);
            this.pause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pause.TabIndex = 4;
            this.pause.TabStop = false;
            // 
            // explosion
            // 
            this.explosion.Image = global::Car_Racing_Game.Properties.Resources.explosion;
            this.explosion.Location = new System.Drawing.Point(137, 384);
            this.explosion.Name = "explosion";
            this.explosion.Size = new System.Drawing.Size(64, 64);
            this.explosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.explosion.TabIndex = 7;
            this.explosion.TabStop = false;
            // 
            // award
            // 
            this.award.Image = global::Car_Racing_Game.Properties.Resources.bronze;
            this.award.Location = new System.Drawing.Point(128, 252);
            this.award.Name = "award";
            this.award.Size = new System.Drawing.Size(250, 100);
            this.award.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.award.TabIndex = 6;
            this.award.TabStop = false;
            this.award.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // AI2
            // 
            this.AI2.Image = global::Car_Racing_Game.Properties.Resources.carYellow;
            this.AI2.Location = new System.Drawing.Point(257, 68);
            this.AI2.Name = "AI2";
            this.AI2.Size = new System.Drawing.Size(50, 99);
            this.AI2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.AI2.TabIndex = 5;
            this.AI2.TabStop = false;
            this.AI2.Tag = "carRight";
            this.AI2.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // AI1
            // 
            this.AI1.Image = global::Car_Racing_Game.Properties.Resources.ambulance;
            this.AI1.Location = new System.Drawing.Point(90, 115);
            this.AI1.Name = "AI1";
            this.AI1.Size = new System.Drawing.Size(50, 100);
            this.AI1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.AI1.TabIndex = 4;
            this.AI1.TabStop = false;
            this.AI1.Tag = "carLeft";
            this.AI1.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // player
            // 
            this.player.Image = global::Car_Racing_Game.Properties.Resources.carGrey;
            this.player.Location = new System.Drawing.Point(378, 500);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(50, 100);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 3;
            this.player.TabStop = false;
            this.player.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // roadTrack2
            // 
            this.roadTrack2.Image = global::Car_Racing_Game.Properties.Resources.roadTrack;
            this.roadTrack2.Location = new System.Drawing.Point(0, 0);
            this.roadTrack2.Name = "roadTrack2";
            this.roadTrack2.Size = new System.Drawing.Size(510, 603);
            this.roadTrack2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.roadTrack2.TabIndex = 2;
            this.roadTrack2.TabStop = false;
            this.roadTrack2.Click += new System.EventHandler(this.roadTrack2_Click);
            // 
            // roadTrack1
            // 
            this.roadTrack1.Image = global::Car_Racing_Game.Properties.Resources.roadTrack;
            this.roadTrack1.Location = new System.Drawing.Point(0, 603);
            this.roadTrack1.Name = "roadTrack1";
            this.roadTrack1.Size = new System.Drawing.Size(510, 603);
            this.roadTrack1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadTrack1.TabIndex = 1;
            this.roadTrack1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Gadugi", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(99, 686);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 145);
            this.label2.TabIndex = 3;
            this.label2.Text = "* Press arrow keys to move your car.\r\n\r\n* Avoid the enemy cars.\r\n\r\n*Press \'P\' to " +
    "pause or resume.\r\n\r\n*After a certain score game speed increases.\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // txtScore
            // 
            this.txtScore.Font = new System.Drawing.Font("Gadugi", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtScore.Location = new System.Drawing.Point(260, 613);
            this.txtScore.Name = "txtScore";
            this.txtScore.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtScore.Size = new System.Drawing.Size(259, 29);
            this.txtScore.TabIndex = 2;
            this.txtScore.Text = "Score : 0";
            this.txtScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtScore.Click += new System.EventHandler(this.txtScore_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnStart.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStart.Location = new System.Drawing.Point(214, 645);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(91, 35);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.restartGame);
            // 
            // HighScoreTxt
            // 
            this.HighScoreTxt.Font = new System.Drawing.Font("Gadugi", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HighScoreTxt.Location = new System.Drawing.Point(9, 613);
            this.HighScoreTxt.Name = "HighScoreTxt";
            this.HighScoreTxt.Size = new System.Drawing.Size(253, 29);
            this.HighScoreTxt.TabIndex = 4;
            this.HighScoreTxt.Text = "HighScore : 0";
            this.HighScoreTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HighScoreTxt.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 831);
            this.Controls.Add(this.HighScoreTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Car Racing Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.award)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadTrack1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label2;
        private PictureBox roadTrack1;
        private PictureBox roadTrack2;
        private PictureBox explosion;
        private PictureBox award;
        private PictureBox AI2;
        private PictureBox AI1;
        private PictureBox player;
        private System.Windows.Forms.Timer gameTimer;
        private Label txtScore;
        private Button btnStart;
        private PictureBox pause;
        private Label HighScoreTxt;
    }
}