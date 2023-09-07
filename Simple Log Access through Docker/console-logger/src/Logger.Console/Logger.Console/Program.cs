using System;
using System.Diagnostics;

// Basic .NET application, trying to print the logs from the standard output stream, as well as the standard error stream.
// I am going to parse those logs and send them to the Docker Logging so it will be shown in the console on "docker logs" command, which usually does not appear because the logs are
// inside the container, but not surfaced to the Docker Image
namespace Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            Console.WriteLine("stdout print");
            Console.Error.WriteLine("stderr print");
            Debug.WriteLine("debug print");

            Console.WriteLine("Finish");
        }
    }
}
