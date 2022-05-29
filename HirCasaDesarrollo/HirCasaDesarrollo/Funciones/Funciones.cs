
using HirCasaDesarrollo.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace HirCasaDesarrollo.Funciones
{
    public class Funciones
    {
        public static void insertClient(Clientes obj)
        {
            ClientesEntities context = new ClientesEntities();

            int aprobacion = Moneda(obj.Aprobación);
            ClientesDb cliente = new ClientesDb();
            cliente.ClienteId = int.Parse(obj.ClienteId);
            cliente.Nombre = obj.Nombre;
            cliente.Telefono = Int32.Parse(LimpiaCadena(obj.Telefono));
            cliente.Correo = obj.Correo;
            cliente.Edad = int.Parse(obj.Edad);
            cliente.MontoSolicitud = Convert.ToDecimal(LimpiaCadena(obj.MontoSolicitud));
            cliente.Estatus = obj.Estatus;
 
            cliente.FechaAlta = DateTime.Parse(obj.FechaAlta);

            Model.Clientes objCliente = new Model.Clientes();
            //objCliente.ClienteId = cliente.ClienteId;
            objCliente.Nombre = LimpiaEspacio(cliente.Nombre);
            objCliente.Telefono = cliente.Telefono;
            objCliente.Correo = cliente.Correo;
            objCliente.Edad = cliente.Edad;
            objCliente.MontoSolicitud = cliente.MontoSolicitud;
            objCliente.Estatus = cliente.Estatus;
            objCliente.Aprobación = aprobacion;
            objCliente.FechaAlta = cliente.FechaAlta;


            context.Clientes.Add(objCliente);
            context.SaveChanges();
        }


        public static string LimpiaEspacio(string text)
        {

            text = Regex.Replace(text, @"\s+", " ").Trim();
            return text;
        }
        public static int Moneda(string valor)
        {
            int respuesta = 0;//int.MaxValue;
            try
            {
                respuesta = Int32.Parse(valor);
            }
            catch (Exception)
            {
            }
            finally
            {

            }
            return respuesta;


        }
        public static string LimpiaCadena(string text)
        {

            text = text.Replace("-", "");
            text = text.Replace("$", "");
            text = text.Replace(",", "");
            text = text.Replace("?", "");
            return text;
        }
        public static string Serialize(object input)
        {
            XmlSerializer mySerializer = new XmlSerializer(input.GetType());
            string xml = "";
            using (StringWriter sww = new StringWriter())
            {
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Encoding = new UTF8Encoding(false, false);
                settings.Indent = true;
                settings.OmitXmlDeclaration = true;
                XmlWriter writer = XmlWriter.Create(sww, settings);
                mySerializer.Serialize(writer, input);
                xml = sww.ToString();
            }
            return xml;
        }
    }
}
