using System;
using System.Collections;
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

            Fibonacci ob2 = new Fibonacci();
            ArrayList MyAL1 = new ArrayList();
            ArrayList MyAL2 = new ArrayList();
            MyAL1.Add(4);
            MyAL1.Add(6);
            MyAL1.Add(20);
            MyAL1.Add(1);
            MyAL1.Add(11);
            MyAL1.Add(25);

            MyAL2 = ob2.arrayL(MyAL1);
            //Console.WriteLine(ob2.arrayL(MyAL1));
            //Console.ReadKey();

            imprimirResultado(MyAL2);

            //Fibonacci ob1 = new Fibonacci();
            //Console.WriteLine(ob1.Calcular(4));
            //Console.ReadKey();
        }

        private static void imprimirResultado(ArrayList MyAL2)
        {
            foreach (int obj in MyAL2)
            {

                Console.WriteLine(obj);

            }
            Console.ReadKey();
        }
    }
}
