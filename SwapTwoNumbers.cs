using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgrms
{
    public class SwapTwoNumbers
    {
        public static void SwapNumbers()
        {
            Console.Write("Enter first number : ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second number : ");
            int second = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before Swap\tFirst = " +first  + "\tSecond = " + second);

            int temp = first;
            first = second;
            second = temp;

            Console.WriteLine("After Swap\tFirst = " + first + "\tSecond = " + second);
        }
    }
}
