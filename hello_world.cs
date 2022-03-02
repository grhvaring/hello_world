using System;

namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            var who = "World";
            if (args.Length > 1) who = args[1];
            Console.WriteLine("Hello {0}!", who);
        }
    }
}