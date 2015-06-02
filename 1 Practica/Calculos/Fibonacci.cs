using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//se quitó el nameSpace para que pueda ser leído en clases de otros paquetes.

    public class Fibonacci
    {
       

        public ArrayList arrayL (ArrayList Array)
        {
            ArrayList MyAL = new ArrayList();

            foreach (int obj in Array){
            MyAL.Add(Calcular(obj));
            //Console.WriteLine(MyAL);
        }
            
            return MyAL;

        }





        //fibonacci
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

