using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace usodetryparse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title="uso de tryParse";
            string dato;
            Console.WriteLine("ingrese su edad");
            dato = Console.ReadLine();
            int numero;
           //numero = int.Parse(dato);
            while(int.TryParse(dato,out numero)==false)
                {
                    Console.WriteLine("error reintente ingresando un numero");
                    dato = Console.ReadLine();
                   }

        }
    }
}
