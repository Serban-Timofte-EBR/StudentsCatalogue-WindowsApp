using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Students_Classes_Centraliser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Student student1 = new Student(
                familyName: "Popescu",
                givenName: "Ion",
                dateOfBirth: new DateTime(2000, 4, 25),
                email: "ion.popescu@example.com",
                address: "Strada Principala, Nr. 1, Bucuresti",
                gender: 'M',
                phoneNumber: "0700000001",
                yearOfStudy: 1,
                university: "Universitatea Bucuresti",
                faculty: "Facultatea de Matematica si Informatica",
                programOfStudy: "Informatica",
                enrollmentStatus: enrollmentStatus.ACTIV,
                enrollmentDate: DateTime.Now,
                mean: 9.5
            );

            Student student2 = new Student(
                familyName: "Ionescu",
                givenName: "Maria",
                dateOfBirth: new DateTime(1999, 7, 15),
                email: "maria.ionescu@example.com",
                address: "Strada Libertatii, Nr. 4, Cluj-Napoca",
                gender: 'F',
                phoneNumber: "0700000002",
                yearOfStudy: 2,
                university: "Universitatea Babes-Bolyai",
                faculty: "Facultatea de Istorie",
                programOfStudy: "Istorie",
                enrollmentStatus: enrollmentStatus.ACTIV,
                enrollmentDate: DateTime.Now,
                mean: 9.7
            );

            Student student3 = new Student(
                familyName: "Vasilescu",
                givenName: "Andrei",
                dateOfBirth: new DateTime(2001, 11, 5),
                email: "andrei.vasilescu@example.com",
                address: "Strada Secundara, Nr. 10, Iasi",
                gender: 'M',
                phoneNumber: "0700000003",
                yearOfStudy: 1,
                university: "Universitatea Alexandru Ioan Cuza",
                faculty: "Facultatea de Filosofie si Stiinte Social-Politice",
                programOfStudy: "Sociologie",
                enrollmentStatus: enrollmentStatus.GRADUATED,
                enrollmentDate: DateTime.Now,
                mean: 8.9
            );

            UnivClass pawClass = new UnivClass(
                "PAW",
                "C# and Windows Forms",
                "Prof. Dr. Ion Ionescu",
                5
            );

            UnivClass sddClass = new UnivClass(
                "SDD",
                "Implementing data structures in C",
                "Prof. Dr. Struct Structurescu",
                4
            );

            UnivClass mraiClass = new UnivClass(
                "MRAI",
                "Risk management",
                "Prof. Dr. Risculescovici Riscovici",
                3
            );

            ListViewItem lvStud1 = new ListViewItem(new string[]
                {student1.FamilyName, student1.GivenName, student1.DateOfBirth.ToString(),
                student1.Email, student1.EnrollmentStatusStudent.ToString(), student1.yearOfStudy.ToString(),
                student1.ProgramOfStudy});

            lvStud1.Tag = student1;
            lvStudenti.Items.Add(lvStud1);

            ListViewItem lvStud2 = new ListViewItem(new string[]
                {student2.FamilyName, student2.GivenName, student2.DateOfBirth.ToString(),
                student2.Email, student2.EnrollmentStatusStudent.ToString(), student2.yearOfStudy.ToString(),
                student2.ProgramOfStudy});

            lvStud2.Tag = student2;
            lvStudenti.Items.Add(lvStud2);

            ListViewItem lvStud3 = new ListViewItem(new string[]
                {student3.FamilyName, student3.GivenName, student3.DateOfBirth.ToString(),
                student3.Email, student3.EnrollmentStatusStudent.ToString(), student3.yearOfStudy.ToString(),
                student3.ProgramOfStudy});

            lvStud3.Tag = student3;
            lvStudenti.Items.Add(lvStud3);

            ListViewItem lvClasa1 = new ListViewItem(new string[]
            {
                pawClass.UnivClassName, pawClass.Description, pawClass.ProfessorName, pawClass.Credits.ToString()
            });

            lvClasa1.Tag = pawClass;
            lvClase.Items.Add(lvClasa1);

            ListViewItem lvClasa2 = new ListViewItem(new string[]
            {
                sddClass.UnivClassName, sddClass.Description, sddClass.ProfessorName, sddClass.Credits.ToString()
            });

            lvClasa2.Tag = sddClass;
            lvClase.Items.Add(lvClasa2);

            ListViewItem lvClasa3 = new ListViewItem(new string[]
            {
                mraiClass.UnivClassName, mraiClass.Description, mraiClass.proffesorName, mraiClass.Credits.ToString()
            });

            lvClasa3.Tag = mraiClass;
            lvClase.Items.Add(lvClasa3);
        }

        private void adaugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student stud = null;
            AdaugaStudent formAdauga = new AdaugaStudent(stud);
            if (formAdauga.ShowDialog() == DialogResult.OK)
            {
                stud = formAdauga.sFormStudent;
                ListViewItem lvStudentNou = new ListViewItem(new string[]
                {
                    stud.FamilyName, stud.GivenName, stud.DateOfBirth.ToString(), stud.Email, stud.EnrollmentStatusStudent.ToString(),
                    stud.yearOfStudy.ToString(), stud.ProgramOfStudy
                });
                lvStudentNou.Tag = stud;
                lvStudenti.Items.Add(lvStudentNou);
            }
        }

        private void modificaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvStudenti.Items.Count > 0)
            {
                ListViewItem lvItem = lvStudenti.SelectedItems[0];
                Student stud = lvItem.Tag as Student;
                AdaugaStudent formEdit = new AdaugaStudent(stud);
                if (formEdit.ShowDialog() == DialogResult.OK)
                {
                    lvItem.SubItems[0].Text = stud.FamilyName;
                    lvItem.SubItems[1].Text = stud.GivenName;
                    lvItem.SubItems[2].Text = stud.DateOfBirth.ToString("d");
                    lvItem.SubItems[3].Text = stud.Email;
                    lvItem.SubItems[4].Text = stud.EnrollmentStatusStudent.ToString();
                    lvItem.SubItems[5].Text = stud.YearOfStudy.ToString();
                    lvItem.SubItems[6].Text = stud.ProgramOfStudy.ToString();
                }
            }
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvStudenti.Items.Count > 0)
            {
                if (MessageBox.Show("Esti sigur ca vrei sa stergi inregistrarea?", "Warning",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    lvStudenti.SelectedItems[0].Remove();
                }
            }
        }

        private void adaugaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UnivClass c = null;
            AdaugaClasa formClasa = new AdaugaClasa(c);
            if (formClasa.ShowDialog() == DialogResult.OK)
            {
                c = formClasa.cformClass;
                ListViewItem lvNou = new ListViewItem(new string[]
                {
                    c.UnivClassName, c.Description, c.ProfessorName, c.Credits.ToString()
                });
                lvNou.Tag = c;
                lvClase.Items.Add(lvNou);
            }
        }

        private void editeazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvClase.SelectedItems.Count > 0)
            {
                UnivClass c = lvClase.SelectedItems[0].Tag as UnivClass;
                AdaugaClasa formEdit = new AdaugaClasa(c);
                if (formEdit.ShowDialog() == DialogResult.OK)
                {
                    ListViewItem lvItem = lvClase.SelectedItems[0] as ListViewItem;
                    lvItem.SubItems[0].Text = c.UnivClassName;
                    lvItem.SubItems[1].Text = c.Description;
                    lvItem.SubItems[2].Text = c.ProfessorName;
                    lvItem.SubItems[3].Text = c.Credits.ToString();
                }
            }
        }

        private void stergeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (lvClase.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Esti sigur ca vrei sa stergi aceasta inregistrare?", "Warning",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    lvClase.SelectedItems[0].Remove();
                }
            }
        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void adaugaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            adaugaToolStripMenuItem_Click(sender, e);
        }

        private void lvStudenti_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbTitluStudenti_TextChanged(object sender, EventArgs e)
        {

        }

        private void adaugaToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            Student stud = null;
            AdaugaStudent formAdauga = new AdaugaStudent(stud);
            if (formAdauga.ShowDialog() == DialogResult.OK)
            {
                stud = formAdauga.sFormStudent;
                ListViewItem studNou = new ListViewItem(new string[]
                {
                    stud.FamilyName, stud.GivenName, stud.DateOfBirth.ToString(), stud.Email, stud.EnrollmentStatusStudent.ToString(),
                    stud.yearOfStudy.ToString(), stud.ProgramOfStudy
                });
                studNou.Tag = stud;
                lvStudenti.Items.Add(studNou);
            }
        }

        private void editeazaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Student stud = lvStudenti.SelectedItems[0].Tag as Student;
            AdaugaStudent formEdit = new AdaugaStudent(stud);
            if (formEdit.ShowDialog() == DialogResult.OK)
            {
                stud = formEdit.sFormStudent;
                ListViewItem lvItem = lvStudenti.SelectedItems[0] as ListViewItem;
                lvItem.SubItems[0].Text = stud.FamilyName;
                lvItem.SubItems[1].Text = stud.GivenName;
                lvItem.SubItems[2].Text = stud.DateOfBirth.ToString("d");
                lvItem.SubItems[3].Text = stud.Email;
                lvItem.SubItems[4].Text = stud.EnrollmentStatusStudent.ToString();
                lvItem.SubItems[5].Text = stud.YearOfStudy.ToString();
                lvItem.SubItems[6].Text = stud.ProgramOfStudy.ToString(); ;
            }
        }

        private void stergeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (lvStudenti.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Esti sigur ca vrei sa stergi acest student?", "Warning",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    lvStudenti.SelectedItems[0].Remove();
                }
            }
        }

        private void adaugaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            UnivClass c = null;
            AdaugaClasa formAdauga = new AdaugaClasa(c);
            if (formAdauga.ShowDialog() == DialogResult.OK)
            {
                c = formAdauga.cformClass;
                ListViewItem item = new ListViewItem(new String[]
                {
                    c.UnivClassName, c.Description, c.ProfessorName, c.Credits.ToString()
                });
                item.Tag = c;
                lvClase.Items.Add(item);
            }
        }

        private void editeazaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            UnivClass c = lvClase.SelectedItems[0].Tag as UnivClass;
            AdaugaClasa formEdit = new AdaugaClasa(c);
            if (formEdit.ShowDialog() == DialogResult.OK)
            {
                c = formEdit.cformClass;
                ListViewItem item = lvClase.SelectedItems[0] as ListViewItem;
                item.SubItems[0].Text = c.UnivClassName;
                item.SubItems[1].Text = c.Description;
                item.SubItems[2].Text = c.ProfessorName;
                item.SubItems[3].Text = c.Credits.ToString();
            }
        }

        private void stergeToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (lvClase.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Esti sigur ca vrei sa stergi inregistrarea?", "Warning",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    lvClase.SelectedItems[0].Remove();
                }
            }
        }

        private void contextMenuStripStudenti_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (lvStudenti.SelectedItems.Count > 0)
            {
                adaugaToolStripMenuItem1.Enabled = true;
                editeazaToolStripMenuItem1.Enabled = true;
                stergeToolStripMenuItem2.Enabled = true;
            }
            else
            {
                adaugaToolStripMenuItem1.Enabled = true;
                editeazaToolStripMenuItem1.Enabled = false;
                stergeToolStripMenuItem2.Enabled = false;
            }
        }

        private void contextMenuStripClase_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (lvClase.SelectedItems.Count > 0)
            {
                adaugaToolStripMenuItem2.Enabled = true;
                editeazaToolStripMenuItem2.Enabled = true;
                stergeToolStripMenuItem3.Enabled = true;
            }
            else
            {
                adaugaToolStripMenuItem2.Enabled = true;
                editeazaToolStripMenuItem2.Enabled = false;
                stergeToolStripMenuItem3.Enabled = false;
            }
        }

        private void salvareBinarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "fisier studenti (*stud) | *.stud";
            fd.CheckPathExists = true;

            if (fd.ShowDialog() == DialogResult.OK)
            {
                List<Student> lista = new List<Student>();
                foreach (ListViewItem item in lvStudenti.Items)
                {
                    lista.Add((Student)item.Tag);
                }

                BinaryFormatter serialiazer = new BinaryFormatter();
                Stream fisier = File.Create(fd.FileName);
                serialiazer.Serialize(fisier, lista);
                fisier.Close();
            }
        }

        private void restaurareBinarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "fisier studenti (*stud) | *.stud";
            ofd.CheckFileExists = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                List<Student> lista = new List<Student>();

                Stream fisier = File.OpenRead(ofd.FileName);
                BinaryFormatter serializer = new BinaryFormatter();
                lista.AddRange((List<Student>)serializer.Deserialize(fisier));

                if (lvStudenti.Items.Count > 0)
                {
                    if (MessageBox.Show("Sunt stundeti in lista. Doriti sa stergeti lista existenta?", "Warning",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        lvStudenti.Items.Clear();
                    }

                    foreach (Student stud in lista)
                    {
                        ListViewItem item = new ListViewItem(new string[]
                        {
                            stud.FamilyName, stud.GivenName, stud.DateOfBirth.ToString(), stud.Email, stud.EnrollmentStatusStudent.ToString(),
                            stud.yearOfStudy.ToString(), stud.ProgramOfStudy
                        });
                        item.Tag = stud;
                        lvStudenti.Items.Add(item);
                    }
                }
                fisier.Close();
            }
        }

        private void salvareXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "salvare xml | *.xml";
            fd.CheckPathExists = true;

            if (fd.ShowDialog() == DialogResult.OK)
            {
                List<Student> lista = new List<Student>();
                foreach (ListViewItem item in lvStudenti.Items)
                {
                    lista.Add((Student)item.Tag);
                }

                XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));
                Stream fisier = File.Create(fd.FileName);
                serializer.Serialize(fisier, lista);
                MessageBox.Show("Lista de studenti a fost serializata in format XML");
                fisier.Close();
            }
        }

        private void restaurareXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "fisier xml | *.xml";
            fd.CheckPathExists = true;

            if (fd.ShowDialog() == DialogResult.OK)
            {
                Stream fisier = File.OpenRead(fd.FileName);
                XmlSerializer serializer = new XmlSerializer(typeof(List<Student>));
                List<Student> lista = (List<Student>)serializer.Deserialize(fisier);

                if (lvStudenti.Items.Count > 0)
                {
                    if (MessageBox.Show("Vrei sa stergi inregistrarile din lista?", "Warning",
                        MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                    {
                        lvStudenti.Items.Clear();
                    }
                    foreach (Student stud in lista)
                    {
                        ListViewItem lvi = new ListViewItem(new string[] {
                            stud.FamilyName, stud.GivenName, stud.DateOfBirth.ToString(), stud.Email, stud.EnrollmentStatusStudent.ToString(),
                            stud.yearOfStudy.ToString(), stud.ProgramOfStudy
                        });
                        lvi.Tag = stud;
                        lvStudenti.Items.Add(lvi);
                    }
                }
                fisier.Close();
            }
        }

        private void salvareBinarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "fisiere clase .clasa | *.clasa";
            fd.CheckPathExists = true;

            if (fd.ShowDialog() == DialogResult.OK)
            {
                List<UnivClass> lista = new List<UnivClass>();
                foreach (ListViewItem item in lvClase.Items)
                {
                    lista.Add((UnivClass)item.Tag);
                }

                Stream fisier = File.Create(fd.FileName);
                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(fisier, lista);
                MessageBox.Show("Lista de clase a fost serializata!");
                fisier.Close();
            }
        }

        private void restaurareBinarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "fisiere clase .clasa | *.clasa";
            fd.CheckFileExists = true;

            if (fd.ShowDialog() == DialogResult.OK)
            {
                Stream fisier = File.OpenRead(fd.FileName);
                BinaryFormatter serializer = new BinaryFormatter();
                List<UnivClass> lista = (List<UnivClass>)serializer.Deserialize(fisier);

                if (lvClase.Items.Count > 0)
                {
                    if (MessageBox.Show("Sunt stundeti in lista. Doriti sa stergeti lista existenta?", "Warning",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        lvClase.Items.Clear();
                    }
                }

                foreach (UnivClass clasa in lista)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                            clasa.UnivClassName, clasa.Description, clasa.ProfessorName, clasa.Credits.ToString()
                    });
                    item.Tag = clasa;
                    lvClase.Items.Add(item);
                }
            }
        }

        private void salvareXMLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog fd = new SaveFileDialog();
            fd.Filter = "fisier XML | *.xml";
            fd.CheckPathExists = true;

            if (fd.ShowDialog() == DialogResult.OK)
            {
                List<UnivClass> lista = new List<UnivClass>();
                foreach (ListViewItem item in lvClase.Items)
                {
                    lista.Add((UnivClass)item.Tag);
                }

                XmlSerializer serializer = new XmlSerializer(typeof(List<UnivClass>));
                Stream fisier = File.Create(fd.FileName);
                serializer.Serialize(fisier, lista);
                fisier.Close();
            }
        }

        private void restaurareXMLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "fisier xml | *.xml";
            fd.CheckFileExists = true;

            if(fd.ShowDialog() == DialogResult.OK )
            {
                Stream fisier = File.OpenRead(fd.FileName);
                XmlSerializer serializer = new XmlSerializer (typeof(List<UnivClass>));
                List<UnivClass> lista = (List<UnivClass>)serializer.Deserialize(fisier);

                if (MessageBox.Show("Sunt clase in lista. Doriti sa stergeti lista existenta?", "Warning",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    lvClase.Items.Clear();
                }

                foreach(UnivClass c in lista)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        c.UnivClassName, c.Description, c.ProfessorName, c.Credits.ToString()
                    });
                    item.Tag = c;
                    lvClase.Items.Add(item);
                }
                fisier.Close();
            }
        }
    }
}