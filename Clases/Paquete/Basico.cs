using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Servicios.Clases
{
    class Basico : Paquete
    {
        public override string Descripccion { get => "Paquete Basico"; }

        public override float PorcentajeCosto => 0.067f;

        public override float PorcentajeImpuesto => 0.13f;
    }
}
