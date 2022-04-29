using Entitie;
using System;
using System.Collections.Generic;
using System.Linq;
using Lab_Clinic;


namespace Lab_Clinic
{
     class Program
    {
        static void Main(string[] args)
        {
           
            
            Paciente p1 = new Paciente(2222, "Luiz", "rua g", "1111-1122",  new DateTime(1976, 11, 11));

            var p2 = new Paciente(1112, "Savastane", "rua d", "1122-1111", new DateTime(1973 , 11 , 11));


            Console.WriteLine(p1.Nome);
            Console.WriteLine(p1.Endereco);
            Console.WriteLine(p1.Telefone);
            Console.WriteLine(p1.GetIdade());

            Console.WriteLine(p2.Nome);
            Console.WriteLine(p2.Endereco);
            Console.WriteLine(p2.Telefone);
            Console.WriteLine(p2.GetIdade());









        }
    }
}
