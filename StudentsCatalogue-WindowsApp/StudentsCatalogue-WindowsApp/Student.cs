using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsCatalogue_WindowsApp
{
    public enum enrollmentStatus { 
        ACTIV,
        SUSPENDED,
        EXMATRICULATED,
        GRADUATED
    }
    internal class Student
    {
        public static int NUMBER_OF_STUDENTS_IN_DB = 100;

        public readonly int id;
        public string familyName;
        public string givenName;
        public DateTime dateOfBirth;
        public string email;
        public string address;
        public char gender;
        public string phoneNumber;
        public int yearOfStudy;
        public string university;
        public string faculty;
        public string programOfStudy;
        public enrollmentStatus enrollmentStatusStudent;
        public DateTime enrollmentDate;
        public double mean;

        public string FamilyName
        {
            get { return familyName; }
            set { if (!string.IsNullOrEmpty(value)) familyName = value; }
        }

        public string GivenName
        {
            get { return givenName; }
            set { if (!string.IsNullOrEmpty(value)) givenName = value; }
        }

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; }
        }

        public string Email
        {
            get { return email; }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Contains("@")
                    && (value.EndsWith(".ro") || value.EndsWith(".com")))
                {
                    email = value;
                }
                else
                {
                    throw new ArgumentException("Email should contain @ and ends with .ro or .com");
                }
            }
        }

        public string Address
        {
            get { return address; }
            set { if (!string.IsNullOrEmpty(value)) address = value; }
        }

        public char Gender
        {
            get { return gender; }
            set { if(value == 'M' || value == 'm' || value == 'F' || value == 'f') gender = value; } 
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { if (value.Length == 10) phoneNumber = value; }
        }

        public int YearOfStudy
        {
            get { return yearOfStudy; }
            set { if(value <= DateTime.Now.Year) yearOfStudy = value; } 
        }

        public string University
        {
            get { return university; }
            set { if (!string.IsNullOrEmpty(value)) university = value; }
        }

        public string Faculty
        {
            get { return faculty; }
            set { if (!string.IsNullOrEmpty(value)) faculty = value; }
        }

        public string ProgramOfStudy
        {
            get { return programOfStudy; }
            set { if (!string.IsNullOrEmpty(value)) programOfStudy = value; }
        }

        public enrollmentStatus EnrollmentStatusStudent
        {
            get { return enrollmentStatusStudent; }
            set { enrollmentStatusStudent = value; }
        }

        public DateTime EnrollmentDate
        {
            get { return enrollmentDate; }
            set { if(value <= DateTime.Now) enrollmentDate = value; }
        }

        public double Mean
        {
            get { return mean; }
            set { if (value >= 0) mean = value; }
        }

        // Default Constructor
        public Student()
        {
            id = ++NUMBER_OF_STUDENTS_IN_DB;
            EnrollmentDate = DateTime.Now; 
            EnrollmentStatusStudent = enrollmentStatus.ACTIV;
        }

        // Constructor with all parameters
        public Student(string familyName, string givenName, DateTime dateOfBirth, string email,
                       string address, char gender, string phoneNumber, int yearOfStudy,
                       string university, string faculty, string programOfStudy,
                       enrollmentStatus enrollmentStatus, DateTime enrollmentDate, double mean) : this()
        {
            FamilyName = familyName;
            GivenName = givenName;
            DateOfBirth = dateOfBirth;
            Email = email;
            Address = address;
            Gender = gender;
            PhoneNumber = phoneNumber;
            YearOfStudy = yearOfStudy;
            University = university;
            Faculty = faculty;
            ProgramOfStudy = programOfStudy;
            EnrollmentStatusStudent = enrollmentStatus;
            EnrollmentDate = enrollmentDate;
            Mean = mean;
        }

        // Constructor for new student admitted
        public Student(string familyName, string givenName, string programOfStudy, int yearOfStudy, DateTime enrollmentDate) : this()
        {
            FamilyName = familyName;
            GivenName = givenName;
            ProgramOfStudy = programOfStudy;
            YearOfStudy = yearOfStudy;
            EnrollmentDate = enrollmentDate;
            EnrollmentStatusStudent = enrollmentStatus.ACTIV;
        }

        // Constructor for new registred student
        public Student(string familyName, string givenName, string email, string phoneNumber, enrollmentStatus enrollmentStatus) : this()
        {

            FamilyName = familyName;
            GivenName = givenName;
            Email = email;
            PhoneNumber = phoneNumber;
            EnrollmentStatusStudent = enrollmentStatus;
        }

        public void UpdateStudentDetails(string newFamilyName = null, string newGivenName = null, DateTime? newDateOfBirth = null,
                                 string newEmail = null, string newAddress = null, char? newGender = null,
                                 string newPhoneNumber = null, int? newYearOfStudy = null, string newUniversity = null,
                                 string newFaculty = null, string newProgramOfStudy = null,
                                 enrollmentStatus? newEnrollmentStatusStudent = null, DateTime? newEnrollmentDate = null,
                                 double? newMean = null)
        {
            if (!string.IsNullOrEmpty(newFamilyName)) FamilyName = newFamilyName;
            if (!string.IsNullOrEmpty(newGivenName)) GivenName = newGivenName;

            if (newDateOfBirth.HasValue) DateOfBirth = newDateOfBirth.Value;

            if (!string.IsNullOrEmpty(newEmail) && newEmail.Contains("@") && (newEmail.EndsWith(".ro") || newEmail.EndsWith(".com")))
            {
                Email = newEmail;
            }

            if (!string.IsNullOrEmpty(newAddress)) Address = newAddress;

            if (newGender.HasValue && (newGender == 'M' || newGender == 'm' || newGender == 'F' || newGender == 'f')) Gender = newGender.Value;

            if (!string.IsNullOrEmpty(newPhoneNumber) && newPhoneNumber.Length == 10) PhoneNumber = newPhoneNumber;

            if (newYearOfStudy.HasValue && newYearOfStudy.Value > 0 && newYearOfStudy.Value <= DateTime.Now.Year) YearOfStudy = newYearOfStudy.Value;

            if (!string.IsNullOrEmpty(newUniversity)) University = newUniversity;
            if (!string.IsNullOrEmpty(newFaculty)) Faculty = newFaculty;
            if (!string.IsNullOrEmpty(newProgramOfStudy)) ProgramOfStudy = newProgramOfStudy;

            if (newEnrollmentStatusStudent.HasValue) EnrollmentStatusStudent = newEnrollmentStatusStudent.Value;

            if (newEnrollmentDate.HasValue && newEnrollmentDate.Value <= DateTime.Now) EnrollmentDate = newEnrollmentDate.Value;

            if (newMean.HasValue && newMean.Value >= 0) Mean = newMean.Value;
        }

        public void ResetStudentData()
        {
            // Reset to default values
            FamilyName = "";
            GivenName = "";
            DateOfBirth = DateTime.Now;
            Email = "";
            Address = "";
            Gender = '\0'; 
            PhoneNumber = "";
            YearOfStudy = 0;
            University = "";
            Faculty = "";
            ProgramOfStudy = "";
            EnrollmentStatusStudent = enrollmentStatus.ACTIV;
            EnrollmentDate = DateTime.Now; 
            Mean = 0.0;
        }
    }
}
