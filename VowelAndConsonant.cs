using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalPrograms
{
    public class VowelAndConsonant
    {
        public void Alphabet(char alphabet)
        {
            if (alphabet == 'a' || alphabet == 'e' || alphabet == 'i' || alphabet == 'o' || alphabet == 'u' || alphabet == 'A' || alphabet == 'E' || alphabet == 'I' || alphabet == 'O' || alphabet == 'U' )
            {
                Console.WriteLine("\n" + alphabet + "{0} is Vowel.");
            }
            else { Console.WriteLine("\n" + alphabet + "{0} is Consonant."); 
            }
            Console.ReadKey();
        }
    }
}
