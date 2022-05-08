using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgrms
{
    public class FlipCoin
    {
        public static void Flip()
        {
            //Declare Local variables
            int head =0 , tail =0 ,count = 0 ;

            //Getting user input and ensure its a positive integer
            Console.Write("How Many Times You Want to Flip the Coin : ");
            int flip =Math.Abs(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("\nFlip : "+flip +"\n");

            //Loop execution based on user input
            while(count < flip)
            {
                Random random = new Random();
                double coin = random.Next(0, 2);
                if (coin < 0.5)
                {
                    Console.WriteLine("Heads");
                    head++;
                    count++;
                }
                else
                {
                    Console.WriteLine("Tails");
                    tail++;
                    count++;
                }
            }

            //Displaying head and tail percentage 
            double headpercentage =(double) head / (double) flip * 100;
            double tailpercentage =(double) tail / (double) flip * 100;
            Console.WriteLine("\nHead Percentage : " + headpercentage + " %");
            Console.WriteLine("\nTail Percentage : " + tailpercentage + " %");
        }
    }
}
