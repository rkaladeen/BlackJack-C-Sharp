using System;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            Player john = new Player("John");
            deck.shuffle();
            Console.WriteLine(john.draw(deck.deal()).Show());
            Console.WriteLine(john.draw(deck.deal()).Show());
            Console.WriteLine(john.draw(deck.deal()).Show());
            Console.WriteLine(john.draw(deck.deal()).Show());
            Console.WriteLine(john.draw(deck.deal()).Show());

            Console.WriteLine("Cards Below have been discarded");
            Console.WriteLine(john.discard(1).Show());

            Console.WriteLine("[{0}]", string.Join(", ", john.showHand()));

            // Console.WriteLine(first.deal().Show());
            // first.reset();
            // Console.WriteLine(deck.deal().Show());

        }
    }
}
