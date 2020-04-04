using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
    public class ContratoRepositorio
    {
        List<Contrato> ListaContrato;

        public ContratoRepositorio()
        {
            ListaContrato = new List<Contrato>();
        }

        public void Guardar(Contrato contrato)
        {
            ListaContrato.Add(contrato);
        }

        public List<Contrato> Consultar()
        {
            return ListaContrato;
        }


    }
}
