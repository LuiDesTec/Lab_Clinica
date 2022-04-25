using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitie
{
    class PedidoDeExame
    {
        private int Codigo { get; set; }
        private TipoDeRequisicao Tipo { get; set; }
        public Medico Medico { get; set; }
    }
}
