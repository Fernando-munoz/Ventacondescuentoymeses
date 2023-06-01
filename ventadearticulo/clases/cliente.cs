using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ventadearticulo.clases
{
    public class cliente

    {
        public string Nombre { get; set; }  
   public  string apellido { get; set; }
  public    string correo { get; set; }
        public string numero { get; set; }

        public void contacto()

        {
            Console.WriteLine("Por favor ingrese cuidadosamente los datos del Cliente");
            Console.WriteLine("Nombre del cliente;");
            cliente nom = new cliente();
            nom.Nombre = Console.ReadLine();

            Console.WriteLine("Apellido del Cliente");
            cliente ape = new cliente();
            ape.apellido = Console.ReadLine();

            Console.WriteLine("agregue el correo electronico del cliente");
            cliente cor = new cliente();
            cor.correo = Console.ReadLine();

            Console.WriteLine("ingrese el numero telefonico del cliente");
            cliente tel = new cliente();
            tel.numero = Console.ReadLine();

        }
        }

        }

    

   

    


