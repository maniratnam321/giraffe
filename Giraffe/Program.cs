using System;

namespace Giraffe
{
    class Program
    {
        private const string PrintMessage = "Hello World";

        static void Main(string[] args)
        {
            string test = PrintMessage;
            Console.WriteLine(test.IndexOf('z'));

        }
    }
}
