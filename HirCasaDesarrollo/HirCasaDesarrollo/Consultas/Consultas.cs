using LinqToExcel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HirCasaDesarrollo.Consultas
{
    public class Consultas
    {
        public static List<Clientes> getDataExcelClientes(string path)
        {

            List<Clientes> respuesta = new List<Clientes>();
            var book = new ExcelQueryFactory(path);
            respuesta = (from row in book.Worksheet("Clientes")
                         let item = new Clientes
                         {
                             ClienteId = row["ClienteId"].Cast<string>(),
                             Nombre = row["Nombre"].Cast<string>(),
                             Telefono = row["Telefono"].Cast<string>(),
                             Correo = row["Correo"].Cast<string>(),
                             Edad = row["Edad"].Cast<string>(),
                             MontoSolicitud = row["MontoSolicitud"].Cast<string>(),
                             Estatus = row["Estatus"].Cast<string>(),
                             Aprobación = row["Aprobación"].Cast<string>(),
                             FechaAlta = row["FechaAlta"].Cast<string>(),
                         }
                         select item).ToList();
            book.Dispose();
            return respuesta;
        }
    }
}
