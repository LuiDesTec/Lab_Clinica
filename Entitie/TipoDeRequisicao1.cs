using System.Collections.Generic;

namespace Entitie
{
     class TipoDeRequisicao 
    {
        public string Sus { get; set; }
        public List<Convenio>  Convenio { get; set; }
        public string Particular { get; set; }
    

        public TipoDeRequisicao()
        {

        }
        
    }
}