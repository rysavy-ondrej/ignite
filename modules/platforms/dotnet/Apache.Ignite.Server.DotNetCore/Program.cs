using Apache.Ignite.Core;
using System;

namespace Apache.Ignite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running Ignite Server");
            IgniteRunner.Run(args);
        }
    }
}
