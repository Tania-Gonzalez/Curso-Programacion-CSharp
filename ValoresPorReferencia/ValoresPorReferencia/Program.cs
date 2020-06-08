using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValoresPorReferencia
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            Metodo(ref x);
            Console.WriteLine(x);
            Console.ReadKey();
        }
        
        static void Metodo(ref int numero)
        {
            numero += 44;
        }
    }
}
