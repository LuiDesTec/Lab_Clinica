using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lab_Clinic.Entitie;

namespace Entitie
{
     public class Grupo_Exame : IImprimir
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
    
        public void SetCadastrar()
        {

        }

        public void GetImprimirExames()
        {

        }

        public void GetImprimir()
        {
            throw new NotImplementedException();
        }
    }




}
