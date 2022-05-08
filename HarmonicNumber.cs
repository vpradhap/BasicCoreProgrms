using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgrms
{
    public class HarmonicNumber
    {
        public static void Harmonic()
        {
            //User input and local variable declaration
            Console.Write("Enter value for N : ");
            int N = Math.Abs(Convert.ToInt32(Console.ReadLine()));
            double x = 0 ,i;

            //checking given condition
            if (N > 0)
            {
                //Harmonic Number logic
                for ( i = 1; i <= N; i++)
                {
                    x += 1 / i;
                }
                Console.WriteLine("The Harmonic Number is : " + x);
            }
        }
    }
}
