using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores_Ejercicio
{
     class Program
     {
         static void Main(string[] args)
         {

            Color colores = new Color(); // Objeto de la clase 

            colores.R = 500;
            colores.G = 1000;
            colores.B = 800;


            Console.WriteLine("({0}, {1}, {2})", colores.R, colores.G, colores.B);
            Console.ReadKey();
         }
     }

        public class Color    // Clase
        {

            private int r;  //Campos
            private int g;
            private int b;


            public int R  //Propiedad pública
            {

                
                set
                {
                    if (r <= 255)
                    {

                        r = value;
                    }
                    else
                    {
                        r = 255;
                    }
                }
                get { return r; }

        }
            public int G  //Propiedad pública
            {
                get { return g; }
                set
                {
                    if (g <= 255)
                    {

                        g = value;
                    }
                    else
                    {
                        g = 255;
                    }
                }
            }
            public int B //Propiedad pública
            {
                get { return b; }
                set
                {
                    if (b <= 255)
                    {

                        b = value;
                    }
                    else
                    {
                        b = 255;
                    }
                }
            }

        }
}
