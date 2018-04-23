using System.Text;
using System.Collections.Generic;

namespace Poker
{
    public class Hand : IHand
    {
        public IList<ICard> Cards { get; private set; }

        public Hand(IList<ICard> cards)
        {
            this.Cards = cards;
        }

        public override string ToString()  
        {
            var builder = new StringBuilder();
            builder.Append(Cards);

            return builder.ToString();
        }
    }
}
