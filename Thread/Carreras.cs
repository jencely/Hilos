using System;
using System.Threading;

namespace Hilos
{
    class Carreras
    {
        public static void Corredor()
        {
            var nombre = (string)obj;
            _ = Thread.CurrentThread;
            var pasos = 0;
            var random = new Random();

            while (pasos < 10000)
            {
                pasos += random.Next(0, 4);
                Console.WriteLine("El corredor {1} dio tantos {1} pasos",nombre, pasos);
                Thread.Sleep(10);
            }
            Console.WriteLine("El corredor {0} llego a la meta", nombre);
        }
    }
}
