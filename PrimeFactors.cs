using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgrms
{
    public class PrimeFactors
    {
        public static void Factors()
        {
            Console.Write("Enter a Number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Prime Factors of " + num);

            //check for even number
            while (num % 2 == 0)
            {
                Console.Write(2 +"\n");
                num /= 2;
            }

            //loop to check for odd number    
            for (int i = 3; i*i <= num; i += 2)
            {
                while (num % i == 0)
                {
                    Console.Write(i + "\n");
                    num /= i;
                }
            }
            if (num > 2)
            {
                Console.Write(num);
            }

        }
    }
}
