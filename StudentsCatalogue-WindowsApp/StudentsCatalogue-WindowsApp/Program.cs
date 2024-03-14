using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsCatalogue_WindowsApp
{
    class Program
    {
        static void Main(string[] args)
        {
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
                enrollmentStatus: enrollmentStatus.ACTIV,
                enrollmentDate: DateTime.Now,
                mean: 8.9
            );

            UnivClass pawClass = new UnivClass( 
                "PAW", 
                "C# and Windows Forms",
                "Prof. Dr. Ion Ionescu", 
                5
            );

            Console.WriteLine($"PAW Class has ID: {pawClass.univClassId}");

            Centraliser paw_grades = new Centraliser(1);
            Console.WriteLine($"PAW Class Centraliser has ID: {paw_grades.CentraliserId}");
            paw_grades.AddOrUpdateGrade(student1.id, 9.5);
            paw_grades.AddOrUpdateGrade(student2.id, 8.5);
            paw_grades.AddOrUpdateGrade(student3.id, 8.0);

            Console.WriteLine($"Grades for {pawClass.univClassName} are: ");
            foreach(var entry in paw_grades.Grades)
            {
                Console.WriteLine($"Student ID: {entry.Key}, Nota: {entry.Value}");
            }

            Console.ReadLine();
        }   
    }
}