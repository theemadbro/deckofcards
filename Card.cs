namespace deckofcards
{
    public class Card
    {
        public string StringVal;
        public string Suit;
        public int Val;

        public Card(string strval, string suit, int val)
        {
            this.StringVal = strval;
            this.Suit = suit;
            this.Val = val;
        }
    }
}