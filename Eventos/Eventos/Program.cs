using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Eventos
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo C1 = new Circulo(54);
            Circulo C2 = new Circulo(88);

            C1.CirculoCambio += ManejadorCirculoCambio;
            C2.CirculoCambio += ManejadorCirculoCambio;

            C1.Dibujo();
            C2.Dibujo();

            C1.Actualizar(57);
            C2.Actualizar(94);

            Console.ReadKey();



        }

        public static void ManejadorCirculoCambio(object sender, CirculoEventArgs AreaCambio)
        {
            Circulo s = (Circulo)sender;
            Console.WriteLine("Nuevo evento, el área dl circulo ahora es de: {0}", AreaCambio.NuevaArea);
            s.Dibujo();
        }
    }




    public class Circulo
    {

        public double radio; // Campo
        public double area { get; set; } // Propiedad
        public  Circulo(double rad) // Cosntructor
        {
            radio = rad;
            area = 3.14 * radio * radio;

        }
        public void Actualizar(double rad)
        {
            radio = rad;
            area = 3.14 * radio * radio;
            OnCirculoCambio(new CirculoEventArgs(area));
        }
    
        public void Dibujo() //Constructor
        {

            Console.WriteLine("Dibujando un circulo");
        }



        public event EventHandler<CirculoEventArgs> CirculoCambio;

        protected void OnCirculoCambio(CirculoEventArgs AreaCambio)
        {
            EventHandler<CirculoEventArgs> Manejador = CirculoCambio;

            if (Manejador != null)
            {
                Manejador(this, AreaCambio);
            }
        }
        
    } 

    public class CirculoEventArgs:EventArgs
    {
        public double NuevaArea { get; set; }
        public CirculoEventArgs(double rad)
        {
            NuevaArea = rad; 
        }
    }
}
