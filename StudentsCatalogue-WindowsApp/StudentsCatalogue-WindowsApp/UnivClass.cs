using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsCatalogue_WindowsApp
{
    internal class UnivClass : ICloneable
    {
        public readonly int id;
        public String courseName;
        public List<Student> students;

        public int Id
        {
            get { return id; }
        }

        public String CourseName
        {
            get { return courseName; }
            set { if (value.Length >= 3) courseName = value; }
        }

        public List<Student> Students
        {
            get { return students; }
            set { students = value; }
        }

        public UnivClass(int id)
        {
            this.id = id;
            Students = new List<Student>();
        }

        public UnivClass(int id, String courseName)
        {
            this.id = id;
            CourseName = courseName;
            Students = new List<Student>();
        }

        object ICloneable.Clone()
        {
            return this.MemberwiseClone();
        }

        public UnivClass Clone()
        {
            UnivClass clonedClass = (UnivClass)((ICloneable)this).Clone();
            clonedClass.students = new List<Student>(this.students);

            return clonedClass;
        }
    }
}