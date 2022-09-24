namespace CarGame
{
    partial class Form1
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
            this.pnlGame = new System.Windows.Forms.Panel();
            this.car = new System.Windows.Forms.PictureBox();
            this.car1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.L6 = new System.Windows.Forms.PictureBox();
            this.L5 = new System.Windows.Forms.PictureBox();
            this.L4 = new System.Windows.Forms.PictureBox();
            this.L3 = new System.Windows.Forms.PictureBox();
            this.L2 = new System.Windows.Forms.PictureBox();
            this.L1 = new System.Windows.Forms.PictureBox();
            this.Lblscore = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.GameOver = new System.Windows.Forms.Label();
            this.car2 = new System.Windows.Forms.PictureBox();
            this.pnlGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlGame
            // 
            this.pnlGame.BackColor = System.Drawing.Color.CornflowerBlue;
            this.pnlGame.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlGame.Controls.Add(this.car2);
            this.pnlGame.Controls.Add(this.GameOver);
            this.pnlGame.Controls.Add(this.car);
            this.pnlGame.Controls.Add(this.car1);
            this.pnlGame.Controls.Add(this.player);
            this.pnlGame.Controls.Add(this.L6);
            this.pnlGame.Controls.Add(this.L5);
            this.pnlGame.Controls.Add(this.L4);
            this.pnlGame.Controls.Add(this.L3);
            this.pnlGame.Controls.Add(this.L2);
            this.pnlGame.Controls.Add(this.L1);
            this.pnlGame.Location = new System.Drawing.Point(-1, 66);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(485, 538);
            this.pnlGame.TabIndex = 0;
            // 
            // car
            // 
            this.car.BackColor = System.Drawing.Color.Transparent;
            this.car.Image = global::CarGame.Properties.Resources.car2;
            this.car.Location = new System.Drawing.Point(22, 177);
            this.car.Name = "car";
            this.car.Size = new System.Drawing.Size(46, 99);
            this.car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.car.TabIndex = 8;
            this.car.TabStop = false;
            // 
            // car1
            // 
            this.car1.BackColor = System.Drawing.Color.Transparent;
            this.car1.Image = global::CarGame.Properties.Resources.car4;
            this.car1.Location = new System.Drawing.Point(354, 245);
            this.car1.Name = "car1";
            this.car1.Size = new System.Drawing.Size(46, 99);
            this.car1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.car1.TabIndex = 7;
            this.car1.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.BackgroundImage = global::CarGame.Properties.Resources.car4;
            this.player.Image = global::CarGame.Properties.Resources.car0;
            this.player.Location = new System.Drawing.Point(211, 421);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(46, 99);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 6;
            this.player.TabStop = false;
            this.player.Click += new System.EventHandler(this.player_Click);
            // 
            // L6
            // 
            this.L6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.L6.Location = new System.Drawing.Point(367, 364);
            this.L6.Name = "L6";
            this.L6.Size = new System.Drawing.Size(16, 204);
            this.L6.TabIndex = 5;
            this.L6.TabStop = false;
            // 
            // L5
            // 
            this.L5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.L5.Location = new System.Drawing.Point(367, 20);
            this.L5.Name = "L5";
            this.L5.Size = new System.Drawing.Size(16, 204);
            this.L5.TabIndex = 4;
            this.L5.TabStop = false;
            // 
            // L4
            // 
            this.L4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.L4.Location = new System.Drawing.Point(225, 364);
            this.L4.Name = "L4";
            this.L4.Size = new System.Drawing.Size(16, 204);
            this.L4.TabIndex = 3;
            this.L4.TabStop = false;
            // 
            // L3
            // 
            this.L3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.L3.Location = new System.Drawing.Point(225, 20);
            this.L3.Name = "L3";
            this.L3.Size = new System.Drawing.Size(16, 204);
            this.L3.TabIndex = 2;
            this.L3.TabStop = false;
            // 
            // L2
            // 
            this.L2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.L2.Location = new System.Drawing.Point(91, 364);
            this.L2.Name = "L2";
            this.L2.Size = new System.Drawing.Size(16, 204);
            this.L2.TabIndex = 1;
            this.L2.TabStop = false;
            // 
            // L1
            // 
            this.L1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.L1.Location = new System.Drawing.Point(91, 20);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(16, 204);
            this.L1.TabIndex = 0;
            this.L1.TabStop = false;
            // 
            // Lblscore
            // 
            this.Lblscore.AutoSize = true;
            this.Lblscore.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblscore.ForeColor = System.Drawing.Color.DarkGray;
            this.Lblscore.Location = new System.Drawing.Point(159, 12);
            this.Lblscore.Name = "Lblscore";
            this.Lblscore.Size = new System.Drawing.Size(148, 36);
            this.Lblscore.TabIndex = 1;
            this.Lblscore.Text = "Score : 0";
            this.Lblscore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // GameOver
            // 
            this.GameOver.AutoSize = true;
            this.GameOver.BackColor = System.Drawing.Color.Brown;
            this.GameOver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GameOver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GameOver.Font = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Bold);
            this.GameOver.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GameOver.Location = new System.Drawing.Point(128, 177);
            this.GameOver.Name = "GameOver";
            this.GameOver.Size = new System.Drawing.Size(222, 47);
            this.GameOver.TabIndex = 9;
            this.GameOver.Text = "Game over";
            this.GameOver.Visible = false;
            // 
            // car2
            // 
            this.car2.BackColor = System.Drawing.Color.Transparent;
            this.car2.Image = global::CarGame.Properties.Resources.car1;
            this.car2.Location = new System.Drawing.Point(152, 339);
            this.car2.Name = "car2";
            this.car2.Size = new System.Drawing.Size(46, 99);
            this.car2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.car2.TabIndex = 10;
            this.car2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(486, 605);
            this.Controls.Add(this.Lblscore);
            this.Controls.Add(this.pnlGame);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Car Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.pnlGame.ResumeLayout(false);
            this.pnlGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.Label Lblscore;
        private System.Windows.Forms.PictureBox L6;
        private System.Windows.Forms.PictureBox L5;
        private System.Windows.Forms.PictureBox L4;
        private System.Windows.Forms.PictureBox L3;
        private System.Windows.Forms.PictureBox L2;
        private System.Windows.Forms.PictureBox L1;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox car;
        private System.Windows.Forms.PictureBox car1;
        private System.Windows.Forms.Label GameOver;
        private System.Windows.Forms.PictureBox car2;
    }
}

