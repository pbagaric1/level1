using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace level1.Code
{
    public class StudentContainer
    {
       List<Student> Students = new List<Student>();

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
            return Sort(Students);
        }

        public void AddToList(Student stud)

        {
            Students.Add(stud);
        }

        public List<Student> Sort(List<Student> stud)
        {
            return stud.OrderBy(x => x.LastName).ToList();
        }
    }
   
}
