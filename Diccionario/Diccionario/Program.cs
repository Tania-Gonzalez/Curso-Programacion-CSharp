using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Diccionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Elemento> DiccElemento = new Dictionary<string, Elemento> {

                {"K", new Elemento("K", "Potasio", 19)},
                {"Ca", new Elemento("Ca", "Calcio", 20)},
                {"Sc", new Elemento("Sc", "Escandio", 21)},
                {"Ti", new Elemento("Ti", "Titanio", 22) }
            
            };

            foreach (KeyValuePair<string, Elemento> KVPclave in DiccElemento)
            {
                Elemento Elelemento = KVPclave.Value;

                Console.WriteLine("Clave: " + KVPclave.Key); 
                Console.WriteLine("Elemento: " + Elelemento.Simbolo + " " + Elelemento.Nombre + " " + Elelemento.NumeroAtomico);
            }

            Console.ReadLine();
     
        }
    }


    public class Elemento
    {
        public string Simbolo { get; set; }
        public string Nombre { get; set; }
        public int NumeroAtomico { get; set; }

        public Elemento(string simbolo, string nombre, int numeroAtomico)
        {
            Simbolo = simbolo;
            Nombre = nombre;
            NumeroAtomico = numeroAtomico;
        }
    }
}
