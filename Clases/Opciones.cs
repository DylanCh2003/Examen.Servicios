using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Examen.Servicios.Clases
{
    class Opciones
    {
        string ruta = @"../../Json/Opciones.json";
        public string Zona { get; set; }
        public string Servicio { get; set; }
        public double PrecioTransporte { get; set; }
        public double PrecioLavadoA { get; set; }
        public double PrecioJardineria { get; set; }
        public double PrecioLimpiezaC { get; set; }




        private List<Opciones> ObtenerOpciones()
        {
            List<Opciones> ListaOpcionesTemporal = new List<Opciones>();

            string datos = File.ReadAllText(ruta);

            ListaOpcionesTemporal = JSONGenericList<Opciones>.JSonToList(datos);

            return ListaOpcionesTemporal;
        }

        public List<Opciones> ObtenerOpcionesporServicio(string servicio)
        {
            List<Opciones> ListaOpcionesXServicio = new List<Opciones>();

            ListaOpcionesXServicio = ObtenerOpciones().FindAll(x => x.Servicio.Equals(servicio, StringComparison.CurrentCultureIgnoreCase)).ToList();

            return ListaOpcionesXServicio;
        }
    }
}
