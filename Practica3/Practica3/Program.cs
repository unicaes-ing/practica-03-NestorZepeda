using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    class Program
    {
      static void Main(string[] args)
        {
            Console.WriteLine("Seleccione practica");
            Console.WriteLine("1-)Practica 1");
            Console.WriteLine("2-)Practica 2");
            Console.WriteLine("3-)Practica 3");
            Console.WriteLine("4-)Practica 4");
            Console.WriteLine("5-)Practica 5");
            Console.WriteLine("6-)Practica 6");
            Console.WriteLine("7-)Practica 7");
            Console.WriteLine("8-)Practica 8");
            int op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1:
                    ejercicio1 e1 = new ejercicio1();
                    e1.ejercicio_1();
                    break;
                case 2:
                    ejercicio2 e2 = new ejercicio2();
                    e2.ejercicio_2();
                    break;
                case 3:
                    ejercicio3 e3 = new ejercicio3();
                    e3.ejercicio_3();
                    break;
                case 4:
                    ejercicio4 e4 = new ejercicio4();
                    e4.ejercicio_4();
                    break;
                case 5:
                    ejercicio5 e5 = new ejercicio5();
                    e5.ejercicio_5();
                    break;
                case 6:
                    ejercicio6 e6 = new ejercicio6();
                    e6.ejercicio_6();


                    break;
                case 7:
                    ejercicio7 e7 = new ejercicio7();
                    e7.ejercicio_7();
                    break;
                case 8:
                    ejercicio8 e8 = new ejercicio8();
                    e8.ejercicio_8();
                    break;
               
                default:
                    break;
            }
            Console.ReadKey();
        }
    }
}
