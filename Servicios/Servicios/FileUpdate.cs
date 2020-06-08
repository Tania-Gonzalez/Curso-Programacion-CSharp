using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;
using System.IO;

namespace Servicios
{
    class FileUpdate
    {
        private readonly Timer Temporizador;

        public FileUpdate()
        {
            Temporizador = new Timer(10000);
            Temporizador.AutoReset = true;
            Temporizador.Elapsed += Timer_Elapsed;

        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            string[] Lines = new string[] { DateTime.Now.ToString() };
            File.AppendAllLines(@"C:\\Users\\CruzG\\Desktop\\MEGA\\FileUpdate.txt", Lines);
        }

        public void Start()
        {
            Temporizador.Start();
        }

        public void Stop()
        {
            Temporizador.Stop();
        }
    }
}
