using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics_Assingnment
{
    internal class Q18
    {
        public static void Main()
        {
            string str1;
            string str2;

            //input strings
            Console.Write("Enter a string: ");
            str1 = Console.ReadLine();
            Console.Write("Enter another string: ");
            str2 = Console.ReadLine();

            //comparing strings 
            if (str1 == str2)
                Console.WriteLine("\"{0}\" and \"{1}\" are equal", str1, str2);
              
            else
                Console.WriteLine("\"{0}\" and \"{1}\" are not equal", str1, str2);
                Console.ReadLine();
        }
        
        
    }
    
}
