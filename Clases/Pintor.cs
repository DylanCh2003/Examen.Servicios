using Examen.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Servicios.Clases
{

    class Pintor : IServicio
    {
        public double CostoBase => 15000;

        public string Nombre => "Servicio: Pintor";

        public Opciones Opcion
        {
            get;
            set;
        }

        public double AplicarDescuento(Paquete paquete)
        {
            double total = 0;
            double descuentoCostoBase = 0;
            double descuentoXCantHora = 0;

            foreach (Adicionales a in paquete.listaAdicionales)
            {
                if (paquete.TieneAdicional(a))
                {
                    if (a is Adicionales.LavadoAcera)
                    {
                        descuentoCostoBase = CostoBase * 0.5d;
                    }
                }

                if (paquete is Premium)
                {
                    descuentoXCantHora = CostoSegunCantidad(paquete.CantidadHoras) * 1d;
                }
            }
            return total;

        }

        public double CostoSegunCantidad(int CantidadHoras)
        {

            double total = 0;

            if (CantidadHoras >= 1 && CantidadHoras <= 3)
            {
                total = 20000;
            }
            else if (CantidadHoras >= 4 && CantidadHoras <= 6)
            {
                double Primeras3h = 20000d;

                double De4a6Horas = (CantidadHoras - 3) * 5000d;

                total = Primeras3h + De4a6Horas;
            }
            else if (CantidadHoras >= 6)
            {
                double Primeras3h = 20000d;

                double De4a6Horas = 5000d;

                double masDe6H = (CantidadHoras - 6) * 4500d;

                total = Primeras3h + De4a6Horas + masDe6H;
            }

            return total;
        }

        public double ObtenerCosto()
        {
            return CostoBase + Opcion.PrecioTransporte;
        }
    }
}
