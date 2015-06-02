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
            
            //Calculos.Fibonacci() ob2 = new Calculos.Fibonacci();
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
         

            //imprime metodo
            imprimirResultado(MyAL2);

            Base_de_Datos.ListaNum ob3 = new Base_de_Datos.ListaNum();
            ob3.Agregar(1);
            ob3.Agregar(999);
            ob3.Agregar(57);
            ob3.Agregar(23);

            int cantidad = ob3.ObtenerCantidad();
            Console.WriteLine("Cantidad: " + cantidad);
            Console.ReadKey();
            
        }

        private static void imprimirResultado(ArrayList MyAL2)
        {
            Console.WriteLine("ArrayList: ");

            foreach (int obj in MyAL2)
            {
                Console.WriteLine(obj);
            }
            Console.ReadKey();
        }

        
    }
}
