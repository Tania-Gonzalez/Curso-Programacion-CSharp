using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Estatica
{
    class Program
    {
        static void Main(string[] args)
        {

            Empleado a = new Empleado("Tania","EJLUIVJYEW");
            Empleado b = new Empleado("Paola", "EJLUIVJYEW");
            Empleado c = new Empleado("Cruz", "EJLUIVJYEW");

            Console.WriteLine("Número de empleados: {0}", Empleado.ContadorEmpleado);
            Console.ReadLine();


        }
    }

    public class Empleado
    {

        public string id;
        public string Nombre;
        public static int ContadorEmpleado;

        public Empleado(string Nombre, string id)
        {

            this.Nombre = Nombre;
            this.id = id;
            ContadorEmpleado++;

        }

    }
}
