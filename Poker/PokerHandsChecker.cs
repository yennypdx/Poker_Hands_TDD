using System;
using System.Linq;

namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        public bool IsValidHand(IHand hand)
        {
            bool valid = true;
            int counter = 0;
            foreach(Card c in hand.Cards) {
                counter++;
            }
                if(counter != 5) {
                    valid = false;
                }
            return valid;
        }

        public bool IsRoyal(IHand hand)
        {
            bool valid = true;
            if (hand.Equals(CardFace.Ace) || hand.Equals(CardFace.King)
                || hand.Equals(CardFace.Queen) || hand.Equals(CardFace.Jack)) {
                valid = true;
            }
            return valid;
        }

        public bool IsRoyalFlush(IHand hand)
        {
            bool valid = false;
            if (IsValidHand(hand)) {
                if (IsFlush(hand)) {
                    if (IsStraightFlush(hand)) {
                        if (IsRoyal(hand))
                        {
                            valid = true;
                        }
                    }
                }
            }     
             return valid;
        }

        public bool IsStraightFlush(IHand hand)
        {
            bool valid = true;
            if (IsValidHand(hand))  {
                if (IsStraight(hand))  {
                    if (IsFlush(hand))
                    {
                        valid = true;
                    }
                }
            }
            return valid;
        }

        public bool IsFourOfAKind(IHand hand)
        {
            bool valid = true;
            if (IsValidHand(hand)) {
                if (IsTwoPair(hand)) {
                    if (IsThreeOfAKind(hand))
                    {
                        valid = true;
                    }
                }
            }
            return valid;
        }

        public bool IsFullHouse(IHand hand)
        {
            bool valid = true;
            if (IsValidHand(hand)) {
                if (IsOnePair(hand)) {
                    if (IsTwoPair(hand)) {
                        if (IsThreeOfAKind(hand))
                        {
                            valid = true;
                        }
                    }
                }
            }
            return valid;
        }

        public bool IsFlush(IHand hand)
        {
            bool valid = true;
            int countClubs = 0;
            int countSpades = 0;
            int countDiamond = 0;
            int countHeart = 0;

            if (IsValidHand(hand)) {
                for(int c = 0; c < 5; c++) {
                    if (hand.Equals(CardSuit.Clubs)) {
                        countClubs++;
                    }
                    else if (hand.Equals(CardSuit.Spades)) {
                        countSpades++;
                    }
                    else if (hand.Equals(CardSuit.Diamonds)) {
                        countDiamond++;
                    }
                    else if (hand.Equals(CardSuit.Hearts)) {
                        countHeart++;
                    }
                }
            }

            if (countClubs.Equals(5) || countSpades.Equals(5) ||
                 countDiamond.Equals(5) || countHeart.Equals(5)) {
                valid = true;
            }
            return valid;
        }
        public bool IsStraight(IHand hand)
        {
            return true;
        }
        public bool IsThreeOfAKind(IHand hand)
        {
            var distinctFaces = hand.Cards.Select(card => card.Face).Distinct().ToArray();
            int counter = 0;

            foreach (var distinctItem in distinctFaces) {
                for (int i = 0; i < hand.Cards.Count(); i++) {
                    if (hand.Cards[i].Face.Equals(distinctItem)) {
                        counter++;
                    }

                    if (counter == 3) {
                        return true;
                    }
                }
                counter = 0;
            }
            return false;
        }
        public bool IsTwoPair(IHand hand)
        {
            return true;
        }
        public bool IsOnePair(IHand hand)
        {
            var distinctFaces = hand.Cards.Select(card => card.Face).Distinct().ToArray();
            int counter = 0;
            foreach (var distinctItem in distinctFaces) {
                for (int i = 0; i < hand.Cards.Count(); i++) {
                    if (hand.Cards[i].Face.Equals(distinctItem)) {
                        counter++;
                    }

                    if (counter == 2) {
                        return true;
                    }
                }
                counter = 0;
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
