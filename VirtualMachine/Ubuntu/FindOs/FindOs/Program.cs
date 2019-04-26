using System;

namespace FindOs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find your machine's OS (press a key)");
            Console.ReadLine();
            Console.WriteLine(Environment.OSVersion.Platform);

            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
    }
}
