using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Intefaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Tanque tanque = new Tanque();

            Validar1(tanque);
            Validar2(tanque);

            int x = 30;

            tanque.Acelerar(x);
            tanque.Disparar();
            tanque.Apuntar();

            Console.ReadKey();

        }


        static void Validar1(IVehiculo a)
        {
            Console.WriteLine("Esto es un vehiculo");
        }

        static void Validar2(IArmaDeGuerra a)
        {
            Console.WriteLine("Esta es un arma de guerra");
        }

    }


    interface IVehiculo
    {
        void Acelerar(int Km);
        void Frenar();
        void Girar(int angulos);
    } 

    interface IArmaDeGuerra
    { 
        void Apuntar();
        void Disparar();
    }

    class Tanque : IVehiculo, IArmaDeGuerra
    {
        public void Acelerar(int Km) { Console.WriteLine("Tanque acelerando a {0}", Km); }
        public void Frenar() { Console.WriteLine("Tanque frenando"); }
        public void Girar(int angulos) { Console.WriteLine("Girando a {0}", angulos); }

        public void Apuntar() { Console.WriteLine("Tanque apuntando"); }
        public void Disparar() {Console.WriteLine("Tanque disparando"); }
    }
}
