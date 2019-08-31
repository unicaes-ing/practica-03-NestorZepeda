using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    class ejercicio6
    {
        public void ejercicio_6()
        {
            {
                string prod;
                int cant;
                decimal precio=0.00m, total=0.00m, descuento=0.00m,totalapagar=0.00m;
                Console.Clear();
                Console.WriteLine("Ingrese el nombre del producto");
                prod = Console.ReadLine();
                Console.WriteLine("Ingrese la cantidad: ");
                cant = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el precio: ");
                Console.Write("$ ");
                precio = Convert.ToDecimal(Console.ReadLine());
                total = cant * precio;
                if (total >= 0.00m && total <= 100.00m)
                {
                    descuento = 0.00m;
                }
                else if (total >= 100.01m && total <= 200.00m)
                {
                    descuento = total * 0.12m;
                   
                }
                else if (total >= 200.01m && total <= 500.00m)
                {
                    descuento = total * 0.15m;
                   
                }
                else if (total >= 500.01m)
                {
                    descuento = total * 0.20m;
                    
                }
                totalapagar = total - descuento;
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Total: "+total.ToString("C2"));
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Descuento: " + descuento.ToString("C2"));
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Total a pagar: " + totalapagar.ToString("C2"));
                Console.WriteLine("----------------------------------------");
                Console.ReadKey();
            }
        }
    }
}
