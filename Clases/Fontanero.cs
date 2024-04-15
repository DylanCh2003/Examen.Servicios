using Examen.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Servicios.Clases
{
    internal class Fontanero : IServicio
    {
        public double CostoBase => 18000;

        public string Nombre => "Servicio: Fontanero";

        public Opciones Opcion
        {
            get; set;
        }

        public double AplicarDescuento(Paquete paquete)
        {
            double total = 0;
            double descuentoCostoBase = 0;
            double descuentoXAdicionales = 0;

            foreach (Adicionales a in paquete.listaAdicionales)
            {
                if (paquete.TieneAdicional(a))
                {
                    if (a is Adicionales.LavadoAcera)
                    {
                        descuentoCostoBase = CostoBase * 0.3d;
                    }
                }

                if (paquete is Economico)
                {
                    if (paquete.TieneAdicional(a))
                    {
                        if (a is Adicionales.LimpiezaCanoas)
                        {
                            descuentoXAdicionales += Opcion.PrecioLimpiezaC * 0.25d;
                        }
                    }
                }
            }

            total = descuentoCostoBase + descuentoXAdicionales;
            return total;
        }

        public double CostoSegunCantidad(int CantidadHoras)
        {
            double total = 0;

            if (CantidadHoras >= 1 && CantidadHoras <= 3)
            {
                total = 30000;
            }
            else if (CantidadHoras >= 4 && CantidadHoras <= 6)
            {
                double Primeras3h = 30000;

                double De4a6Horas = (CantidadHoras - 3) * 9000d;

                total = Primeras3h + De4a6Horas;
            }
            else if (CantidadHoras >= 7)
            {
                double Primeras3h = 30000d;

                double De4a6Horas = 9000d;

                double masDe6H = (CantidadHoras - 6) * 8500d;

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
