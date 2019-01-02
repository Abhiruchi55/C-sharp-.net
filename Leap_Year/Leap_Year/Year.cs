using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leap_Year
{
    class Year
    {
        private int Y;

        public void YearInput()
        {
            bool Check;
            Console.WriteLine("Test Data: ");
            Y = Convert.ToInt32(Console.ReadLine());
            Check = YearCheck(Y);
            if (Check == true)
                Console.WriteLine(Y + " is a leap year");
            else
                Console.WriteLine(Y + " is not a leap year");
            Console.ReadLine();
        }
        public bool YearCheck(int y)
        {
            if (y % 4 == 0)
                return true;
            else
                return false;
        }
    }

}
