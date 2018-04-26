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
            var builder = new StringBuilder();
            for (int i = 0; i < this.Cards.Count; i++)
            {
                builder.Append(Cards[i] + "\r\n");
            }

            return builder.ToString();
        }
        //still need to do this
        public override int GetHashCode()
        {
            var hashCode = 0;
            return hashCode;
        }

    }
}
