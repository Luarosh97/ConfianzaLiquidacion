using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;

namespace BLL
{
    public class ContratoService
    {
        public string Guardar(Contrato contrato)
        {
            Datos.listaContratos.Guardar(contrato);

            return "Se guardo el contrato";

        }

        public List<Contrato> Consultar()
        {
            return Datos.listaContratos.Consultar();
        }
    }


}
