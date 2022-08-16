using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics_Assingnment
{
    internal class Q10
    {
        public static void Main()
        {
            int num, firstNum = 0, secondNum = 1, temp, thirdNum = 3;
            Console.Write("Enter the number: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.Write(firstNum + "\t" + secondNum); // print the first two number i.e 1 2   
            while (thirdNum <= num) // check enter number is less than third number i.e 3  
            {
                temp = firstNum + secondNum; // add firstNum and secondNum and stored in temp  
                Console.Write("\t" + temp); // print the third numb  
                firstNum = secondNum; // assing secondNumb to firstNum  
                secondNum = temp; // assing temp number to secondNum  
                thirdNum = thirdNum + 1; // Increment the thirdNum
                //Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
