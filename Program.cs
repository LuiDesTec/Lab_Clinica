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
            Paciente p = new Paciente ( 2222, "Luiz", "rua g", "1111-1122", "13/12/1999" );

            Paciente p1 = new Paciente(1112, "Savastane", "rua d", "1122-1111", "01/03/1960");


           Console.WriteLine($" { p1.Nome} , {p.Nome}");

        
            PedidoDeExame pd = new PedidoDeExame();
            pd.Medico = new Medico("");





        }
}
}
