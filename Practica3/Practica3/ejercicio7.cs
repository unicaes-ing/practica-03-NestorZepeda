using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    class ejercicio7
    {
        public void ejercicio_7()
        {
            Console.Clear();
            int op, op2;
            decimal cant, conver;
            Console.WriteLine("Conversión de unidades");
            Console.WriteLine("[1] Onza");
            Console.WriteLine("[2] Libra");
            Console.WriteLine("[3] Gramo");
            Console.WriteLine("[4] Tonelada");
            op = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (op)
            {
                case 1:

                    Console.WriteLine("Escoja la unidad a la que desea hacer la conversión");
                    Console.WriteLine("[1] Libra");
                    Console.WriteLine("[2] Gramo");
                    Console.WriteLine("[3] Tonelada");
                   op2 = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Ingrese la cantidad:");
                    cant = Convert.ToDecimal(Console.ReadLine());
                    if (op2== 1)
                    {
                        conver = cant * 0.0625m;
                        Console.WriteLine(cant + " onza equivale a " + conver + " lb");
                    }
                    else if (op2 == 2)
                    {
                        conver = cant * 28.3495m;
                        Console.WriteLine(cant + " onza equivale a " + conver + " g");
                    }
                    else if (op2 == 3)
                    {
                        conver = cant / 35273.962m;
                        Console.WriteLine(cant + " onza equivale a " + conver+ " t");
                    }
                    break;
                case 2:

                    Console.WriteLine("Escoja la unidad a la que desea hacer la conversión");
                    Console.WriteLine("[1] Onza");
                    Console.WriteLine("[2] Gramo");
                    Console.WriteLine("[3] Tonelada");
                    op2 = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Ingrese la cantidad:");
                    cant = Convert.ToDecimal(Console.ReadLine());
                    if (op2 == 1)
                    {
                        conver = cant / 16;
                        Console.WriteLine(cant + " lb equivale a " + conver + " oz");
                    }
                    else if (op2 == 2)
                    {
                        conver = cant * 453.592m;
                        Console.WriteLine(cant + " lb equivale a " + conver + " g");
                    }
                    else if (op2 == 3)
                    {
                         conver = cant * 0.000453592m;
                        Console.WriteLine(cant + " lb equivale a " + conver + " t");
                    }
                    break;
                case 3:

                    Console.WriteLine("Escoja la unidad a la que desea hacer la conversión");
                    Console.WriteLine("[1] Onza");
                    Console.WriteLine("[2] Libra");
                    Console.WriteLine("[3] Tonelada");
                    op2 = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Ingrese la cantidad:");
                    cant = Convert.ToDecimal(Console.ReadLine());
                    if (op2 == 1)
                    {
                        conver = cant * 0.035274m;
                        Console.WriteLine(cant + " g equivale a " + conver + " oz");
                    }
                    else if (op2 == 2)
                    {
                        conver = cant * 0.00220462m;
                        Console.WriteLine(cant + " g equivale a " + conver + " lb");
                    }
                    else if (op2 == 3)
                    {
                        conver = cant * 0.000001m;
                        Console.WriteLine(cant + " g equivale a " + conver + " t");
                    }
                    break;
                case 4:

                    Console.WriteLine("Escoja la unidad a la que desea hacer la conversión");
                    Console.WriteLine("[1] Onza");
                    Console.WriteLine("[2] Libra");
                    Console.WriteLine("[3] gramo");
                    op2 = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine("Ingrese la cantidad:");
                    cant = Convert.ToDecimal(Console.ReadLine());
                    if (op2 == 1)
                    {
                        conver = cant * 35274;
                        Console.WriteLine(cant + " t equivale a " + conver + " oz");
                    }
                    else if (op2 == 2)
                    {
                        conver = cant * 2204.62m;
                        Console.WriteLine(cant + " t equivale a " + conver + " lb");
                    }
                    else if (op2 == 3)
                    {
                        conver = cant * 1000000m;
                        Console.WriteLine(cant + " t equivale a " + conver + " g");
                    }
                    break;
                default:
                    Console.WriteLine("Por favor ingrese un valor válido");
                    break;
            }
            Console.ReadKey();
        }
    }
}
    

