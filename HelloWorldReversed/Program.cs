using System;

namespace HelloWorldReversed
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "Hello World!";

            for (int i = phrase.Length - 1; i >= 0; i--)
            {
                Console.Write(phrase[i]);
            }
        }
    }
}
