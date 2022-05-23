using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLogin;

namespace StudentInfoSystem
{
    internal static class StudentData
    {
        private static List<Student> _testStudents;

        public static List<Student> TestStudents { 
            get 
            {
                ResetStudentsData();
                return _testStudents;
            } 
        }

        private static void ResetStudentsData()
        {
            if (_testStudents == null)
            {
                _testStudents = new List<Student>();

                Student student = new Student();
                student.FirstName = "Yasna";
                student.SecondName = "Vladimirov";
                student.FacNum = "123219010";
                student.Course = 3;
                student.Major = "KSI";

                _testStudents.Add(student);
            }
        }
    }
}
