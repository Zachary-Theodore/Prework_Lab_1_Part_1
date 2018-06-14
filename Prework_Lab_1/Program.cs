using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prework_Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // asks for user to input two numbers of the same length
            Console.WriteLine("Input two numbers of the same length.");
            Console.WriteLine("Number one: ");
            string num1 = Console.ReadLine();
            Console.WriteLine("Number two: ");
            string num2 = Console.ReadLine();

            //displays what was entered
            Console.WriteLine("You entered " + num1 + " And " + num2);


            //checks at whether or not the user inputs are of equal value and if not asks to input again
            while (num1.Length != num2.Length)
            {
                Console.WriteLine("The numbers you have entered are not of equal length.");
                Console.WriteLine("Input two numbers of the same length.");
                Console.WriteLine("Number one: ");
                num1 = Console.ReadLine();
                Console.WriteLine("Number two: ");
                num2 = Console.ReadLine();
                Console.WriteLine("You entered " + num1 + " And " + num2);
            }






            // this loop makes the decision on whether the numbers are equal or not and outputs true or false 
            for (int i = 0; i <= num1.Length - 1; i++)
            {
                if (i == num1.Length - 1)
                {
                    Console.WriteLine("True");
                    break;
                }
                else if (num1[i] + num2[i] != num1[i + 1] + num2[i + 1])
                {
                    Console.WriteLine("False");
                    break;
                }


            }
            //closing comment and waits for user to to press enter before exiting
            Console.WriteLine("Thank You!!!");
            Console.ReadKey();
        }

    }


}
    

