 using System;

namespace Singleton
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
