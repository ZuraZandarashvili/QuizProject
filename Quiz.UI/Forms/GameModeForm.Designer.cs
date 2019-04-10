namespace Quiz.UI.Forms
{
    partial class GameModeForm
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
            this.GameOnTimebutton = new System.Windows.Forms.Button();
            this.UntimedGamebutton = new System.Windows.Forms.Button();
            this.Backbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GameOnTimebutton
            // 
            this.GameOnTimebutton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GameOnTimebutton.FlatAppearance.BorderSize = 5;
            this.GameOnTimebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GameOnTimebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameOnTimebutton.ForeColor = System.Drawing.Color.ForestGreen;
            this.GameOnTimebutton.Location = new System.Drawing.Point(66, 63);
            this.GameOnTimebutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GameOnTimebutton.Name = "GameOnTimebutton";
            this.GameOnTimebutton.Size = new System.Drawing.Size(531, 88);
            this.GameOnTimebutton.TabIndex = 5;
            this.GameOnTimebutton.Text = "Game on Time";
            this.GameOnTimebutton.UseVisualStyleBackColor = true;
            // 
            // UntimedGamebutton
            // 
            this.UntimedGamebutton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UntimedGamebutton.FlatAppearance.BorderSize = 5;
            this.UntimedGamebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UntimedGamebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UntimedGamebutton.ForeColor = System.Drawing.Color.Teal;
            this.UntimedGamebutton.Location = new System.Drawing.Point(66, 161);
            this.UntimedGamebutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UntimedGamebutton.Name = "UntimedGamebutton";
            this.UntimedGamebutton.Size = new System.Drawing.Size(531, 88);
            this.UntimedGamebutton.TabIndex = 5;
            this.UntimedGamebutton.Text = "Untimed Game";
            this.UntimedGamebutton.UseVisualStyleBackColor = true;
            // 
            // Backbutton
            // 
            this.Backbutton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Backbutton.FlatAppearance.BorderSize = 5;
            this.Backbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Backbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Backbutton.Location = new System.Drawing.Point(66, 259);
            this.Backbutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(531, 88);
            this.Backbutton.TabIndex = 7;
            this.Backbutton.Text = "Back";
            this.Backbutton.UseVisualStyleBackColor = true;
            this.Backbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // GameModeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 410);
            this.Controls.Add(this.Backbutton);
            this.Controls.Add(this.UntimedGamebutton);
            this.Controls.Add(this.GameOnTimebutton);
            this.MaximumSize = new System.Drawing.Size(678, 449);
            this.MinimumSize = new System.Drawing.Size(678, 449);
            this.Name = "GameModeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game_Mode_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GameOnTimebutton;
        private System.Windows.Forms.Button UntimedGamebutton;
        private System.Windows.Forms.Button Backbutton;
    }
}