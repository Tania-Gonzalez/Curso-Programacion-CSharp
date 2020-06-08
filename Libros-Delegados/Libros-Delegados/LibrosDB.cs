using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libros_Delegados
{


    public class LibrosDB
    {

        ArrayList ListaLibros = new ArrayList();

        public void AgrgarLibros(string titulo, string autor, double precio, bool portadadepapel)
        {
            ListaLibros.Add(new Libro(titulo,autor,precio,portadadepapel));

        }

        public void MetProcesarPortada(DelegadoProcesarLibro Delegado){

            foreach (Libro b in ListaLibros )
            {
                if (b.PortadaPapel)
                {
                    Delegado(b);
                }
            }
        }


    }
}
