using System;
using System.Collections.Generic;
namespace deckofcards
{
    public class Deck
    {
        public List<Card> cards = new List<Card>();
        public List<Card> outlist = new List<Card>();
        
        public Deck()
        {
            string[] stringval = {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};
            int[] val = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13};
            string[] suits = {"Clubs", "Spades", "Hearts", "Diamonds"};
            int count = 0;
            for (int i=0; i<suits.Length; i++)
            {
                for (int x=0; x<val.Length; x++)
                {
                    cards.Add(new Card(stringval[x], suits[i], val[x]));
                    count++;
                }
            }

        }
            public Card deal()
            {
                Card trg = cards[0];
                outlist.Add(cards[0]);
                cards.RemoveAt(0);
                return trg;
            }
            public void shuffle()
            {
                reset();
                Random rand = new Random();
                for (int i=0; i<cards.Count; i++)
                {
                    Card temp = cards[i];
                    int x = rand.Next(0, cards.Count);
                    cards[i] = cards[x];
                    cards[x] = temp;
                }
            }
            public void reset()
            {
                for (int i=outlist.Count-1; i>=0; i--)
                {
                    cards.Add(outlist[i]);
                    outlist.Remove(outlist[i]);
                }
            }
    }
}