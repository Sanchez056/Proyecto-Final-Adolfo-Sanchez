using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVentas
{
   public  class UtilidadesDouble
    {
        public double StringDouble(string texto)
        {
            double numero = 0;

            double.TryParse(texto, out numero);

            return numero;
        }
    }
}
