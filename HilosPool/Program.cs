using System;
using System.IO;
using System.Threading;

namespace HilosPool
{
    class Program
    {
        const string path = @"C:\Users\Administrador\source\repos\Thread\";
        private static bool ejecutar = true;
        static void Main(string[] args)
        {


            var m = 0;
            var x = 0;

            for (x = 0; x < 8; x++)
            {
                Thread miHilo = new Thread(Mensaje_M);
                miHilo.Start(x);
            }

            while (ejecutar)
            {
                Console.WriteLine("Saludos desde el hilo principal{0}", m);
                m++;
                if (m == 250000)
                    ejecutar = false;
            }
        }
        static void Mensaje()
        {
            var n = 0;
            while (ejecutar)
            {
                Console.WriteLine("Saludos dese el hilo {0}", n);
                n++;
            }

        }
        static void Mensaje_M(object o)
        {
            var n = 0;
            while (ejecutar)
            {
                Console.WriteLine("Saludos desde el hilo {0} - {1}", o, n);
                n++;
            }
        }
    }
}
