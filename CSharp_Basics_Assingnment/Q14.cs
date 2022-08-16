using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics_Assingnment
{
    internal class Q14
    {
        public static void Main()
        {
            Console.WriteLine("\nInput first integer:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second integer:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input third integer:");
            int z = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input fourth integer:");
            int a= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input fifth integer:");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lowest of five: " + Math.Min(x, Math.Min(y,Math.Min(z,Math.Min(a,b)))));
            Console.ReadLine();
        }
    }
    
}
