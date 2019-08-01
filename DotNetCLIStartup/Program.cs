using System;

namespace DotNetCLIStartup
{
    /// <summary>
    /// The sole purpose of this project is to serve as a runtime for the dotnet CLI
    /// due to the unique way how Xamarn works. 
    /// See url: https://docs.microsoft.com/en-gb/ef/core/miscellaneous/cli/dotnet#other-target-frameworks
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
