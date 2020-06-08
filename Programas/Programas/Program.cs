using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Programas
{
    class Programas
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Serie Fibonacci\r\n");

            int i;
            int NumActual = 1;
            int NumAnterio = 1;
            int NumNuevo;
            string Salida = "1, 1";



            for (i = 0; i <= 100; i++)
            {
                NumNuevo = NumActual + NumAnterio;

                Salida += ", " + NumNuevo;

                NumAnterio = NumActual;
                NumActual = NumNuevo;
            }
            Console.WriteLine(Salida);
            Console.ReadKey();
        }

    }
}
