using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics_Assingnment
{
    internal class Q15
    {
        public static void Main()
        {
            int[] arr1 = new int[100];
            int i,mx,mn,j,tmp, sum = 0;
            double avg;

            Console.Write("\n\n");
            Console.Write("Read 10 students marks and calculate sum and average and minimum and maximum, asending, decending marks:\n");
            Console.Write("----------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input the 10 marks : \n");
            for (i = 0; i < 10; i++)
            {
                Console.Write("Marks-{0} :", i+1);

                arr1[i] = Convert.ToInt32(Console.ReadLine());
                sum += arr1[i];
            }
            avg = sum / 10.0;

            mx = arr1[0];
            mn = arr1[0];

            for (i = 1; i<10; i++)
            {
                if (arr1[i] > mx)
                {
                    mx = arr1[i];
                }


                if (arr1[i] < mn)
                {
                    mn = arr1[i];
                }
            }

            for (i = 0; i < 10; i++)
            {
                for (j = i + 1; j < 10; j++)
                {
                    if (arr1[j] < arr1[i])
                    {
                        tmp = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = tmp;
                    }
                }
            }

            for (i = 0; i < 10; i++)
            {
                for (j = i + 1; j < 10; j++)
                {
                    if (arr1[i] < arr1[j])
                    {
                        tmp = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = tmp;
                    }
                }
            }


            Console.Write("The sum of the marks of 10 students is : {0}\nThe Average marks of 10 students : {1}\nThe Minimum marks obtained out of 10 students is : {2}\nThe maximum marks obtained out of 10 students is : {3}", sum, avg, mn, mx);

            Console.Write("\nMarks of students sorted in  ascending order:\n");

            for (i = 0; i < 10; i++)
            {
                Console.Write("{0}  ", arr1[i]);
            }

            Console.Write("\n\n");

            Console.Write("\nMarks of the students in sorted descending order:\n");
            for (i = 0; i < 10; i++)
            {
                Console.Write("{0}  ", arr1[i]);
            }
            Console.Write("\n\n");


            Console.ReadLine();
        }
    }
           
}
    

