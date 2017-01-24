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
            string input;
            Console.WriteLine("Unesite operaciju (ENLIST/DISPLAY)");
            input = Console.ReadLine();
            if (String.Compare(Operations.enlist, input, true) == 0)
            {
                function_Enlist();
            }
            else if (String.Compare(Operations.display, input, true) == 0)
            {
                function_Display();
            }

            else
            {
                Console.WriteLine("Kriva operacija, pokusajte ponovno");
                input = Console.ReadLine();
            }
        }
           

        public static void function_Enlist()
        {
            Student student = new Student();
            string name, last_name;
            int id;
            float GPA;

            Console.WriteLine("Unesite ime");
            name = Console.ReadLine();
            student.name = name;

            Console.WriteLine("Unesite prezime");
            last_name = Console.ReadLine();
            student.last_name = last_name;

            Console.WriteLine("Unesite GPA");
            GPA = float.Parse(Console.ReadLine());
            student.GPA = GPA;

            StudentContainer lista = StudentContainer.Instance;
            lista.AddToList(student);
        }

        public static  void function_Display()
        {
            StudentContainer lista = StudentContainer.Instance;
            List<Student> stud = lista.GetList();

            for (int i = 0; i < stud.Count; i++)
            {
                Console.WriteLine(stud[i].name + ',' + stud[i].last_name);
            }


        }


    }
}
