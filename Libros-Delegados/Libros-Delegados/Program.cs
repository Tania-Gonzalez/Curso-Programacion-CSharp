using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libros_Delegados
{
    public delegate void DelegadoProcesarLibro(Libro libro);
    class Program
    {
        static void Main(string[] args)
        {
            LibrosDB ObjLibroDB = new LibrosDB();

            InsertarLibros(ObjLibroDB);
            Console.WriteLine("Titulos de los libros con portada de papel");

            ObjLibroDB.MetProcesarPortada(ImprimirTitulo);
        }

        static void ImprimirTitulo(Libro TituloLibro)
        {
            Console.WriteLine("Titulo del libro: "+ TituloLibro.Titulo);

        }

        static void InsertarLibros(LibrosDB Libro)
        {
            Libro.AgrgarLibros("Libro 1","Auto 1",1200,false);
            Libro.AgrgarLibros("Libro 2", "Auto 2", 800, true);
            Libro.AgrgarLibros("Libro 3", "Auto 3", 900, false);
            Libro.AgrgarLibros("Libro 4", "Auto 4", 500, true);

        }


    }



}
