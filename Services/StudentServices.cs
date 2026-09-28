using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Branches_Practice
{
    public class StudentServices : IStudentServices
    {
        List<string> studentList = ["Jacob", "Student 2", "Student 3"];

        public List<string> StudentsGetAll()
        {
            return studentList;
        }
    }
}