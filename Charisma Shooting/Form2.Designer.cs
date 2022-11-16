namespace Charisma_Shooting
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.BgMove = new System.Windows.Forms.Timer(this.components);
            this.Uptimer = new System.Windows.Forms.Timer(this.components);
            this.DownTimer = new System.Windows.Forms.Timer(this.components);
            this.LeftTimer = new System.Windows.Forms.Timer(this.components);
            this.RightTimer = new System.Windows.Forms.Timer(this.components);
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.PBbullet = new System.Windows.Forms.PictureBox();
            this.BulletTimer = new System.Windows.Forms.Timer(this.components);
            this.BulletMoving = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBbullet)).BeginInit();
            this.SuspendLayout();
            // 
            // BgMove
            // 
            this.BgMove.Enabled = true;
            this.BgMove.Interval = 10;
            this.BgMove.Tick += new System.EventHandler(this.BgMove_Tick);
            // 
            // Uptimer
            // 
            this.Uptimer.Interval = 5;
            this.Uptimer.Tick += new System.EventHandler(this.Uptimer_Tick);
            // 
            // DownTimer
            // 
            this.DownTimer.Interval = 5;
            this.DownTimer.Tick += new System.EventHandler(this.DownTimer_Tick);
            // 
            // LeftTimer
            // 
            this.LeftTimer.Interval = 5;
            this.LeftTimer.Tick += new System.EventHandler(this.LeftTimer_Tick);
            // 
            // RightTimer
            // 
            this.RightTimer.Interval = 5;
            this.RightTimer.Tick += new System.EventHandler(this.RightTimer_Tick);
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(426, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 59);
            this.label1.TabIndex = 3;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // enemy2
            // 
            this.enemy2.Image = global::Charisma_Shooting.Properties.Resources.enemy2;
            this.enemy2.Location = new System.Drawing.Point(471, 28);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(60, 54);
            this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy2.TabIndex = 2;
            this.enemy2.TabStop = false;
            // 
            // enemy1
            // 
            this.enemy1.Image = global::Charisma_Shooting.Properties.Resources.enemy1;
            this.enemy1.Location = new System.Drawing.Point(250, 28);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(55, 54);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy1.TabIndex = 1;
            this.enemy1.TabStop = false;
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.Image = global::Charisma_Shooting.Properties.Resources.spaceship_removebg_preview;
            this.Player.Location = new System.Drawing.Point(417, 616);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(137, 61);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // PBbullet
            // 
            this.PBbullet.Image = global::Charisma_Shooting.Properties.Resources.trial_removebg_preview;
            this.PBbullet.Location = new System.Drawing.Point(-200, 474);
            this.PBbullet.Name = "PBbullet";
            this.PBbullet.Size = new System.Drawing.Size(68, 96);
            this.PBbullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBbullet.TabIndex = 4;
            this.PBbullet.TabStop = false;
            this.PBbullet.Click += new System.EventHandler(this.PBbullet_Click);
            // 
            // BulletTimer
            // 
            this.BulletTimer.Enabled = true;
            this.BulletTimer.Interval = 1500;
            // 
            // BulletMoving
            // 
            this.BulletMoving.Enabled = true;
            this.BulletMoving.Interval = 50;
            this.BulletMoving.Tick += new System.EventHandler(this.BulletMoving_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1001, 675);
            this.Controls.Add(this.PBbullet);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1001, 675);
            this.MinimumSize = new System.Drawing.Size(1001, 675);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBbullet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer BgMove;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.Timer Uptimer;
        private System.Windows.Forms.Timer DownTimer;
        private System.Windows.Forms.Timer LeftTimer;
        private System.Windows.Forms.Timer RightTimer;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PBbullet;
        private System.Windows.Forms.Timer BulletTimer;
        private System.Windows.Forms.Timer BulletMoving;
    }
}