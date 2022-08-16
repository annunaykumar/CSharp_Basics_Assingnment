using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics_Assingnment
{
    internal class Q16
    {
        public static void Main()
        {
            string str; /* Declares a string of size 100 */
            int l = 0;

            Console.Write("\n\nFind the length of a word :\n");
            Console.Write("Write the word : ");
            str = Console.ReadLine();

            foreach (char chr in str)
            {
                l += 1;

            }

            Console.Write("Length of the word is : {0}\n\n", l);
            Console.ReadLine();
        }
    }
    
}
