using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgrms
{
    public class EvenOrOdd
    {
        public static void OddOrEven()
        {
            Console.Write("Enter a Number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            //Even or odd logic
            if (num % 2 == 0)
            {
                Console.WriteLine("\n"+num +" is a Even Number");
            }
            else
            {
                Console.WriteLine("\n"+num +" is a Odd Number");
            }

        }
    }
}
