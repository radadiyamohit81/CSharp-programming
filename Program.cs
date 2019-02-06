using System;
namespace CommandLineArgument
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (String arg in Environment.GetCommandLineArgs())
            {
                Console.Write(arg);
            }
        }
    }
}
