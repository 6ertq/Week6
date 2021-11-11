using System;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            string[] predictions = { "win a million", "fall in love", 
                "buy youtube premium", "join the darkside for cookies"};

            Console.WriteLine("Tomorrow you will " + predictions[rnd.Next(0,predictions.Length)]);
        }
    }
}
