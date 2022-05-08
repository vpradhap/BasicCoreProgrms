using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgrms
{
    public class QuotientAndRemainder
    {
        public static void QAndR()
        {
            //User input and local varible declaration
            Console.Write("Enter the Dividend : ");
            int dividend = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the divisor : ");
            int divisor = Convert.ToInt32(Console.ReadLine());
            int quotient , remainder ;

            //checking whether dividend is greater than divisor or not
            if(dividend < divisor)
            {
                quotient = divisor / dividend;
                remainder = divisor % dividend;
            }
            else
            {
                quotient = dividend / divisor;
                remainder = dividend % divisor;
            }
            Console.WriteLine("Quotient  = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
        }
    }
}
