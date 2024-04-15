using Examen.Servicios.Clases;
using Examen.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Servicios.Patrones
{
    class ServicioFactory
    {
        public IServicio CrearServicio(string nombreServicio, Opciones opcion)
        {
            IServicio servicio = null;

            switch (nombreServicio)
            {
                case "Electricista":
                    servicio = new Electricista();
                    //servicio.Opcion.Servicio = nombreServicio;
                    break;
                case "Fontanero":
                    servicio = new Fontanero();
                    //servicio.Opcion.Servicio = nombreServicio;
                    break;
                case "Pintor":
                    servicio = new Pintor();
                    //servicio.Opcion.Servicio = nombreServicio;
                    break;
            }

            servicio.Opcion = opcion;

            return servicio;
        }
    }
}
