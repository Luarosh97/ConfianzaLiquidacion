using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Poliza
    {
        public long ValorContrato { get; set; }

        public string NumPoliza  { get; set; }
        public Fecha FechaEmision;
        public double ValorPoliza { get; set; }
        public List<Amparo> ListaAmparos;

        public Poliza(long valor)
        {
            ValorContrato = valor;
            ListaAmparos = new List<Amparo>();
            FechaEmision = new Fecha();
            CalcularPoliza();
        }

        public void GuardarAmparo(Amparo amparo)
        {
            ListaAmparos.Add(amparo);
            CalcularPoliza();

        }

        public void CalcularPoliza()
        {
            ValorPoliza = ValorContrato * 0.19;
            foreach (var item in ListaAmparos)
            {
                ValorPoliza += item.ValorPrima;
            }

        }



    }
}
