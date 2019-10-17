namespace RussionRouletteGame
{
    partial class MainGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGame));
            this.cbPointAway = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbWins = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbPlayer = new System.Windows.Forms.Label();
            this.lblWaitingToDIe = new System.Windows.Forms.Label();
            this.bullet6 = new System.Windows.Forms.PictureBox();
            this.bullet5 = new System.Windows.Forms.PictureBox();
            this.bullet4 = new System.Windows.Forms.PictureBox();
            this.bullet3 = new System.Windows.Forms.PictureBox();
            this.bullet2 = new System.Windows.Forms.PictureBox();
            this.bullet1 = new System.Windows.Forms.PictureBox();
            this.btn_RecordScore = new System.Windows.Forms.Button();
            this.btnFire = new System.Windows.Forms.Button();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.btnSpinChambers = new System.Windows.Forms.Button();
            this.btnLoadBullet = new System.Windows.Forms.Button();
            this.pbImage3 = new System.Windows.Forms.PictureBox();
            this.pbImage2 = new System.Windows.Forms.PictureBox();
            this.pbImage1 = new System.Windows.Forms.PictureBox();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bullet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbPointAway
            // 
            this.cbPointAway.AutoSize = true;
            this.cbPointAway.BackColor = System.Drawing.Color.Black;
            this.cbPointAway.Font = new System.Drawing.Font("OCR A Extended", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPointAway.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.cbPointAway.Location = new System.Drawing.Point(9, 56);
            this.cbPointAway.Margin = new System.Windows.Forms.Padding(2);
            this.cbPointAway.Name = "cbPointAway";
            this.cbPointAway.Size = new System.Drawing.Size(148, 24);
            this.cbPointAway.TabIndex = 4;
            this.cbPointAway.Text = "POINT AWAY";
            this.cbPointAway.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Location = new System.Drawing.Point(9, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Your Score:";
            // 
            // lbWins
            // 
            this.lbWins.AutoSize = true;
            this.lbWins.BackColor = System.Drawing.Color.Black;
            this.lbWins.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWins.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lbWins.Location = new System.Drawing.Point(101, 33);
            this.lbWins.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbWins.Name = "lbWins";
            this.lbWins.Size = new System.Drawing.Size(15, 15);
            this.lbWins.TabIndex = 6;
            this.lbWins.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Location = new System.Drawing.Point(9, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Player Name:";
            // 
            // lbPlayer
            // 
            this.lbPlayer.AutoSize = true;
            this.lbPlayer.BackColor = System.Drawing.Color.Black;
            this.lbPlayer.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayer.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.lbPlayer.Location = new System.Drawing.Point(108, 10);
            this.lbPlayer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPlayer.Name = "lbPlayer";
            this.lbPlayer.Size = new System.Drawing.Size(39, 15);
            this.lbPlayer.TabIndex = 8;
            this.lbPlayer.Text = "Name";
            // 
            // lblWaitingToDIe
            // 
            this.lblWaitingToDIe.AutoSize = true;
            this.lblWaitingToDIe.BackColor = System.Drawing.Color.Black;
            this.lblWaitingToDIe.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaitingToDIe.ForeColor = System.Drawing.Color.Red;
            this.lblWaitingToDIe.Location = new System.Drawing.Point(58, 58);
            this.lblWaitingToDIe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWaitingToDIe.Name = "lblWaitingToDIe";
            this.lblWaitingToDIe.Size = new System.Drawing.Size(228, 17);
            this.lblWaitingToDIe.TabIndex = 25;
            this.lblWaitingToDIe.Text = "YOU\'RE GOING TO DIE!";
            this.lblWaitingToDIe.Visible = false;
            // 
            // bullet6
            // 
            this.bullet6.Image = ((System.Drawing.Image)(resources.GetObject("bullet6.Image")));
            this.bullet6.Location = new System.Drawing.Point(239, 301);
            this.bullet6.Margin = new System.Windows.Forms.Padding(2);
            this.bullet6.Name = "bullet6";
            this.bullet6.Size = new System.Drawing.Size(22, 57);
            this.bullet6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bullet6.TabIndex = 24;
            this.bullet6.TabStop = false;
            this.bullet6.Visible = false;
            // 
            // bullet5
            // 
            this.bullet5.Image = ((System.Drawing.Image)(resources.GetObject("bullet5.Image")));
            this.bullet5.Location = new System.Drawing.Point(212, 301);
            this.bullet5.Margin = new System.Windows.Forms.Padding(2);
            this.bullet5.Name = "bullet5";
            this.bullet5.Size = new System.Drawing.Size(22, 57);
            this.bullet5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bullet5.TabIndex = 23;
            this.bullet5.TabStop = false;
            this.bullet5.Visible = false;
            // 
            // bullet4
            // 
            this.bullet4.Image = ((System.Drawing.Image)(resources.GetObject("bullet4.Image")));
            this.bullet4.Location = new System.Drawing.Point(185, 301);
            this.bullet4.Margin = new System.Windows.Forms.Padding(2);
            this.bullet4.Name = "bullet4";
            this.bullet4.Size = new System.Drawing.Size(22, 57);
            this.bullet4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bullet4.TabIndex = 22;
            this.bullet4.TabStop = false;
            this.bullet4.Visible = false;
            // 
            // bullet3
            // 
            this.bullet3.Image = ((System.Drawing.Image)(resources.GetObject("bullet3.Image")));
            this.bullet3.Location = new System.Drawing.Point(158, 301);
            this.bullet3.Margin = new System.Windows.Forms.Padding(2);
            this.bullet3.Name = "bullet3";
            this.bullet3.Size = new System.Drawing.Size(22, 57);
            this.bullet3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bullet3.TabIndex = 21;
            this.bullet3.TabStop = false;
            this.bullet3.Visible = false;
            // 
            // bullet2
            // 
            this.bullet2.Image = ((System.Drawing.Image)(resources.GetObject("bullet2.Image")));
            this.bullet2.Location = new System.Drawing.Point(131, 301);
            this.bullet2.Margin = new System.Windows.Forms.Padding(2);
            this.bullet2.Name = "bullet2";
            this.bullet2.Size = new System.Drawing.Size(22, 57);
            this.bullet2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bullet2.TabIndex = 20;
            this.bullet2.TabStop = false;
            this.bullet2.Visible = false;
            // 
            // bullet1
            // 
            this.bullet1.Image = ((System.Drawing.Image)(resources.GetObject("bullet1.Image")));
            this.bullet1.Location = new System.Drawing.Point(104, 301);
            this.bullet1.Margin = new System.Windows.Forms.Padding(2);
            this.bullet1.Name = "bullet1";
            this.bullet1.Size = new System.Drawing.Size(22, 57);
            this.bullet1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bullet1.TabIndex = 19;
            this.bullet1.TabStop = false;
            this.bullet1.Visible = false;
            // 
            // btn_RecordScore
            // 
            this.btn_RecordScore.BackgroundImage = global::RussionRouletteGame.Properties.Resources.button_fire;
            this.btn_RecordScore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RecordScore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_RecordScore.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RecordScore.ForeColor = System.Drawing.Color.White;
            this.btn_RecordScore.Location = new System.Drawing.Point(428, 56);
            this.btn_RecordScore.Margin = new System.Windows.Forms.Padding(2);
            this.btn_RecordScore.Name = "btn_RecordScore";
            this.btn_RecordScore.Size = new System.Drawing.Size(150, 41);
            this.btn_RecordScore.TabIndex = 9;
            this.btn_RecordScore.Text = "Record Score";
            this.btn_RecordScore.UseVisualStyleBackColor = true;
            this.btn_RecordScore.Click += new System.EventHandler(this.btn_Score_Click);
            // 
            // btnFire
            // 
            this.btnFire.BackColor = System.Drawing.SystemColors.Control;
            this.btnFire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFire.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFire.Font = new System.Drawing.Font("OCR A Extended", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFire.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFire.Image = global::RussionRouletteGame.Properties.Resources.button_fire;
            this.btnFire.Location = new System.Drawing.Point(274, 301);
            this.btnFire.Margin = new System.Windows.Forms.Padding(2);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(304, 57);
            this.btnFire.TabIndex = 3;
            this.btnFire.Text = "FIRE!";
            this.btnFire.UseVisualStyleBackColor = false;
            this.btnFire.Click += new System.EventHandler(this.btnFire_Click);
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlayAgain.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgain.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPlayAgain.Image = global::RussionRouletteGame.Properties.Resources.button_load;
            this.btnPlayAgain.Location = new System.Drawing.Point(428, 10);
            this.btnPlayAgain.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(150, 41);
            this.btnPlayAgain.TabIndex = 2;
            this.btnPlayAgain.Text = "PLAY AGAIN";
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // btnSpinChambers
            // 
            this.btnSpinChambers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSpinChambers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSpinChambers.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpinChambers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSpinChambers.Image = global::RussionRouletteGame.Properties.Resources.button_spin;
            this.btnSpinChambers.Location = new System.Drawing.Point(428, 256);
            this.btnSpinChambers.Margin = new System.Windows.Forms.Padding(2);
            this.btnSpinChambers.Name = "btnSpinChambers";
            this.btnSpinChambers.Size = new System.Drawing.Size(150, 41);
            this.btnSpinChambers.TabIndex = 1;
            this.btnSpinChambers.Text = "SPIN CHAMBERS";
            this.btnSpinChambers.UseVisualStyleBackColor = true;
            this.btnSpinChambers.Click += new System.EventHandler(this.btnSpinChambers_Click);
            // 
            // btnLoadBullet
            // 
            this.btnLoadBullet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLoadBullet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadBullet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoadBullet.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadBullet.ForeColor = System.Drawing.Color.MintCream;
            this.btnLoadBullet.Image = global::RussionRouletteGame.Properties.Resources.button_load;
            this.btnLoadBullet.Location = new System.Drawing.Point(273, 256);
            this.btnLoadBullet.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoadBullet.Name = "btnLoadBullet";
            this.btnLoadBullet.Size = new System.Drawing.Size(150, 41);
            this.btnLoadBullet.TabIndex = 0;
            this.btnLoadBullet.Text = "LOAD BULLET";
            this.btnLoadBullet.UseVisualStyleBackColor = true;
            this.btnLoadBullet.Click += new System.EventHandler(this.btnLoadBullet_Click);
            // 
            // pbImage3
            // 
            this.pbImage3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbImage3.Image = global::RussionRouletteGame.Properties.Resources.player_image3;
            this.pbImage3.Location = new System.Drawing.Point(0, 0);
            this.pbImage3.Margin = new System.Windows.Forms.Padding(2);
            this.pbImage3.Name = "pbImage3";
            this.pbImage3.Size = new System.Drawing.Size(586, 368);
            this.pbImage3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage3.TabIndex = 18;
            this.pbImage3.TabStop = false;
            this.pbImage3.Visible = false;
            // 
            // pbImage2
            // 
            this.pbImage2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbImage2.Image = global::RussionRouletteGame.Properties.Resources.player_image2;
            this.pbImage2.Location = new System.Drawing.Point(0, 0);
            this.pbImage2.Margin = new System.Windows.Forms.Padding(2);
            this.pbImage2.Name = "pbImage2";
            this.pbImage2.Size = new System.Drawing.Size(586, 368);
            this.pbImage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage2.TabIndex = 17;
            this.pbImage2.TabStop = false;
            this.pbImage2.Visible = false;
            // 
            // pbImage1
            // 
            this.pbImage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbImage1.Image = global::RussionRouletteGame.Properties.Resources.player_image1;
            this.pbImage1.Location = new System.Drawing.Point(0, 0);
            this.pbImage1.Margin = new System.Windows.Forms.Padding(2);
            this.pbImage1.Name = "pbImage1";
            this.pbImage1.Size = new System.Drawing.Size(586, 368);
            this.pbImage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage1.TabIndex = 16;
            this.pbImage1.TabStop = false;
            // 
            // btn_back
            // 
            this.btn_back.BackgroundImage = global::RussionRouletteGame.Properties.Resources.button_fire;
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_back.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(257, 11);
            this.btn_back.Margin = new System.Windows.Forms.Padding(2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(150, 41);
            this.btn_back.TabIndex = 26;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(586, 368);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lblWaitingToDIe);
            this.Controls.Add(this.bullet6);
            this.Controls.Add(this.bullet5);
            this.Controls.Add(this.bullet4);
            this.Controls.Add(this.bullet3);
            this.Controls.Add(this.bullet2);
            this.Controls.Add(this.bullet1);
            this.Controls.Add(this.cbPointAway);
            this.Controls.Add(this.btn_RecordScore);
            this.Controls.Add(this.lbPlayer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbWins);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFire);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.btnSpinChambers);
            this.Controls.Add(this.btnLoadBullet);
            this.Controls.Add(this.pbImage3);
            this.Controls.Add(this.pbImage2);
            this.Controls.Add(this.pbImage1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainGame";
            this.Text = "MainGame";
            this.Load += new System.EventHandler(this.MainGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bullet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadBullet;
        private System.Windows.Forms.Button btnSpinChambers;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Button btnFire;
        private System.Windows.Forms.CheckBox cbPointAway;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbWins;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbPlayer;
        private System.Windows.Forms.Button btn_RecordScore;
        private System.Windows.Forms.PictureBox pbImage1;
        private System.Windows.Forms.PictureBox pbImage2;
        private System.Windows.Forms.PictureBox pbImage3;
        private System.Windows.Forms.PictureBox bullet1;
        private System.Windows.Forms.PictureBox bullet2;
        private System.Windows.Forms.PictureBox bullet3;
        private System.Windows.Forms.PictureBox bullet4;
        private System.Windows.Forms.PictureBox bullet5;
        private System.Windows.Forms.PictureBox bullet6;
        private System.Windows.Forms.Label lblWaitingToDIe;
        private System.Windows.Forms.Button btn_back;
    }
}