using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campos_Propiedades_Constructores
{
    class Program
    {
        static void Main(string[] args)
        {

            Color colores = new Color(400,300, 450); // Objeto de la clase 

 
            Console.WriteLine("({0}, {1}, {2})",colores.R, colores.G, colores.B);
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

            get { return r; }
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

        public Color(int Red, int Green, int Blue)
        {

            R = Red;
            G = Green;
            B = Blue;

        }
    }
}
