using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsCatalogue_WindowsApp
{
    internal class Centraliser
    {
        //studentClassMappings = new Dictionary<int, List<int>>
        //{
        //    { 1, new List<int> { 101, 102 } },      //Student with id 1 is enrolled in the classes with id 101 and 102
        //    { 2, new List<int> { 102, 103 } },      //Student with id 2 is enrolled in the classes with id 102 and 103
        //    { 3, new List<int> { 101, 102, 103 } } //Student with id 3 is enrolled in the classes with id 101 and 102 and 102
        //};

        public Dictionary<int, List<int>> studentClassMapper;

        public Centraliser()
        {
            studentClassMapper = new Dictionary<int, List<int>>();
        }

        public void addStudentToClass(int studentId, int classId)
        {
            if (!studentClassMapper.ContainsKey(studentId))
            {
                studentClassMapper[studentId] = new List<int> { classId };
            }
            else
            {
                if (!studentClassMapper[studentId].Contains(classId))
                {
                    studentClassMapper[studentId].Add(classId);
                }
            }
        }

        public void removeStudentFromClass(int studentId, int classId)
        {
            if (studentClassMapper.ContainsKey(studentId))
            {
                studentClassMapper[studentId].Remove(classId);
            }
        }

        public List<int> getAllClassesForAStudent(int studentID)
        {
            if (studentClassMapper.ContainsKey(studentID))
            {
                return studentClassMapper[studentID];
            }
            return new List<int>();
        }
    }
}