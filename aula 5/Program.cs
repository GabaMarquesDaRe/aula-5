using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
           float a;
          
            a = int.Parse(Console.ReadLine());
            float b = a / 4;
            if (a == (int)b * 4)          
            {
                Console.WriteLine("numero invalido");
            }
            else
            {
                Console.WriteLine("numero valido");
            }
            Console.ReadKey();

        }
    }
}
