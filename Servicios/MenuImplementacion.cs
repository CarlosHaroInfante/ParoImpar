using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParoImpar.Servicios
{
    internal class MenuImplementacion : MenuIntefaz
    { 


        public int numero()
        {
            int numero;
            Console.WriteLine("Elige un número");
            numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(numero); 
            return numero;
        }
    }
}