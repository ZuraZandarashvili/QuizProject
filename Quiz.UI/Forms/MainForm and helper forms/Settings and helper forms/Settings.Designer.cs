namespace Quiz.UI.Forms
{
    partial class SettingsForm
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
            this.GameModebutton = new System.Windows.Forms.Button();
            this.Soundbutton = new System.Windows.Forms.Button();
            this.HighScoresStatisticsbutton = new System.Windows.Forms.Button();
            this.BeckSettingsbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GameModebutton
            // 
            this.GameModebutton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GameModebutton.FlatAppearance.BorderSize = 5;
            this.GameModebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GameModebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameModebutton.ForeColor = System.Drawing.Color.Teal;
            this.GameModebutton.Location = new System.Drawing.Point(23, 46);
            this.GameModebutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GameModebutton.Name = "GameModebutton";
            this.GameModebutton.Size = new System.Drawing.Size(510, 88);
            this.GameModebutton.TabIndex = 4;
            this.GameModebutton.Text = "Game Mode";
            this.GameModebutton.UseVisualStyleBackColor = true;
            this.GameModebutton.Click += new System.EventHandler(this.GameModebutton_Click);
            // 
            // Soundbutton
            // 
            this.Soundbutton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Soundbutton.FlatAppearance.BorderSize = 5;
            this.Soundbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Soundbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Soundbutton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Soundbutton.Location = new System.Drawing.Point(23, 144);
            this.Soundbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Soundbutton.Name = "Soundbutton";
            this.Soundbutton.Size = new System.Drawing.Size(510, 88);
            this.Soundbutton.TabIndex = 4;
            this.Soundbutton.Text = "Sound";
            this.Soundbutton.UseVisualStyleBackColor = true;
            // 
            // HighScoresStatisticsbutton
            // 
            this.HighScoresStatisticsbutton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HighScoresStatisticsbutton.FlatAppearance.BorderSize = 5;
            this.HighScoresStatisticsbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HighScoresStatisticsbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighScoresStatisticsbutton.ForeColor = System.Drawing.Color.Purple;
            this.HighScoresStatisticsbutton.Location = new System.Drawing.Point(23, 242);
            this.HighScoresStatisticsbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HighScoresStatisticsbutton.Name = "HighScoresStatisticsbutton";
            this.HighScoresStatisticsbutton.Size = new System.Drawing.Size(510, 88);
            this.HighScoresStatisticsbutton.TabIndex = 4;
            this.HighScoresStatisticsbutton.Text = " High Scores Statistics";
            this.HighScoresStatisticsbutton.UseVisualStyleBackColor = true;
            this.HighScoresStatisticsbutton.Click += new System.EventHandler(this.HighScoresStatisticsbutton_Click);
            // 
            // BeckSettingsbutton
            // 
            this.BeckSettingsbutton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BeckSettingsbutton.FlatAppearance.BorderSize = 5;
            this.BeckSettingsbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BeckSettingsbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BeckSettingsbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BeckSettingsbutton.Location = new System.Drawing.Point(23, 340);
            this.BeckSettingsbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BeckSettingsbutton.Name = "BeckSettingsbutton";
            this.BeckSettingsbutton.Size = new System.Drawing.Size(510, 88);
            this.BeckSettingsbutton.TabIndex = 6;
            this.BeckSettingsbutton.Text = "Back";
            this.BeckSettingsbutton.UseVisualStyleBackColor = true;
            this.BeckSettingsbutton.Click += new System.EventHandler(this.BeckSettingsbutton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 486);
            this.Controls.Add(this.BeckSettingsbutton);
            this.Controls.Add(this.HighScoresStatisticsbutton);
            this.Controls.Add(this.Soundbutton);
            this.Controls.Add(this.GameModebutton);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GameModebutton;
        private System.Windows.Forms.Button Soundbutton;
        private System.Windows.Forms.Button HighScoresStatisticsbutton;
        private System.Windows.Forms.Button BeckSettingsbutton;
    }
}