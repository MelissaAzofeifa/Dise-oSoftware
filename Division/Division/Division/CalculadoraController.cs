using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Division
{
    class CalculadoraController
    {
       public string CoordineLaDivision()
        {
            
            CalculadoraBoundary elLimite = new CalculadoraBoundary();
            string resultadoString;

            try
            {
                
                double dividendo = elLimite.ObtenerDividendo();
                double divisor = elLimite.ObtenerDivisor();

                CalculadoraEntity laCalculadora = new CalculadoraEntity();
                double resultado = laCalculadora.Dividir(dividendo, divisor);
                resultadoString = resultado.ToString();
            }
            catch (Exception)
            {
                
                resultadoString = "error";
            }

            elLimite.MostrarResultado(resultadoString);

            return resultadoString;
        }
    }
}
