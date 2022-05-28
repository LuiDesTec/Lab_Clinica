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
<<<<<<< HEAD
        

        public int Codigo { get; private set; }
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
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



=======
        private int Codigo { get; set; }
        private string Nome { get; set; }
        private string Endereco { get; set; }
        private int Cep { get; set; }
        private int Telefone { get; set; }
        private int DataNacimento { get; set; }
        
>>>>>>> temp-branch
        public void SetCadastrar()
        {

        }
        
        public void GetImprimirPaciente()
        {

        }
        
        }
}
