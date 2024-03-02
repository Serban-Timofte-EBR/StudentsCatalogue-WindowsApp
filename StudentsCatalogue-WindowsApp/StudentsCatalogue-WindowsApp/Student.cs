using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsCatalogue_WindowsApp
{
    internal class Student : ICloneable, IComparable<Student>
    {
        public readonly int id;
        private string name;
        private Dictionary<string, int> grades;

        public int Id { get { return id; } }

        public string Name
        {
            get { return name; }
            set { if (value.Length >= 3) name = value; }
        }

        public Dictionary<string, int> Grades
        {
            get { return grades; }
            set { grades = value; }
        }

        public Student(int id)
        {
            this.id = id;
            this.name = "";
            this.grades = new Dictionary<string, int>();
        }

        public Student(int id, string name, Dictionary<string, int> grades)
        {
            this.id = id;
            this.name = name;
            this.grades = grades ?? new Dictionary<string, int>();
        }

        object ICloneable.Clone()
        {
            return this.MemberwiseClone();
        }

        public Student Clone()
        {
           Student clonedStudent = (Student)((ICloneable)this).Clone();
           clonedStudent.grades = new Dictionary<string, int>(this.grades);

           return clonedStudent;
        }

        public int CompareTo(Student other)
        {
            double thisAverage = this.grades.Values.Average();
            double otherAverage = other.grades.Values.Average();

            return thisAverage.CompareTo(otherAverage);
        }

        public double GetAverageGrade()
        {
            if (grades.Count == 0) return 0;
            return grades.Values.Average();
        }
    }
}
