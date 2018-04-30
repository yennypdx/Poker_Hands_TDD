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
            var handArray = hand.Cards.Select(card => card.Face).ToArray();
            bool valid = false;

            foreach (var c in handArray)
            {
                if (c.Equals(CardFace.Ace)) { valid = true; }
                else if (c.Equals(CardFace.King)) { valid = true; }
                else if (c.Equals(CardFace.Queen)) { valid = true; }
                else if (c.Equals(CardFace.Jack)) { valid = true; }
                else if (c.Equals(CardFace.Ten)) { valid = true; }
                else { valid = false; }
            }
            return valid;
        }

        public bool IsRoyalFlush(IHand hand)
        {
            bool valid = false;
            if (IsValidHand(hand)) {
                if (IsRoyal(hand)) {
                    if (IsStraightFlush(hand)) {
                         valid = true;
                    }
                }
            }
            return valid;
        }

        public bool IsStraightFlush(IHand hand)
        {
            bool valid = false;

            if (IsValidHand(hand)) {
                if (IsStraight(hand)) {
                    if (IsFlush(hand)) {
                        valid = true;
                    }
                }
            }
            return valid;
        }

        public bool IsFourOfAKind(IHand hand)
        {
            bool valid = false;
            if (IsValidHand(hand)) {
                if (IsTwoPair(hand)) {
                    if (IsThreeOfAKind(hand)) {
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
                if (IsOnePair(hand)) {
                    if (IsTwoPair(hand)) {
                        if (IsThreeOfAKind(hand)) {
                            valid = true;
                        }
                    }
                }
            }
            return valid;
        }

        public bool IsFlush(IHand hand)
        {
            bool validFlush = false;
            var groupSuits = hand.Cards.GroupBy(card => card.Suit);

            foreach(var set in groupSuits) {
                if (set.Count().Equals(5)) {
                    validFlush = true;
                }
            }
            return validFlush;
        }
        public bool IsStraight(IHand hand)
        {
            bool validStraight = false;
            var handSorted = hand.Cards.OrderByDescending(card => card.Face).ToList();
            var handDistinctSorted = handSorted.Distinct().ToList();

            if (IsValidHand(hand)) {
                if (handDistinctSorted.Count().Equals(5)) {
                    for (var i = 0; i < handDistinctSorted.Count(); i++) {
                        if (handDistinctSorted.First().Face.Equals(CardFace.Ace) && handDistinctSorted.Last().Face.Equals(CardFace.Ten))
                            validStraight = true;
                        else if (handDistinctSorted.First().Face.Equals(CardFace.King) && handDistinctSorted.Last().Face.Equals(CardFace.Nine))
                            validStraight = true;
                        else if (handDistinctSorted.First().Face.Equals(CardFace.Queen) && handDistinctSorted.Last().Face.Equals(CardFace.Eight))
                            validStraight = true;
                        else if (handDistinctSorted.First().Face.Equals(CardFace.Jack) && handDistinctSorted.Last().Face.Equals(CardFace.Seven))
                            validStraight = true;
                        else if (handDistinctSorted.First().Face.Equals(CardFace.Ten) && handDistinctSorted.Last().Face.Equals(CardFace.Six))
                            validStraight = true;
                        else if (handDistinctSorted.First().Face.Equals(CardFace.Nine) && handDistinctSorted.Last().Face.Equals(CardFace.Five))
                            validStraight = true;
                        else if (handDistinctSorted.First().Face.Equals(CardFace.Eight) && handDistinctSorted.Last().Face.Equals(CardFace.Four))
                            validStraight = true;
                        else if (handDistinctSorted.First().Face.Equals(CardFace.Seven) && handDistinctSorted.Last().Face.Equals(CardFace.Three))
                            validStraight = true;
                        else if (handDistinctSorted.First().Face.Equals(CardFace.Six) && handDistinctSorted.Last().Face.Equals(CardFace.Two))
                            validStraight = true;
                        else if (handDistinctSorted.First().Face.Equals(CardFace.Five) && handDistinctSorted.Last().Face.Equals(CardFace.Ace))
                            validStraight = true;
                        else
                            validStraight = false;
                    }
                }
            }
            return validStraight;
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
