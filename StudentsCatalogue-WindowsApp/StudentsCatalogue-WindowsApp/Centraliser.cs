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
                // Aici poți adăuga validări dacă este necesar
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

    }
}