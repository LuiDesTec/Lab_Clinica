using System;
using System.Collections.Generic;
using System.Linq;
using Lab_Clinic;
using Entitie;
using Lab_Clinic.Entitie;

namespace Entitie
{
        class Paciente
        {
        

        public int Codigo { get; private set; }
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
        public int Cep { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        
        
        
        public Paciente()
        {

        }
        public Paciente(int codigo, string nome, Endereco endereco, string telefone, DateTime datanascimento)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Endereco = endereco;
            this.Telefone = telefone;
            this.DataNascimento = datanascimento;
            
           
                
        }
        public string GetIdade()
        {
            return DateTime.Now.Year - DataNascimento.Year + " years old";
        }



        public void SetCadastrar()
        {

        }
        
        public void GetImprimirPaciente()
        {

        }
        
        }
}
