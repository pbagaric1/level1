using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace level1.Code
{
    public class StudentContainer
    {
       List<Student> students = new List<Student>();

        private static StudentContainer instance ;

        private StudentContainer()
        {
        }

        public static StudentContainer Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new StudentContainer();
                }
                return instance;
            }
        }

        public List<Student> GetList()
        {
            return students;
        }

        public void AddToList(Student stud)

        {
            students.Add(stud);
        }
    }
   
}
