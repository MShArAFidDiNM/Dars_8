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
            Console.Write("Enter Number : ");
            string input = Console.ReadLine();
            int output = int.Parse(input);
            Number(output);
            Main(args);
        }

        public static int sanoq = 1;

        public static void Number(int input)
        {
            
            if (input > 9)
            {
                sanoq+=1;
                Number(input /= 10);
            }
            else
            {
                Console.WriteLine($"Result : {sanoq}");
            }
        }
    }
}
