using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitie
{
    class PedidoDeExame
    {
        private int codigo { get; set; }
        private Convenio Convenio  { get; set; }
        public Medico Medico { get; set; }
    }
}
