namespace Quiz.UI.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainExitbutton = new System.Windows.Forms.Button();
            this.highScoresButton = new System.Windows.Forms.Button();
            this.gameModesButton = new System.Windows.Forms.Button();
            this.QuizpictureBox = new System.Windows.Forms.PictureBox();
            this.Startgamebutton = new System.Windows.Forms.Button();
            this.quizpanel = new System.Windows.Forms.Panel();
            this.contentPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.QuizpictureBox)).BeginInit();
            this.quizpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainExitbutton
            // 
            this.MainExitbutton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainExitbutton.FlatAppearance.BorderSize = 5;
            this.MainExitbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainExitbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainExitbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MainExitbutton.Location = new System.Drawing.Point(29, 454);
            this.MainExitbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MainExitbutton.Name = "MainExitbutton";
            this.MainExitbutton.Size = new System.Drawing.Size(600, 88);
            this.MainExitbutton.TabIndex = 0;
            this.MainExitbutton.Text = "Exit";
            this.MainExitbutton.UseVisualStyleBackColor = true;
            this.MainExitbutton.Click += new System.EventHandler(this.MainExitbutton_Click);
            // 
            // highScoresButton
            // 
            this.highScoresButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.highScoresButton.FlatAppearance.BorderSize = 5;
            this.highScoresButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.highScoresButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScoresButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.highScoresButton.Location = new System.Drawing.Point(29, 356);
            this.highScoresButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.highScoresButton.Name = "highScoresButton";
            this.highScoresButton.Size = new System.Drawing.Size(600, 88);
            this.highScoresButton.TabIndex = 0;
            this.highScoresButton.Text = "High Scores";
            this.highScoresButton.UseVisualStyleBackColor = true;
            this.highScoresButton.Click += new System.EventHandler(this.HighScoresButton_Click);
            // 
            // gameModesButton
            // 
            this.gameModesButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gameModesButton.FlatAppearance.BorderSize = 5;
            this.gameModesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gameModesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameModesButton.ForeColor = System.Drawing.Color.Blue;
            this.gameModesButton.Location = new System.Drawing.Point(29, 258);
            this.gameModesButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gameModesButton.Name = "gameModesButton";
            this.gameModesButton.Size = new System.Drawing.Size(600, 88);
            this.gameModesButton.TabIndex = 0;
            this.gameModesButton.Text = "Game Modes";
            this.gameModesButton.UseVisualStyleBackColor = true;
            this.gameModesButton.Click += new System.EventHandler(this.GameModesButton_Click);
            // 
            // QuizpictureBox
            // 
            this.QuizpictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QuizpictureBox.Image = global::Quiz.UI.Properties.Resources.quiz_2432440_1920;
            this.QuizpictureBox.Location = new System.Drawing.Point(29, 5);
            this.QuizpictureBox.Name = "QuizpictureBox";
            this.QuizpictureBox.Size = new System.Drawing.Size(600, 126);
            this.QuizpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.QuizpictureBox.TabIndex = 2;
            this.QuizpictureBox.TabStop = false;
            // 
            // Startgamebutton
            // 
            this.Startgamebutton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Startgamebutton.FlatAppearance.BorderSize = 5;
            this.Startgamebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Startgamebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Startgamebutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Startgamebutton.Location = new System.Drawing.Point(29, 139);
            this.Startgamebutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Startgamebutton.Name = "Startgamebutton";
            this.Startgamebutton.Size = new System.Drawing.Size(600, 109);
            this.Startgamebutton.TabIndex = 0;
            this.Startgamebutton.Text = "Start game";
            this.Startgamebutton.UseVisualStyleBackColor = true;
            this.Startgamebutton.Click += new System.EventHandler(this.Startgamebutton_Click);
            // 
            // quizpanel
            // 
            this.quizpanel.AutoSize = true;
            this.quizpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.quizpanel.Controls.Add(this.Startgamebutton);
            this.quizpanel.Controls.Add(this.QuizpictureBox);
            this.quizpanel.Controls.Add(this.gameModesButton);
            this.quizpanel.Controls.Add(this.highScoresButton);
            this.quizpanel.Controls.Add(this.MainExitbutton);
            this.quizpanel.Controls.Add(this.contentPanel);
            this.quizpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quizpanel.Location = new System.Drawing.Point(0, 0);
            this.quizpanel.Name = "quizpanel";
            this.quizpanel.Size = new System.Drawing.Size(653, 562);
            this.quizpanel.TabIndex = 3;
            // 
            // contentPanel
            // 
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(653, 562);
            this.contentPanel.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 562);
            this.Controls.Add(this.quizpanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(669, 601);
            this.MinimumSize = new System.Drawing.Size(669, 601);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.QuizpictureBox)).EndInit();
            this.quizpanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MainExitbutton;
        private System.Windows.Forms.Button highScoresButton;
        private System.Windows.Forms.Button gameModesButton;
        private System.Windows.Forms.PictureBox QuizpictureBox;
        private System.Windows.Forms.Button Startgamebutton;
        private System.Windows.Forms.Panel quizpanel;
        private System.Windows.Forms.Panel contentPanel;
    }
}