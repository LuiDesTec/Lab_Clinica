﻿using Entitie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Clinic.Entitie
{
    class Endereco
    {
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public int CEP { get; set; }
        public Cidade Cidade { get; set; } 
        public UF Estado { get; set; } 

        public Endereco()
        {
        }
        public Endereco(string rua, string numero, string bairro)
        {
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
          
        }
    }
    
}
