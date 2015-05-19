using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Practica
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hola Mundo!");
            //Console.WriteLine("Melissa Azofeifa");
            //Console.ReadKey();

            Fibonacci ob1 = new Fibonacci();
            Console.WriteLine(ob1.Calcular(4));
            Console.ReadKey();
        }
    }
}
