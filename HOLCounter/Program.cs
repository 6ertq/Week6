using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args){

            string phrase = "Hello World!";
            string phraseToLower = phrase.ToLower();

            int hCounter = 0;
            int lCounter = 0;
            int oCounter = 0;

            for (int i = 0; i < phrase.Length; i++){
                if (phraseToLower[i] == 'h'){
                    hCounter++;
                }

                if (phraseToLower[i] == 'l'){
                    lCounter++;
                }

                if (phraseToLower[i] == 'o'){
                    oCounter++;
                }
            }

            Console.WriteLine($"The phrase {phrase} has {hCounter} h letter(s), " +
                $"{lCounter} l letter(s) and {oCounter} o letter(s).");
        }
    }
}
