using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgrms
{
    public class VowelOrConsonant
    {
        public static void ConsonantOrVowel()
        {
            char ch;
            Console.Write("\nEnter a Alphabet: ");
            ch = Convert.ToChar(Console.Read());

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' )
            {
                Console.WriteLine("\n"+ch + " is Vowel");
            }
            else if(ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine("\n"+ch + " is Vowel");
            }
            else
            {
                Console.WriteLine("\n"+ch + " is Consonant.");
            }
        }
    }
}
