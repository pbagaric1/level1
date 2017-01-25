using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace level1.Code
{
   public class StudentIdGenerator
    {
       
        private static StudentIdGenerator instance;
        private int ID;

        private StudentIdGenerator()
        {
        }

        public static StudentIdGenerator Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new StudentIdGenerator();
                }
                return instance;
            }
        }

        public int IncID()
        {
            return ID++;
        }

    }
}
