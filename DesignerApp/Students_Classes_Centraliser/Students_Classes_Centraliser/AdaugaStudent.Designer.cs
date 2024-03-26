namespace Students_Classes_Centraliser
{
    partial class AdaugaStudent
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
            lbAdaugaNume = new Label();
            lbAdaugaPrenume = new Label();
            lbAdaugaDataNasterii = new Label();
            lbAdaugaEmail = new Label();
            lbAdaugaStatus = new Label();
            lbAdaugaAnStudiu = new Label();
            lbProgramStudiu = new Label();
            tbAdaugaNume = new TextBox();
            tbAdaugaPrenume = new TextBox();
            tbAdaugaEmail = new TextBox();
            tbAdaugaAnStudiu = new TextBox();
            tbAdaugaProgramStudiu = new TextBox();
            cbAdaugaStatus = new ComboBox();
            dateAdaugaDataNasterii = new DateTimePicker();
            btnAdauga = new Button();
            btnRenunta = new Button();
            SuspendLayout();
            // 
            // lbAdaugaNume
            // 
            lbAdaugaNume.AutoSize = true;
            lbAdaugaNume.Location = new Point(101, 70);
            lbAdaugaNume.Name = "lbAdaugaNume";
            lbAdaugaNume.Size = new Size(80, 32);
            lbAdaugaNume.TabIndex = 0;
            lbAdaugaNume.Text = "Nume";
            // 
            // lbAdaugaPrenume
            // 
            lbAdaugaPrenume.AutoSize = true;
            lbAdaugaPrenume.Location = new Point(101, 138);
            lbAdaugaPrenume.Name = "lbAdaugaPrenume";
            lbAdaugaPrenume.Size = new Size(110, 32);
            lbAdaugaPrenume.TabIndex = 1;
            lbAdaugaPrenume.Text = "Prenume";
            // 
            // lbAdaugaDataNasterii
            // 
            lbAdaugaDataNasterii.AutoSize = true;
            lbAdaugaDataNasterii.Location = new Point(101, 199);
            lbAdaugaDataNasterii.Name = "lbAdaugaDataNasterii";
            lbAdaugaDataNasterii.Size = new Size(151, 32);
            lbAdaugaDataNasterii.TabIndex = 2;
            lbAdaugaDataNasterii.Text = "Data Nasterii";
            // 
            // lbAdaugaEmail
            // 
            lbAdaugaEmail.AutoSize = true;
            lbAdaugaEmail.Location = new Point(101, 272);
            lbAdaugaEmail.Name = "lbAdaugaEmail";
            lbAdaugaEmail.Size = new Size(71, 32);
            lbAdaugaEmail.TabIndex = 3;
            lbAdaugaEmail.Text = "Email";
            // 
            // lbAdaugaStatus
            // 
            lbAdaugaStatus.AutoSize = true;
            lbAdaugaStatus.Location = new Point(101, 340);
            lbAdaugaStatus.Name = "lbAdaugaStatus";
            lbAdaugaStatus.Size = new Size(78, 32);
            lbAdaugaStatus.TabIndex = 4;
            lbAdaugaStatus.Text = "Status";
            // 
            // lbAdaugaAnStudiu
            // 
            lbAdaugaAnStudiu.AutoSize = true;
            lbAdaugaAnStudiu.Location = new Point(101, 408);
            lbAdaugaAnStudiu.Name = "lbAdaugaAnStudiu";
            lbAdaugaAnStudiu.Size = new Size(152, 32);
            lbAdaugaAnStudiu.TabIndex = 5;
            lbAdaugaAnStudiu.Text = "An de Studiu";
            // 
            // lbProgramStudiu
            // 
            lbProgramStudiu.AutoSize = true;
            lbProgramStudiu.Location = new Point(101, 476);
            lbProgramStudiu.Name = "lbProgramStudiu";
            lbProgramStudiu.Size = new Size(213, 32);
            lbProgramStudiu.TabIndex = 6;
            lbProgramStudiu.Text = "Program de Studiu";
            // 
            // tbAdaugaNume
            // 
            tbAdaugaNume.Location = new Point(375, 76);
            tbAdaugaNume.Name = "tbAdaugaNume";
            tbAdaugaNume.Size = new Size(641, 39);
            tbAdaugaNume.TabIndex = 7;
            // 
            // tbAdaugaPrenume
            // 
            tbAdaugaPrenume.Location = new Point(375, 150);
            tbAdaugaPrenume.Name = "tbAdaugaPrenume";
            tbAdaugaPrenume.Size = new Size(641, 39);
            tbAdaugaPrenume.TabIndex = 8;
            // 
            // tbAdaugaEmail
            // 
            tbAdaugaEmail.Location = new Point(375, 272);
            tbAdaugaEmail.Name = "tbAdaugaEmail";
            tbAdaugaEmail.Size = new Size(641, 39);
            tbAdaugaEmail.TabIndex = 9;
            // 
            // tbAdaugaAnStudiu
            // 
            tbAdaugaAnStudiu.Location = new Point(375, 412);
            tbAdaugaAnStudiu.Name = "tbAdaugaAnStudiu";
            tbAdaugaAnStudiu.Size = new Size(641, 39);
            tbAdaugaAnStudiu.TabIndex = 10;
            // 
            // tbAdaugaProgramStudiu
            // 
            tbAdaugaProgramStudiu.Location = new Point(375, 478);
            tbAdaugaProgramStudiu.Name = "tbAdaugaProgramStudiu";
            tbAdaugaProgramStudiu.Size = new Size(641, 39);
            tbAdaugaProgramStudiu.TabIndex = 11;
            // 
            // cbAdaugaStatus
            // 
            cbAdaugaStatus.FormattingEnabled = true;
            cbAdaugaStatus.Items.AddRange(new object[] { "ACTIV", "SUSPENDED", "EXMATRICULATED", "GRADUATED" });
            cbAdaugaStatus.Location = new Point(375, 340);
            cbAdaugaStatus.Name = "cbAdaugaStatus";
            cbAdaugaStatus.Size = new Size(641, 40);
            cbAdaugaStatus.TabIndex = 12;
            // 
            // dateAdaugaDataNasterii
            // 
            dateAdaugaDataNasterii.Location = new Point(375, 202);
            dateAdaugaDataNasterii.Name = "dateAdaugaDataNasterii";
            dateAdaugaDataNasterii.Size = new Size(641, 39);
            dateAdaugaDataNasterii.TabIndex = 13;
            // 
            // btnAdauga
            // 
            btnAdauga.DialogResult = DialogResult.OK;
            btnAdauga.Location = new Point(609, 595);
            btnAdauga.Name = "btnAdauga";
            btnAdauga.Size = new Size(156, 80);
            btnAdauga.TabIndex = 14;
            btnAdauga.Text = "Adauga";
            btnAdauga.UseVisualStyleBackColor = true;
            btnAdauga.Click += btnAdauga_Click;
            // 
            // btnRenunta
            // 
            btnRenunta.BackColor = Color.IndianRed;
            btnRenunta.DialogResult = DialogResult.Cancel;
            btnRenunta.Location = new Point(846, 597);
            btnRenunta.Name = "btnRenunta";
            btnRenunta.Size = new Size(170, 76);
            btnRenunta.TabIndex = 15;
            btnRenunta.Text = "Renunta";
            btnRenunta.UseVisualStyleBackColor = false;
            // 
            // AdaugaStudent
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1231, 810);
            Controls.Add(btnRenunta);
            Controls.Add(btnAdauga);
            Controls.Add(dateAdaugaDataNasterii);
            Controls.Add(cbAdaugaStatus);
            Controls.Add(tbAdaugaProgramStudiu);
            Controls.Add(tbAdaugaAnStudiu);
            Controls.Add(tbAdaugaEmail);
            Controls.Add(tbAdaugaPrenume);
            Controls.Add(tbAdaugaNume);
            Controls.Add(lbProgramStudiu);
            Controls.Add(lbAdaugaAnStudiu);
            Controls.Add(lbAdaugaStatus);
            Controls.Add(lbAdaugaEmail);
            Controls.Add(lbAdaugaDataNasterii);
            Controls.Add(lbAdaugaPrenume);
            Controls.Add(lbAdaugaNume);
            Name = "AdaugaStudent";
            Text = "AdaugaStudent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbAdaugaNume;
        private Label lbAdaugaPrenume;
        private Label lbAdaugaDataNasterii;
        private Label lbAdaugaEmail;
        private Label lbAdaugaStatus;
        private Label lbAdaugaAnStudiu;
        private Label lbProgramStudiu;
        private TextBox tbAdaugaNume;
        private TextBox tbAdaugaPrenume;
        private TextBox tbAdaugaEmail;
        private TextBox tbAdaugaAnStudiu;
        private TextBox tbAdaugaProgramStudiu;
        private ComboBox cbAdaugaStatus;
        private DateTimePicker dateAdaugaDataNasterii;
        private Button btnAdauga;
        private Button btnRenunta;
    }
}