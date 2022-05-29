
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
        public static void insertClient(OClientes obj)
        {
            Console.WriteLine(Funciones.Serialize(obj));
            Console.ReadKey();
            ClientesEntities context = new ClientesEntities();

            var objCliente = new Clientes()
            {
                ClienteId = Int32.Parse(obj.ClienteId),
                Nombre = LimpiaEspacio(obj.Nombre),
                Telefono = obj.Telefono,
                Correo = obj.Correo,
                Edad = Int32.Parse(obj.Edad),
                MontoSolicitud = obj.MontoSolicitud,
                Estatus = obj.Estatus,
                Aprobacion = ValidaAprobacion(obj.Aprobacion),
                FechaAlta = DateTime.Now,
            };

            context.Clientes.Add(objCliente);
            context.SaveChanges();
        }


        public static string LimpiaEspacio(string text)
        {

            text = Regex.Replace(text, @"\s+", " ").Trim();
            return text;
        }
        public static int ValidaAprobacion(string valor)
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
