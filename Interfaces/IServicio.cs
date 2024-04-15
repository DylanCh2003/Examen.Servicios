using Examen.Servicios.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Servicios.Interfaces
{
    interface IServicio
    {
        double CostoBase { get; }
        string Nombre { get; }
        Opciones Opcion { get; set; }

        double AplicarDescuento(Paquete paquete);
        double CostoSegunCantidad(int CantidadHoras);
        double ObtenerCosto();

    }
}
