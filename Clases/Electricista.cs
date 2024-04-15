using Examen.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Servicios.Clases
{
    class Electricista : IServicio
    {
        public double CostoBase => 20000;

        public string Nombre => "Servicio: Electricista";

        public Opciones Opcion
        {
            get;
            set;
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
                        descuentoCostoBase = CostoBase * 0.4d;
                    }
                }

                if (paquete is Premium)
                {
                    if (paquete.TieneAdicional(a))
                    {
                        if (a is Adicionales.LimpiezaCanoas)
                        {
                            descuentoXAdicionales += Opcion.PrecioLimpiezaC * 0.45d;
                        }

                        if (a is Adicionales.Jardineria)
                        {
                            descuentoXAdicionales += Opcion.PrecioJardineria * 0.2d;
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
                total = 25000;
            }
            else if (CantidadHoras >= 4 && CantidadHoras <= 6)
            {
                double Primeras3h = 25000d;

                double De4a6Horas = (CantidadHoras - 3) * 8200d;

                total = Primeras3h + De4a6Horas;
            }
            else if (CantidadHoras >= 7)
            {
                double Primeras3h = 25000d;

                double De4a6Horas = 8200d;

                double masDe6H = (CantidadHoras - 6) * 7750d;

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
