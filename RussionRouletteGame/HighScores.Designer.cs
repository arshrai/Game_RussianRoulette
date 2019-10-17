namespace RussionRouletteGame
{
    partial class HighScores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGScores = new System.Windows.Forms.DataGridView();
            this.PlayerNames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HighestScores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGScores)).BeginInit();
            this.SuspendLayout();
            // 
            // DGScores
            // 
            this.DGScores.AllowUserToAddRows = false;
            this.DGScores.AllowUserToDeleteRows = false;
            this.DGScores.AllowUserToResizeColumns = false;
            this.DGScores.AllowUserToResizeRows = false;
            this.DGScores.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGScores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGScores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlayerNames,
            this.HighestScores});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGScores.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGScores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGScores.GridColor = System.Drawing.SystemColors.Control;
            this.DGScores.Location = new System.Drawing.Point(0, 0);
            this.DGScores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DGScores.Name = "DGScores";
            this.DGScores.ReadOnly = true;
            this.DGScores.RowTemplate.Height = 24;
            this.DGScores.Size = new System.Drawing.Size(717, 286);
            this.DGScores.TabIndex = 0;
            // 
            // PlayerNames
            // 
            this.PlayerNames.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PlayerNames.DefaultCellStyle = dataGridViewCellStyle1;
            this.PlayerNames.HeaderText = "Player Names:";
            this.PlayerNames.MinimumWidth = 40;
            this.PlayerNames.Name = "PlayerNames";
            this.PlayerNames.ReadOnly = true;
            this.PlayerNames.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PlayerNames.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // HighestScores
            // 
            this.HighestScores.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.HighestScores.DefaultCellStyle = dataGridViewCellStyle2;
            this.HighestScores.HeaderText = "Highest Scores:";
            this.HighestScores.MinimumWidth = 20;
            this.HighestScores.Name = "HighestScores";
            this.HighestScores.ReadOnly = true;
            this.HighestScores.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // HighScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 286);
            this.Controls.Add(this.DGScores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "HighScores";
            this.Text = "HighScores";
            this.Load += new System.EventHandler(this.HighScores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGScores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGScores;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerNames;
        private System.Windows.Forms.DataGridViewTextBoxColumn HighestScores;
    }
}