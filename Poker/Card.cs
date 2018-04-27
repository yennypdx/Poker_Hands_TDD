using System.Text;

namespace Poker
{
    public class Card : ICard
    {
        public CardFace Face { get; set; }
        public CardSuit Suit { get; set; }

        public Card(CardFace face, CardSuit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

        public override string ToString() 
        {
            var builder = new StringBuilder();
            builder.Append(Face + "|" + Suit);

            return builder.ToString();
        }

        public override bool Equals(object obj)
        {
            var card = obj as Card;
            if ((this.Face == card.Face) && (this.Suit == card.Suit))
            {
                return true;
            }

            return false;
        }
        public override int GetHashCode()
        {
            var intValOfFace = (int)this.Face;
            var intValOfSuit = (int)this.Suit;
            var hashCode = intValOfFace + intValOfSuit;

            return hashCode;
        }
    }
}
