using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics_Assingnment
{
    internal class Q6
    {
        public static void Main()
        {
            double celsius;
            Console.Write("Enter Fahrenheit temperature : ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            celsius = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("The converted Celsius temperature is" + celsius);
            Console.ReadLine();
        }
    }
    
}
