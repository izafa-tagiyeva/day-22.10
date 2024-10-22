using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Group
    {
        public string GroupNo { get; set; }
        private int _studentLimit;
        public int StudentLimit
        {
            get { return _studentLimit; }
            set
            {
                if (value < 5 || value > 18)
                {
                    _studentLimit = value;
                }
                else { Console.WriteLine("Student limit must be between 5 and 18"); };
            }
        }

        

        private Student[] Students;
        private int _currentStudentCount;

        public Group(string groupNo, int studentLimit)
        {
            

            GroupNo = groupNo;
            _studentLimit = studentLimit;
            Students = new Student[studentLimit];
            _currentStudentCount = 0;
        }

        public bool CheckGroupNo(string groupNo)
        {
            if (groupNo.Length == 5 &&
                char.IsUpper(groupNo[0]) &&
                char.IsUpper(groupNo[1]) &&
                char.IsDigit(groupNo[2]) &&
                char.IsDigit(groupNo[3]) &&
                char.IsDigit(groupNo[4]))
            {
                return true;
            }
            return false;
        }

        public void AddStudent(Student student)
        {
            if (_currentStudentCount < StudentLimit)
            {
                Students[_currentStudentCount++] = student;
            }
            else
            {
                Console.WriteLine("Student limit exceeded.");
            }
        }

        public Student GetStudent(int? id)
        {
            if (id == null) return null;
            else {

            foreach (var student in Students)
            {
                if (student != null && student.Id == id)
                    return student;
            }
            return null; }
        }

        public Student[] GetAllStudents()
        {

            int count = 0;
            foreach (var student in Students)
            {
                if (student != null)
                {
                    count++;
                }
            }

            
            Student[] nonNullStudents = new Student[count];

            
            int index = 0;
            foreach (var student in Students)
            {
                if (student != null)
                {
                    nonNullStudents[index++] = student;
                }
            }

      
            return nonNullStudents;
        }
    }
}
