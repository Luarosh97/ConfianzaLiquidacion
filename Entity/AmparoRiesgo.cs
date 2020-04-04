using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class AmparoRiesgo:Amparo
    {
        public long ValorContrato { get; set; }

        public AmparoRiesgo(long valor)
        {
            ValorContrato = valor;
            Calcular();
        }

        public override void Calcular()
        {
            if (ValorContrato<=5000000)    
            {
                ValorAsegurado = ValorContrato * 0.2;
                ValorPrima = ValorContrato*0.005;
            }
            else if(ValorContrato>5000000 && ValorContrato<=10000000)
            {
                ValorAsegurado = ValorContrato * 0.25;
                ValorPrima = ValorContrato * 0.01;
            }
            else
            {
                ValorAsegurado = ValorContrato;
                ValorPrima =ValorContrato*0.015;
            }
        }
    }
}
