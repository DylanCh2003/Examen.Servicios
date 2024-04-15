using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Servicios.Clases
{
    abstract class Paquete
    {
        public int CantidadHoras { get; set; }
        public abstract String Descripccion { get; }
        public List<Adicionales> listaAdicionales { get; set; } = new List<Adicionales>();
        public abstract float PorcentajeCosto { get; }

        public abstract float PorcentajeImpuesto { get; }

        public void AgregarAdicional(Adicionales adicional)
        {

            listaAdicionales.Add(adicional);
        }

        public double CostoAdicional(Opciones opcion)
        {
            double total = 0;

            foreach (Adicionales a in listaAdicionales)
            {
                switch (a)
                {
                    case Adicionales.LavadoAcera:
                        total += opcion.PrecioLavadoA;
                        break;
                    case Adicionales.Jardineria:
                        total += opcion.PrecioJardineria;
                        break;
                    case Adicionales.LimpiezaCanoas:
                        total += opcion.PrecioLimpiezaC;
                        break;
                    default:
                        break;
                }

            }

            return total;
        }

        public bool TieneAdicional(Adicionales adicional)
        {
            bool validarAdicionales = false;

            switch (adicional)
            {
                case Adicionales.LavadoAcera:
                    validarAdicionales = true;
                    break;
                case Adicionales.Jardineria:
                    validarAdicionales = true;
                    break;
                case Adicionales.LimpiezaCanoas:
                    validarAdicionales = true;
                    break;
                default:
                    break;
            }
            return validarAdicionales;
        }
    }
}
