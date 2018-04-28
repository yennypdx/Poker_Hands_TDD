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
        //still need to do this
        public override int GetHashCode()
        {
            var hashCode = 0;
            return hashCode;
        }

    }
}
