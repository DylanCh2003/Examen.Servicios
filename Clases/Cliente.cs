using Examen.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Servicios.Clases
{
    class Cliente
    {
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public Paquete Paquete { get; set; }
        public IServicio Servicio { get; set; }
        public string Telefono { get; set; }
    }
}
