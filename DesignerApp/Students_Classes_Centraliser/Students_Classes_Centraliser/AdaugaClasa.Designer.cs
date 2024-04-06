namespace Students_Classes_Centraliser
{
    partial class AdaugaClasa
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
            lbNumeClasa = new Label();
            lbDescriereClasa = new Label();
            lbProfesor = new Label();
            lbCredite = new Label();
            tbNumeClasa = new TextBox();
            tbDescriere = new TextBox();
            tbProfesor = new TextBox();
            tbCredite = new TextBox();
            btAdauga = new Button();
            btRenunta = new Button();
            SuspendLayout();
            // 
            // lbNumeClasa
            // 
            lbNumeClasa.AutoSize = true;
            lbNumeClasa.Location = new Point(128, 168);
            lbNumeClasa.Name = "lbNumeClasa";
            lbNumeClasa.Size = new Size(142, 32);
            lbNumeClasa.TabIndex = 0;
            lbNumeClasa.Text = "Nume Clasa";
            // 
            // lbDescriereClasa
            // 
            lbDescriereClasa.AutoSize = true;
            lbDescriereClasa.Location = new Point(128, 244);
            lbDescriereClasa.Name = "lbDescriereClasa";
            lbDescriereClasa.Size = new Size(113, 32);
            lbDescriereClasa.TabIndex = 1;
            lbDescriereClasa.Text = "Descriere";
            // 
            // lbProfesor
            // 
            lbProfesor.AutoSize = true;
            lbProfesor.Location = new Point(128, 321);
            lbProfesor.Name = "lbProfesor";
            lbProfesor.Size = new Size(102, 32);
            lbProfesor.TabIndex = 2;
            lbProfesor.Text = "Profesor";
            // 
            // lbCredite
            // 
            lbCredite.AutoSize = true;
            lbCredite.Location = new Point(128, 395);
            lbCredite.Name = "lbCredite";
            lbCredite.Size = new Size(91, 32);
            lbCredite.TabIndex = 3;
            lbCredite.Text = "Credite";
            // 
            // tbNumeClasa
            // 
            tbNumeClasa.Location = new Point(313, 168);
            tbNumeClasa.Name = "tbNumeClasa";
            tbNumeClasa.Size = new Size(411, 39);
            tbNumeClasa.TabIndex = 4;
            // 
            // tbDescriere
            // 
            tbDescriere.Location = new Point(313, 244);
            tbDescriere.Name = "tbDescriere";
            tbDescriere.Size = new Size(411, 39);
            tbDescriere.TabIndex = 5;
            // 
            // tbProfesor
            // 
            tbProfesor.Location = new Point(313, 321);
            tbProfesor.Name = "tbProfesor";
            tbProfesor.Size = new Size(411, 39);
            tbProfesor.TabIndex = 6;
            // 
            // tbCredite
            // 
            tbCredite.Location = new Point(313, 395);
            tbCredite.Name = "tbCredite";
            tbCredite.Size = new Size(411, 39);
            tbCredite.TabIndex = 7;
            // 
            // btAdauga
            // 
            btAdauga.DialogResult = DialogResult.OK;
            btAdauga.Location = new Point(313, 526);
            btAdauga.Name = "btAdauga";
            btAdauga.Size = new Size(177, 89);
            btAdauga.TabIndex = 8;
            btAdauga.Text = "Adauga";
            btAdauga.UseVisualStyleBackColor = true;
            btAdauga.Click += btAdauga_Click;
            // 
            // btRenunta
            // 
            btRenunta.BackColor = Color.FromArgb(255, 128, 128);
            btRenunta.DialogResult = DialogResult.Cancel;
            btRenunta.Location = new Point(547, 526);
            btRenunta.Name = "btRenunta";
            btRenunta.Size = new Size(177, 89);
            btRenunta.TabIndex = 9;
            btRenunta.Text = "Renunta";
            btRenunta.UseVisualStyleBackColor = false;
            // 
            // AdaugaClasa
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 984);
            Controls.Add(btRenunta);
            Controls.Add(btAdauga);
            Controls.Add(tbCredite);
            Controls.Add(tbProfesor);
            Controls.Add(tbDescriere);
            Controls.Add(tbNumeClasa);
            Controls.Add(lbCredite);
            Controls.Add(lbProfesor);
            Controls.Add(lbDescriereClasa);
            Controls.Add(lbNumeClasa);
            Name = "AdaugaClasa";
            Text = "AdaugaClasa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbNumeClasa;
        private Label lbDescriereClasa;
        private Label lbProfesor;
        private Label lbCredite;
        private TextBox tbNumeClasa;
        private TextBox tbDescriere;
        private TextBox tbProfesor;
        private TextBox tbCredite;
        private Button btAdauga;
        private Button btRenunta;
    }
}