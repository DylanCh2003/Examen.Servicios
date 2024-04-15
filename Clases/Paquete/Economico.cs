using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Servicios.Clases
{
    class Economico : Paquete
    {
        public override string Descripccion { get => "Paquete Economico"; }

        public override float PorcentajeCosto => 0.052f;

        public override float PorcentajeImpuesto => 0.13f;
    }
}
