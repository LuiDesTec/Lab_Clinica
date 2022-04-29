using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitie
{
    internal class Medico
    {   
        public CRM CRM { get; set; }
        public string Nome { get; set; }

        public Medico (CRM crm, string nome)
        {
            CRM = crm;
            Nome = nome;
        }
    }
}
