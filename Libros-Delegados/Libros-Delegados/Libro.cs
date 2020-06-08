using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libros_Delegados
{

    public class Libro
    {

        public string Titulo;
        public string Autor;
        public double Precio;
        public bool PortadaPapel;

        public Libro(string titulo, string autor, double precio, bool portada)
        {
            Titulo = titulo;
            Autor = autor;
            Precio = precio;
            PortadaPapel = portada;


        }
    }
}
