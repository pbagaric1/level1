using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace level1.Code
{
    public class Validation
    {
        public bool FlagEnlist; //if string is enlist
        public bool FlagDisplay; //if string is display
        public bool WrongInput; //if string is not correct or empty
        double x;
        public void CheckOperation(string s)
        {
            FlagEnlist = false;
            FlagDisplay = false;
            if (String.Compare(Operations.ENLIST, s, true) == 0)
            {
                FlagEnlist = true;
            }
            else if (String.Compare(Operations.DISPLAY, s, true) == 0)
            {
                FlagDisplay = true;
            }
            else
            {
                Console.WriteLine("Kriva operacija, pokusajte ponovno");
            }
        }
        public void CheckIfEmpty(string a)
        {
            WrongInput = false;
            if (string.IsNullOrEmpty(a))
            {
                WrongInput = true;
                Console.WriteLine("Krivi unos");
            }
            else WrongInput = false;
        }
        public void CheckGPA(string b)
        {
            WrongInput = true;
            double.TryParse(b, out x);
            if (x >= 1 && x <= 5)
            {
                WrongInput = false;
            }
            else

            {
                WrongInput = true;
                Console.WriteLine("Krivi unos");
            }
            }
    }
}
