﻿namespace Quiz.UI.Forms
{
    partial class InGameUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InGameUI));
            this.questionLabel = new System.Windows.Forms.Label();
            this.questionNumberLabel = new System.Windows.Forms.Label();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.choiceALabel = new System.Windows.Forms.Label();
            this.choiceBLabel = new System.Windows.Forms.Label();
            this.choiceCLabel = new System.Windows.Forms.Label();
            this.choiceDLabel = new System.Windows.Forms.Label();
            this.radioButtonA = new System.Windows.Forms.RadioButton();
            this.radioButtonB = new System.Windows.Forms.RadioButton();
            this.radioButtonC = new System.Windows.Forms.RadioButton();
            this.radioButtonD = new System.Windows.Forms.RadioButton();
            this.submitButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.correctLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.correctCountLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.wrongLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.wrongCountLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.rateLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ratePercentLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statsPanel = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.analysisLabel = new System.Windows.Forms.Label();
            this.analysisTextLabel = new System.Windows.Forms.Label();
            this.questionPanel = new System.Windows.Forms.Panel();
            this.statusStrip1.SuspendLayout();
            this.statsPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.questionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            this.questionLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.Location = new System.Drawing.Point(406, 32);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(91, 20);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.Text = "Question: ";
            // 
            // questionNumberLabel
            // 
            this.questionNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.questionNumberLabel.AutoSize = true;
            this.questionNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionNumberLabel.Location = new System.Drawing.Point(493, 32);
            this.questionNumberLabel.Name = "questionNumberLabel";
            this.questionNumberLabel.Size = new System.Drawing.Size(19, 20);
            this.questionNumberLabel.TabIndex = 0;
            this.questionNumberLabel.Text = "1";
            // 
            // questionTextBox
            // 
            this.questionTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.questionTextBox.Location = new System.Drawing.Point(191, 78);
            this.questionTextBox.Multiline = true;
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.ShortcutsEnabled = false;
            this.questionTextBox.Size = new System.Drawing.Size(577, 109);
            this.questionTextBox.TabIndex = 0;
            this.questionTextBox.TabStop = false;
            this.questionTextBox.Text = "Questions display here...";
            // 
            // choiceALabel
            // 
            this.choiceALabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.choiceALabel.AutoSize = true;
            this.choiceALabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choiceALabel.Location = new System.Drawing.Point(200, 233);
            this.choiceALabel.Name = "choiceALabel";
            this.choiceALabel.Size = new System.Drawing.Size(21, 20);
            this.choiceALabel.TabIndex = 0;
            this.choiceALabel.Text = "A";
            // 
            // choiceBLabel
            // 
            this.choiceBLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.choiceBLabel.AutoSize = true;
            this.choiceBLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choiceBLabel.Location = new System.Drawing.Point(560, 233);
            this.choiceBLabel.Name = "choiceBLabel";
            this.choiceBLabel.Size = new System.Drawing.Size(21, 20);
            this.choiceBLabel.TabIndex = 0;
            this.choiceBLabel.Text = "B";
            // 
            // choiceCLabel
            // 
            this.choiceCLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.choiceCLabel.AutoSize = true;
            this.choiceCLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choiceCLabel.Location = new System.Drawing.Point(200, 283);
            this.choiceCLabel.Name = "choiceCLabel";
            this.choiceCLabel.Size = new System.Drawing.Size(21, 20);
            this.choiceCLabel.TabIndex = 0;
            this.choiceCLabel.Text = "C";
            // 
            // choiceDLabel
            // 
            this.choiceDLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.choiceDLabel.AutoSize = true;
            this.choiceDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choiceDLabel.Location = new System.Drawing.Point(560, 283);
            this.choiceDLabel.Name = "choiceDLabel";
            this.choiceDLabel.Size = new System.Drawing.Size(22, 20);
            this.choiceDLabel.TabIndex = 0;
            this.choiceDLabel.Text = "D";
            // 
            // radioButtonA
            // 
            this.radioButtonA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioButtonA.AutoSize = true;
            this.radioButtonA.Location = new System.Drawing.Point(240, 232);
            this.radioButtonA.Name = "radioButtonA";
            this.radioButtonA.Size = new System.Drawing.Size(153, 24);
            this.radioButtonA.TabIndex = 1;
            this.radioButtonA.TabStop = true;
            this.radioButtonA.Text = "Possible answer...";
            this.radioButtonA.UseVisualStyleBackColor = true;
            this.radioButtonA.Click += new System.EventHandler(this.RadioButtonA_Click);
            // 
            // radioButtonB
            // 
            this.radioButtonB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioButtonB.AutoSize = true;
            this.radioButtonB.Location = new System.Drawing.Point(600, 232);
            this.radioButtonB.Name = "radioButtonB";
            this.radioButtonB.Size = new System.Drawing.Size(153, 24);
            this.radioButtonB.TabIndex = 2;
            this.radioButtonB.TabStop = true;
            this.radioButtonB.Text = "Possible answer...";
            this.radioButtonB.UseVisualStyleBackColor = true;
            this.radioButtonB.Click += new System.EventHandler(this.RadioButtonB_Click);
            // 
            // radioButtonC
            // 
            this.radioButtonC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioButtonC.AutoSize = true;
            this.radioButtonC.Location = new System.Drawing.Point(240, 282);
            this.radioButtonC.Name = "radioButtonC";
            this.radioButtonC.Size = new System.Drawing.Size(153, 24);
            this.radioButtonC.TabIndex = 3;
            this.radioButtonC.TabStop = true;
            this.radioButtonC.Text = "Possible answer...";
            this.radioButtonC.UseVisualStyleBackColor = true;
            this.radioButtonC.Click += new System.EventHandler(this.RadioButtonC_Click);
            // 
            // radioButtonD
            // 
            this.radioButtonD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radioButtonD.AutoSize = true;
            this.radioButtonD.Location = new System.Drawing.Point(600, 282);
            this.radioButtonD.Name = "radioButtonD";
            this.radioButtonD.Size = new System.Drawing.Size(153, 24);
            this.radioButtonD.TabIndex = 4;
            this.radioButtonD.TabStop = true;
            this.radioButtonD.Text = "Possible answer...";
            this.radioButtonD.UseVisualStyleBackColor = true;
            this.radioButtonD.Click += new System.EventHandler(this.RadioButtonD_Click);
            // 
            // submitButton
            // 
            this.submitButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.submitButton.BackColor = System.Drawing.Color.SpringGreen;
            this.submitButton.FlatAppearance.BorderSize = 0;
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(410, 403);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(135, 43);
            this.submitButton.TabIndex = 5;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.correctLabel,
            this.correctCountLabel,
            this.wrongLabel,
            this.wrongCountLabel,
            this.rateLabel,
            this.ratePercentLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 485);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(958, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // correctLabel
            // 
            this.correctLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.correctLabel.Name = "correctLabel";
            this.correctLabel.Size = new System.Drawing.Size(96, 17);
            this.correctLabel.Text = "Correct Answers:";
            // 
            // correctCountLabel
            // 
            this.correctCountLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.correctCountLabel.Name = "correctCountLabel";
            this.correctCountLabel.Size = new System.Drawing.Size(13, 17);
            this.correctCountLabel.Text = "0";
            // 
            // wrongLabel
            // 
            this.wrongLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.wrongLabel.Name = "wrongLabel";
            this.wrongLabel.Size = new System.Drawing.Size(96, 17);
            this.wrongLabel.Text = "Wrong Answers: ";
            // 
            // wrongCountLabel
            // 
            this.wrongCountLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.wrongCountLabel.Name = "wrongCountLabel";
            this.wrongCountLabel.Size = new System.Drawing.Size(13, 17);
            this.wrongCountLabel.Text = "0";
            // 
            // rateLabel
            // 
            this.rateLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(80, 17);
            this.rateLabel.Text = "Success Rate: ";
            // 
            // ratePercentLabel
            // 
            this.ratePercentLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ratePercentLabel.Name = "ratePercentLabel";
            this.ratePercentLabel.Size = new System.Drawing.Size(13, 17);
            this.ratePercentLabel.Text = "0";
            // 
            // statsPanel
            // 
            this.statsPanel.Controls.Add(this.panel1);
            this.statsPanel.Controls.Add(this.listView1);
            this.statsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statsPanel.Location = new System.Drawing.Point(0, 0);
            this.statsPanel.Name = "statsPanel";
            this.statsPanel.Size = new System.Drawing.Size(958, 507);
            this.statsPanel.TabIndex = 6;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.MaximumSize = new System.Drawing.Size(958, 507);
            this.listView1.MinimumSize = new System.Drawing.Size(958, 507);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(958, 507);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.analysisTextLabel);
            this.panel1.Controls.Add(this.analysisLabel);
            this.panel1.Location = new System.Drawing.Point(0, 425);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(958, 61);
            this.panel1.TabIndex = 1;
            // 
            // analysisLabel
            // 
            this.analysisLabel.AutoSize = true;
            this.analysisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.analysisLabel.Location = new System.Drawing.Point(25, 20);
            this.analysisLabel.Name = "analysisLabel";
            this.analysisLabel.Size = new System.Drawing.Size(80, 20);
            this.analysisLabel.TabIndex = 0;
            this.analysisLabel.Text = "Analysis:";
            // 
            // analysisTextLabel
            // 
            this.analysisTextLabel.AutoSize = true;
            this.analysisTextLabel.Location = new System.Drawing.Point(170, 20);
            this.analysisTextLabel.Name = "analysisTextLabel";
            this.analysisTextLabel.Size = new System.Drawing.Size(0, 20);
            this.analysisTextLabel.TabIndex = 1;
            // 
            // questionPanel
            // 
            this.questionPanel.Controls.Add(this.questionTextBox);
            this.questionPanel.Controls.Add(this.questionLabel);
            this.questionPanel.Controls.Add(this.submitButton);
            this.questionPanel.Controls.Add(this.radioButtonD);
            this.questionPanel.Controls.Add(this.questionNumberLabel);
            this.questionPanel.Controls.Add(this.radioButtonC);
            this.questionPanel.Controls.Add(this.choiceALabel);
            this.questionPanel.Controls.Add(this.radioButtonB);
            this.questionPanel.Controls.Add(this.choiceBLabel);
            this.questionPanel.Controls.Add(this.radioButtonA);
            this.questionPanel.Controls.Add(this.choiceCLabel);
            this.questionPanel.Controls.Add(this.choiceDLabel);
            this.questionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.questionPanel.Location = new System.Drawing.Point(0, 0);
            this.questionPanel.Name = "questionPanel";
            this.questionPanel.Size = new System.Drawing.Size(958, 507);
            this.questionPanel.TabIndex = 2;
            // 
            // InGameUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(958, 507);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.statsPanel);
            this.Controls.Add(this.questionPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(974, 546);
            this.MinimumSize = new System.Drawing.Size(974, 546);
            this.Name = "InGameUI";
            this.Text = "Quiz";
            this.Load += new System.EventHandler(this.InGameUI_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.statsPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.questionPanel.ResumeLayout(false);
            this.questionPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Label questionNumberLabel;
        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.Label choiceALabel;
        private System.Windows.Forms.Label choiceBLabel;
        private System.Windows.Forms.Label choiceCLabel;
        private System.Windows.Forms.Label choiceDLabel;
        private System.Windows.Forms.RadioButton radioButtonA;
        private System.Windows.Forms.RadioButton radioButtonB;
        private System.Windows.Forms.RadioButton radioButtonC;
        private System.Windows.Forms.RadioButton radioButtonD;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel correctLabel;
        private System.Windows.Forms.ToolStripStatusLabel correctCountLabel;
        private System.Windows.Forms.ToolStripStatusLabel wrongLabel;
        private System.Windows.Forms.ToolStripStatusLabel wrongCountLabel;
        private System.Windows.Forms.ToolStripStatusLabel rateLabel;
        private System.Windows.Forms.ToolStripStatusLabel ratePercentLabel;
        private System.Windows.Forms.Panel statsPanel;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label analysisTextLabel;
        private System.Windows.Forms.Label analysisLabel;
        private System.Windows.Forms.Panel questionPanel;
    }
}