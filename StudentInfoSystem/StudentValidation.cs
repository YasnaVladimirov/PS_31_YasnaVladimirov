using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLogin;

namespace StudentInfoSystem
{
    internal class StudentValidation
    {
        public Student GetStudentDataByUser(User user)
        {
            StudentData studentData = new StudentData();
            if (user != null && user.FacNum != null)
            {
                IEnumerable<Student> list = studentData.GetStudents();

                foreach (Student student in list)
                {
                    if (student.FacultyNumber.Equals(user.FacNum))
                    {
                        return student;
                    }
                }

                throw new ArgumentNullException("No such student");
            }
            throw new ArgumentNullException("No faculty number in this user");

        }
    }
}
