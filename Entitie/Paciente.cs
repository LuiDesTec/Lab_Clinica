using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitie
{
        class Paciente
        {
        public int Codigo { get; private set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public int Cep { get; set; }
        public string Telefone { get; set; }
        public string DataNacimento { get; set; }
        
        
        public Paciente(int v)
        {

        }
        public Paciente(int codigo, string nome, string endereco, string telefone, string datanascimento)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Endereco = endereco;
            this.Telefone = telefone;
            this.Telefone = datanascimento;
           
                
        }
        

        public void SetCadastrar()
        {

        }
        
        public void GetImprimirPaciente()
        {

        }
        
        }
}
