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
            Console.WriteLine($"Max : {INPUT(3)}");
            Main(args);
        }
        public static int INPUT(int a)
        {
        number1:
            Console.Write("Enter Number 1 :");
            string input = Console.ReadLine();
            bool check = int.TryParse(input, out int inputnumber);
            if (!check)
            {
                Console.WriteLine($"Error : {input}");
                goto number1;
            }
            number2:
            Console.Write("Enter Number 2 :");
            string input2 = Console.ReadLine();
            bool check2 = int.TryParse(input2, out int inputnumber2);
            if (!check2)
            {
                Console.WriteLine($"Error : {input2}");
                goto number2;
            }
            int b;
            b = Max(inputnumber, inputnumber2);
            return b;
        }
        
        public static int Max(int input1,int input2)
        {
            return (input1 >  input2) ? input1 : input2;
        }
        
        
    }
}
