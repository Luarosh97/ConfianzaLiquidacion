using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Contrato
    {

        public string NumContrato { get; set; }
        public string tipoContrato { get; set; }
        public long ValorContrato { get; set; }
        public Poliza poliza;

        public Contrato(string numContrato, string tipoContrato, long valorContrato)
        {
            NumContrato = numContrato;
            this.tipoContrato = tipoContrato;
            ValorContrato = valorContrato;
            poliza = new Poliza(valorContrato);
        }
    }
}
