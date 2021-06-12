using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_4.TP3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, prom,num,acu=0;
           ;
            for (i=1;i<=4;i++)
            {
                Console.WriteLine("Ingrese su calificacion");
                num= Int32.Parse(Console.ReadLine());

                acu = (acu+num);
            }

            prom = (acu / 4);

               if (prom> 4)
               {
                   Console.WriteLine("Tu promedio es: {0}", prom);
                   Console.WriteLine("¡Felicitaciones, estas APROBADO!");
               }
               else
               {
                   Console.WriteLine("Tu promedio es: {0}", prom);
                   Console.WriteLine("¡Malas noticias, estas DESAPROBADO!");

               }

               Console.ReadKey();

            
        }
    }
}
