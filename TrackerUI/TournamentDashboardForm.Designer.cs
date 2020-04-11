namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.createTrnBtn = new System.Windows.Forms.Button();
            this.loadTrnDropDown = new System.Windows.Forms.ComboBox();
            this.roundLabel = new System.Windows.Forms.Label();
            this.tournamentLabel = new System.Windows.Forms.Label();
            this.loadTrnBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.createTrnBtn);
            this.groupBox1.Controls.Add(this.loadTrnDropDown);
            this.groupBox1.Controls.Add(this.roundLabel);
            this.groupBox1.Controls.Add(this.tournamentLabel);
            this.groupBox1.Controls.Add(this.loadTrnBtn);
            this.groupBox1.Location = new System.Drawing.Point(31, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(554, 337);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Welcome User";
            // 
            // createTrnBtn
            // 
            this.createTrnBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.createTrnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTrnBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.createTrnBtn.Location = new System.Drawing.Point(131, 258);
            this.createTrnBtn.Name = "createTrnBtn";
            this.createTrnBtn.Size = new System.Drawing.Size(189, 54);
            this.createTrnBtn.TabIndex = 31;
            this.createTrnBtn.Text = "Create Tournament";
            this.createTrnBtn.UseVisualStyleBackColor = true;
            // 
            // loadTrnDropDown
            // 
            this.loadTrnDropDown.FormattingEnabled = true;
            this.loadTrnDropDown.Location = new System.Drawing.Point(121, 120);
            this.loadTrnDropDown.Name = "loadTrnDropDown";
            this.loadTrnDropDown.Size = new System.Drawing.Size(216, 21);
            this.loadTrnDropDown.TabIndex = 29;
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundLabel.Location = new System.Drawing.Point(116, 67);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(229, 25);
            this.roundLabel.TabIndex = 28;
            this.roundLabel.Text = "Load Existing Tournament";
            // 
            // tournamentLabel
            // 
            this.tournamentLabel.AutoSize = true;
            this.tournamentLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tournamentLabel.Location = new System.Drawing.Point(98, 4);
            this.tournamentLabel.Name = "tournamentLabel";
            this.tournamentLabel.Size = new System.Drawing.Size(295, 37);
            this.tournamentLabel.TabIndex = 27;
            this.tournamentLabel.Text = "Tournament Dashboard";
            // 
            // loadTrnBtn
            // 
            this.loadTrnBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.loadTrnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadTrnBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loadTrnBtn.Location = new System.Drawing.Point(167, 165);
            this.loadTrnBtn.Name = "loadTrnBtn";
            this.loadTrnBtn.Size = new System.Drawing.Size(100, 41);
            this.loadTrnBtn.TabIndex = 30;
            this.loadTrnBtn.Text = "Lets Go";
            this.loadTrnBtn.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(664, 424);
            this.Controls.Add(this.groupBox1);
            this.Name = "TournamentDashboardForm";
            this.Text = "TournamentDashboardForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button createTrnBtn;
        private System.Windows.Forms.ComboBox loadTrnDropDown;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.Label tournamentLabel;
        private System.Windows.Forms.Button loadTrnBtn;
    }
}