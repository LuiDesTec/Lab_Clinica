using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entitie
{
   class Convenio
    {
        public int Codigo { get; private set; }
        public string Nome { get; private set; }

        public Convenio()
        {
           
        }
        public void SetNome( string nome)
        {
          
            Nome = nome;    
        }

    }

    
}
