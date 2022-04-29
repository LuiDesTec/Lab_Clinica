using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitie
{
    class PedidoDeExame
    {
        public int Codigo { get; private set; }
        public  TipoDeRequisicao Tipo { get; set; }
        public Medico Medico { get; set; }

        public PedidoDeExame()
        {

        }
    }
}
