using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {

            var ListaNombres = new List<string>() {"Tania","Paola","Maria","Andrea" };

            ListaNombres.Add("Karla");
            ListaNombres.Remove("Andrea");

            Console.WriteLine(ListaNombres[0]);

            foreach (var Nombres in ListaNombres)
            {
                Console.WriteLine(Nombres);
            }
            Console.ReadLine();
        }
    }
}
