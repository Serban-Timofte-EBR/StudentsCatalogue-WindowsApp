using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsCatalogue_WindowsApp
{
    internal class Centraliser
    {
        // ID Disciplina {idstudent1: notaStudentului, idstudent2: notaStudentului ,  ... }
        // 50 {101: 10, 102: 9, 103: 8}
        // https://learn.microsoft.com/en-us/ef/
        public static int NUMBER_OF_ELEMENTS_IN_CENTRALISER = 500;

        public string cetraliser_pk;

        public int centraliserId;
        public int classId;
        public Dictionary<int, double> grades;

        public int CentraliserId
        {
            get { return centraliserId; }
            set { centraliserId = value + NUMBER_OF_ELEMENTS_IN_CENTRALISER; }
        }

        public int ClassId
        {
            get { return classId; }
            set { classId = value; }
        }

        public Dictionary<int, double> Grades
        {
            get { return grades; }
            set { grades = value; }
        }

        public Centraliser()
        {
            centraliserId = 0;
            classId = 0;
            grades = new Dictionary<int, double>();
        }

        public Centraliser(int classId)
        {
            CentraliserId = ++NUMBER_OF_ELEMENTS_IN_CENTRALISER;
            ClassId = classId;
            Grades = new Dictionary<int, double>();
            ++NUMBER_OF_ELEMENTS_IN_CENTRALISER;
        }

        public void AddOrUpdateGrade(int studentId, double grade)
        {
            if(Grades.ContainsKey(studentId))
            {
                Grades[studentId] = grade;
            }
            else
            {
                Grades.Add(studentId, grade);
            }
        }

        public void RemoveStudentGrade(int studentId)
        {
            if(Grades.ContainsKey(studentId)) { Grades.Remove(studentId);}
        }

        public double GetStudentGrade(int studentId)
        {
            if(Grades.ContainsKey(studentId))
            {
                return Grades[studentId];
            }
            throw new KeyNotFoundException($"Student with ID {studentId} was not found in this class!");
        }
    }
}