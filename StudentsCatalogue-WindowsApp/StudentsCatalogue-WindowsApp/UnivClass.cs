using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsCatalogue_WindowsApp
{
    internal class UnivClass
    {
        public static int NUMBER_OF_CLASSES_IN_DB = 0;
        public readonly string univClass_pk;
        public readonly int univClass_id;
        public string univClassName;
        public string description;
        public TimeSpan startTime;
        public double duration;
        public string dayOfWeek;
        public string classRoom;
        public string language;
        public string proffesorName;
        public int credits;

        public string UnivClassName
        {
            get => univClassName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("ClassName cannot be null or whitespace.");
                univClassName = value;
            }
        }

        public string Description
        {
            get { return description; }
            set
            {
                if (value.Length > 500) throw new ArgumentException("Descrierea este prea lungă.");
                description = value;
            }
        }

        public TimeSpan StartTime
        {
            get => startTime;
            set => startTime = value;
        }

        public double Duration
        {
            get => duration;
            set
            {
                if (value <= 0 || value > 120)
                    throw new ArgumentOutOfRangeException(nameof(value), "Duration must be between 1 and 120.");
                duration = value;
            }
        }

        public string DayOfWeek
        {
            get => dayOfWeek;
            set
            {
                var validDays = new List<string> { "monday", "tuesday", "wednesday", "thursday", "friday", "saturday", "sunday" };
                if (!validDays.Contains(value.ToLower()))
                    throw new ArgumentException("Invalid day of the week.");
                dayOfWeek = value;
            }
        }


        public string ClassRoom
        {
            get => classRoom;
            set => classRoom = value ?? throw new ArgumentException("Classroom cannot be null.");
        }

        public string Language
        {
            get => language;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Language cannot be null or whitespace.");
                language = value;
            }
        }

        public string ProfessorName
        {
            get => ProfessorName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("ProfessorName cannot be null or whitespace.");
                proffesorName = value;
            }
        }

        public int Credits
        {
            get => credits;
            set
            {
                if (value < 0 || value > 10)
                    throw new ArgumentOutOfRangeException(nameof(value), "Credits must be a non-negative number lower than 10.");
                credits = value;
            }
        }

        public UnivClass(string univClassName, string description, TimeSpan startTime, double duration,
                     string dayOfWeek, string classRoom, string language, string professorName, int credits)
        {
            this.univClass_pk = (++NUMBER_OF_CLASSES_IN_DB).ToString();
            UnivClassName = univClassName;
            Description = description;
            StartTime = startTime;
            Duration = duration;
            DayOfWeek = dayOfWeek;
            ClassRoom = classRoom;
            Language = language;
            ProfessorName = professorName;
            Credits = credits;
        }

        public UnivClass()
        {
            univClass_pk = (++NUMBER_OF_CLASSES_IN_DB).ToString();
            univClass_id = new Random().Next(1000, 9999); 
            UnivClassName = "Default Class";
            Duration = 1; 
            DayOfWeek = "monday"; 
            Credits = 1; 
        }

        // Constructor for an intro class
        public UnivClass(string univClassName, string classRoom, string language)
            : this() 
        {
            UnivClassName = univClassName;
            ClassRoom = classRoom;
            Language = language;
            Duration = 1.5; 
            Credits = 1; 
        }

        // Constructor for an advance class
        public UnivClass(string univClassName, string description, TimeSpan startTime, string dayOfWeek,
                         string classRoom, string professorName, int credits)
            : this() 
        {
            UnivClassName = univClassName;
            Description = description;
            StartTime = startTime;
            DayOfWeek = dayOfWeek;
            ClassRoom = classRoom;
            ProfessorName = professorName;
            Duration = 3; 
            Credits = credits;
        }

        // Constructor with all parameters
        public UnivClass(int univClassId, string univClassName, string description, TimeSpan startTime,
                         double duration, string dayOfWeek, string classRoom, string language,
                         string professorName, int credits) : this()
        {
            univClass_id = new Random().Next(1000, 9999);
            UnivClassName = univClassName;
            Description = description;
            StartTime = startTime;
            Duration = duration;
            DayOfWeek = dayOfWeek;
            ClassRoom = classRoom;
            Language = language;
            ProfessorName = professorName;
            Credits = credits;
        }
    }
}