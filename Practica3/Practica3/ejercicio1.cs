using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    class ejercicio1
    {
        public void ejercicio_1()
            {
            Console.Clear();
            int hh, min, seg;
            Console.Write("Ingrese la hora ");
            hh = Convert.ToInt32(Console.ReadLine());
            if (hh > 0)
            {
                min = hh * 60;
                seg = hh * 3600;

                Console.WriteLine("minutos: " + min + " Segundos: " + seg);

            }

            Console.ReadKey();

        }
    }
}
