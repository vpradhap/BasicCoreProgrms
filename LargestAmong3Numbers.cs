using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgrms
{
    public class LargestAmong3Numbers
    {
        public static void LargestAmong3Number()
        {
            Console.Write("\nEnter First number : ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second number : ");
            int second = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Third number : ");
            int third = Convert.ToInt32(Console.ReadLine());

            if (first > second && first > third)
            {
                Console.WriteLine("\n"+first + " is Largest Among Three Numbers");
            }            
            else if (second > first && second > third)
            {
                Console.WriteLine("\n" + second +" is Largest Among Three Numbers");
            }
            else if (third > first && third > second)
            {
                Console.WriteLine("\n" + third +" is Largest Among Three Numbers");
            }
            else
            {
                Console.WriteLine("\nAll Numbers Are Equal");
            }
        }
    }
}
