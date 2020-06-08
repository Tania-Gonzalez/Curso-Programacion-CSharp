using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Principal
    {
        static void Main(string[] args)
        {

            Chihuahua Perro1 = new Chihuahua("Perr");

            Perro1.PerroLadra();
            Console.ReadKey();
        }
    }

    public class Perro { 
        
        public string PerroLadra() { 
            return "Ladrando"; 
        }
        
    }

    public class Chihuahua : Perro
    {

        public void ChihuahuaLadra()
        {
            base.PerroLadra();
        }

        public Chihuahua(string mensaje) : base("Soy un perro")
        {

            Console.WriteLine(mensaje);

        }
    }


}
