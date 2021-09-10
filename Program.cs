using System;
using Sharpway.JavaScript; 

namespace Sharpway
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(JSParser.Parse(@"
                println<Error>('tst')
            "));
        }
    }
}