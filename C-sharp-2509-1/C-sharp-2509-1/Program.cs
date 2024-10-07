using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_2509_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* for (int i = 1; i <= 11; i+=2)
             {
                     Console.WriteLine(i);
             }
             Console.ReadLine(); 


             for (int i = 0; i < 5; i++)
             {
                 for(int j = 0; j<=i+1; j++)
                 {
                     Console.Write("*");
                 }
                 Console.WriteLine();
             }
             Console.ReadLine();
            

            int i = 1;
            int sum = 0;
            while (i <= 5)
            {
                sum = sum + i;
                i++;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
            */

            /*int number = 1;
            int rows = 4;
            for(int i=1; i<=rows; i++)
            {
                for(int j=1; j<=rows-i; j++)
                {
                    Console.Write(" ");
                }
                for(int j=1; j<=i; j++)
                {
                    Console.Write(number+ " ");
                    number++;
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            
            

            for (int i=1; i<=190;i++)
            {
                if (i%10!=0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.ReadLine();
            */

            // switch case
            /*
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            switch(number%2)
            {
                case 0: Console.WriteLine($"{number} is even");
                    break;
                case 1: Console.WriteLine($"{number} is odd");
                    break;
                default: Console.WriteLine("Unexpected output");
                    break;

            }
            Console.ReadLine();


            */
            // to print the value one by one that is stored in array

            /* int[] num = { 1, 2, 3, 4, 5 };
            for (int i=0; i<num.Length;i++)
            {
                Console.WriteLine(num[i]);
            }
            Console.ReadLine();
            */


            int num = 1;
            int rows = 20;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows - i; j++)
                {
                    Console.Write(" ");

                }
                for (int k = 0; k < i + 1; k++)
                {
                    Console.Write(num + " ");
                    num++;
                }
                Console.WriteLine();
            }
            Console.ReadLine();


        }
    }
}
