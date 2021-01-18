using System;
using System.IO;
using System.Threading;

namespace HilosPool
{
    class Program
    {
        const string path = @"C:\Users\Administrador\source\repos\Thread\";
        private static bool ejecutar = true;
        private static int conteo = 0;
        static void Main(string[] args)
        {


            static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem(Incremento, 1000);

            Thread.Sleep(1000);

            Console.WriteLine("El conteo final es {0}", conteo);

        }

        
        static void Incremento(object dato)
        {
            var limite = (int)dato;

            while (ejecutar)
            {
                conteo = conteo + 1;
                Console.Write(Thread.CurrentThread.ManagedThreadId);
                Console.WriteLine(" -> {0} ", conteo);

                if(conteo > limite)
                {
                    ejecutar = false;
                }
            }

        }
    }
}
