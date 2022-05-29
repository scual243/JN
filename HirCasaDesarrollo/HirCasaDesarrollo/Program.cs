using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HirCasaDesarrollo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("INICIALIZANDO PROYECTO....");
            Console.WriteLine("Recuperando información del los clientes desde el archivo de excel");
            Controles.Controles.GetClientes();
            Console.WriteLine("Fin del PROYECTO....");
            Console.ReadKey();


        }
    }
}
