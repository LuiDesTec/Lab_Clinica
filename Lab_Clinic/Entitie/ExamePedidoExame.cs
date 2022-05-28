using Lab_Clinic.Entitie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitie
{
     class ExamePedidoExame : IImprimir
    {
        public string DataRealizacao { get; set; }
        public string HorarioRealizacao { set; get; }
        public string DataResultado { get; set; }
        public string  EntregaResultado { get; set; }
        public double ValorExame { get; set; }

        void IImprimir.GetImprimir()
        {
            throw new NotImplementedException();
        }

        void IImprimir.SetCadastrar()
        {
            throw new NotImplementedException();
        }
    }
    


}
