using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace guiaejercicio11
{
    class validacion
    {
        public static bool validar(int , int , int )
        {
            int min=0, max=0, promedio;
            int numero;
            int acumulador = 0;
            string dato;
            int resp=0;
            for (int i = 0; i < 10; i++)
            {
                 do
              {
                  resp = 0;
                while (int.TryParse(dato = Console.ReadLine(), out numero) == false)
                {
                    Console.WriteLine("error reingrese un numero");
                }
                if (numero<= -100 || numero >= 100)
                {
                    Console.WriteLine("reingrese numero mayor a 0");
                    resp = 1;

                }

              } while (resp == 1);

                 if (i == 0)
                 {
                     min = numero;
                     max = numero;

                 }
                 else
                 {
                     if (min > numero)
                     {
                         min = numero;
                     }
                     if (min > numero)
                     {
                         min = numero;
                     }
                    
                 }
                 acumulador = +numero;
            }
           
            promedio= acumulador/10;
        }

    }
}
