using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dars_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the year : ");
            string input = Console.ReadLine();
            int output = int.Parse(input);
            Console.WriteLine($"Result : {Century(output)} century");
            Main(args);
        }
        public static int Century(int input)
        {
            return (input / 100) + 1;
        }
    }
}
