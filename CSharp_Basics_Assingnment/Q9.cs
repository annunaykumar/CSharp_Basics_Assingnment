using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics_Assingnment
{
    internal class Q9
    {
        public static void Main()
        {
            // Factorial of number 4 is: 4*3*2*1 = 24  
            int num, factorial = 1;
            Console.Write("Enter the number: ");
            num = Convert.ToInt32(Console.ReadLine());
            while (num >= 1) // check number is greater or equal to 1  
            {
                factorial = factorial * num; // multiply the number  
                num--; // decrement the number by 1  
            }
            Console.Write("Factorial: " + factorial);
            Console.ReadLine();
        }
    }
}
