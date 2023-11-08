using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ejercicio2 ejercicio2 = new Ejercicio2();          
            Console.WriteLine("I'm testing this");
            ejercicio2.message("HI THERE");
            Console.ReadKey();
        }
    }
}
