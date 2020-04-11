namespace TrackerUI
{
    partial class CreateTournamentForm
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
            this.selectTeamDropDown = new System.Windows.Forms.ComboBox();
            this.roundLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addTeamBtn = new System.Windows.Forms.Button();
            this.trnNameInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.eFeeInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.createPrizeBtn = new System.Windows.Forms.Button();
            this.createTournamentBtn = new System.Windows.Forms.Button();
            this.trnPlayerListBox = new System.Windows.Forms.ListBox();
            this.prizeListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dltTeamPlyBtn = new System.Windows.Forms.Button();
            this.dtlPrizeBtn = new System.Windows.Forms.Button();
            this.createNewLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // tournamentLabel
            // 
            this.tournamentLabel.AutoSize = true;
            this.tournamentLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentLabel.Location = new System.Drawing.Point(33, 30);
            this.tournamentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tournamentLabel.Name = "tournamentLabel";
            this.tournamentLabel.Size = new System.Drawing.Size(307, 46);
            this.tournamentLabel.TabIndex = 1;
            this.tournamentLabel.Text = "Create Tournament";
            // 
            // selectTeamDropDown
            // 
            this.selectTeamDropDown.FormattingEnabled = true;
            this.selectTeamDropDown.Location = new System.Drawing.Point(69, 353);
            this.selectTeamDropDown.Margin = new System.Windows.Forms.Padding(4);
            this.selectTeamDropDown.Name = "selectTeamDropDown";
            this.selectTeamDropDown.Size = new System.Drawing.Size(259, 24);
            this.selectTeamDropDown.TabIndex = 24;
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundLabel.Location = new System.Drawing.Point(63, 128);
            this.roundLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(215, 32);
            this.roundLabel.TabIndex = 23;
            this.roundLabel.Text = "Tournament Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(515, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 28);
            this.label1.TabIndex = 22;
            this.label1.Text = "Teams / Players";
            // 
            // addTeamBtn
            // 
            this.addTeamBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.addTeamBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addTeamBtn.Location = new System.Drawing.Point(775, 178);
            this.addTeamBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addTeamBtn.Name = "addTeamBtn";
            this.addTeamBtn.Size = new System.Drawing.Size(104, 43);
            this.addTeamBtn.TabIndex = 26;
            this.addTeamBtn.Text = "Add Team";
            this.addTeamBtn.UseVisualStyleBackColor = true;
            this.addTeamBtn.Click += new System.EventHandler(this.addTeamBtn_Click);
            // 
            // trnNameInput
            // 
            this.trnNameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.trnNameInput.Location = new System.Drawing.Point(69, 174);
            this.trnNameInput.Margin = new System.Windows.Forms.Padding(4);
            this.trnNameInput.Name = "trnNameInput";
            this.trnNameInput.Size = new System.Drawing.Size(259, 22);
            this.trnNameInput.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 241);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 32);
            this.label2.TabIndex = 27;
            this.label2.Text = "Entry Fee";
            // 
            // eFeeInput
            // 
            this.eFeeInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eFeeInput.Location = new System.Drawing.Point(196, 241);
            this.eFeeInput.Margin = new System.Windows.Forms.Padding(4);
            this.eFeeInput.Name = "eFeeInput";
            this.eFeeInput.Size = new System.Drawing.Size(133, 22);
            this.eFeeInput.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 313);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 32);
            this.label3.TabIndex = 29;
            this.label3.Text = "Select Team";
            // 
            // createPrizeBtn
            // 
            this.createPrizeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.createPrizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPrizeBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.createPrizeBtn.Location = new System.Drawing.Point(775, 329);
            this.createPrizeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.createPrizeBtn.Name = "createPrizeBtn";
            this.createPrizeBtn.Size = new System.Drawing.Size(104, 43);
            this.createPrizeBtn.TabIndex = 30;
            this.createPrizeBtn.Text = "Create Prize";
            this.createPrizeBtn.UseVisualStyleBackColor = true;
            this.createPrizeBtn.Click += new System.EventHandler(this.createPrizeBtn_Click);
            // 
            // createTournamentBtn
            // 
            this.createTournamentBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.createTournamentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.createTournamentBtn.Location = new System.Drawing.Point(304, 468);
            this.createTournamentBtn.Margin = new System.Windows.Forms.Padding(4);
            this.createTournamentBtn.Name = "createTournamentBtn";
            this.createTournamentBtn.Size = new System.Drawing.Size(219, 50);
            this.createTournamentBtn.TabIndex = 34;
            this.createTournamentBtn.Text = "Create Tournament";
            this.createTournamentBtn.UseVisualStyleBackColor = true;
            this.createTournamentBtn.Click += new System.EventHandler(this.createTournamentBtn_Click);
            // 
            // trnPlayerListBox
            // 
            this.trnPlayerListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.trnPlayerListBox.FormattingEnabled = true;
            this.trnPlayerListBox.ItemHeight = 16;
            this.trnPlayerListBox.Location = new System.Drawing.Point(520, 174);
            this.trnPlayerListBox.Margin = new System.Windows.Forms.Padding(4);
            this.trnPlayerListBox.Name = "trnPlayerListBox";
            this.trnPlayerListBox.Size = new System.Drawing.Size(247, 98);
            this.trnPlayerListBox.TabIndex = 35;
            // 
            // prizeListBox
            // 
            this.prizeListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.prizeListBox.FormattingEnabled = true;
            this.prizeListBox.ItemHeight = 16;
            this.prizeListBox.Location = new System.Drawing.Point(520, 325);
            this.prizeListBox.Margin = new System.Windows.Forms.Padding(4);
            this.prizeListBox.Name = "prizeListBox";
            this.prizeListBox.Size = new System.Drawing.Size(247, 98);
            this.prizeListBox.TabIndex = 36;
            this.prizeListBox.SelectedIndexChanged += new System.EventHandler(this.prizeListBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(515, 290);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 28);
            this.label4.TabIndex = 37;
            this.label4.Text = "Prizes";
            // 
            // dltTeamPlyBtn
            // 
            this.dltTeamPlyBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.dltTeamPlyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dltTeamPlyBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dltTeamPlyBtn.Location = new System.Drawing.Point(775, 229);
            this.dltTeamPlyBtn.Margin = new System.Windows.Forms.Padding(4);
            this.dltTeamPlyBtn.Name = "dltTeamPlyBtn";
            this.dltTeamPlyBtn.Size = new System.Drawing.Size(104, 43);
            this.dltTeamPlyBtn.TabIndex = 32;
            this.dltTeamPlyBtn.Text = "Delete Selected";
            this.dltTeamPlyBtn.UseVisualStyleBackColor = true;
            this.dltTeamPlyBtn.Click += new System.EventHandler(this.dltTeamPlyBtn_Click);
            // 
            // dtlPrizeBtn
            // 
            this.dtlPrizeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.dtlPrizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dtlPrizeBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtlPrizeBtn.Location = new System.Drawing.Point(775, 380);
            this.dtlPrizeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.dtlPrizeBtn.Name = "dtlPrizeBtn";
            this.dtlPrizeBtn.Size = new System.Drawing.Size(104, 43);
            this.dtlPrizeBtn.TabIndex = 38;
            this.dtlPrizeBtn.Text = "Delete Selected";
            this.dtlPrizeBtn.UseVisualStyleBackColor = true;
            this.dtlPrizeBtn.Click += new System.EventHandler(this.dtlPrizeBtn_Click);
            // 
            // createNewLink
            // 
            this.createNewLink.AutoSize = true;
            this.createNewLink.Location = new System.Drawing.Point(256, 324);
            this.createNewLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.createNewLink.Name = "createNewLink";
            this.createNewLink.Size = new System.Drawing.Size(79, 17);
            this.createNewLink.TabIndex = 39;
            this.createNewLink.TabStop = true;
            this.createNewLink.Text = "Create new";
            this.createNewLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.createNewLink_LinkClicked);
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.createNewLink);
            this.Controls.Add(this.dtlPrizeBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.prizeListBox);
            this.Controls.Add(this.trnPlayerListBox);
            this.Controls.Add(this.createTournamentBtn);
            this.Controls.Add(this.dltTeamPlyBtn);
            this.Controls.Add(this.createPrizeBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.eFeeInput);
            this.Controls.Add(this.selectTeamDropDown);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addTeamBtn);
            this.Controls.Add(this.trnNameInput);
            this.Controls.Add(this.tournamentLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreateTournamentForm";
            this.Text = "CreateTournamentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tournamentLabel;
        private System.Windows.Forms.ComboBox selectTeamDropDown;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addTeamBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox eFeeInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button createPrizeBtn;
        private System.Windows.Forms.Button createTournamentBtn;
        private System.Windows.Forms.ListBox trnPlayerListBox;
        private System.Windows.Forms.ListBox prizeListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button dltTeamPlyBtn;
        private System.Windows.Forms.Button dtlPrizeBtn;
        private System.Windows.Forms.TextBox trnNameInput;
        private System.Windows.Forms.LinkLabel createNewLink;
    }
}