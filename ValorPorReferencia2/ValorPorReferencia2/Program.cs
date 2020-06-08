using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ValorPorReferencia2
{
    class Program
    {
        static void Main(string[] args)
        {
            var TipoAnonimo = new { Cantidad = 100, Mensaje = "Cien" }; // Ejemplo de variable anonima

            ArregloNumeros Arreglo = new ArregloNumeros();
            Console.WriteLine("Secuendia de digitos: " + Arreglo.Cadena());

            int Numero = 80;
            ref int RefNumero = ref Arreglo.BuscarNumeros(Numero);
            RefNumero *= 2;
            Console.WriteLine("Números Mutiplicados: " + Arreglo.Cadena());
            Console.WriteLine(TipoAnonimo.Cantidad + " " + TipoAnonimo.Mensaje); // Lllamada ala variable anonima

        }
    }

    public class ArregloNumeros
    {
        int[] Numeros = { 12, 51, 22, 54, 84, 23 };

        public  ref int BuscarNumeros(int Num)
        {
            for (int i = 0; i <= Numeros.Length; i++)
            {
                if (Numeros[i] >= Num)
                {
                    return ref Numeros[i];
                }

            }
            return ref Numeros[0];
        }

        public string Cadena()
        {
            return string.Join(" ", Numeros);
        }
    }
}
