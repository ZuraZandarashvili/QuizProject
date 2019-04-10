namespace Quiz.UI.Forms
{ 
    partial class HighScoreForm
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
            this.HighScoureBackbutton = new System.Windows.Forms.Button();
            this.HighScoreUntimedGamebutton = new System.Windows.Forms.Button();
            this.HighScoreGameOnTimebutton = new System.Windows.Forms.Button();
            this.recordsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // HighScoureBackbutton
            // 
            this.HighScoureBackbutton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HighScoureBackbutton.FlatAppearance.BorderSize = 5;
            this.HighScoureBackbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HighScoureBackbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighScoureBackbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.HighScoureBackbutton.Location = new System.Drawing.Point(21, 259);
            this.HighScoureBackbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HighScoureBackbutton.Name = "HighScoureBackbutton";
            this.HighScoureBackbutton.Size = new System.Drawing.Size(343, 88);
            this.HighScoureBackbutton.TabIndex = 10;
            this.HighScoureBackbutton.Text = "Back";
            this.HighScoureBackbutton.UseVisualStyleBackColor = true;
            this.HighScoureBackbutton.Click += new System.EventHandler(this.HighScoureBackbutton_Click);
            // 
            // HighScoreUntimedGamebutton
            // 
            this.HighScoreUntimedGamebutton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HighScoreUntimedGamebutton.FlatAppearance.BorderSize = 5;
            this.HighScoreUntimedGamebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HighScoreUntimedGamebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighScoreUntimedGamebutton.ForeColor = System.Drawing.Color.Teal;
            this.HighScoreUntimedGamebutton.Location = new System.Drawing.Point(21, 161);
            this.HighScoreUntimedGamebutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HighScoreUntimedGamebutton.Name = "HighScoreUntimedGamebutton";
            this.HighScoreUntimedGamebutton.Size = new System.Drawing.Size(343, 88);
            this.HighScoreUntimedGamebutton.TabIndex = 8;
            this.HighScoreUntimedGamebutton.Text = "High Score Untimed Game";
            this.HighScoreUntimedGamebutton.UseVisualStyleBackColor = true;
            // 
            // HighScoreGameOnTimebutton
            // 
            this.HighScoreGameOnTimebutton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HighScoreGameOnTimebutton.FlatAppearance.BorderSize = 5;
            this.HighScoreGameOnTimebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HighScoreGameOnTimebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HighScoreGameOnTimebutton.ForeColor = System.Drawing.Color.ForestGreen;
            this.HighScoreGameOnTimebutton.Location = new System.Drawing.Point(21, 63);
            this.HighScoreGameOnTimebutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HighScoreGameOnTimebutton.Name = "HighScoreGameOnTimebutton";
            this.HighScoreGameOnTimebutton.Size = new System.Drawing.Size(343, 88);
            this.HighScoreGameOnTimebutton.TabIndex = 9;
            this.HighScoreGameOnTimebutton.Text = "High Score Game on Time";
            this.HighScoreGameOnTimebutton.UseVisualStyleBackColor = true;
            // 
            // recordsListBox
            // 
            this.recordsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.recordsListBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordsListBox.FormattingEnabled = true;
            this.recordsListBox.ItemHeight = 18;
            this.recordsListBox.Location = new System.Drawing.Point(407, 63);
            this.recordsListBox.Name = "recordsListBox";
            this.recordsListBox.Size = new System.Drawing.Size(234, 270);
            this.recordsListBox.TabIndex = 11;
            // 
            // HighScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 410);
            this.Controls.Add(this.recordsListBox);
            this.Controls.Add(this.HighScoureBackbutton);
            this.Controls.Add(this.HighScoreUntimedGamebutton);
            this.Controls.Add(this.HighScoreGameOnTimebutton);
            this.MaximumSize = new System.Drawing.Size(678, 449);
            this.MinimumSize = new System.Drawing.Size(678, 449);
            this.Name = "HighScoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HighScoreForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HighScoureBackbutton;
        private System.Windows.Forms.Button HighScoreUntimedGamebutton;
        private System.Windows.Forms.Button HighScoreGameOnTimebutton;
        private System.Windows.Forms.ListBox recordsListBox;
    }
}