using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    class ejercicio8
    {
        public void ejercicio_8()
        {
            string producto;
            int cant, bolita;
            decimal precio, total, des=0.00m,totalapagar;
            Console.Clear();
            Console.WriteLine("Ingrese el nombre del producto");
            producto = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad: ");
            cant = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el precio: ");
            precio = Convert.ToDecimal(Console.ReadLine());
            total = cant * precio;
            Console.Clear();

            Console.WriteLine("Presione cualquier tecla para saber el color de la bolita:");
            Console.WriteLine("Segun el color de la bolita obtendra un descuento");
            Console.WriteLine("Blanca ------ 0%");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Verde ------- 15%");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Amarilla ---- 18%");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Azul -------- 20%");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Roja -------- 25%");
            Console.ReadKey();
            Console.Clear();
            Random bola = new Random();
            bolita = bola.Next(1, 6);
            if (bolita == 1)
            {
                Console.WriteLine("El color de la bolita es blanco, su descuento es 0%.");
                des = total * 0.00m;


                ;
            }
            else if (bolita == 2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("El color de la bolita es verde, su descuento es 15%.");

                des = total * 0.15m;

            }
            else if (bolita == 3)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("El color de la bolita es amarillo, su descuento es 18%.");

                des = total * 0.18m;

            }
            else if (bolita == 4)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("El color de la bolita es azul, su descuento es 20%.");

                des = total * 0.20m;
            }
            else if (bolita == 5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("El color de la bolita es rojo, su descuento es 25%.");

                des = total * 0.25m;
                
            }
            totalapagar = total - des;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Producto: "+producto);
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Total: "+total.ToString("C2"));
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Descuento: "+des.ToString("C2"));
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Total a pagar: "+totalapagar.ToString("C2"));
            Console.WriteLine("-------------------------------");
            Console.ReadKey();
        }
    }
}
