namespace Students_Classes_Centraliser
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lvStudenti = new ListView();
            Nume = new ColumnHeader();
            Prenume = new ColumnHeader();
            DataNastere = new ColumnHeader();
            Email = new ColumnHeader();
            Status = new ColumnHeader();
            An = new ColumnHeader();
            ProgramDeStudiu = new ColumnHeader();
            tbTitluStudenti = new TextBox();
            menuStrip1 = new MenuStrip();
            studentiToolStripMenuItem = new ToolStripMenuItem();
            adaugaToolStripMenuItem = new ToolStripMenuItem();
            modificaToolStripMenuItem = new ToolStripMenuItem();
            stergeToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lvStudenti
            // 
            lvStudenti.Columns.AddRange(new ColumnHeader[] { Nume, Prenume, DataNastere, Email, Status, An, ProgramDeStudiu });
            lvStudenti.FullRowSelect = true;
            lvStudenti.Location = new Point(2, 98);
            lvStudenti.Name = "lvStudenti";
            lvStudenti.Size = new Size(836, 424);
            lvStudenti.TabIndex = 0;
            lvStudenti.UseCompatibleStateImageBehavior = false;
            lvStudenti.View = View.Details;
            // 
            // Nume
            // 
            Nume.Text = "Nume";
            // 
            // Prenume
            // 
            Prenume.Text = "Prenume";
            // 
            // DataNastere
            // 
            DataNastere.Text = "Data Nasterii";
            // 
            // Email
            // 
            Email.Text = "Email";
            // 
            // Status
            // 
            Status.Text = "Status";
            // 
            // An
            // 
            An.Text = "An";
            // 
            // ProgramDeStudiu
            // 
            ProgramDeStudiu.Text = "Program De Studiu";
            // 
            // tbTitluStudenti
            // 
            tbTitluStudenti.Location = new Point(3, 54);
            tbTitluStudenti.Name = "tbTitluStudenti";
            tbTitluStudenti.Size = new Size(835, 39);
            tbTitluStudenti.TabIndex = 1;
            tbTitluStudenti.Text = "       Lista Studenti";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { studentiToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(2067, 40);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // studentiToolStripMenuItem
            // 
            studentiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adaugaToolStripMenuItem, modificaToolStripMenuItem, stergeToolStripMenuItem });
            studentiToolStripMenuItem.Name = "studentiToolStripMenuItem";
            studentiToolStripMenuItem.Size = new Size(123, 36);
            studentiToolStripMenuItem.Text = "Studenti";
            // 
            // adaugaToolStripMenuItem
            // 
            adaugaToolStripMenuItem.Name = "adaugaToolStripMenuItem";
            adaugaToolStripMenuItem.Size = new Size(240, 44);
            adaugaToolStripMenuItem.Text = "Adauga";
            adaugaToolStripMenuItem.Click += adaugaToolStripMenuItem_Click;
            // 
            // modificaToolStripMenuItem
            // 
            modificaToolStripMenuItem.Name = "modificaToolStripMenuItem";
            modificaToolStripMenuItem.Size = new Size(240, 44);
            modificaToolStripMenuItem.Text = "Modifica";
            // 
            // stergeToolStripMenuItem
            // 
            stergeToolStripMenuItem.Name = "stergeToolStripMenuItem";
            stergeToolStripMenuItem.Size = new Size(240, 44);
            stergeToolStripMenuItem.Text = "Sterge";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2067, 1084);
            Controls.Add(tbTitluStudenti);
            Controls.Add(lvStudenti);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvStudenti;
        private TextBox tbTitluStudenti;
        private ColumnHeader Nume;
        private ColumnHeader Prenume;
        private ColumnHeader DataNastere;
        private ColumnHeader Email;
        private ColumnHeader Status;
        private ColumnHeader An;
        private ColumnHeader ProgramDeStudiu;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem studentiToolStripMenuItem;
        private ToolStripMenuItem adaugaToolStripMenuItem;
        private ToolStripMenuItem modificaToolStripMenuItem;
        private ToolStripMenuItem stergeToolStripMenuItem;
    }
}