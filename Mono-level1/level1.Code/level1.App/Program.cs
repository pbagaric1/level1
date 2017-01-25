using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using level1.Code;
namespace level1.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Validation Val = new Validation();
            string input;
            bool flag4, flag5;
            do
            {
                flag5 = false;
                do
                {
                    flag4 = false;
                    Console.WriteLine("Unesite operaciju (ENLIST/DISPLAY)");
                    input = Console.ReadLine();
                    Val.check_operation(input);
                    if(Val.Flag1)
                    {
                        Enlist();
                        flag4 = true;
                    }
                    else if (Val.Flag2)
                    {
                        Display();
                        flag4 = true;
                        flag5 = true;
                    }
                } while (!flag4);
            } while (!flag5);
        }
           

        public static void Enlist()
        {
            Validation Val = new Validation();
            StudentIdGenerator STID = StudentIdGenerator.Instance;
            Student Student = new Student();
            string name, lastName, gpa;
            do
            {
                Console.WriteLine("Unesite ime");
                name = Console.ReadLine();
                Val.check_if_empty(name);       
            } while (!Val.Flag3);
            Student.Name = name;

            do
            {
                Console.WriteLine("Unesite prezime");
                lastName = Console.ReadLine();
                Val.check_if_empty(lastName);

            } while (!Val.Flag3);
            Student.LastName = lastName;

            do
            {
                Console.WriteLine("Unesite GPA");
                gpa = Console.ReadLine();
                Val.check_gpa(gpa);

            } while (!Val.Flag3);
            Student.GPA = gpa;

            Student.ID = STID.IncID();
            StudentContainer lista = StudentContainer.Instance;
            lista.AddToList(Student);
        }

        public static  void Display()
        {
            StudentContainer lista = StudentContainer.Instance;
            List<Student> stud = lista.GetList();
            StudentIdGenerator student_id = StudentIdGenerator.Instance;

            stud.Sort(delegate (Student x, Student y)
            {
                return x.LastName.CompareTo(y.LastName);
            });

            for (int i = 0; i < stud.Count; i++)
            {
                Console.WriteLine(stud[i].ID  + " " + stud[i].Name + ',' + stud[i].LastName+ ',' + stud[i].GPA);
            }


        }


    }
}
