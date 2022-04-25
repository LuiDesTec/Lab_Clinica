using Entitie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab_Clinic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Paciente p = new Paciente ( 2222, "Luiz", "rua g", "1111-1122", "13/12/1999" );

            Paciente p1= new Paciente(2222, "Savastane", "rua d", "1122-1111", "01/03/1960");
        }
    }
}
