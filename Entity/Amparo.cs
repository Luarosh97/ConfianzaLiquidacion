using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public abstract class Amparo
    {

        public Fecha FechaInicio;
        public Fecha FechaFin;
        public string Tipo { get; set; }
        public double ValorAsegurado { get; set; }
        public double ValorPrima { get; set; }

        public Amparo()
        {
            FechaInicio = new Fecha();
            FechaFin = new Fecha();
        }

        public abstract void Calcular();

    }
}
