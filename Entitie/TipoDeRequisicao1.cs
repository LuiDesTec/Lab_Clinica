using System.Collections.Generic;

namespace Entitie
{
     class TipoDeRequisicao 
    {
        public string Sus { get; set; }
        public List<Convenio>  Convenios { get; set; }= new List<Convenio>();   
        public string Particular { get; set; }
    

        public TipoDeRequisicao()
        {

        }
        public void AddConvenio (Convenio convenio)
        {
            Convenios.Add(convenio);
        }
    }
}