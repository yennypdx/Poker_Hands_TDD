using System.Text;
using System.Collections.Generic;

namespace Poker
{
    public class Hand : IHand
    {
        public IList<ICard> Cards { get; set; }

        public Hand(IList<ICard> cards)
        {
            this.Cards = cards;
        }

        public override string ToString()  
        {
            string outString = "";
            foreach(Card c in Cards)
            {
                outString += c + " ";
            }
            return outString;
        }
       public override int GetHashCode()
        {
            var hashCode = Convert.ToInt32(this.Cards[0].Face) + 
                Convert.ToInt32(this.Cards[1].Face) + Convert.ToInt32(this.Cards[2].Face) +
                Convert.ToInt32(this.Cards[3].Face) + Convert.ToInt32(this.Cards[4].Face) +
                Convert.ToInt32(this.Cards[0].Suit) + Convert.ToInt32(this.Cards[1].Suit) + 
                Convert.ToInt32(this.Cards[2].Suit) + Convert.ToInt32(this.Cards[3].Suit) +
                Convert.ToInt32(this.Cards[4].Suit);

            return hashCode;
        }
       /* public override bool Equals(object obj)
        {
            var hand = obj as Hand;

            if ((this.Hand == hand.Cards.CardFace))
            {
                return true;
            }

            return false;
        }
        */
    }
}
