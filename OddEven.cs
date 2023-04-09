using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountCreation
{
    internal class OddEvenNumbers
    {
        static void Main(string[] args)
        {
            int[] arrayElements = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, };
            oddEvenClassifier(arrayElements);
        }
        
        private static void oddEvenClassifier(int[] numbers)
        {
            Console.WriteLine( "the even numbers are");
            foreach (int number in numbers)
            {
                if(number % 2 == 0)
                {
                    Console.WriteLine(number);
                }
            }
            Console.WriteLine("the odd numbers are");
            foreach (int number in numbers)
            {
                if (number % 2 == 1)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
