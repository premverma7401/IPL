namespace TrackerUI
{
    partial class CreateTeamForm
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
            this.tmMemberListBox = new System.Windows.Forms.ListBox();
            this.createMemberBtn = new System.Windows.Forms.Button();
            this.dltMemberBtn = new System.Windows.Forms.Button();
            this.roundLabel = new System.Windows.Forms.Label();
            this.addMemberBtn = new System.Windows.Forms.Button();
            this.teamNameInput = new System.Windows.Forms.TextBox();
            this.teamLabel = new System.Windows.Forms.Label();
            this.teamMemberDropDown = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fNameInput = new System.Windows.Forms.TextBox();
            this.lNameInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mobileInput = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mailInput = new System.Windows.Forms.TextBox();
            this.createTeamBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmMemberListBox
            // 
            this.tmMemberListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tmMemberListBox.FormattingEnabled = true;
            this.tmMemberListBox.ItemHeight = 16;
            this.tmMemberListBox.Location = new System.Drawing.Point(653, 142);
            this.tmMemberListBox.Margin = new System.Windows.Forms.Padding(4);
            this.tmMemberListBox.Name = "tmMemberListBox";
            this.tmMemberListBox.Size = new System.Drawing.Size(421, 514);
            this.tmMemberListBox.TabIndex = 52;
            // 
            // createMemberBtn
            // 
            this.createMemberBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.createMemberBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createMemberBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.createMemberBtn.Location = new System.Drawing.Point(86, 270);
            this.createMemberBtn.Margin = new System.Windows.Forms.Padding(4);
            this.createMemberBtn.Name = "createMemberBtn";
            this.createMemberBtn.Size = new System.Drawing.Size(177, 36);
            this.createMemberBtn.TabIndex = 51;
            this.createMemberBtn.Text = "Create Member";
            this.createMemberBtn.UseVisualStyleBackColor = true;
            this.createMemberBtn.Click += new System.EventHandler(this.createMemberBtn_Click);
            // 
            // dltMemberBtn
            // 
            this.dltMemberBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.dltMemberBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dltMemberBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dltMemberBtn.Location = new System.Drawing.Point(1083, 142);
            this.dltMemberBtn.Margin = new System.Windows.Forms.Padding(4);
            this.dltMemberBtn.Name = "dltMemberBtn";
            this.dltMemberBtn.Size = new System.Drawing.Size(104, 54);
            this.dltMemberBtn.TabIndex = 50;
            this.dltMemberBtn.Text = "Delete Selected";
            this.dltMemberBtn.UseVisualStyleBackColor = true;
            this.dltMemberBtn.Click += new System.EventHandler(this.dltMemberBtn_Click);
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundLabel.Location = new System.Drawing.Point(77, 111);
            this.roundLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(143, 32);
            this.roundLabel.TabIndex = 42;
            this.roundLabel.Text = "Team Name";
            // 
            // addMemberBtn
            // 
            this.addMemberBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.addMemberBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMemberBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addMemberBtn.Location = new System.Drawing.Point(137, 308);
            this.addMemberBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addMemberBtn.Name = "addMemberBtn";
            this.addMemberBtn.Size = new System.Drawing.Size(131, 34);
            this.addMemberBtn.TabIndex = 45;
            this.addMemberBtn.Text = "Add Member";
            this.addMemberBtn.UseVisualStyleBackColor = true;
            this.addMemberBtn.Click += new System.EventHandler(this.addTeamBtn_Click);
            // 
            // teamNameInput
            // 
            this.teamNameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamNameInput.Location = new System.Drawing.Point(83, 145);
            this.teamNameInput.Margin = new System.Windows.Forms.Padding(4);
            this.teamNameInput.Name = "teamNameInput";
            this.teamNameInput.Size = new System.Drawing.Size(259, 22);
            this.teamNameInput.TabIndex = 44;
            // 
            // teamLabel
            // 
            this.teamLabel.AutoSize = true;
            this.teamLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamLabel.Location = new System.Drawing.Point(75, 32);
            this.teamLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.teamLabel.Name = "teamLabel";
            this.teamLabel.Size = new System.Drawing.Size(206, 46);
            this.teamLabel.TabIndex = 40;
            this.teamLabel.Text = "Create Team";
            // 
            // teamMemberDropDown
            // 
            this.teamMemberDropDown.FormattingEnabled = true;
            this.teamMemberDropDown.Location = new System.Drawing.Point(84, 260);
            this.teamMemberDropDown.Margin = new System.Windows.Forms.Padding(4);
            this.teamMemberDropDown.Name = "teamMemberDropDown";
            this.teamMemberDropDown.Size = new System.Drawing.Size(259, 24);
            this.teamMemberDropDown.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(77, 219);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 32);
            this.label5.TabIndex = 48;
            this.label5.Text = "Select Team Member";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 32);
            this.label2.TabIndex = 46;
            this.label2.Text = "First Name";
            // 
            // fNameInput
            // 
            this.fNameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fNameInput.Location = new System.Drawing.Point(159, 46);
            this.fNameInput.Margin = new System.Windows.Forms.Padding(4);
            this.fNameInput.Name = "fNameInput";
            this.fNameInput.Size = new System.Drawing.Size(133, 22);
            this.fNameInput.TabIndex = 47;
            // 
            // lNameInput
            // 
            this.lNameInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lNameInput.Location = new System.Drawing.Point(159, 108);
            this.lNameInput.Margin = new System.Windows.Forms.Padding(4);
            this.lNameInput.Name = "lNameInput";
            this.lNameInput.Size = new System.Drawing.Size(133, 22);
            this.lNameInput.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 108);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 32);
            this.label6.TabIndex = 48;
            this.label6.Text = "Last Name";
            // 
            // mobileInput
            // 
            this.mobileInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mobileInput.Location = new System.Drawing.Point(159, 219);
            this.mobileInput.Margin = new System.Windows.Forms.Padding(4);
            this.mobileInput.Name = "mobileInput";
            this.mobileInput.Size = new System.Drawing.Size(133, 22);
            this.mobileInput.TabIndex = 53;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 219);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 32);
            this.label8.TabIndex = 52;
            this.label8.Text = "Mobile";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.mailInput);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.mobileInput);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lNameInput);
            this.groupBox1.Controls.Add(this.createMemberBtn);
            this.groupBox1.Controls.Add(this.fNameInput);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(51, 350);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(483, 338);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Member";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 165);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 32);
            this.label7.TabIndex = 54;
            this.label7.Text = "Email";
            // 
            // mailInput
            // 
            this.mailInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mailInput.Location = new System.Drawing.Point(159, 165);
            this.mailInput.Margin = new System.Windows.Forms.Padding(4);
            this.mailInput.Name = "mailInput";
            this.mailInput.Size = new System.Drawing.Size(133, 22);
            this.mailInput.TabIndex = 55;
            // 
            // createTeamBtn
            // 
            this.createTeamBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.createTeamBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTeamBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.createTeamBtn.Location = new System.Drawing.Point(497, 695);
            this.createTeamBtn.Margin = new System.Windows.Forms.Padding(4);
            this.createTeamBtn.Name = "createTeamBtn";
            this.createTeamBtn.Size = new System.Drawing.Size(177, 36);
            this.createTeamBtn.TabIndex = 56;
            this.createTeamBtn.Text = "Create Team";
            this.createTeamBtn.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1236, 759);
            this.Controls.Add(this.createTeamBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tmMemberListBox);
            this.Controls.Add(this.dltMemberBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.teamMemberDropDown);
            this.Controls.Add(this.roundLabel);
            this.Controls.Add(this.addMemberBtn);
            this.Controls.Add(this.teamNameInput);
            this.Controls.Add(this.teamLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CreateTeamForm";
            this.Text = "CreateTeamForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox tmMemberListBox;
        private System.Windows.Forms.Button createMemberBtn;
        private System.Windows.Forms.Button dltMemberBtn;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.Button addMemberBtn;
        private System.Windows.Forms.TextBox teamNameInput;
        private System.Windows.Forms.Label teamLabel;
        private System.Windows.Forms.ComboBox teamMemberDropDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fNameInput;
        private System.Windows.Forms.TextBox lNameInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox mobileInput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox mailInput;
        private System.Windows.Forms.Button createTeamBtn;
    }
}