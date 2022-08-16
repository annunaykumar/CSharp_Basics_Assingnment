using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics_Assingnment
{
    internal class Q12
    {
        public static void Main()
        {
            int i;
            string bag = null;
            Console.Write("\n\n");
            Console.Write("Numbers between 200 and 300, divisible by 7 : \n");
            for (i = 200; i <= 300; i++)
            {
                if (i % 7 == 0)
                {
                    Console.Write("{0}  ", i);
                    bag += i;
                }

            }
            Console.ReadLine();

        }
    }
}
