using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Forma Forma1 = new Forma();
            Circulo Forma2 = new Circulo();
            Rectangulo Forma3 = new Rectangulo();

            Forma1.Dibjar();
            Forma2.Dibjar();
            Forma3.Dibjar();

            Console.ReadKey();
        }

        public class Forma {

            public virtual void Dibjar(){

                Console.WriteLine("Una Forma");
            }
        }

        public class Circulo:Forma
        {
            public override void Dibjar()
            {
                Console.WriteLine("Forma Circulo");
                base.Dibjar();

            }

        }
        public class Rectangulo : Forma
        {
            public override void Dibjar()
            {
                Console.WriteLine("Forma Rectangulo");
                base.Dibjar();
            }


        }

    }
}
