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
            contextMenuStripStudenti = new ContextMenuStrip(components);
            adaugaToolStripMenuItem2 = new ToolStripMenuItem();
            editeazaToolStripMenuItem1 = new ToolStripMenuItem();
            stergeToolStripMenuItem2 = new ToolStripMenuItem();
            tbTitluStudenti = new TextBox();
            navBarApp = new MenuStrip();
            studentiToolStripMenuItem = new ToolStripMenuItem();
            adaugaToolStripMenuItem = new ToolStripMenuItem();
            modificaToolStripMenuItem = new ToolStripMenuItem();
            stergeToolStripMenuItem = new ToolStripMenuItem();
            fisierToolStripMenuItem = new ToolStripMenuItem();
            salvareBinarToolStripMenuItem = new ToolStripMenuItem();
            salvareXMLToolStripMenuItem = new ToolStripMenuItem();
            restaurareBinarToolStripMenuItem = new ToolStripMenuItem();
            restaurareXMLToolStripMenuItem = new ToolStripMenuItem();
            claseToolStripMenuItem = new ToolStripMenuItem();
            adaugaToolStripMenuItem1 = new ToolStripMenuItem();
            editeazaToolStripMenuItem = new ToolStripMenuItem();
            stergeToolStripMenuItem1 = new ToolStripMenuItem();
            fisiereToolStripMenuItem = new ToolStripMenuItem();
            salvareBinarToolStripMenuItem1 = new ToolStripMenuItem();
            salvareXMLToolStripMenuItem1 = new ToolStripMenuItem();
            restaurareBinarToolStripMenuItem1 = new ToolStripMenuItem();
            restaurareXMLToolStripMenuItem1 = new ToolStripMenuItem();
            tbTitluClase = new TextBox();
            lvClase = new ListView();
            Clasa = new ColumnHeader();
            Descriere = new ColumnHeader();
            Profesor = new ColumnHeader();
            Credite = new ColumnHeader();
            contextMenuStripClase = new ContextMenuStrip(components);
            adaugaToolStripMenuItem3 = new ToolStripMenuItem();
            editeazaToolStripMenuItem2 = new ToolStripMenuItem();
            stergeToolStripMenuItem3 = new ToolStripMenuItem();
            contextMenuStripStudenti.SuspendLayout();
            navBarApp.SuspendLayout();
            contextMenuStripClase.SuspendLayout();
            SuspendLayout();
            // 
            // lvStudenti
            // 
            lvStudenti.Columns.AddRange(new ColumnHeader[] { Nume, Prenume, DataNastere, Email, Status, An, ProgramDeStudiu });
            lvStudenti.ContextMenuStrip = contextMenuStripStudenti;
            lvStudenti.FullRowSelect = true;
            lvStudenti.Location = new Point(2, 98);
            lvStudenti.Margin = new Padding(4, 2, 4, 2);
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
            // contextMenuStripStudenti
            // 
            contextMenuStripStudenti.ImageScalingSize = new Size(32, 32);
            contextMenuStripStudenti.Items.AddRange(new ToolStripItem[] { adaugaToolStripMenuItem2, editeazaToolStripMenuItem1, stergeToolStripMenuItem2 });
            contextMenuStripStudenti.Name = "contextMenuStripStudenti";
            contextMenuStripStudenti.Size = new Size(177, 118);
            contextMenuStripStudenti.Opening += contextMenuStripStudenti_Opening;
            // 
            // adaugaToolStripMenuItem2
            // 
            adaugaToolStripMenuItem2.Name = "adaugaToolStripMenuItem2";
            adaugaToolStripMenuItem2.Size = new Size(176, 38);
            adaugaToolStripMenuItem2.Text = "Adauga";
            adaugaToolStripMenuItem2.Click += adaugaToolStripMenuItem2_Click_1;
            // 
            // editeazaToolStripMenuItem1
            // 
            editeazaToolStripMenuItem1.Name = "editeazaToolStripMenuItem1";
            editeazaToolStripMenuItem1.Size = new Size(176, 38);
            editeazaToolStripMenuItem1.Text = "Editeaza";
            editeazaToolStripMenuItem1.Click += editeazaToolStripMenuItem1_Click;
            // 
            // stergeToolStripMenuItem2
            // 
            stergeToolStripMenuItem2.Name = "stergeToolStripMenuItem2";
            stergeToolStripMenuItem2.Size = new Size(176, 38);
            stergeToolStripMenuItem2.Text = "Sterge";
            stergeToolStripMenuItem2.Click += stergeToolStripMenuItem2_Click;
            // 
            // tbTitluStudenti
            // 
            tbTitluStudenti.Location = new Point(2, 53);
            tbTitluStudenti.Margin = new Padding(4, 2, 4, 2);
            tbTitluStudenti.Name = "tbTitluStudenti";
            tbTitluStudenti.Size = new Size(834, 39);
            tbTitluStudenti.TabIndex = 1;
            tbTitluStudenti.Text = "                                           Lista Studenti";
            tbTitluStudenti.TextChanged += tbTitluStudenti_TextChanged;
            // 
            // navBarApp
            // 
            navBarApp.ImageScalingSize = new Size(32, 32);
            navBarApp.Items.AddRange(new ToolStripItem[] { studentiToolStripMenuItem, claseToolStripMenuItem });
            navBarApp.Location = new Point(0, 0);
            navBarApp.Name = "navBarApp";
            navBarApp.Size = new Size(1894, 42);
            navBarApp.TabIndex = 2;
            navBarApp.Text = "navBarApp";
            // 
            // studentiToolStripMenuItem
            // 
            studentiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adaugaToolStripMenuItem, modificaToolStripMenuItem, stergeToolStripMenuItem, fisierToolStripMenuItem });
            studentiToolStripMenuItem.Name = "studentiToolStripMenuItem";
            studentiToolStripMenuItem.Size = new Size(123, 38);
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
            modificaToolStripMenuItem.Click += modificaToolStripMenuItem_Click;
            // 
            // stergeToolStripMenuItem
            // 
            stergeToolStripMenuItem.Name = "stergeToolStripMenuItem";
            stergeToolStripMenuItem.Size = new Size(240, 44);
            stergeToolStripMenuItem.Text = "Sterge";
            stergeToolStripMenuItem.Click += stergeToolStripMenuItem_Click;
            // 
            // fisierToolStripMenuItem
            // 
            fisierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salvareBinarToolStripMenuItem, salvareXMLToolStripMenuItem, restaurareBinarToolStripMenuItem, restaurareXMLToolStripMenuItem });
            fisierToolStripMenuItem.Name = "fisierToolStripMenuItem";
            fisierToolStripMenuItem.Size = new Size(240, 44);
            fisierToolStripMenuItem.Text = "Fisier";
            // 
            // salvareBinarToolStripMenuItem
            // 
            salvareBinarToolStripMenuItem.Name = "salvareBinarToolStripMenuItem";
            salvareBinarToolStripMenuItem.Size = new Size(319, 44);
            salvareBinarToolStripMenuItem.Text = "Salvare Binar";
            salvareBinarToolStripMenuItem.Click += salvareBinarToolStripMenuItem_Click;
            // 
            // salvareXMLToolStripMenuItem
            // 
            salvareXMLToolStripMenuItem.Name = "salvareXMLToolStripMenuItem";
            salvareXMLToolStripMenuItem.Size = new Size(319, 44);
            salvareXMLToolStripMenuItem.Text = "Salvare XML";
            salvareXMLToolStripMenuItem.Click += salvareXMLToolStripMenuItem_Click;
            // 
            // restaurareBinarToolStripMenuItem
            // 
            restaurareBinarToolStripMenuItem.Name = "restaurareBinarToolStripMenuItem";
            restaurareBinarToolStripMenuItem.Size = new Size(319, 44);
            restaurareBinarToolStripMenuItem.Text = "Restaurare Binar";
            restaurareBinarToolStripMenuItem.Click += restaurareBinarToolStripMenuItem_Click;
            // 
            // restaurareXMLToolStripMenuItem
            // 
            restaurareXMLToolStripMenuItem.Name = "restaurareXMLToolStripMenuItem";
            restaurareXMLToolStripMenuItem.Size = new Size(319, 44);
            restaurareXMLToolStripMenuItem.Text = "Restaurare XML";
            restaurareXMLToolStripMenuItem.Click += restaurareXMLToolStripMenuItem_Click;
            // 
            // claseToolStripMenuItem
            // 
            claseToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adaugaToolStripMenuItem1, editeazaToolStripMenuItem, stergeToolStripMenuItem1, fisiereToolStripMenuItem });
            claseToolStripMenuItem.Name = "claseToolStripMenuItem";
            claseToolStripMenuItem.Size = new Size(90, 38);
            claseToolStripMenuItem.Text = "Clase";
            // 
            // adaugaToolStripMenuItem1
            // 
            adaugaToolStripMenuItem1.Name = "adaugaToolStripMenuItem1";
            adaugaToolStripMenuItem1.Size = new Size(359, 44);
            adaugaToolStripMenuItem1.Text = "Adauga";
            adaugaToolStripMenuItem1.Click += adaugaToolStripMenuItem1_Click;
            // 
            // editeazaToolStripMenuItem
            // 
            editeazaToolStripMenuItem.Name = "editeazaToolStripMenuItem";
            editeazaToolStripMenuItem.Size = new Size(359, 44);
            editeazaToolStripMenuItem.Text = "Editeaza";
            editeazaToolStripMenuItem.Click += editeazaToolStripMenuItem_Click;
            // 
            // stergeToolStripMenuItem1
            // 
            stergeToolStripMenuItem1.Name = "stergeToolStripMenuItem1";
            stergeToolStripMenuItem1.Size = new Size(359, 44);
            stergeToolStripMenuItem1.Text = "Sterge";
            stergeToolStripMenuItem1.Click += stergeToolStripMenuItem1_Click;
            // 
            // fisiereToolStripMenuItem
            // 
            fisiereToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salvareBinarToolStripMenuItem1, salvareXMLToolStripMenuItem1, restaurareBinarToolStripMenuItem1, restaurareXMLToolStripMenuItem1 });
            fisiereToolStripMenuItem.Name = "fisiereToolStripMenuItem";
            fisiereToolStripMenuItem.Size = new Size(359, 44);
            fisiereToolStripMenuItem.Text = "Fisiere";
            // 
            // salvareBinarToolStripMenuItem1
            // 
            salvareBinarToolStripMenuItem1.Name = "salvareBinarToolStripMenuItem1";
            salvareBinarToolStripMenuItem1.Size = new Size(359, 44);
            salvareBinarToolStripMenuItem1.Text = "Salvare Binar";
            salvareBinarToolStripMenuItem1.Click += salvareBinarToolStripMenuItem1_Click;
            // 
            // salvareXMLToolStripMenuItem1
            // 
            salvareXMLToolStripMenuItem1.Name = "salvareXMLToolStripMenuItem1";
            salvareXMLToolStripMenuItem1.Size = new Size(359, 44);
            salvareXMLToolStripMenuItem1.Text = "Salvare XML";
            salvareXMLToolStripMenuItem1.Click += salvareXMLToolStripMenuItem1_Click;
            // 
            // restaurareBinarToolStripMenuItem1
            // 
            restaurareBinarToolStripMenuItem1.Name = "restaurareBinarToolStripMenuItem1";
            restaurareBinarToolStripMenuItem1.Size = new Size(359, 44);
            restaurareBinarToolStripMenuItem1.Text = "Restaurare Binar";
            restaurareBinarToolStripMenuItem1.Click += restaurareBinarToolStripMenuItem1_Click;
            // 
            // restaurareXMLToolStripMenuItem1
            // 
            restaurareXMLToolStripMenuItem1.Name = "restaurareXMLToolStripMenuItem1";
            restaurareXMLToolStripMenuItem1.Size = new Size(359, 44);
            restaurareXMLToolStripMenuItem1.Text = "Restaurare XML";
            restaurareXMLToolStripMenuItem1.Click += restaurareXMLToolStripMenuItem1_Click;
            // 
            // tbTitluClase
            // 
            tbTitluClase.Location = new Point(916, 53);
            tbTitluClase.Margin = new Padding(4, 2, 4, 2);
            tbTitluClase.Name = "tbTitluClase";
            tbTitluClase.Size = new Size(838, 39);
            tbTitluClase.TabIndex = 3;
            tbTitluClase.Text = "                                           Lista Clase";
            // 
            // lvClase
            // 
            lvClase.Columns.AddRange(new ColumnHeader[] { Clasa, Descriere, Profesor, Credite });
            lvClase.ContextMenuStrip = contextMenuStripClase;
            lvClase.FullRowSelect = true;
            lvClase.Location = new Point(919, 98);
            lvClase.Margin = new Padding(4, 2, 4, 2);
            lvClase.Name = "lvClase";
            lvClase.Size = new Size(832, 422);
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
            // contextMenuStripClase
            // 
            contextMenuStripClase.ImageScalingSize = new Size(32, 32);
            contextMenuStripClase.Items.AddRange(new ToolStripItem[] { adaugaToolStripMenuItem3, editeazaToolStripMenuItem2, stergeToolStripMenuItem3 });
            contextMenuStripClase.Name = "contextMenuStripClase";
            contextMenuStripClase.Size = new Size(177, 118);
            contextMenuStripClase.Opening += contextMenuStripClase_Opening;
            // 
            // adaugaToolStripMenuItem3
            // 
            adaugaToolStripMenuItem3.Name = "adaugaToolStripMenuItem3";
            adaugaToolStripMenuItem3.Size = new Size(176, 38);
            adaugaToolStripMenuItem3.Text = "Adauga";
            adaugaToolStripMenuItem3.Click += adaugaToolStripMenuItem3_Click;
            // 
            // editeazaToolStripMenuItem2
            // 
            editeazaToolStripMenuItem2.Name = "editeazaToolStripMenuItem2";
            editeazaToolStripMenuItem2.Size = new Size(176, 38);
            editeazaToolStripMenuItem2.Text = "Editeaza";
            editeazaToolStripMenuItem2.Click += editeazaToolStripMenuItem2_Click;
            // 
            // stergeToolStripMenuItem3
            // 
            stergeToolStripMenuItem3.Name = "stergeToolStripMenuItem3";
            stergeToolStripMenuItem3.Size = new Size(176, 38);
            stergeToolStripMenuItem3.Text = "Sterge";
            stergeToolStripMenuItem3.Click += stergeToolStripMenuItem3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1894, 926);
            Controls.Add(lvClase);
            Controls.Add(tbTitluClase);
            Controls.Add(tbTitluStudenti);
            Controls.Add(lvStudenti);
            Controls.Add(navBarApp);
            MainMenuStrip = navBarApp;
            Margin = new Padding(4, 2, 4, 2);
            Name = "Form1";
            Text = "A";
            contextMenuStripStudenti.ResumeLayout(false);
            navBarApp.ResumeLayout(false);
            navBarApp.PerformLayout();
            contextMenuStripClase.ResumeLayout(false);
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
        private ContextMenuStrip contextMenuStripStudenti;
        private ToolStripMenuItem adaugaToolStripMenuItem2;
        private ToolStripMenuItem editeazaToolStripMenuItem1;
        private ToolStripMenuItem stergeToolStripMenuItem2;
        private ContextMenuStrip contextMenuStripClase;
        private ToolStripMenuItem adaugaToolStripMenuItem3;
        private ToolStripMenuItem editeazaToolStripMenuItem2;
        private ToolStripMenuItem stergeToolStripMenuItem3;
        private ToolStripMenuItem fisierToolStripMenuItem;
        private ToolStripMenuItem salvareBinarToolStripMenuItem;
        private ToolStripMenuItem salvareXMLToolStripMenuItem;
        private ToolStripMenuItem restaurareBinarToolStripMenuItem;
        private ToolStripMenuItem restaurareXMLToolStripMenuItem;
        private ToolStripMenuItem fisiereToolStripMenuItem;
        private ToolStripMenuItem salvareBinarToolStripMenuItem1;
        private ToolStripMenuItem salvareXMLToolStripMenuItem1;
        private ToolStripMenuItem restaurareBinarToolStripMenuItem1;
        private ToolStripMenuItem restaurareXMLToolStripMenuItem1;
    }
}