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
            foreach (Card c in hand.Cards) {
                counter++;
            }
            if (counter != 5) {
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
                    if (IsStraight(hand)) {
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
            if (IsValidHand(hand)) {
                if (IsStraight(hand)) {
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
                if (IsThreeOfAKind(hand)) {
                    if (IsTwoPair(hand))
                    {
                        valid = true;
                    }
                }
            }
            return valid;
        }

        public bool IsFullHouse(IHand hand)
        {
            bool valid = false;
            if (IsValidHand(hand)) {
                if (IsThreeOfAKind(hand)) {
                    if (IsOnePair(hand))
                    {
                        valid = true;
                    }
                }
            }
            return valid;
        }

        public bool IsFlush(IHand hand)
        {
            bool valid = false;
            int countClubs = 0;
            int countSpades = 0;
            int countDiamond = 0;
            int countHeart = 0;

            if (IsValidHand(hand)) {
                for (int i = 0; i < 5; i++)
                {
                    if (hand.Cards[i].Suit.Equals(CardSuit.Clubs)) {
                        countClubs++;
                    }
                    else if (hand.Cards[i].Suit.Equals(CardSuit.Spades)) {
                        countSpades++;
                    }
                    else if (hand.Cards[i].Suit.Equals(CardSuit.Diamonds)) {
                        countDiamond++;
                    }
                    else if (hand.Cards[i].Suit.Equals(CardSuit.Hearts)) {
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
            var isThereAnAce = false;
            var handList = hand.Cards.OrderBy(card => card.Face).ToList();
            var isItStraight = true;

            //this is for considering Ace to be a possible lowest card in the straight
            //generate a list of all the aces
            var contains = handList.Where(card => card.Face == CardFace.Ace).ToList();

            if (contains.Count() > 0)
            {
                isThereAnAce = true;
                handList.Remove(contains[0]);
            }

            for (int i = 0; i < handList.Count() - 1; i++)
            {
                if ((handList[i + 1].Face) - (handList[i].Face) == 1)
                {
                    continue;
                }
                else
                {
                    isItStraight = false;
                    break;
                }
            }

            //straight hands with ace as 1 will have its lowest element as 2
            if (isThereAnAce && isItStraight)
            {
                if (Convert.ToInt16(handList.First().Face) != 2 &&
                    Convert.ToInt16(handList.Last().Face) != 13)
                {
                    isItStraight = false;   
                }
            }
            return isItStraight;
        }
        public bool IsThreeOfAKind(IHand hand)
        {
            var distinctFaces = hand.Cards.Select(card => card.Face).Distinct().ToArray();

            int counter = 0;

            foreach (var distinctItem in distinctFaces)
            {
                for (int i = 0; i < hand.Cards.Count(); i++)
                {

                    if (hand.Cards[i].Face.Equals(distinctItem))
                    {
                        counter++;
                    }

                    if (counter == 3)
                    {
                        return true;
                    }

                }
                counter = 0;
            }

            return false;
            throw new NotImplementedException();
        }
        public bool IsTwoPair(IHand hand)
        {
            var handList = hand.Cards.OrderBy(card => card.Face).ToList();

            int counterFirstPair = 0;
            int counterSecondPair = 0;

            for (int i = 0; i < handList.Count() - 1; i++)
            {

                if (handList[i].Face.Equals(handList[i + 1].Face))
                {
                    counterFirstPair++;
                    handList.RemoveAt(i);
                    handList.RemoveAt(i);
                    break;
                }
            }

            for (int i = 0; i < handList.Count() - 1; i++)
            {
                if (handList[i].Face.Equals(handList[i + 1].Face))
                {
                    counterSecondPair++;
                    handList.RemoveAt(i);
                    handList.RemoveAt(i);
                    break;
                }
            }

            if ((counterFirstPair == 1) && (counterSecondPair == 1))
            {
                return true;
            }

            return false;

            throw new NotImplementedException();

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

                    if (counter == 2)
                    {
                        return true;
                    }

                }
                counter = 0;
            }

            return false;
        }

        public bool IsHighCard(IHand hand)
        {
            //if the number of distinct faces is 5, if it's not a straight (no ranks in order), 
            //and it's not a flush (not all the same suit)
            if (!(IsStraight(hand)))
            {
                if (!(IsFlush(hand)))
                {

                    var distinctFaces = hand.Cards.Select(card => card.Face).Distinct().ToArray().Length;

                    if (distinctFaces == 5)
                    {
                        return true;
                    }
                }

            }

            //else false
            return false;
        }
        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            var resultOfFirstHand = HandNumber(firstHand);
            var resultOfSecondHand = HandNumber(firstHand);
            var resultOfComparison = default(int);

            if (resultOfFirstHand < resultOfSecondHand) {
                resultOfComparison = -1;
            } else if (resultOfFirstHand > resultOfSecondHand) {
                resultOfComparison = 1;
            } else {
                resultOfComparison = 0;
            }
            return resultOfComparison;
        }

        public int HandNumber(IHand hand) {

           var handNum = default(int);

            if (IsRoyalFlush(hand)) {
                handNum = 9;
            } else if (IsStraightFlush(hand)) {
                handNum = 8;
            } else if (IsFourOfAKind(hand)) {
                handNum = 7;
            } else if (IsFullHouse(hand)) {
                handNum = 6;
            } else if (IsFlush(hand)) {
                handNum = 5;
            } else if (IsStraight(hand)) {
                handNum = 4;
            } else if (IsThreeOfAKind(hand)) {
                handNum = 3;
            } else if (IsTwoPair(hand)) {
                handNum = 2;
            } else if (IsOnePair(hand)) {
                handNum = 1;
            } else {
                handNum = 0;
            }
            return handNum;
        }
    }
}
