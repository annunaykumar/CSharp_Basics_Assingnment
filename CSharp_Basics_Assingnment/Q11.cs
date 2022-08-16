using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics_Assingnment
{
    internal class Q11
    {
        public static void Main()
        {
            // Print table form 1 to 20
            int x,y;
            Console.Write("Enter the First number: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            for (y = 1; y <= 20; y++)
            {
                Console.Write("{0} X {1} = {2} \n", x, y, x * y);
            }
            Console.ReadLine();
        }
    }
}
