using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics_Assingnment
{
    internal class Q17
    {
        public static void Main()
        {
            string str = "", reverse = "";
            int Length = 0;
            Console.WriteLine("Enter a Word");
            //Getting String(word) from Console  
            str = Console.ReadLine();
            //Calculate length of string str  
            Length = str.Length - 1;
            while (Length >= 0)
            {
                reverse = reverse + str[Length];
                Length--;
            }
            //Displaying the reverse word  
            Console.WriteLine("Reverse word is {0}", reverse);
            Console.ReadLine();
        }
    }
    
}
