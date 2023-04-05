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
            teskari("salom");
        }
        public static void teskari(string message )
        {
            for (int i = message.Length-1; i >= 0; i--)
            {
                Console.Write(message[i]);
            }
            Console.ReadLine();
        }
        
    }
}
