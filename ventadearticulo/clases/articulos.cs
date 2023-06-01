using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ventadearticulo.clases
{
    public  class articulos
    {
         public void sumaarticulo()
        {
            
            int nv;
            float valor = 0;
            float acumulado = 0;
            float  div = 0;
            double porciento = 0;

            Console.WriteLine("           ¿cuantos articulos desea cobrar?");
            nv = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= nv; i++)
            {
                Console.WriteLine("         Ingresa el precio del articulo" +i);
                valor = int.Parse(Console.ReadLine());
                acumulado = acumulado + valor;
            }
        Console.WriteLine("               el total a pagat es de :" + acumulado);
            if (acumulado >=500 && acumulado <=799 )
            {
                porciento = acumulado - (acumulado * 0.10);
                Console.WriteLine($"        su pago con el 10% de descuento es: {(porciento)}");

            }
         else if (acumulado >= 800 && acumulado <= 999)
            {
                div = (acumulado / 3);
                Console.WriteLine($"       Su pago mensual durante 3 meses será de:  {(div)}");
            }
           
            else if (acumulado >= 1000 && acumulado <= 2000)
                Console.WriteLine("felicidades su pago participa en la promocion de 3 o 6 meses sin intereses por favor elija su oferta");
            Console.WriteLine("precione tecla 1 si desea su pago a 3 meses o tecla 2 si desea pagar a 6 meses");
           

             string op = Console.ReadLine();

                switch (op)
            {
                case "1":
                    div = (acumulado / 3);
                    Console.WriteLine($"su pago a 3 meses sera de ; {(div)}");
                    break;

                case "2":
                    div = (acumulado / 6);
                    Console.WriteLine($"su pago a 6 meses sera de ; {(div)}");
                    break;

            }


        }
     
            
             
      


    }
}
