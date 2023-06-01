using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ventadearticulo.clases
{
    public class fecha
    {
        public void date() { 
             DateTime currentDateTime = DateTime.Now;
        string formattedDateTime = currentDateTime.ToString("dddd, dd MMMM yyyy HH:mm:ss");
        Console.WriteLine(" Fecha de la compra : " + formattedDateTime);
        }
       
    }
}
