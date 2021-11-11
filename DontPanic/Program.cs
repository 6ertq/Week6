using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "Don't panic!";

            phrase = phrase.ToLower().Replace('o','0');
            phrase = phrase.ToLower().Replace('a','4');

            Console.Write(phrase);
        }
    }
}
