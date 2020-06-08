using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Delagados
{
    class Program
    {
        static void Main(string[] args)
        {

            DelMensaje Objmensaje = MetodoMesaje;
            Objmensaje("Este un mensaje");
            MetodoConDelegadoComoParametro(10, 15, Objmensaje);

        }

        static void MetodoMesaje(string M)
        {

            Console.WriteLine(M);
        }

        static void MetodoConDelegadoComoParametro(int num, int num2, DelMensaje ObjMensaje)
        {
            Console.WriteLine("El número es :" + (num2 + num2).ToString());

        }

        public delegate void DelMensaje(string Msj);
    }
}
