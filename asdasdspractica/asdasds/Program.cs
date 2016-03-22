using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace asdasds
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena;
            int numero;
            int aux;
            Console.WriteLine("ingrese numero");
            while (int.TryParse(Console.ReadLine(), out numero) == false)
            {
                Console.WriteLine("reingrese numero");
            }

            aux = numero;

            for (int i = numero; i > 0; i--)
            {
                
                if(i%2!=0 && i%3!=0)
                {
                 Console.WriteLine(i);
                }
              
            }
         
          
      /*     aux = numero % 2;
            
           

            aux = numero % 3;

           // cadena = Console.ReadLine();
            Console.WriteLine(aux);*/

        }
    }
}
