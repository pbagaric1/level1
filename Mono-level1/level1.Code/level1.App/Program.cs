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
            bool CheckDisplay;
                CheckDisplay = false;
                do
                {
                    Console.WriteLine("Unesite operaciju (ENLIST/DISPLAY)");
                    input = Console.ReadLine();
                    Val.CheckOperation(input);
                    if(Val.FlagEnlist)
                    {
                        Enlist();
                    }
                    else if (Val.FlagDisplay)
                    {
                        Display();
                        CheckDisplay = true;
                    }
                } while (!CheckDisplay);
        }
           

        public static void Enlist()
        {
            Validation Val = new Validation();
            StudentIdGenerator StID = StudentIdGenerator.Instance;
            Student Student = new Student();
            string name, lastName, gpa;
            do
            {
                Console.WriteLine("Unesite ime");
                name = Console.ReadLine();
                Val.CheckIfEmpty(name);       
            } while (Val.WrongInput);
            Student.Name = name;

            do
            {
                Console.WriteLine("Unesite prezime");
                lastName = Console.ReadLine();
                Val.CheckIfEmpty(lastName);

            } while (Val.WrongInput);
            Student.LastName = lastName;

            do
            {
                Console.WriteLine("Unesite GPA");
                gpa = Console.ReadLine();
                Val.CheckGPA(gpa);

            } while (Val.WrongInput);
            Student.Gpa = gpa;

            Student.Id = StID.IncID();
            StudentContainer Lista = StudentContainer.Instance;
            Lista.AddToList(Student);
        }

        public static  void Display()
        {
            StudentContainer Lista = StudentContainer.Instance;
            List<Student> Stud = Lista.GetList();

   
            for (int i = 0; i < Stud.Count; i++)
            {
                Console.WriteLine(Stud[i].Id  + " " + Stud[i].Name + "," + Stud[i].LastName+ ", " + Stud[i].Gpa);
            }


        }


    }
}
