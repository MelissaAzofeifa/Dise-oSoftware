using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Practica
{
    class Fibonacci
    {
        public int Calcular (int n)
        {
           if (n == 1){
               return 1;
           }
           else if (n == 2)
           {
               return 1;
           }
           return Calcular (n-1) + Calcular (n-2);
        }
    }
}
