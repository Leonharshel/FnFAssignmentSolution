using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountCreation
{
    internal class MathCalcProgram
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int res = 0;
                int num2=int.Parse(Console.ReadLine());
                int num1=int.Parse(Console.ReadLine());
                string message = "******************calculator**************\r\n1----------------------->ADD\r\n2---------------------->SUBTRACT\r\n3--------------------->MULTIPLY\r\n4--------------------->DIVIDE\r\nOTHER NUBERS TO EXIT\r\n******************************************";
                int choice=int.Parse(Console.ReadLine());
                switch (choice) 
                { 
                    case 1:res= add(num1, num2);
                        Console.WriteLine(res);
                        break;
                    case 2:
                        res = sub(num1, num2);
                        Console.WriteLine(res);
                        break;
                    case 3:
                        res = mul(num1, num2);
                        Console.WriteLine(res);
                        break;
                    case 4:
                        res = div(num1, num2);
                        Console.WriteLine(res);
                        break;
                    default:break;

                }
            }
        }

        private static int div(int num1, int num2)
        {
            return num1 / num2;
        }

        private static int mul(int num1, int num2)
        {
            return num1 * num2;
        }

        private static int sub(int num1, int num2)
        {
            return num1 - num2;
        }

        private static int add(int num1, int num2)
        {
            return num2 + num1;
        }
    }
}
