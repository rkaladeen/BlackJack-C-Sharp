using System;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck first = new Deck();
            // first.shuffle();
            // Console.WriteLine(first.deal().Show());

            // first.reset();
            Console.WriteLine(first.deal().Show());

        }
    }
}
