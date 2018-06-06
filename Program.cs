using System;

namespace deckofcards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck game = new Deck();
            game.shuffle();
            Player kevin = new Player("Kevin");
            kevin.draw(game);
            kevin.draw(game);
            kevin.draw(game);
            kevin.discard(0);
            kevin.draw(game);
            kevin.draw(game);
            kevin.draw(game);
            kevin.discard(5);
            kevin.discard(4);
        }
    }
}
