namespace RussionRouletteGame
{
    partial class StartScreen
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
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnHighScores = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.Black;
            this.btnNewGame.BackgroundImage = global::RussionRouletteGame.Properties.Resources.button_image;
            this.btnNewGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewGame.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.ForeColor = System.Drawing.Color.White;
            this.btnNewGame.Location = new System.Drawing.Point(22, 265);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(200, 50);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Text = "NEW GAME";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnHighScores
            // 
            this.btnHighScores.BackColor = System.Drawing.Color.Black;
            this.btnHighScores.BackgroundImage = global::RussionRouletteGame.Properties.Resources.button_image;
            this.btnHighScores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHighScores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHighScores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHighScores.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHighScores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHighScores.Location = new System.Drawing.Point(22, 321);
            this.btnHighScores.Name = "btnHighScores";
            this.btnHighScores.Size = new System.Drawing.Size(200, 50);
            this.btnHighScores.TabIndex = 1;
            this.btnHighScores.Text = "HIGH SCORES";
            this.btnHighScores.UseVisualStyleBackColor = false;
            this.btnHighScores.Click += new System.EventHandler(this.btnHighScores_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.BackgroundImage = global::RussionRouletteGame.Properties.Resources.button_image;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("OCR A Extended", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(22, 377);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 50);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "R U S S I A N   R O U L E T T E";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartScreen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::RussionRouletteGame.Properties.Resources.title_image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(682, 453);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHighScores);
            this.Controls.Add(this.btnNewGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StartScreen";
            this.Text = "Welcome to Russian Roulette";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnHighScores;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
    }
}

