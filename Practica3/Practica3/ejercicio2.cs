using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    class ejercicio2
    {
       public void ejercicio_2()
        {
            Console.Clear();
            Random alea = new Random();
            int num = alea.Next(1,101);
            Console.WriteLine("Numero generado: " + num);

            if(num % 2 == 0)
            {
                Console.WriteLine("El numero es par");
            }
            else {
                Console.WriteLine("El numero es impar");
            }
            Console.ReadKey();
            
        }
    }
}
