using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Students_Classes_Centraliser
{
    public partial class AdaugaStudent : Form
    {
        public Student sFormStudent;
        public AdaugaStudent(Student stud)
        {
            InitializeComponent();
            if (stud == null)
            {
                stud = new Student();
                btnAdauga.Text = "Adauga";
            }
            else
            {
                btnAdauga.Text = "Editeaza";
                tbAdaugaNume.Text = stud.FamilyName;
                tbAdaugaPrenume.Text = stud.GivenName;
                dateAdaugaDataNasterii.Value = stud.DateOfBirth;
                tbAdaugaEmail.Text = stud.Email;
                cbAdaugaStatus.Text = stud.EnrollmentStatusStudent.ToString();
                tbAdaugaAnStudiu.Text = stud.YearOfStudy.ToString();
                tbAdaugaProgramStudiu.Text = stud.ProgramOfStudy;
            }
            sFormStudent = stud;
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            sFormStudent.FamilyName = tbAdaugaNume.Text;
            sFormStudent.GivenName = tbAdaugaPrenume.Text;
            sFormStudent.DateOfBirth = dateAdaugaDataNasterii.Value;
            sFormStudent.Email = tbAdaugaEmail.Text;
            if (Enum.TryParse<enrollmentStatus>(cbAdaugaStatus.SelectedItem.ToString(), out var status))
            {
                sFormStudent.EnrollmentStatusStudent = status;
            }
            else
            {
                MessageBox.Show("Statusul selectat este invalid!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            sFormStudent.YearOfStudy = Convert.ToInt32(tbAdaugaAnStudiu.Text);
            sFormStudent.ProgramOfStudy = tbAdaugaProgramStudiu.Text;
        }
    }
}
