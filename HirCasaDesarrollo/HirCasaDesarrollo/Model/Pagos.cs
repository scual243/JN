//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HirCasaDesarrollo.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Pagos
    {
        public int PagoId { get; set; }
        public Nullable<int> ClienteId { get; set; }
        public Nullable<decimal> MontoPagado { get; set; }
        public Nullable<int> Aplicado { get; set; }
        public Nullable<System.DateTime> FechaPago { get; set; }
    }
}
