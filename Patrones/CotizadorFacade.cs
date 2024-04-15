using Examen.Servicios.Clases;
using Examen.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace Examen.Servicios.Patrones
{
    class CotizadorFacade
    {
        IServicio servicio;
        public void InicializarServicio(IServicio servicio)
        {
            this.servicio = servicio;
        }

        Cliente Cliente = new Cliente();

        public void AgregarCliente(Cliente cliente)
        {
            Cliente = cliente;
        }
        public double CalcularCosto()
        {
            double total = 0;

            //Subtotal
            double CalcularRegla1 = Cliente.Servicio.ObtenerCosto() + Cliente.Paquete.CostoAdicional(Cliente.Servicio.Opcion);

            //Sacar el costo segun las horas
            double CalcularRegla2 = Cliente.Servicio.CostoSegunCantidad(Cliente.Paquete.CantidadHoras);

            //Sumamos el porcentaje del costo
            double CalcularRegla3 = CalcularRegla1 + Cliente.Paquete.PorcentajeCosto;

            //Total descuentos
            double CalcularRegla4 = CalcularRegla1 - Cliente.Servicio.AplicarDescuento(Cliente.Paquete);

            //total = ((CalcularRegla1 + CalcularRegla2 + CalcularRegla3 + CalcularRegla4 )* Cliente.Paquete.PorcentajeImpuesto);

            total = CalcularRegla1 + CalcularRegla2 + CalcularRegla3 - CalcularRegla4 + (Cliente.Paquete.PorcentajeImpuesto);

            return total;
        }
        public List<Opciones> CargarServicios(string servicio)
        {
            List<Opciones> tempOpci = Cliente.Servicio.Opcion.ObtenerOpcionesporServicio(servicio);
            return tempOpci;
        }
        public void ExportarXML(string ruta)
        {
            //documento XML
            XmlDocument xDoc = new XmlDocument();

            //declaracion inicial de que el archivo a continuación es un XML
            XmlDeclaration dec =
            xDoc.CreateXmlDeclaration("1.0", null, null);
            xDoc.AppendChild(dec);


            string rutaXSLT = System.Windows.Forms.Application.StartupPath + "\\Xslt\\Servicio.xslt";
            XmlProcessingInstruction xslt = xDoc.CreateProcessingInstruction("xml-stylesheet", "type=\"text/xsl\" href=\"" + rutaXSLT + "\"");
            xDoc.AppendChild(xslt);

            XmlElement root = xDoc.CreateElement("Servicios");


            XmlElement nServicio = xDoc.CreateElement("Servicio");
            nServicio.SetAttribute("Nombre", Cliente.Servicio.Nombre);
            nServicio.SetAttribute("CostoBase", Cliente.Servicio.CostoBase.ToString());


            XmlElement nPaquete = xDoc.CreateElement("Paquete");
            nPaquete.SetAttribute("Descripcion", Cliente.Paquete.Descripccion);

            XmlElement nCLiente = xDoc.CreateElement("Cliente");
            nCLiente.SetAttribute("Identificacion", Cliente.Identificacion);
            nCLiente.SetAttribute("Nombre", Cliente.Nombre);
            nCLiente.SetAttribute("CantidadHoras", Cliente.Paquete.CantidadHoras.ToString());


            XmlElement nZona = xDoc.CreateElement("Zona");
            nZona.SetAttribute("PrecioTransporte", Cliente.Servicio.Opcion.PrecioTransporte.ToString());
            nZona.InnerText = Cliente.Servicio.Opcion.Zona;

            //Adicionales
            XmlElement xAdicionales = xDoc.CreateElement("Adicionales");
            foreach (Adicionales a in Cliente.Paquete.listaAdicionales)
            {
                XmlElement xAdicional = xDoc.CreateElement("Adicional");
                xAdicional.InnerText = a.ToString();
                xAdicionales.AppendChild(xAdicional);
            }
            nServicio.AppendChild(xAdicionales);

            XmlElement nTotal = xDoc.CreateElement("Total");
            nTotal.SetAttribute("Descuentos", Cliente.Servicio.AplicarDescuento(Cliente.Paquete).ToString("N2"));
            nTotal.InnerText = CalcularCosto().ToString("N2");
            nServicio.AppendChild(nTotal);

            root.AppendChild(nServicio);
            nServicio.AppendChild(nPaquete);
            nServicio.AppendChild(nCLiente);
            nServicio.AppendChild(nZona);
            nServicio.AppendChild(xAdicionales);
            nServicio.AppendChild(nTotal);

            xDoc.AppendChild(root);
            xDoc.Save(ruta);
            File.Copy(@"../../Xslt/Servicio.xslt", @"c:\temp\Servicio.xslt", true);

        }


    }
}
