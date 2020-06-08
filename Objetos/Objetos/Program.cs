using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{

    class Program
    {
        static void Main(string[] args)
        {

            Person Persona1 = new Person();

            Persona1.Name = "Tania";
            Persona1.Age = 24;

            Console.WriteLine("Name = {0}  Age= {1}", Persona1.Name, Persona1.Age);

            Person Persona2 = Persona1;
            Persona2.Name = "Paola";
            Persona2.Age = 23;


            // Imprimen los mismos dstos ya que los objetos apuntan al mismo bloque de memoria, cuando se cambia el vaor se cambia el valor para todos los
            //   objetos que apunten a ese bloque de memoria

            Console.WriteLine("Name = {0}  Age= {1}", Persona2.Name, Persona2.Age);

            Console.WriteLine("Name = {0}  Age= {1}", Persona1.Name, Persona1.Age);


            Console.ReadKey();
        }
    }

    public struct Person {  // El modificador struct copia el valr en un espacio de memoria difefrente para cada objeto creado a partir del la clase
        // en comparación del modificador class que asiga los valores en el mismo espacio de memoria

        public string Name;
        public int Age;
    

    }
    
    

}
