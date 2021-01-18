using System;
using System.Threading;

namespace Hilos
{
    class Program
    {
        static void Main(string[] args)
        { /*
            Console.WriteLine("Hello World!");
            Thread hilo_1 = new Thread(MetodoAEjecutar);
            Thread hilo_2 = new Thread(MetodoAEjecutar);
            Console.WriteLine("Voy a ejecutar el hilo 1"); //ejecutando hilo 1
            hilo_1.Start(); 
            Console.WriteLine("Voy a ejecutar el hilo 2"); //ejecutando hilo 2
            hilo_1.Start();

            Thread.Sleep(1000);//500 medio segundo - 1000 1 segundo
            Console.WriteLine("La cultura del hilo principal es : {0}", Thread.CurrentCulture);

            Console.WriteLine("El hilo uno se junta");
            hilo_1.Join();//Join retorna al hilo principal
            
            Console.WriteLine("El hilo dos se junta");
            hilo_1.Join();//Join retorna al hilo principal
            
        }*/
            Thread corredor_1 = new Thread(Carreras.Corredor); //
            Thread corredor_2 = new Thread(Carreras.Corredor);
            Thread corredor_3 = new Thread(Carreras.Corredor);
            Thread corredor_4 = new Thread(Carreras.Corredor);

            corredor_1.Start("Antony");
            corredor_2.Start("Tania");
            corredor_3.Start("Jose");
            corredor_4.Start("Marcelo");

            corredor_1.Join();
            corredor_2.Join();
            corredor_3.Join();
            corredor_4.Join();
        }

        public static void MetodoAEjecutar()
        {
            //to do: aqui pones tu codigo
            var hilo_actual = Thread.CurrentThread;
            hilo_actual.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            Console.WriteLine("Hilo actual {0}: ", hilo_actual.ManagedThreadId);
            Console.WriteLine("Hilo cultura {0}: ", hilo_actual.CurrentCulture);

            var random = new Random();

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("hilo {0} indice {1}", hilo_actual.ManagedThreadId, i);

                Thread.Sleep(random.Next(100, 500));


            }

        }
    }
    //Simular columnas simulando que sean corredores

    //calculo de una red neuronal
}
