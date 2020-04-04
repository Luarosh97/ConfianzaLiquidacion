using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class AmparoCalidad:Amparo
    {

        public long ValorContrato { get; set; }

        public AmparoCalidad(long valor)
        {
            ValorContrato = valor;
            Calcular();
        }

        public override void Calcular()
        {
            ValorAsegurado=ValorContrato*0.1;
            ValorPrima = 10000;
        }


    }
}
