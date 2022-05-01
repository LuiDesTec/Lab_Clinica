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
           
            
            var p1 = new Paciente(2222, "Vanderson", new Endereco("Rua A","7" ,"Castelo Branco"), "1111-1122",  new DateTime(1976, 11, 11));

            var p2 = new Paciente(1112, "Kevinyn", new Endereco("Rua Bahia", "10", "Brotas"), "1122-1111", new DateTime(1973 , 10 , 11));


            Console.WriteLine(p1.Nome);
            Console.WriteLine(p1.Endereco);
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
