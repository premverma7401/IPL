namespace TrackerUI
{
    partial class TournamentViewerForm
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
            this.tournamentLabel = new System.Windows.Forms.Label();
            this.tournamentName = new System.Windows.Forms.Label();
            this.roundLabel = new System.Windows.Forms.Label();
            this.roundDropDown = new System.Windows.Forms.ComboBox();
            this.unplayedCheck = new System.Windows.Forms.CheckBox();
            this.matchUpListBox = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.scoreBtn = new System.Windows.Forms.Button();
            this.vsLabel = new System.Windows.Forms.Label();
            this.team2ScoreInput = new System.Windows.Forms.TextBox();
            this.team1scoreInput = new System.Windows.Forms.TextBox();
            this.team2Score = new System.Windows.Forms.Label();
            this.team1Score = new System.Windows.Forms.Label();
            this.team2Label = new System.Windows.Forms.Label();
            this.team1Label = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tournamentLabel
            // 
            this.tournamentLabel.AutoSize = true;
            this.tournamentLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentLabel.Location = new System.Drawing.Point(36, 44);
            this.tournamentLabel.Name = "tournamentLabel";
            this.tournamentLabel.Size = new System.Drawing.Size(178, 37);
            this.tournamentLabel.TabIndex = 0;
            this.tournamentLabel.Text = "Tournament : ";
            this.tournamentLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // tournamentName
            // 
            this.tournamentName.AutoSize = true;
            this.tournamentName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentName.Location = new System.Drawing.Point(209, 44);
            this.tournamentName.Name = "tournamentName";
            this.tournamentName.Size = new System.Drawing.Size(136, 37);
            this.tournamentName.TabIndex = 1;
            this.tournamentName.Text = "{{DLF IPL}}";
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundLabel.Location = new System.Drawing.Point(54, 107);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(66, 25);
            this.roundLabel.TabIndex = 2;
            this.roundLabel.Text = "Round";
            // 
            // roundDropDown
            // 
            this.roundDropDown.FormattingEnabled = true;
            this.roundDropDown.Location = new System.Drawing.Point(149, 107);
            this.roundDropDown.Name = "roundDropDown";
            this.roundDropDown.Size = new System.Drawing.Size(216, 21);
            this.roundDropDown.TabIndex = 3;
            // 
            // unplayedCheck
            // 
            this.unplayedCheck.AutoSize = true;
            this.unplayedCheck.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unplayedCheck.ForeColor = System.Drawing.SystemColors.ControlText;
            this.unplayedCheck.Location = new System.Drawing.Point(149, 147);
            this.unplayedCheck.Name = "unplayedCheck";
            this.unplayedCheck.Size = new System.Drawing.Size(132, 25);
            this.unplayedCheck.TabIndex = 4;
            this.unplayedCheck.Text = "Unplayed Only";
            this.unplayedCheck.UseVisualStyleBackColor = true;
            // 
            // matchUpListBox
            // 
            this.matchUpListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchUpListBox.FormattingEnabled = true;
            this.matchUpListBox.Location = new System.Drawing.Point(59, 200);
            this.matchUpListBox.Name = "matchUpListBox";
            this.matchUpListBox.Size = new System.Drawing.Size(306, 197);
            this.matchUpListBox.TabIndex = 5;
            this.matchUpListBox.SelectedIndexChanged += new System.EventHandler(this.matchUpListBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.scoreBtn);
            this.groupBox1.Controls.Add(this.vsLabel);
            this.groupBox1.Controls.Add(this.team2ScoreInput);
            this.groupBox1.Controls.Add(this.team1scoreInput);
            this.groupBox1.Controls.Add(this.team2Score);
            this.groupBox1.Controls.Add(this.team1Score);
            this.groupBox1.Controls.Add(this.team2Label);
            this.groupBox1.Controls.Add(this.team1Label);
            this.groupBox1.Location = new System.Drawing.Point(403, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 290);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Score";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // scoreBtn
            // 
            this.scoreBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.scoreBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoreBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.scoreBtn.Location = new System.Drawing.Point(307, 140);
            this.scoreBtn.Name = "scoreBtn";
            this.scoreBtn.Size = new System.Drawing.Size(100, 41);
            this.scoreBtn.TabIndex = 21;
            this.scoreBtn.Text = "Score";
            this.scoreBtn.UseVisualStyleBackColor = true;
            // 
            // vsLabel
            // 
            this.vsLabel.AutoSize = true;
            this.vsLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vsLabel.Location = new System.Drawing.Point(164, 140);
            this.vsLabel.Name = "vsLabel";
            this.vsLabel.Size = new System.Drawing.Size(22, 20);
            this.vsLabel.TabIndex = 20;
            this.vsLabel.Text = "vs";
            // 
            // team2ScoreInput
            // 
            this.team2ScoreInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.team2ScoreInput.Location = new System.Drawing.Point(168, 228);
            this.team2ScoreInput.Name = "team2ScoreInput";
            this.team2ScoreInput.Size = new System.Drawing.Size(100, 22);
            this.team2ScoreInput.TabIndex = 19;
            // 
            // team1scoreInput
            // 
            this.team1scoreInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.team1scoreInput.Location = new System.Drawing.Point(168, 92);
            this.team1scoreInput.Name = "team1scoreInput";
            this.team1scoreInput.Size = new System.Drawing.Size(100, 22);
            this.team1scoreInput.TabIndex = 18;
            // 
            // team2Score
            // 
            this.team2Score.AutoSize = true;
            this.team2Score.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.team2Score.Location = new System.Drawing.Point(78, 222);
            this.team2Score.Name = "team2Score";
            this.team2Score.Size = new System.Drawing.Size(59, 25);
            this.team2Score.TabIndex = 17;
            this.team2Score.Text = "Score";
            // 
            // team1Score
            // 
            this.team1Score.AutoSize = true;
            this.team1Score.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.team1Score.Location = new System.Drawing.Point(78, 89);
            this.team1Score.Name = "team1Score";
            this.team1Score.Size = new System.Drawing.Size(59, 25);
            this.team1Score.TabIndex = 16;
            this.team1Score.Text = "Score";
            // 
            // team2Label
            // 
            this.team2Label.AutoSize = true;
            this.team2Label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.team2Label.Location = new System.Drawing.Point(98, 185);
            this.team2Label.Name = "team2Label";
            this.team2Label.Size = new System.Drawing.Size(150, 25);
            this.team2Label.TabIndex = 15;
            this.team2Label.Text = "{{Team 2 Name}}";
            // 
            // team1Label
            // 
            this.team1Label.AutoSize = true;
            this.team1Label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.team1Label.Location = new System.Drawing.Point(98, 53);
            this.team1Label.Name = "team1Label";
            this.team1Label.Size = new System.Drawing.Size(150, 25);
            this.team1Label.TabIndex = 14;
            this.team1Label.Text = "{{Team 1 Name}}";
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(861, 439);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.matchUpListBox);
            this.Controls.Add(this.unplayedCheck);
            this.Controls.Add(this.roundDropDown);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.tournamentName);
            this.Controls.Add(this.tournamentLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TournamentViewerForm";
            this.Text = "Tournament Viewer";
            this.Load += new System.EventHandler(this.TournamentViewerForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tournamentLabel;
        private System.Windows.Forms.Label tournamentName;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.ComboBox roundDropDown;
        private System.Windows.Forms.CheckBox unplayedCheck;
        private System.Windows.Forms.ListBox matchUpListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button scoreBtn;
        private System.Windows.Forms.Label vsLabel;
        private System.Windows.Forms.TextBox team2ScoreInput;
        private System.Windows.Forms.TextBox team1scoreInput;
        private System.Windows.Forms.Label team2Score;
        private System.Windows.Forms.Label team1Score;
        private System.Windows.Forms.Label team2Label;
        private System.Windows.Forms.Label team1Label;
    }
}

