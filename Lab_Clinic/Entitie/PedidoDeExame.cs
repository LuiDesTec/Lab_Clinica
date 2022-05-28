﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitie
{
    class PedidoDeExame
    {
        public int Codigo { get; private set; }
        public  TipoDeRequisicao Tipo { get; private set; }
        public Medico Medico { get; private set; }
        public Paciente Paciente { get; private set; }
        
        public PedidoDeExame()
        {

        }

        public PedidoDeExame(int codigo, TipoDeRequisicao tipo, Medico medico, Paciente paciente)
        {
            Codigo = codigo;
            Tipo = tipo;
            Medico = medico;
            Paciente = paciente;
        }

    }
}
