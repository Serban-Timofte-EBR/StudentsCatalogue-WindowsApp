using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsCatalogue_WindowsApp
{
    class Program
    {
        static void Main()
        {
            Student student1 = new Student(1, "John Doe", new Dictionary<string, int>
            {
                { "Math", 90 },
                { "Science", 85 }
            });

            Student studentClone = student1.Clone();
            studentClone.Grades["Math"] = 95; 

            // Check deepCopy
            Console.WriteLine("Original Student Grades:");
            foreach (var grade in student1.Grades)
            {
                Console.WriteLine($"{grade.Key}: {grade.Value}");
            }

            Console.WriteLine("\nCloned Student Grades:");
            foreach (var grade in studentClone.Grades)
            {
                Console.WriteLine($"{grade.Key}: {grade.Value}");
            }

            Student student2 = new Student(2, "Jane Smith", new Dictionary<string, int>
            {
                { "Math", 88 },
                { "Science", 90 }
            });

            // Compare the two students based on their average grades
            int comparisonResult = student1.CompareTo(student2);
            if (comparisonResult < 0)
            {
                Console.WriteLine("\nStudent1 has a lower grade average than Student2.");
            }
            else if (comparisonResult > 0)
            {
                Console.WriteLine("\nStudent1 has a higher grade average than Student2.");
            }
            else
            {
                Console.WriteLine("\nStudent1 and Student2 have the same grade average.");
            }

            //Students List
            Student andrei = new Student(3, "Andrei", new Dictionary<string, int> { { "OOP", 90 } });
            Student gabriel = new Student(4, "Gabriel", new Dictionary<string, int> { { "PAW", 85 } });
            Student alina = new Student(5, "Alina", new Dictionary<string, int> { { "SDD", 92 } });

            //University Classes List
            UnivClass oopClass = new UnivClass(101, "OOP");
            UnivClass pawClass = new UnivClass(102, "PAW");
            UnivClass sddClass = new UnivClass(103, "SDD");

            //Centraliser
            Centraliser centraliser = new Centraliser();

            centraliser.addStudentToClass(andrei.Id, oopClass.Id);
            centraliser.addStudentToClass(andrei.Id, pawClass.Id);  //Andrei takes OOP & PAW
            centraliser.addStudentToClass(gabriel.Id, pawClass.Id); //Gabriel takes PAW
            centraliser.addStudentToClass(alina.Id, sddClass.Id);   //Alina takes SDD

            Console.WriteLine("Classes of Andrei: ");
            List<int> classesOfAndrei = centraliser.getAllClassesForAStudent(andrei.Id);
            foreach (int i in classesOfAndrei)
            {
                Console.Write(i + " ");
            }

            Console.ReadLine();
        }
    }
}