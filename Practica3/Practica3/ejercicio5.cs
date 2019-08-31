using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    class ejercicio5
    {
        public void ejercicio_5()
        {
            {
                int num;
                string letra="";
                Console.Clear();
                Console.WriteLine("Ingrese un número del 1 al 10");
                num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        letra = "uno";
                        break;
                    case 2:
                        letra = "dos";
                        break;
                    case 3:
                        letra = "tres";
                        break;
                    case 4:
                        letra = "cuatro";
                        break;
                    case 5:
                        letra = "cinco";
                        break;
                    case 6:
                        letra = "seis";
                        break;
                    case 7:
                        letra = "siete";
                        break;
                    case 8:
                        letra = "ocho";
                        break;
                    case 9:
                        letra = "nueve";
                        break;
                    case 10:
                        letra = "diez";
                        break;
                    default:
                        Console.WriteLine("Solo mostramos numeros del uno al diez");
                        break;
                }
                Console.WriteLine("El número es: "+letra);
                Console.ReadKey();
            }
        }
    }
}
