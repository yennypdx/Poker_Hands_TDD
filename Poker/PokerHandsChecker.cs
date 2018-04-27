using System;

namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        public bool IsValidHand(IHand hand)
        {
            //to be valid a hand should have 5 cards
            //bool status = false;
            //throw new NotImplementedException();
            return false;

        }
        public bool IsRoyalFlush(IHand hand)
        {
            throw new NotImplementedException();
        }
        public bool IsStraightFlush(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFourOfAKind(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFullHouse(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFlush(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsStraight(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsTwoPair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsOnePair(IHand hand)
        {
            
            foreach (var cards in hand.Cards) {
                //check the list agaist itself
                foreach (var cardsCheck in hand.Cards) {
                    if (!(hand.Equals(hand.Cards[1]))) && ()) {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool IsHighCard(IHand hand)
        {
            if (IsValidHand(hand)) {
                if (!(IsFlush(hand))) {
                    if (!(IsStraight(hand))) {
                        if (!(IsOnePair(hand))) {
                            return true;
                        }
                    }
                }
            }
            //else false
            return false;
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            //decide whether we should do the extra work of comparing 
            //hands of equal 'rank'

            throw new NotImplementedException();
        }
    }
}
