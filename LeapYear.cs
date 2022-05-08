using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgrms
{
    public class LeapYear
    {
        public static void Leap()
        {
            Console.Write("Enter Four Digit year : ");
            int year = Convert.ToInt32(Console.ReadLine());

            //Condition to check 4 digit number or not
            if (year >= 1000 && year <= 9999)
            {
                //Leap Year Logic
                if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                {
                    Console.WriteLine(year+" is Leap Year");
                }
                else
                {
                    Console.WriteLine(year+" is not Leap Year");
                }
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }

        }
    }
}
