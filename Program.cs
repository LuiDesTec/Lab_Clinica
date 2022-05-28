using Entitie;
using System;
using System.Collections.Generic;
using System.Linq;
using Lab_Clinic;
using Lab_Clinic.Entitie;

namespace Lab_Clinic
{
     class Program
    {
        static void Main(string[] args)
        {
           
            
            var p1 = new Paciente(2222, "Vanderson", new Endereco("Rua A","7" ,"Castelo Branco"),"7187654321", 
                new DateTime(1993, 11, 11));

            var p2 = new Paciente(1112, "Kevinyn", new Endereco("Rua Bahia", "10", "Brotas"), "7112345678", 
                new DateTime(2012, 10, 11));


            Console.WriteLine(p1.Nome);
            Console.WriteLine(p1.Endereco.Rua);
            Console.WriteLine(p1.Endereco.Numero);
            Console.WriteLine(p1.Endereco.Bairro);
            Console.WriteLine(p1.Telefone);
            Console.WriteLine(p1.GetIdade());

            Console.WriteLine(p2.Nome);
            Console.WriteLine(p2.Endereco.Rua);
            Console.WriteLine(p2.Endereco.Numero);
            Console.WriteLine(p2.Endereco.Bairro);
            Console.WriteLine(p2.Telefone);
            Console.WriteLine(p2.GetIdade());

            









        }
    }
}
