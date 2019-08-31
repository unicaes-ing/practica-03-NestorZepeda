using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    class ejercicio3
    {
       public void ejercicio_3()
        {
            Console.Clear();
            int num1, num2, num3;
            Console.WriteLine("Ingrese los numeros a ordenar");
           Console.Write("Numero 1: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Numero 2: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Numero 3: ");
            num3 = Convert.ToInt32(Console.ReadLine());
            if (num1>num2)
            {
                if (num2 > num3)
                {
                    Console.WriteLine("Los numeros ordenados quedan asi: " + num2 + num3 + num1);
                }
            }
            else
            {
                if (num1>num3)
                {
                    if (num2 > num3)
                    {
                        Console.WriteLine("Los numeros ordenados quedan asi: " + num3 + " " + num1 + " " + num2);
                    }
                }

            }

            Console.ReadKey();

        }
    }
}
