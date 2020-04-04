using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Fecha
    {
        public string Dia { get; set; }
        public string Mes { get; set; }
        public string Año { get; set; }

        public Fecha()
        {

        }

        public Fecha(string dia, string mes, string año)
        {
            Dia = dia;
            Mes = mes;
            Año = año;
        }

        public override string ToString()
        {
            return $"Dia: {Dia} / Mes: {Mes} / Año: {Año} ";
        }


    }
}
