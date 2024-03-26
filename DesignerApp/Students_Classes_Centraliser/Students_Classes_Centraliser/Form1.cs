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

            ListViewItem lvStud1 = new ListViewItem(new string[]
                {student1.FamilyName, student1.GivenName, student1.DateOfBirth.ToString(),
                student1.Email, student1.EnrollmentStatusStudent.ToString(), student1.yearOfStudy.ToString(),
                student1.ProgramOfStudy});

            lvStudenti.Items.Add(lvStud1);

            ListViewItem lvStud2 = new ListViewItem(new string[]
                {student2.FamilyName, student2.GivenName, student2.DateOfBirth.ToString(),
                student2.Email, student2.EnrollmentStatusStudent.ToString(), student2.yearOfStudy.ToString(),
                student2.ProgramOfStudy});

            lvStudenti.Items.Add(lvStud2);

            ListViewItem lvStud3 = new ListViewItem(new string[]
                {student3.FamilyName, student3.GivenName, student3.DateOfBirth.ToString(),
                student3.Email, student3.EnrollmentStatusStudent.ToString(), student3.yearOfStudy.ToString(),
                student3.ProgramOfStudy});

            lvStudenti.Items.Add(lvStud3);
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
    }
}