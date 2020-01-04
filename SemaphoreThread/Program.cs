using System;
using System.Threading;

namespace SemaphoreThread
{
    class Program
    {

        public static SemaphoreSlim SemaphoreSlim = new SemaphoreSlim(6);
        static void Main(string[] args)
        {
            Console.WriteLine("Otoparka Hoşgeldiniz!");

            for (int i = 1; i <= 10; i++)
            {
                new Thread(EnterThePark).Start(i);


            }

            Console.ReadLine();
        }

        public static void EnterThePark(object id)
        {
            Console.WriteLine(id + " kuyrukta");
            SemaphoreSlim.Wait();
            Console.WriteLine(id + " park etti");
            Thread.Sleep(1000 * (int)id);
            Console.WriteLine(id + " ayrılıyor");
            SemaphoreSlim.Release();

        }
        


       
    }
}
