using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HirCasaDesarrollo.Controles
{
    public class Controles
    {
        public static void GetClientes()
        {
            string path = @"C:\Users\Personal1\Documents\Jaina\Reclutamiento\datosClientes.xlsx";
            List<Clientes> objListClientes = new List<Clientes>();
            if (File.Exists(path))
            {


                objListClientes = Consultas.Consultas.getDataExcelClientes(path);
                Console.WriteLine("valor i" + objListClientes.Count());
                foreach (var i in objListClientes)
                {
                    Funciones.Funciones.insertClient(i);

                }
            }
            else
            {
                Console.WriteLine("La ruta definida del archivo de excel no existe");
            }
        }
    }
}
