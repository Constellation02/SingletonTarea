using System;

namespace SingletonTarea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Singleton.Instance.mensaje);

            Console.WriteLine(Singleton.Instance.mensaje);
        }
    }
}
