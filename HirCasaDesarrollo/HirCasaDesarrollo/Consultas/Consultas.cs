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
        public static List<OClientes> getDataExcelClientes(string path)
        {

            List<OClientes> respuesta = new List<OClientes>();
            var book = new ExcelQueryFactory(path);
            respuesta = (from row in book.Worksheet("Clientes")
                         let item = new OClientes
                         {
                             ClienteId = row["ClienteId"].Cast<string>(),
                             Nombre = row["Nombre"].Cast<string>(),
                             Telefono = row["Telefono"].Cast<string>(),
                             Correo = row["Correo"].Cast<string>(),
                             Edad = row["Edad"].Cast<string>(),
                             MontoSolicitud = row["MontoSolicitud"].Cast<string>(),
                             Estatus = row["Estatus"].Cast<string>(),
                             Aprobacion = row["Aprobación"].Cast<string>(),
                             FechaAlta = row["FechaAlta"].Cast<string>(),
                         }
                         select item).ToList();
            book.Dispose();
            return respuesta;
        }
    }
}
