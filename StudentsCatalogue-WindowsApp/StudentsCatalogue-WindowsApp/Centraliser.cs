using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsCatalogue_WindowsApp
{
    internal class Centraliser
    {
        public static int NUMBER_OF_ELEMENTS_IN_CENTRALISER = 0;

        public readonly int centraliserId;
        public string studentId;
        public string univClassId;
        public double grade;
        public bool isPassed;

        public string StudentId
        {
            get { return studentId; }
            set
            {
                studentId = value ?? throw new ArgumentNullException(nameof(StudentId), "Student ID cannot be null.");
            }
        }

        public string UnivClassId
        {
            get { return univClassId; }
            set
            {
                // Aici poți adăuga validări dacă este necesar
                univClassId = value ?? throw new ArgumentNullException(nameof(UnivClassId), "UnivClass ID cannot be null.");
            }
        }

        public double Grade
        {
            get { return grade; }
            set
            {
                if (value < 0.0 || value > 10.0) throw new ArgumentOutOfRangeException(nameof(Grade), "Grade must be between 0.0 and 10.0.");
                grade = value;
                IsPassed = value >= 5.0;
            }
        }

        public bool IsPassed
        {
            get { return isPassed; }
            private set { isPassed = value; }
        }

        // Default Constructor
        public Centraliser()
        {
            centraliserId = ++NUMBER_OF_ELEMENTS_IN_CENTRALISER;
            studentId = string.Empty;
            univClassId = string.Empty;
            grade = 0.0;
            isPassed = false;
        }

        // Constructor with all parameters
        public Centraliser(string studentId, string univClassId, double grade)
        {
            centraliserId = ++NUMBER_OF_ELEMENTS_IN_CENTRALISER;
            this.studentId = studentId;
            this.univClassId = univClassId;
            this.grade = grade;
            this.isPassed = grade >= 5.0;
        }

        // Constructor for initial record
        public Centraliser(string studentId, string univClassId)
        {
            centraliserId = ++NUMBER_OF_ELEMENTS_IN_CENTRALISER;
            this.studentId = studentId;
            this.univClassId = univClassId;
            grade = -1.0; 
            isPassed = false; 
        }

        // Constructor to close a course
        public Centraliser(string studentId, string univClassId, double grade, bool isPassed)
        {
            centraliserId = ++NUMBER_OF_ELEMENTS_IN_CENTRALISER;
            this.studentId = studentId;
            this.univClassId = univClassId;
            this.grade = grade;
            this.isPassed = isPassed;
        }

        public void UpdateCentraliserDetails(string newStudentId = null, string newUnivClassId = null, double? newGrade = null)
        {
            if (!string.IsNullOrEmpty(newStudentId)) StudentId = newStudentId;
            if (!string.IsNullOrEmpty(newUnivClassId)) UnivClassId = newUnivClassId;
            if (newGrade.HasValue) Grade = newGrade.Value;
        }

        public void ResetCentraliserData()
        {
            studentId = string.Empty;
            univClassId = string.Empty;
            grade = 0.0;
            isPassed = false;
        }
    }
}