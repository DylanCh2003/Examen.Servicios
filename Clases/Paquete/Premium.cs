using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Servicios.Clases
{
    class Premium : Paquete
    {
        public override string Descripccion { get => "Paquete Premium"; }

        public override float PorcentajeCosto => 0.125f;

        public override float PorcentajeImpuesto => 0.2f;
    }
}
