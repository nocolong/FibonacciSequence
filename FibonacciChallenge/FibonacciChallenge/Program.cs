using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to end the Fibonacci sequence: ");
            int entry = int.Parse(Console.ReadLine());

            int firstNumber = 0;
            Console.Write("{0},", firstNumber);
            int secondNumber = 1;
            Console.Write("{0},", secondNumber);
            int sum = 0;

            while(sum <= entry)
            {
                sum = firstNumber + secondNumber;
                Console.Write("{0},", sum);
                firstNumber = secondNumber;
                secondNumber = sum;

               
            }
            Console.ReadLine();
        
        }
    }
}
