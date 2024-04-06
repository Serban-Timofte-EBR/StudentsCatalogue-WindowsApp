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
            components = new System.ComponentModel.Container();
            lvStudenti = new ListView();
            Nume = new ColumnHeader();
            Prenume = new ColumnHeader();
            DataNastere = new ColumnHeader();
            Email = new ColumnHeader();
            Status = new ColumnHeader();
            An = new ColumnHeader();
            ProgramDeStudiu = new ColumnHeader();
            tbTitluStudenti = new TextBox();
            navBarApp = new MenuStrip();
            studentiToolStripMenuItem = new ToolStripMenuItem();
            adaugaToolStripMenuItem = new ToolStripMenuItem();
            modificaToolStripMenuItem = new ToolStripMenuItem();
            stergeToolStripMenuItem = new ToolStripMenuItem();
            claseToolStripMenuItem = new ToolStripMenuItem();
            adaugaToolStripMenuItem1 = new ToolStripMenuItem();
            editeazaToolStripMenuItem = new ToolStripMenuItem();
            stergeToolStripMenuItem1 = new ToolStripMenuItem();
            tbTitluClase = new TextBox();
            lvClase = new ListView();
            Clasa = new ColumnHeader();
            Descriere = new ColumnHeader();
            Profesor = new ColumnHeader();
            Credite = new ColumnHeader();
            contextMenuStudenti = new ContextMenuStrip(components);
            adaugaToolStripMenuItem2 = new ToolStripMenuItem();
            editeazaToolStripMenuItem1 = new ToolStripMenuItem();
            stergeToolStripMenuItem2 = new ToolStripMenuItem();
            navBarApp.SuspendLayout();
            contextMenuStudenti.SuspendLayout();
            SuspendLayout();
            // 
            // lvStudenti
            // 
            lvStudenti.Columns.AddRange(new ColumnHeader[] { Nume, Prenume, DataNastere, Email, Status, An, ProgramDeStudiu });
            lvStudenti.FullRowSelect = true;
            lvStudenti.Location = new Point(1, 46);
            lvStudenti.Margin = new Padding(2, 1, 2, 1);
            lvStudenti.Name = "lvStudenti";
            lvStudenti.Size = new Size(452, 201);
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
            tbTitluStudenti.Location = new Point(2, 25);
            tbTitluStudenti.Margin = new Padding(2, 1, 2, 1);
            tbTitluStudenti.Name = "tbTitluStudenti";
            tbTitluStudenti.Size = new Size(451, 23);
            tbTitluStudenti.TabIndex = 1;
            tbTitluStudenti.Text = "                                           Lista Studenti";
            // 
            // navBarApp
            // 
            navBarApp.ImageScalingSize = new Size(32, 32);
            navBarApp.Items.AddRange(new ToolStripItem[] { studentiToolStripMenuItem, claseToolStripMenuItem });
            navBarApp.Location = new Point(0, 0);
            navBarApp.Name = "navBarApp";
            navBarApp.Padding = new Padding(3, 1, 0, 1);
            navBarApp.Size = new Size(816, 24);
            navBarApp.TabIndex = 2;
            navBarApp.Text = "navBarApp";
            // 
            // studentiToolStripMenuItem
            // 
            studentiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adaugaToolStripMenuItem, modificaToolStripMenuItem, stergeToolStripMenuItem });
            studentiToolStripMenuItem.Name = "studentiToolStripMenuItem";
            studentiToolStripMenuItem.Size = new Size(63, 22);
            studentiToolStripMenuItem.Text = "Studenti";
            // 
            // adaugaToolStripMenuItem
            // 
            adaugaToolStripMenuItem.Name = "adaugaToolStripMenuItem";
            adaugaToolStripMenuItem.Size = new Size(121, 22);
            adaugaToolStripMenuItem.Text = "Adauga";
            adaugaToolStripMenuItem.Click += adaugaToolStripMenuItem_Click;
            // 
            // modificaToolStripMenuItem
            // 
            modificaToolStripMenuItem.Name = "modificaToolStripMenuItem";
            modificaToolStripMenuItem.Size = new Size(121, 22);
            modificaToolStripMenuItem.Text = "Modifica";
            modificaToolStripMenuItem.Click += modificaToolStripMenuItem_Click;
            // 
            // stergeToolStripMenuItem
            // 
            stergeToolStripMenuItem.Name = "stergeToolStripMenuItem";
            stergeToolStripMenuItem.Size = new Size(121, 22);
            stergeToolStripMenuItem.Text = "Sterge";
            stergeToolStripMenuItem.Click += stergeToolStripMenuItem_Click;
            // 
            // claseToolStripMenuItem
            // 
            claseToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adaugaToolStripMenuItem1, editeazaToolStripMenuItem, stergeToolStripMenuItem1 });
            claseToolStripMenuItem.Name = "claseToolStripMenuItem";
            claseToolStripMenuItem.Size = new Size(47, 22);
            claseToolStripMenuItem.Text = "Clase";
            // 
            // adaugaToolStripMenuItem1
            // 
            adaugaToolStripMenuItem1.Name = "adaugaToolStripMenuItem1";
            adaugaToolStripMenuItem1.Size = new Size(117, 22);
            adaugaToolStripMenuItem1.Text = "Adauga";
            adaugaToolStripMenuItem1.Click += adaugaToolStripMenuItem1_Click;
            // 
            // editeazaToolStripMenuItem
            // 
            editeazaToolStripMenuItem.Name = "editeazaToolStripMenuItem";
            editeazaToolStripMenuItem.Size = new Size(117, 22);
            editeazaToolStripMenuItem.Text = "Editeaza";
            editeazaToolStripMenuItem.Click += editeazaToolStripMenuItem_Click;
            // 
            // stergeToolStripMenuItem1
            // 
            stergeToolStripMenuItem1.Name = "stergeToolStripMenuItem1";
            stergeToolStripMenuItem1.Size = new Size(117, 22);
            stergeToolStripMenuItem1.Text = "Sterge";
            stergeToolStripMenuItem1.Click += stergeToolStripMenuItem1_Click;
            // 
            // tbTitluClase
            // 
            tbTitluClase.Location = new Point(493, 25);
            tbTitluClase.Margin = new Padding(2, 1, 2, 1);
            tbTitluClase.Name = "tbTitluClase";
            tbTitluClase.Size = new Size(453, 23);
            tbTitluClase.TabIndex = 3;
            tbTitluClase.Text = "                                           Lista Clase";
            // 
            // lvClase
            // 
            lvClase.Columns.AddRange(new ColumnHeader[] { Clasa, Descriere, Profesor, Credite });
            lvClase.FullRowSelect = true;
            lvClase.Location = new Point(495, 46);
            lvClase.Margin = new Padding(2, 1, 2, 1);
            lvClase.Name = "lvClase";
            lvClase.Size = new Size(450, 200);
            lvClase.TabIndex = 4;
            lvClase.Tag = "";
            lvClase.UseCompatibleStateImageBehavior = false;
            lvClase.View = View.Details;
            // 
            // Clasa
            // 
            Clasa.Text = "Nume Clasa";
            // 
            // Descriere
            // 
            Descriere.Text = "Descriere";
            // 
            // Profesor
            // 
            Profesor.Text = "Profesor";
            // 
            // Credite
            // 
            Credite.Text = "Credite";
            // 
            // contextMenuStudenti
            // 
            contextMenuStudenti.BackColor = Color.FromArgb(224, 224, 224);
            contextMenuStudenti.Items.AddRange(new ToolStripItem[] { adaugaToolStripMenuItem2, editeazaToolStripMenuItem1, stergeToolStripMenuItem2 });
            contextMenuStudenti.Name = "contextMenuStrip1";
            contextMenuStudenti.Size = new Size(118, 70);
            contextMenuStudenti.Opening += contextMenuStrip1_Opening;
            // 
            // adaugaToolStripMenuItem2
            // 
            adaugaToolStripMenuItem2.Name = "adaugaToolStripMenuItem2";
            adaugaToolStripMenuItem2.Size = new Size(117, 22);
            adaugaToolStripMenuItem2.Text = "Adauga";
            adaugaToolStripMenuItem2.Click += adaugaToolStripMenuItem2_Click;
            // 
            // editeazaToolStripMenuItem1
            // 
            editeazaToolStripMenuItem1.Name = "editeazaToolStripMenuItem1";
            editeazaToolStripMenuItem1.Size = new Size(117, 22);
            editeazaToolStripMenuItem1.Text = "Editeaza";
            // 
            // stergeToolStripMenuItem2
            // 
            stergeToolStripMenuItem2.Name = "stergeToolStripMenuItem2";
            stergeToolStripMenuItem2.Size = new Size(117, 22);
            stergeToolStripMenuItem2.Text = "Sterge";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 434);
            Controls.Add(lvClase);
            Controls.Add(tbTitluClase);
            Controls.Add(tbTitluStudenti);
            Controls.Add(lvStudenti);
            Controls.Add(navBarApp);
            MainMenuStrip = navBarApp;
            Margin = new Padding(2, 1, 2, 1);
            Name = "Form1";
            Text = "A";
            navBarApp.ResumeLayout(false);
            navBarApp.PerformLayout();
            contextMenuStudenti.ResumeLayout(false);
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
        private MenuStrip navBarApp;
        private ToolStripMenuItem studentiToolStripMenuItem;
        private ToolStripMenuItem adaugaToolStripMenuItem;
        private ToolStripMenuItem modificaToolStripMenuItem;
        private ToolStripMenuItem stergeToolStripMenuItem;
        private TextBox tbTitluClase;
        private ListView lvClase;
        private ColumnHeader Clasa;
        private ColumnHeader Descriere;
        private ColumnHeader Profesor;
        private ColumnHeader Credite;
        private ToolStripMenuItem claseToolStripMenuItem;
        private ToolStripMenuItem adaugaToolStripMenuItem1;
        private ToolStripMenuItem editeazaToolStripMenuItem;
        private ToolStripMenuItem stergeToolStripMenuItem1;
        private ContextMenuStrip contextMenuStudenti;
        private ToolStripMenuItem adaugaToolStripMenuItem2;
        private ToolStripMenuItem editeazaToolStripMenuItem1;
        private ToolStripMenuItem stergeToolStripMenuItem2;
    }
}