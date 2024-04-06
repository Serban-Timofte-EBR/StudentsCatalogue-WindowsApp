using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_Classes_Centraliser
{
    public class UnivClass
    {
        public static int NUMBER_OF_CLASSES_IN_DB = 0;

        public int univClassId;
        public string univClassName;
        public string description;
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

        public string ProfessorName
        {
            get => this.proffesorName;
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

        public UnivClass()
        {
            univClassId = ++NUMBER_OF_CLASSES_IN_DB;
        }

        // Constructor for an intro class
        public UnivClass(string univClassName)
        {
            univClassId = ++NUMBER_OF_CLASSES_IN_DB;
            UnivClassName = univClassName;
            Credits = 1;
        }

        public UnivClass(string univClassName, string description, string professorName, int credits)
        {
            univClassId = ++NUMBER_OF_CLASSES_IN_DB;
            UnivClassName = univClassName;
            Description = description;
            ProfessorName = professorName;
            Credits = credits;
        }

        public void UpdateClassDetails(string newUnivClassName = null, string newDescription = null,
            string newProfessorName = null, int? newCredits = null)
        {
            if (!string.IsNullOrEmpty(newUnivClassName)) UnivClassName = newUnivClassName;
            if (!string.IsNullOrEmpty(newDescription)) Description = newDescription;
            if (!string.IsNullOrEmpty(newProfessorName)) ProfessorName = newProfessorName;
            if (newCredits.HasValue && newCredits.Value >= 0 && newCredits.Value <= 10) Credits = newCredits.Value;
        }

        public void ResetClassData()
        {
            // Reset to default values
            UnivClassName = "Default Class";
            Description = "";
            ProfessorName = "";
            Credits = 1;
        }

    }

}
