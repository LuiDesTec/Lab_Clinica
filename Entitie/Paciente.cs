using System;
using System.Collections.Generic;
using System.Linq;
using Lab_Clinic;
using Entitie;

namespace Entitie
{
        class Paciente
        {
        public int Codigo { get; private set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public int Cep { get; set; }
        public string Telefone { get; set; }
        public string DataNascimento { get; }
        public string DataNacimento { get; set; }
        
        
        public Paciente()
        {

        }
        public Paciente(int codigo, string nome, string endereco, string telefone, string datanascimento)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Endereco = endereco;
            this.Telefone = telefone;
            this.DataNascimento = datanascimento;
           
                
        }
        

        public void SetCadastrar()
        {

        }
        
        public void GetImprimirPaciente()
        {

        }
        
        }
}
