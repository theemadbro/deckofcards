using System;
using System.Collections.Generic;
namespace deckofcards
{
    public class Player
    {
        public string Name = "Player";
        public List<Card> Hand = new List<Card>();

        public Player(string name)
        {
            this.Name = name;
        }
        public Card draw(Deck cards)
        {
            Card trg = cards.deal();
            this.Hand.Add(trg);
            return trg;
        }
        public Card discard(int idx)
        {
            if(idx > Hand.Count-1)
            {
                return null;
            }
            else
            {
                Card trg = Hand[idx];
                Hand.RemoveAt(idx);
                return trg;
            }
        }
    }
}