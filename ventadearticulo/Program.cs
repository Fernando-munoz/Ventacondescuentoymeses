using System;
using ventadearticulo.clases;

namespace ventadearticulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine ("             ---Ticket de Compra---");
            cliente client = new cliente();
            client.contacto();

            articulos articulo = new articulos();
            articulo.sumaarticulo();
            
            fecha date = new fecha();
            date.date();
        }
    }
}
