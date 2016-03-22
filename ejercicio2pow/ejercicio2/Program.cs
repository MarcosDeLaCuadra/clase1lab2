using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero=0;
            double num;
            double cubo;
            double cuadrado;
            int resp=0;
            string dato;
            Console.WriteLine("ingrese un numero");

            do
            {
                while (int.TryParse(dato = Console.ReadLine(), out numero) == false)
                {
                    Console.WriteLine("error reingrese un numero"); 
                }
                if (numero <= 0)
                { 
                      Console.WriteLine("reingrese numero mayor a 0");
                      resp = 1;

                }

            } while (resp == 1);

            num = numero;

            cuadrado=Math.Pow(num,2);
            cubo = Math.Pow(num, 3);

            Console.WriteLine(cubo);
            Console.WriteLine(cuadrado);
            Console.Read();
        }
    }
}
