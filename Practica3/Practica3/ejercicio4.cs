using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    class ejercicio4
    {
      public void  ejercicio_4()
        {
            Console.Clear();
            decimal costo=0.00m;
            Console.WriteLine("Ingrese los minutos que ha llamado");
            int  min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Selecione zona");
            Console.WriteLine("1-)Zona Occidental");
            Console.WriteLine("2-)Zona Central");
            Console.WriteLine("3-)Zona Oriental");
            int op = Convert.ToInt32(Console.ReadLine());
            if (op == 1)
            {
                costo = 0.32m * min;
            }else
                if (op==2)
                {
                costo = 0.25m * min;
            }
            else
                if (op == 3)
            {
                costo = 0.36m * min;
            }
            Console.WriteLine("Costo por llamada:"+costo);
        }
    }
}
