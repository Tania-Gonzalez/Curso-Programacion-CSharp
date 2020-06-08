using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace Servicios
{
    class Program
    {
        static void Main(string[] args)
        {
            FileUpdate Servicio = new FileUpdate();
            var Salida =HostFactory.Run(front =>
            {
                //Ulizar los metodos de la paquetría par amandarl al administrador de servicios las
                //Variables necesarias para llenar la tabla de información

                front.RunAsLocalSystem();
                front.SetServiceName("FileUpdate");
                front.SetDisplayName("FileUpdate Services");
                front.SetDescription("Servicio local de actualización de fecha y hora");

                front.Service<FileUpdate>(back => {

                    back.ConstructUsing(service => new FileUpdate());
                    back.WhenStarted(service => Servicio.Start());
                    back.WhenStopped(service => Servicio.Stop()); ;

                
                });
            });

            int ValorSalida = (int)Convert.ChangeType(Salida, Salida.GetTypeCode());

            Environment.ExitCode = ValorSalida;
        }
    }
}
