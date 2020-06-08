using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegadoMultidifusion
{
    class Program
    {
        static void Main(string[] args)
        {
            Delegado Objnombre1, Objnombre2, Objnombre3;

            Objnombre1 = Hello;
            Objnombre2 = GoodBye;
            Objnombre3 = Objnombre1 + Objnombre2;

            Objnombre1("Tania");
            Objnombre2("Paola");


        }


        static void Hello(string Nombre)
        {
            Console.WriteLine("Hello {0}", Nombre);
        }
        static void GoodBye(string Nombre)
        {
            Console.WriteLine("GooBye {0}", Nombre);
        }


    }


    public delegate void Delegado(string M);
}
