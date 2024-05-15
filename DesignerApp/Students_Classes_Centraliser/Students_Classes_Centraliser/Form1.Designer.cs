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
            generareRaportToolStripMenuItem = new ToolStripMenuItem();
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
            twClaseStudenti = new TreeView();
            tbTitluCentralizator = new TextBox();
            dataGridView1 = new DataGridView();
            familyNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            givenNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateOfBirthDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            genderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            yearOfStudyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            universityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            facultyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            programOfStudyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            enrollmentStatusStudentDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            enrollmentDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            meanDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            studentBindingSource = new BindingSource(components);
            dataGridView2 = new DataGridView();
            univClassBindingSource = new BindingSource(components);
            univClassNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            professorNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            creditsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contextMenuStripStudenti.SuspendLayout();
            navBarApp.SuspendLayout();
            contextMenuStripClase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)univClassBindingSource).BeginInit();
            SuspendLayout();
            // 
            // lvStudenti
            // 
            lvStudenti.BackColor = Color.WhiteSmoke;
            lvStudenti.Columns.AddRange(new ColumnHeader[] { Nume, Prenume, DataNastere, Email, Status, An, ProgramDeStudiu });
            lvStudenti.ContextMenuStrip = contextMenuStripStudenti;
            lvStudenti.FullRowSelect = true;
            lvStudenti.Location = new Point(1, 61);
            lvStudenti.Margin = new Padding(2, 1, 2, 1);
            lvStudenti.Name = "lvStudenti";
            lvStudenti.Size = new Size(516, 281);
            lvStudenti.TabIndex = 0;
            lvStudenti.UseCompatibleStateImageBehavior = false;
            lvStudenti.View = View.Details;
            lvStudenti.Click += lvStudenti_Click;
            lvStudenti.MouseDown += lvStudenti_MouseDown;
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
            contextMenuStripStudenti.Size = new Size(136, 76);
            contextMenuStripStudenti.Opening += contextMenuStripStudenti_Opening;
            // 
            // adaugaToolStripMenuItem2
            // 
            adaugaToolStripMenuItem2.Name = "adaugaToolStripMenuItem2";
            adaugaToolStripMenuItem2.Size = new Size(135, 24);
            adaugaToolStripMenuItem2.Text = "Adauga";
            adaugaToolStripMenuItem2.Click += adaugaToolStripMenuItem2_Click_1;
            // 
            // editeazaToolStripMenuItem1
            // 
            editeazaToolStripMenuItem1.Name = "editeazaToolStripMenuItem1";
            editeazaToolStripMenuItem1.Size = new Size(135, 24);
            editeazaToolStripMenuItem1.Text = "Editeaza";
            editeazaToolStripMenuItem1.Click += editeazaToolStripMenuItem1_Click;
            // 
            // stergeToolStripMenuItem2
            // 
            stergeToolStripMenuItem2.Name = "stergeToolStripMenuItem2";
            stergeToolStripMenuItem2.Size = new Size(135, 24);
            stergeToolStripMenuItem2.Text = "Sterge";
            stergeToolStripMenuItem2.Click += stergeToolStripMenuItem2_Click;
            // 
            // tbTitluStudenti
            // 
            tbTitluStudenti.BackColor = SystemColors.Info;
            tbTitluStudenti.Location = new Point(1, 33);
            tbTitluStudenti.Margin = new Padding(2, 1, 2, 1);
            tbTitluStudenti.Name = "tbTitluStudenti";
            tbTitluStudenti.Size = new Size(515, 27);
            tbTitluStudenti.TabIndex = 1;
            tbTitluStudenti.Text = "                                           Lista Studenti";
            tbTitluStudenti.TextChanged += tbTitluStudenti_TextChanged;
            // 
            // navBarApp
            // 
            navBarApp.ImageScalingSize = new Size(32, 32);
            navBarApp.Items.AddRange(new ToolStripItem[] { studentiToolStripMenuItem, claseToolStripMenuItem, generareRaportToolStripMenuItem });
            navBarApp.Location = new Point(0, 0);
            navBarApp.Name = "navBarApp";
            navBarApp.Padding = new Padding(4, 1, 0, 1);
            navBarApp.Size = new Size(1675, 26);
            navBarApp.TabIndex = 2;
            navBarApp.Text = "navBarApp";
            // 
            // studentiToolStripMenuItem
            // 
            studentiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adaugaToolStripMenuItem, modificaToolStripMenuItem, stergeToolStripMenuItem, fisierToolStripMenuItem });
            studentiToolStripMenuItem.Name = "studentiToolStripMenuItem";
            studentiToolStripMenuItem.Size = new Size(78, 24);
            studentiToolStripMenuItem.Text = "Studenti";
            // 
            // adaugaToolStripMenuItem
            // 
            adaugaToolStripMenuItem.Name = "adaugaToolStripMenuItem";
            adaugaToolStripMenuItem.Size = new Size(151, 26);
            adaugaToolStripMenuItem.Text = "Adauga";
            adaugaToolStripMenuItem.Click += adaugaToolStripMenuItem_Click;
            // 
            // modificaToolStripMenuItem
            // 
            modificaToolStripMenuItem.Name = "modificaToolStripMenuItem";
            modificaToolStripMenuItem.Size = new Size(151, 26);
            modificaToolStripMenuItem.Text = "Modifica";
            modificaToolStripMenuItem.Click += modificaToolStripMenuItem_Click;
            // 
            // stergeToolStripMenuItem
            // 
            stergeToolStripMenuItem.Name = "stergeToolStripMenuItem";
            stergeToolStripMenuItem.Size = new Size(151, 26);
            stergeToolStripMenuItem.Text = "Sterge";
            stergeToolStripMenuItem.Click += stergeToolStripMenuItem_Click;
            // 
            // fisierToolStripMenuItem
            // 
            fisierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salvareBinarToolStripMenuItem, salvareXMLToolStripMenuItem, restaurareBinarToolStripMenuItem, restaurareXMLToolStripMenuItem });
            fisierToolStripMenuItem.Name = "fisierToolStripMenuItem";
            fisierToolStripMenuItem.Size = new Size(151, 26);
            fisierToolStripMenuItem.Text = "Fisier";
            // 
            // salvareBinarToolStripMenuItem
            // 
            salvareBinarToolStripMenuItem.Name = "salvareBinarToolStripMenuItem";
            salvareBinarToolStripMenuItem.Size = new Size(200, 26);
            salvareBinarToolStripMenuItem.Text = "Salvare Binar";
            salvareBinarToolStripMenuItem.Click += salvareBinarToolStripMenuItem_Click;
            // 
            // salvareXMLToolStripMenuItem
            // 
            salvareXMLToolStripMenuItem.Name = "salvareXMLToolStripMenuItem";
            salvareXMLToolStripMenuItem.Size = new Size(200, 26);
            salvareXMLToolStripMenuItem.Text = "Salvare XML";
            salvareXMLToolStripMenuItem.Click += salvareXMLToolStripMenuItem_Click;
            // 
            // restaurareBinarToolStripMenuItem
            // 
            restaurareBinarToolStripMenuItem.Name = "restaurareBinarToolStripMenuItem";
            restaurareBinarToolStripMenuItem.Size = new Size(200, 26);
            restaurareBinarToolStripMenuItem.Text = "Restaurare Binar";
            restaurareBinarToolStripMenuItem.Click += restaurareBinarToolStripMenuItem_Click;
            // 
            // restaurareXMLToolStripMenuItem
            // 
            restaurareXMLToolStripMenuItem.Name = "restaurareXMLToolStripMenuItem";
            restaurareXMLToolStripMenuItem.Size = new Size(200, 26);
            restaurareXMLToolStripMenuItem.Text = "Restaurare XML";
            restaurareXMLToolStripMenuItem.Click += restaurareXMLToolStripMenuItem_Click;
            // 
            // claseToolStripMenuItem
            // 
            claseToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adaugaToolStripMenuItem1, editeazaToolStripMenuItem, stergeToolStripMenuItem1, fisiereToolStripMenuItem });
            claseToolStripMenuItem.Name = "claseToolStripMenuItem";
            claseToolStripMenuItem.Size = new Size(58, 24);
            claseToolStripMenuItem.Text = "Clase";
            // 
            // adaugaToolStripMenuItem1
            // 
            adaugaToolStripMenuItem1.Name = "adaugaToolStripMenuItem1";
            adaugaToolStripMenuItem1.Size = new Size(149, 26);
            adaugaToolStripMenuItem1.Text = "Adauga";
            adaugaToolStripMenuItem1.Click += adaugaToolStripMenuItem1_Click;
            // 
            // editeazaToolStripMenuItem
            // 
            editeazaToolStripMenuItem.Name = "editeazaToolStripMenuItem";
            editeazaToolStripMenuItem.Size = new Size(149, 26);
            editeazaToolStripMenuItem.Text = "Editeaza";
            editeazaToolStripMenuItem.Click += editeazaToolStripMenuItem_Click;
            // 
            // stergeToolStripMenuItem1
            // 
            stergeToolStripMenuItem1.Name = "stergeToolStripMenuItem1";
            stergeToolStripMenuItem1.Size = new Size(149, 26);
            stergeToolStripMenuItem1.Text = "Sterge";
            stergeToolStripMenuItem1.Click += stergeToolStripMenuItem1_Click;
            // 
            // fisiereToolStripMenuItem
            // 
            fisiereToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salvareBinarToolStripMenuItem1, salvareXMLToolStripMenuItem1, restaurareBinarToolStripMenuItem1, restaurareXMLToolStripMenuItem1 });
            fisiereToolStripMenuItem.Name = "fisiereToolStripMenuItem";
            fisiereToolStripMenuItem.Size = new Size(149, 26);
            fisiereToolStripMenuItem.Text = "Fisiere";
            // 
            // salvareBinarToolStripMenuItem1
            // 
            salvareBinarToolStripMenuItem1.Name = "salvareBinarToolStripMenuItem1";
            salvareBinarToolStripMenuItem1.Size = new Size(200, 26);
            salvareBinarToolStripMenuItem1.Text = "Salvare Binar";
            salvareBinarToolStripMenuItem1.Click += salvareBinarToolStripMenuItem1_Click;
            // 
            // salvareXMLToolStripMenuItem1
            // 
            salvareXMLToolStripMenuItem1.Name = "salvareXMLToolStripMenuItem1";
            salvareXMLToolStripMenuItem1.Size = new Size(200, 26);
            salvareXMLToolStripMenuItem1.Text = "Salvare XML";
            salvareXMLToolStripMenuItem1.Click += salvareXMLToolStripMenuItem1_Click;
            // 
            // restaurareBinarToolStripMenuItem1
            // 
            restaurareBinarToolStripMenuItem1.Name = "restaurareBinarToolStripMenuItem1";
            restaurareBinarToolStripMenuItem1.Size = new Size(200, 26);
            restaurareBinarToolStripMenuItem1.Text = "Restaurare Binar";
            restaurareBinarToolStripMenuItem1.Click += restaurareBinarToolStripMenuItem1_Click;
            // 
            // restaurareXMLToolStripMenuItem1
            // 
            restaurareXMLToolStripMenuItem1.Name = "restaurareXMLToolStripMenuItem1";
            restaurareXMLToolStripMenuItem1.Size = new Size(200, 26);
            restaurareXMLToolStripMenuItem1.Text = "Restaurare XML";
            restaurareXMLToolStripMenuItem1.Click += restaurareXMLToolStripMenuItem1_Click;
            // 
            // generareRaportToolStripMenuItem
            // 
            generareRaportToolStripMenuItem.Name = "generareRaportToolStripMenuItem";
            generareRaportToolStripMenuItem.Size = new Size(132, 24);
            generareRaportToolStripMenuItem.Text = "Generare Raport";
            generareRaportToolStripMenuItem.Click += generareRaportToolStripMenuItem_Click;
            // 
            // tbTitluClase
            // 
            tbTitluClase.BackColor = SystemColors.Info;
            tbTitluClase.Location = new Point(564, 33);
            tbTitluClase.Margin = new Padding(2, 1, 2, 1);
            tbTitluClase.Name = "tbTitluClase";
            tbTitluClase.Size = new Size(517, 27);
            tbTitluClase.TabIndex = 3;
            tbTitluClase.Text = "                                           Lista Clase";
            // 
            // lvClase
            // 
            lvClase.BackColor = Color.WhiteSmoke;
            lvClase.Columns.AddRange(new ColumnHeader[] { Clasa, Descriere, Profesor, Credite });
            lvClase.ContextMenuStrip = contextMenuStripClase;
            lvClase.FullRowSelect = true;
            lvClase.Location = new Point(566, 61);
            lvClase.Margin = new Padding(2, 1, 2, 1);
            lvClase.Name = "lvClase";
            lvClase.Size = new Size(514, 281);
            lvClase.TabIndex = 4;
            lvClase.Tag = "";
            lvClase.UseCompatibleStateImageBehavior = false;
            lvClase.View = View.Details;
            lvClase.Click += lvClase_Click;
            lvClase.MouseDown += lvClase_MouseDown;
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
            contextMenuStripClase.Size = new Size(136, 76);
            contextMenuStripClase.Opening += contextMenuStripClase_Opening;
            // 
            // adaugaToolStripMenuItem3
            // 
            adaugaToolStripMenuItem3.Name = "adaugaToolStripMenuItem3";
            adaugaToolStripMenuItem3.Size = new Size(135, 24);
            adaugaToolStripMenuItem3.Text = "Adauga";
            adaugaToolStripMenuItem3.Click += adaugaToolStripMenuItem3_Click;
            // 
            // editeazaToolStripMenuItem2
            // 
            editeazaToolStripMenuItem2.Name = "editeazaToolStripMenuItem2";
            editeazaToolStripMenuItem2.Size = new Size(135, 24);
            editeazaToolStripMenuItem2.Text = "Editeaza";
            editeazaToolStripMenuItem2.Click += editeazaToolStripMenuItem2_Click;
            // 
            // stergeToolStripMenuItem3
            // 
            stergeToolStripMenuItem3.Name = "stergeToolStripMenuItem3";
            stergeToolStripMenuItem3.Size = new Size(135, 24);
            stergeToolStripMenuItem3.Text = "Sterge";
            stergeToolStripMenuItem3.Click += stergeToolStripMenuItem3_Click;
            // 
            // twClaseStudenti
            // 
            twClaseStudenti.AllowDrop = true;
            twClaseStudenti.BackColor = Color.WhiteSmoke;
            twClaseStudenti.Location = new Point(1109, 61);
            twClaseStudenti.Margin = new Padding(2);
            twClaseStudenti.Name = "twClaseStudenti";
            twClaseStudenti.Size = new Size(541, 281);
            twClaseStudenti.TabIndex = 5;
            twClaseStudenti.DragDrop += twClaseStudenti_DragDrop_1;
            twClaseStudenti.DragEnter += twClaseStudenti_DragEnter;
            twClaseStudenti.KeyPress += twClaseStudenti_KeyPress;
            // 
            // tbTitluCentralizator
            // 
            tbTitluCentralizator.BackColor = SystemColors.Info;
            tbTitluCentralizator.Location = new Point(1109, 33);
            tbTitluCentralizator.Margin = new Padding(2, 1, 2, 1);
            tbTitluCentralizator.Name = "tbTitluCentralizator";
            tbTitluCentralizator.Size = new Size(541, 27);
            tbTitluCentralizator.TabIndex = 6;
            tbTitluCentralizator.Text = "                                      Centralizator Clase - Studenti";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { familyNameDataGridViewTextBoxColumn, givenNameDataGridViewTextBoxColumn, dateOfBirthDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, genderDataGridViewTextBoxColumn, phoneNumberDataGridViewTextBoxColumn, yearOfStudyDataGridViewTextBoxColumn, universityDataGridViewTextBoxColumn, facultyDataGridViewTextBoxColumn, programOfStudyDataGridViewTextBoxColumn, enrollmentStatusStudentDataGridViewTextBoxColumn, enrollmentDateDataGridViewTextBoxColumn, meanDataGridViewTextBoxColumn });
            dataGridView1.DataSource = studentBindingSource;
            dataGridView1.Location = new Point(0, 373);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(516, 284);
            dataGridView1.TabIndex = 7;
            // 
            // familyNameDataGridViewTextBoxColumn
            // 
            familyNameDataGridViewTextBoxColumn.DataPropertyName = "FamilyName";
            familyNameDataGridViewTextBoxColumn.HeaderText = "FamilyName";
            familyNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            familyNameDataGridViewTextBoxColumn.Name = "familyNameDataGridViewTextBoxColumn";
            familyNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // givenNameDataGridViewTextBoxColumn
            // 
            givenNameDataGridViewTextBoxColumn.DataPropertyName = "GivenName";
            givenNameDataGridViewTextBoxColumn.HeaderText = "GivenName";
            givenNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            givenNameDataGridViewTextBoxColumn.Name = "givenNameDataGridViewTextBoxColumn";
            givenNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
            dateOfBirthDataGridViewTextBoxColumn.MinimumWidth = 6;
            dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            dateOfBirthDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "Address";
            addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            addressDataGridViewTextBoxColumn.Width = 125;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            genderDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            phoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            phoneNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // yearOfStudyDataGridViewTextBoxColumn
            // 
            yearOfStudyDataGridViewTextBoxColumn.DataPropertyName = "YearOfStudy";
            yearOfStudyDataGridViewTextBoxColumn.HeaderText = "YearOfStudy";
            yearOfStudyDataGridViewTextBoxColumn.MinimumWidth = 6;
            yearOfStudyDataGridViewTextBoxColumn.Name = "yearOfStudyDataGridViewTextBoxColumn";
            yearOfStudyDataGridViewTextBoxColumn.Width = 125;
            // 
            // universityDataGridViewTextBoxColumn
            // 
            universityDataGridViewTextBoxColumn.DataPropertyName = "University";
            universityDataGridViewTextBoxColumn.HeaderText = "University";
            universityDataGridViewTextBoxColumn.MinimumWidth = 6;
            universityDataGridViewTextBoxColumn.Name = "universityDataGridViewTextBoxColumn";
            universityDataGridViewTextBoxColumn.Width = 125;
            // 
            // facultyDataGridViewTextBoxColumn
            // 
            facultyDataGridViewTextBoxColumn.DataPropertyName = "Faculty";
            facultyDataGridViewTextBoxColumn.HeaderText = "Faculty";
            facultyDataGridViewTextBoxColumn.MinimumWidth = 6;
            facultyDataGridViewTextBoxColumn.Name = "facultyDataGridViewTextBoxColumn";
            facultyDataGridViewTextBoxColumn.Width = 125;
            // 
            // programOfStudyDataGridViewTextBoxColumn
            // 
            programOfStudyDataGridViewTextBoxColumn.DataPropertyName = "ProgramOfStudy";
            programOfStudyDataGridViewTextBoxColumn.HeaderText = "ProgramOfStudy";
            programOfStudyDataGridViewTextBoxColumn.MinimumWidth = 6;
            programOfStudyDataGridViewTextBoxColumn.Name = "programOfStudyDataGridViewTextBoxColumn";
            programOfStudyDataGridViewTextBoxColumn.Width = 125;
            // 
            // enrollmentStatusStudentDataGridViewTextBoxColumn
            // 
            enrollmentStatusStudentDataGridViewTextBoxColumn.DataPropertyName = "EnrollmentStatusStudent";
            enrollmentStatusStudentDataGridViewTextBoxColumn.HeaderText = "EnrollmentStatusStudent";
            enrollmentStatusStudentDataGridViewTextBoxColumn.MinimumWidth = 6;
            enrollmentStatusStudentDataGridViewTextBoxColumn.Name = "enrollmentStatusStudentDataGridViewTextBoxColumn";
            enrollmentStatusStudentDataGridViewTextBoxColumn.Width = 125;
            // 
            // enrollmentDateDataGridViewTextBoxColumn
            // 
            enrollmentDateDataGridViewTextBoxColumn.DataPropertyName = "EnrollmentDate";
            enrollmentDateDataGridViewTextBoxColumn.HeaderText = "EnrollmentDate";
            enrollmentDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            enrollmentDateDataGridViewTextBoxColumn.Name = "enrollmentDateDataGridViewTextBoxColumn";
            enrollmentDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // meanDataGridViewTextBoxColumn
            // 
            meanDataGridViewTextBoxColumn.DataPropertyName = "Mean";
            meanDataGridViewTextBoxColumn.HeaderText = "Mean";
            meanDataGridViewTextBoxColumn.MinimumWidth = 6;
            meanDataGridViewTextBoxColumn.Name = "meanDataGridViewTextBoxColumn";
            meanDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentBindingSource
            // 
            studentBindingSource.DataSource = typeof(Student);
            // 
            // dataGridView2
            // 
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { univClassNameDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, professorNameDataGridViewTextBoxColumn, creditsDataGridViewTextBoxColumn });
            dataGridView2.DataSource = univClassBindingSource;
            dataGridView2.Location = new Point(571, 376);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(509, 281);
            dataGridView2.TabIndex = 8;
            // 
            // univClassBindingSource
            // 
            univClassBindingSource.DataSource = typeof(UnivClass);
            // 
            // univClassNameDataGridViewTextBoxColumn
            // 
            univClassNameDataGridViewTextBoxColumn.DataPropertyName = "UnivClassName";
            univClassNameDataGridViewTextBoxColumn.HeaderText = "UnivClassName";
            univClassNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            univClassNameDataGridViewTextBoxColumn.Name = "univClassNameDataGridViewTextBoxColumn";
            univClassNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // professorNameDataGridViewTextBoxColumn
            // 
            professorNameDataGridViewTextBoxColumn.DataPropertyName = "ProfessorName";
            professorNameDataGridViewTextBoxColumn.HeaderText = "ProfessorName";
            professorNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            professorNameDataGridViewTextBoxColumn.Name = "professorNameDataGridViewTextBoxColumn";
            professorNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // creditsDataGridViewTextBoxColumn
            // 
            creditsDataGridViewTextBoxColumn.DataPropertyName = "Credits";
            creditsDataGridViewTextBoxColumn.HeaderText = "Credits";
            creditsDataGridViewTextBoxColumn.MinimumWidth = 6;
            creditsDataGridViewTextBoxColumn.Name = "creditsDataGridViewTextBoxColumn";
            creditsDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(1675, 683);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(tbTitluCentralizator);
            Controls.Add(twClaseStudenti);
            Controls.Add(lvClase);
            Controls.Add(tbTitluClase);
            Controls.Add(tbTitluStudenti);
            Controls.Add(lvStudenti);
            Controls.Add(navBarApp);
            MainMenuStrip = navBarApp;
            Margin = new Padding(2, 1, 2, 1);
            Name = "Form1";
            Text = "A";
            contextMenuStripStudenti.ResumeLayout(false);
            navBarApp.ResumeLayout(false);
            navBarApp.PerformLayout();
            contextMenuStripClase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)univClassBindingSource).EndInit();
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
        private TreeView twClaseStudenti;
        private ToolStripMenuItem generareRaportToolStripMenuItem;
        private TextBox tbTitluCentralizator;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn familyNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn givenNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn yearOfStudyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn universityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn facultyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn programOfStudyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn enrollmentStatusStudentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn enrollmentDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn meanDataGridViewTextBoxColumn;
        private BindingSource studentBindingSource;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn univClassNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn professorNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn creditsDataGridViewTextBoxColumn;
        private BindingSource univClassBindingSource;
    }
}