using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace level1.Code
{
    public class Validation
    {
        public Boolean Flag1; //if string is enlist
        public Boolean Flag2; //if string is display
        public Boolean Flag3; //if string is not correct or empty
        double x;
        public void check_operation(string s)
        {
            Flag1 = false;
            Flag2 = false;
            if (String.Compare(Operations.Enlist, s, true) == 0)
            {
                Flag1 = true;
            }
            else if (String.Compare(Operations.Display, s, true) == 0)
            {
                Flag2 = true;
            }
            else
            {
                Console.WriteLine("Kriva operacija, pokusajte ponovno");
            }
        }
        public void check_if_empty(string a)
        {
            Flag3 = false;
            if (string.IsNullOrEmpty(a))
            {
                Flag3 = false;
                Console.WriteLine("Krivi unos");
            }
            else Flag3 = true;
        }
        public void check_gpa(string b)
        {
            Flag3 = false;
            double.TryParse(b, out x);
            if (x >= 1 && x <= 5)
            {
                Flag3 = true;
            }
            else

            {
                Flag3 = false;
                Console.WriteLine("Krivi unos");
            }
            }
    }
}
