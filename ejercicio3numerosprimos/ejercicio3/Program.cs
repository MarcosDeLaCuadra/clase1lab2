using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
           // string aux;
            string aux;

            Console.WriteLine("ingrese un numero");
            while (int.TryParse(aux, out numero) == false)
            {
                Console.WriteLine("error reintente ingresando un numero");
                aux = Console.ReadLine();

                Console.WriteLine("{0}", numero);
            }
        }
    }
}
