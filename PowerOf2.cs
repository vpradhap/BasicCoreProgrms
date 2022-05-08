using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgrms
{
    public class PowerOf2
    {
        public static void Power()
        {
            int i; //Declaring local variable
            Console.Write("Enter the value for N : ");
            int N = Convert.ToInt32(Console.ReadLine());

            //checking the given condition and perform loop for user input
            if (N >= 0 && N < 31)
            {
                for ( i = 0; i <= N; i++)
                {
                    Console.WriteLine("The value of 2 power " + i + " = " + Math.Pow(2, i));
                }
            }
            else
            {
                Console.WriteLine("2^31 Overflows an integer");
            }
        }
    }
}
