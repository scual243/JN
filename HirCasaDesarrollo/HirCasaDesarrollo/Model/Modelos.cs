using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HirCasaDesarrollo
{
    public class OClientes
    {
        public string ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Edad { get; set; }
        public string MontoSolicitud { get; set; }
        public string Estatus { get; set; }
        public string Aprobacion { get; set; }
        public string FechaAlta { get; set; }
    }
    public class OPagos
    {
        public string PagoId { get; set; }
        public string ClienteId { get; set; }
        public string MontoPagado { get; set; }
        public string Aplicado { get; set; }
        public string FechaPago { get; set; }
    }
    public class OAjustes
    {
        public string AjusteId { get; set; }
        public string ClienteId { get; set; }
        public string MontoTotal { get; set; }
        public string Adeudo { get; set; }
    }

}
