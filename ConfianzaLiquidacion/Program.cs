using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using BLL;

namespace ConfianzaLiquidacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
        {
            ConsoleKeyInfo op;

            do
            {
                Console.Clear(); 
                Console.WriteLine("\t\t\t\t           Menú");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("[A]Registrar contratista\t");
                Console.Write("[B]Registrar contrato\t");
                Console.Write("[C]Informe\t");
                Console.Write("[Esc]Salir\t\n\n");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Seleccione opcion...");
                op = Console.ReadKey(true);

                switch (op.Key)
                {
                    case ConsoleKey.A:
                        Console.WriteLine("Ud seleccionó la opción Registrar contratista");
                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.B:
                        Console.WriteLine("Ud seleccionó la opción Registrar contrato");
                        RegistrarContrato();
                        Console.Write("Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case ConsoleKey.C:
                        Console.WriteLine("Ud seleccionó la opción Informe");
                        Mostrar();
                        Console.Write("Presione una tecla para continuar...");

                        Console.ReadKey();
                        break;

                    case ConsoleKey.Escape:
                        Console.WriteLine("Chao");

                        break;
                }
            } while (op.Key != ConsoleKey.Escape);



        }

        public static void RegistrarContrato()
        {
            ContratoService service = new ContratoService();
            char mas = 'n';

            string numContrato;
            string tipoContrato;
            long valorContrato;

            Console.WriteLine("------------------Nuevo Contrato--------------------");

            Console.WriteLine("Digite el numero del contrato: "); numContrato = Console.ReadLine();
            Console.WriteLine("Digite el tipo de contrato: ");tipoContrato = Console.ReadLine();
            Console.WriteLine("Digite el Valor de contrato: ");valorContrato = long.Parse(Console.ReadLine());

            Contrato contrato = new Contrato(numContrato,tipoContrato,valorContrato);

            Console.WriteLine("----------------Datos de la Poliza----------------");

            Console.WriteLine("Numero de la poliza: ");contrato.poliza.NumPoliza = Console.ReadLine();
            Console.WriteLine("Fecha de emision : ");
            contrato.poliza.FechaEmision = LeerFecha();

            Console.WriteLine("Quiere ingresar amparos a la poliza? s/n");mas=char.Parse(Console.ReadLine());

            while (mas=='s')
            {
                Console.WriteLine("Que tipo de amparo quiere ingresar");

                Console.WriteLine("1- Amparo de Calidad del servicio");
                Console.WriteLine("2- Amparo de Riesgo total");
                int op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Amparo amparito = new AmparoCalidad(valorContrato);
                        Console.WriteLine("Fecha inicial: ");amparito.FechaInicio = LeerFecha();
                        Console.WriteLine("Fecha final: "); amparito.FechaFin = LeerFecha();
                        amparito.Tipo = "Calidad de Servicio";

                        contrato.poliza.GuardarAmparo(amparito);
                        break;
                    case 2:
                        Amparo amparita = new AmparoRiesgo(valorContrato);
                        Console.WriteLine("Fecha inicial: "); amparita.FechaInicio = LeerFecha();
                        Console.WriteLine("Fecha final: "); amparita.FechaFin = LeerFecha();
                        amparita.Tipo = "Todo Riesgo";

                        contrato.poliza.GuardarAmparo(amparita);

                        break;

                    
                }
                Console.WriteLine("Quiere seguir agregando mas? s/n"); mas=char.Parse(Console.ReadLine());

            }

            Console.WriteLine(service.Guardar(contrato));
        }

        public static Fecha LeerFecha()
        {
            Fecha fecha = new Fecha();

            Console.WriteLine("Dia: "); fecha.Dia = Console.ReadLine();
            Console.WriteLine("Mes: "); fecha.Mes = Console.ReadLine();
            Console.WriteLine("Año: "); fecha.Año = Console.ReadLine();
            return fecha;

        }

        public static void  Mostrar()
        {
            List<Contrato> ListaContrato= new List<Contrato>();
            ContratoService service = new ContratoService();

            ListaContrato = service.Consultar();

            foreach (var item in ListaContrato)
            {
                Console.WriteLine("**********************************************");
                Console.WriteLine("Numero de contrato: "+item.NumContrato);
                Console.WriteLine("tipo de contrato: " + item.tipoContrato);
                Console.WriteLine("Valor de contrato: " + item.ValorContrato);
                Console.WriteLine("Numero de Poliza: " + item.poliza.NumPoliza);
                Console.WriteLine("Fecha de enmision de la Poliza: " + item.poliza.FechaEmision.ToString());
                Console.WriteLine("Valor de la poliza: " + item.poliza.ValorPoliza);

            }
            Console.ReadKey();

        }
    }
}
