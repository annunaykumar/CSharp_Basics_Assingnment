using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics_Assingnment
{
    internal class Q3
    {
        public static void Main()
        {
            int startingNumber,endingNumber;
            Console.WriteLine("Enter starting Number:");
            startingNumber = int.Parse(Console.ReadLine());
            Console.Write("Entre Ending Number:");
            endingNumber = int.Parse(Console.ReadLine());
            for(int i = startingNumber; i <=endingNumber; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

        }
        
    }
}
