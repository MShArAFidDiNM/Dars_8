using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dars_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number : ");
            string input = Console.ReadLine();
            int output = int.Parse(input);
            Console.WriteLine($"Result : {GetSign(output)}");
            Console.ReadLine();
        }

        public static string GetSign(int number)
        {
            if (number > 0)
            {
                return "+";
            }
            else if (number < 0)
            {
                return "-";
            }
            else
            {
                return "0";
            }
        }

    }
}

