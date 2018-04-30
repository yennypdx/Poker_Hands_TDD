using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Poker;

namespace PokerTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestShouldPassWithFiveCardsInHand()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Diamonds),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsTrue(checker.IsValidHand(hand));
        }

        [TestMethod]
        public void TestShouldFailWithFourCardsInHand()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Spades),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsValidHand(hand));
        }

        [TestMethod]
        public void TestRoyal_ReturnTrueWithRoyalCards()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Clubs),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsTrue(checker.IsRoyal(hand));
        }

        [TestMethod]
        public void TestRoyalFlush_ReturnTrueWithRoyalFlushCards()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Clubs),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsTrue(checker.IsRoyalFlush(hand));
        }

        [TestMethod]
        public void TestRoyalFlush_ReturnFalseWithStraightFlushCards()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Nine, CardSuit.Clubs),
                new Card(CardFace.Eight, CardSuit.Clubs),
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Clubs),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsRoyalFlush(hand));
        }

        [TestMethod]
        public void TestRoyalFlush_ReturnDalseWithFlushCards()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Nine, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Clubs),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsRoyalFlush(hand));
        }

        [TestMethod]
        public void TestStraightFlush_ReturnTrueWithStraightFlushCards()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Nine, CardSuit.Clubs),
                new Card(CardFace.Eight, CardSuit.Clubs),
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Clubs),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsTrue(checker.IsStraightFlush(hand));
        }

        [TestMethod]
        public void TestStraightFlush_ReturnFalseWithFlushCards()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Nine, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Clubs),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsStraightFlush(hand));
        }

        [TestMethod]
        public void TestStraightFlush_ReturnFalseWithStraightCards()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Spades),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsStraightFlush(hand));
        }

        [TestMethod]
        public void TestFourOfAKind_ReturnTrueWithFourOfAKindCards()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Clubs),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsTrue(checker.IsFourOfAKind(hand));
        }

        [TestMethod]
        public void TestFourOfAKind_ReturnFalseWithThreeOfAKindCards()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Hearts),
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Nine, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Clubs),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsFourOfAKind(hand));
        }

       [TestMethod]
        public void TestFullHouse_ReturnTrueWithFullHouseCards()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Clubs),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsTrue(checker.IsFullHouse(hand));
        }

        [TestMethod]
        public void TestFullHouse_ReturnFalseWithThreeOfAKindCards()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Hearts),
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Clubs),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsFullHouse(hand));
        }

        [TestMethod]
        public void TestFullHouse_ReturnFalseWithTwoPairCards()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Diamonds),
                new Card(CardFace.Nine, CardSuit.Clubs),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsFullHouse(hand));
        }

        [TestMethod]
        public void TestFullHouse_ReturnFalseWithOnePairCards()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Eight, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Diamonds),
                new Card(CardFace.Four, CardSuit.Clubs),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsFullHouse(hand));
        }

        [TestMethod]
        public void TestFlush_ReturnTrueWithFlushCards()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Nine, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Clubs),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsTrue(checker.IsFlush(hand));
        }

        [TestMethod]
        public void TestFlush_ReturnTrueWithRoyalFlushCards()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Clubs),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsTrue(checker.IsFlush(hand));
        }

        [TestMethod]
        public void TestFlush_ReturnTrueWithStraightFlushCards()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Nine, CardSuit.Clubs),
                new Card(CardFace.Eight, CardSuit.Clubs),
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Clubs),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsTrue(checker.IsFlush(hand));
        }

        [TestMethod]
        public void TestFlush_ReturnFalseWithStraightCards()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Nine, CardSuit.Clubs),
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Seven, CardSuit.Spades),
                new Card(CardFace.Six, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Spades),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsFlush(hand));
        }

        [TestMethod]
        public void TestStraight_ReturnTrueWithStraightCards()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Nine, CardSuit.Clubs),
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Seven, CardSuit.Spades),
                new Card(CardFace.Six, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Spades),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsTrue(checker.IsStraight(hand));
        }

        [TestMethod]
        public void TestStraight_ReturnTrueWithRoyalFlushCards()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Clubs),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsTrue(checker.IsStraight(hand));
        }

        [TestMethod]
        public void TestStraight_ReturnFalseWithThreeOfAKindCards()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Five, CardSuit.Diamonds),
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Hearts),
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Diamonds),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsStraight(hand));
        }

        [TestMethod]
        public void TestStraight_ReturnFalseWithFullHouseCards()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Hearts),
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Hearts),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsStraight(hand));
        }

        [TestMethod]
        public void TestStraight_ReturnFalseWithFlushCards()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Clubs),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsStraight(hand));
        }

        [TestMethod]
        public void TestStraight_ReturnFalseWithHighCardCards()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Two,  CardSuit.Clubs),
                new Card(CardFace.Four, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Diamonds),
                new Card(CardFace.Queen,CardSuit.Clubs),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsStraight(hand));
        }

        [TestMethod]
        public void TestThreeOfAKind_ReturnTrueWithThreeOfAKindCards()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Five, CardSuit.Diamonds),
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Hearts),
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Diamonds),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsTrue(checker.IsThreeOfAKind(hand));
        }

        [TestMethod]
        public void TestThreeOfAKind_ReturnFalseWithRoyalFlushCards()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Clubs),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsThreeOfAKind(hand));
        }

        [TestMethod]
        public void TestThreeOfAKind_ReturnFalseWithStraightFlushCards()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Six, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Four, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Clubs),
                });

            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsThreeOfAKind(hand));
        }

        [TestMethod]
        public void TestThreeOfAKind_ReturnFalseWithFourOfAKindCards()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Hearts),
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Clubs),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsThreeOfAKind(hand));
        }

        [TestMethod]
        public void TestThreeOfAKind_ReturnTrueWithFullHouseCards()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Hearts),
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Hearts),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsTrue(checker.IsThreeOfAKind(hand));
        }

        [TestMethod]
        public void TestThreeOfAKind_ReturnFalseWithFlushCards()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Clubs),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsThreeOfAKind(hand));
        }

        [TestMethod]
        public void TestThreeOfAKind_ReturnFalseWithTwoPairCards()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Hearts),
                new Card(CardFace.Three, CardSuit.Spades),
                new Card(CardFace.Three, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Clubs),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsThreeOfAKind(hand));
        }

        [TestMethod]
        public void TestThreeOfAKind_ReturnFalseWithOnePairCards()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Hearts),
                new Card(CardFace.Four, CardSuit.Spades),
                new Card(CardFace.Three, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Clubs),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsThreeOfAKind(hand));
        }

        [TestMethod]
        public void TestTwoPair_ReturnTrueWithTwoPairCards()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.King, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Clubs),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsTrue(checker.IsTwoPair(hand));
        }

         [TestMethod]   //last observation
        public void TestTwoPair_ReturnFalseWithFourOfAKindCards()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Hearts),
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Clubs),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsTwoPair(hand));
        }

        [TestMethod]
        public void TestTwoPair_ReturnFalseWithFullHouseCards()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Hearts),
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Hearts),
                });

            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsTwoPair(hand));
        }

        [TestMethod]
        public void TestTwoPair_ReturnFalseWithFlushCards()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Clubs),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsTwoPair(hand));
        }

        [TestMethod]
        public void TestTwoPair_ReturnFalseWithThreeOfAKindCards()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Hearts),
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Three, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Clubs),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsTwoPair(hand));
        }

        [TestMethod]   
        public void TestTwoPair_ReturnFalseWithOnePairCards()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Spades),
                new Card(CardFace.Three, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Clubs),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsTwoPair(hand));
        }

        [TestMethod]
        public void TestOnePair_ReturnTrueWithOnePairCards()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Hearts),
                new Card(CardFace.Five, CardSuit.Spades),
                new Card(CardFace.Three, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Clubs),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsTrue(checker.IsOnePair(hand));
        }

        [TestMethod]
        public void TestOnePair_ReturnFalseWithStraightFlushCards()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Six, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Four, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Clubs),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsOnePair(hand));
        }

        [TestMethod]
        public void TestOnePair_ReturnFalseWithFourOfAKindCards()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Hearts),
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Clubs),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsOnePair(hand));
        }

        [TestMethod]
        public void TestOnePair_ReturnTrueWithFullHouseCards()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Hearts),
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Hearts),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsTrue(checker.IsOnePair(hand));
        }

        [TestMethod]
        public void TestOnePair_ReturnFalseWithFlushCards()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Clubs),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsOnePair(hand));
        }

        [TestMethod]
        public void TestOnePair_ReturnFalseWithStraightCards()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Six, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Diamonds),
                new Card(CardFace.Four, CardSuit.Hearts),
                new Card(CardFace.Three, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Diamonds),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsOnePair(hand));
        }

        [TestMethod]
        public void TestOnePair_ReturnFalseWithThreeOfAKindCards()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Hearts),
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Three, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Clubs),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsOnePair(hand));
        }

        [TestMethod]
        public void TestOnePair_ReturnFalseWithTwoPairCards()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Hearts),
                new Card(CardFace.Three, CardSuit.Spades),
                new Card(CardFace.Three, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Clubs),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsOnePair(hand));
        }

        [TestMethod]
        public void TestHighCard_ReturnTrueWithHighCardCards()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Hearts),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Ace, CardSuit.Clubs),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsTrue(checker.IsHighCard(hand));
        }

        [TestMethod]
        public void TestHighCard_ReturnFalseWithRoyalFlushCards()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Clubs),
            });

            var result = new PokerHandsChecker().IsHighCard(hand);

            Assert.IsFalse(result, "IsHighCard - should have returned false for " +
                "5 cards, K-10, of the same suit");
        }

        [TestMethod]
        public void TestHighCard_ReturnFalseWithStraightFlushCards()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Six, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Clubs),
                new Card(CardFace.Four, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Clubs),
            });

            var result = new PokerHandsChecker().IsHighCard(hand);

            Assert.IsFalse(result, "IsHighCard - should have returned false for " +
                "5 cards in sequential rank, of the same suit");
        }

        [TestMethod]
        public void TestHighCard_ReturnFalseWithFourOfAKindCards()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Hearts),
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Clubs),
            });

            var result = new PokerHandsChecker().IsHighCard(hand);

            Assert.IsFalse(result, "IsHighCard - should have returned false for " +
                "4 cards, with the same face and different suits");
        }

        [TestMethod]
        public void TestHighCard_ReturnFalseWithFullHouseCards()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Hearts),
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Hearts),
            });

            var result = new PokerHandsChecker().IsHighCard(hand);

            Assert.IsFalse(result, "IsHighCard - should have returned false for " +
                "3 cards with one face and 2 cards with another face");
        }

        [TestMethod]
        public void TestHighCard_ReturnFalseWithFlushCards()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Clubs),
            });

            var result = new PokerHandsChecker().IsHighCard(hand);

            Assert.IsFalse(result, "IsHighCard - should have returned false for " +
                "5 cards, of the same suit and not in seqential order");
        }

        [TestMethod]
        public void TestHighCard_ReturnFalseWithStraightCards()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Six, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Diamonds),
                new Card(CardFace.Four, CardSuit.Hearts),
                new Card(CardFace.Three, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Diamonds),
            });

            var result = new PokerHandsChecker().IsHighCard(hand);

            Assert.IsFalse(result, "IsHighCard - should have returned false for " +
                "5 cards in a row of different suits");
        }

        [TestMethod]
        public void TestHighCard_ReturnFalseWithThreeOfAKindCards()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Hearts),
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Three, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Clubs),
            });

            var result = new PokerHandsChecker().IsHighCard(hand);

            Assert.IsFalse(result, "IsHighCard - should have returned false for " +
                "3 cards with the same face and 2 cards with different faces");
        }

        [TestMethod]
        public void TestHighCard_ReturnFalseWithTwoPairCards()
        {

            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Hearts),
                new Card(CardFace.Three, CardSuit.Spades),
                new Card(CardFace.Three, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Clubs),
            });

            var result = new PokerHandsChecker().IsHighCard(hand);

            Assert.IsFalse(result, "IsHighCard - should have returned true for " +
            "2 pairs of cards, with the same face and different suits");
        }

        [TestMethod]
        public void TestHighCard_ReturnFalseWithOnePairCards()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Hearts),
                new Card(CardFace.Four, CardSuit.Spades),
                new Card(CardFace.Three, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Clubs),
            });

            var result = new PokerHandsChecker().IsHighCard(hand);

            Assert.IsFalse(result, "IsHighCard - should have returned false for " +
                "2 cards, with the same face and different suits");
        }

        [TestMethod]
        public void TestCompareHands_ReturnNegativeOneWithHighCardVsOnePair()
        {
            IHand handOne = new Hand(new List<ICard>() {
                new Card(CardFace.Two,  CardSuit.Clubs),
                new Card(CardFace.Four, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Diamonds),
                new Card(CardFace.Queen,CardSuit.Clubs),
            });
            IHand handTwo = new Hand(new List<ICard>() {
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Hearts),
                new Card(CardFace.Four, CardSuit.Spades),
                new Card(CardFace.Three, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Clubs),
            });
            var result = new PokerHandsChecker().CompareHands(handOne, handTwo);
            Assert.IsTrue(result == -1);
        }
        [TestMethod]
        public void TestCompareHands_ReturnNegativeOneWithOnePairVsTwoPair()
        {
            IHand handOne = new Hand(new List<ICard>() {
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Hearts),
                new Card(CardFace.Four, CardSuit.Spades),
                new Card(CardFace.Three, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Clubs),
            });
            IHand handTwo = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Diamonds),
                new Card(CardFace.Nine, CardSuit.Clubs),
            });
            var result = new PokerHandsChecker().CompareHands(handOne, handTwo);
            Assert.IsTrue(result == -1);
        }
        [TestMethod]
        public void TestCompareHands_ReturnNegativeOneWithTwoPairVsThreeOfAKind()
        {
            IHand handOne = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Diamonds),
                new Card(CardFace.Nine, CardSuit.Clubs),
            });
            IHand handTwo = new Hand(new List<ICard>() {
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Hearts),
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Nine, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Clubs),
            });
            var result = new PokerHandsChecker().CompareHands(handOne, handTwo);
            Assert.IsTrue(result == -1);
        }
        [TestMethod]
        public void TestCompareHands_ReturnNegativeOneWithThreeOfAKindVsStraight()
        {
            IHand handOne = new Hand(new List<ICard>() {
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Hearts),
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Nine, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Clubs),
            });
            IHand handTwo = new Hand(new List<ICard>() {
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Spades),
            });
            var result = new PokerHandsChecker().CompareHands(handOne, handTwo);
            Assert.IsTrue(result == -1);
        }
        [TestMethod]
        public void TestCompareHands_ReturnNegativeOneWithStraightVsFlush()
        {
            IHand handOne = new Hand(new List<ICard>() {
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Spades),
            });
            IHand handTwo = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Nine, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Clubs),
            });
            var result = new PokerHandsChecker().CompareHands(handOne, handTwo);
            Assert.IsTrue(result == -1);
        }
        [TestMethod]
        public void TestCompareHands_ReturnNegativeOneWithFlushVsFullHouse()
        {
            IHand handOne = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Nine, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Clubs),
            });
            IHand handTwo = new Hand(new List<ICard>() {
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Clubs),
});
            var result = new PokerHandsChecker().CompareHands(handOne, handTwo);
            Assert.IsTrue(result == -1);
        }
        [TestMethod]
        public void TestCompareHands_ReturnNegativeOneWithFullHouseVsFourOfAKind()
        {
            IHand handOne = new Hand(new List<ICard>() {
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Clubs),
            });
            IHand handTwo = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Clubs),
            });
            var result = new PokerHandsChecker().CompareHands(handOne, handTwo);
            Assert.IsTrue(result == -1);
        }
        [TestMethod]
        public void TestCompareHands_ReturnNegativeOneWithFourOfAKindVsStraightFlush()
        {
            IHand handOne = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Clubs),
            });
            IHand handTwo = new Hand(new List<ICard>() {
                new Card(CardFace.Nine, CardSuit.Clubs),
                new Card(CardFace.Eight, CardSuit.Clubs),
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Clubs),
            });
            var result = new PokerHandsChecker().CompareHands(handOne, handTwo);
            Assert.IsTrue(result == -1);
        }
        [TestMethod]
        public void TestCompareHands_ReturnNegativeOneWithStraightFlushVsRoyalFlush()
        {
            IHand handOne = new Hand(new List<ICard>() {
                new Card(CardFace.Nine, CardSuit.Clubs),
                new Card(CardFace.Eight, CardSuit.Clubs),
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Clubs),
            });
            IHand handTwo = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Clubs),
            });
            var result = new PokerHandsChecker().CompareHands(handOne, handTwo);
            Assert.IsTrue(result == -1);
        }
        //////GREATER THAN
        [TestMethod]
        public void TestCompareHands_ReturnOneWithOnePairVsHighCard()
        {
            IHand handTwo = new Hand(new List<ICard>() {
                    new Card(CardFace.Two,  CardSuit.Clubs),
                    new Card(CardFace.Four, CardSuit.Hearts),
                    new Card(CardFace.King, CardSuit.Spades),
                    new Card(CardFace.Five, CardSuit.Diamonds),
                    new Card(CardFace.Queen,CardSuit.Clubs),
            });
            IHand handOne = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Eight, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Diamonds),
                new Card(CardFace.Four, CardSuit.Clubs),
            });
            var result = new PokerHandsChecker().CompareHands(handOne, handTwo);
            Assert.IsTrue(result == 1);
        }
        [TestMethod]
        public void TestCompareHands_ReturnOneWithTwoPairVsOnePair()
        {
            IHand handTwo = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Eight, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Diamonds),
                new Card(CardFace.Four, CardSuit.Clubs),
            });
            IHand handOne = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Diamonds),
                new Card(CardFace.Nine, CardSuit.Clubs),
            });
            var result = new PokerHandsChecker().CompareHands(handOne, handTwo);
            Assert.IsTrue(result == 1);
        }
        [TestMethod]
        public void TestCompareHands_ReturnOneWithThreeOfAKindVsTwoPair()
        {
            IHand handTwo = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Diamonds),
                new Card(CardFace.Nine, CardSuit.Clubs),
            });
            IHand handOne = new Hand(new List<ICard>() {
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Hearts),
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Nine, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Clubs),
            });
            var result = new PokerHandsChecker().CompareHands(handOne, handTwo);
            Assert.IsTrue(result == 1);
        }
        [TestMethod]
        public void TestCompareHands_ReturnOneWithStraightVsThreeOfKind()
        {
            IHand handTwo = new Hand(new List<ICard>() {
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Hearts),
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Nine, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Clubs),
            });
            IHand handOne = new Hand(new List<ICard>() {
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Spades),
            });
            var result = new PokerHandsChecker().CompareHands(handOne, handTwo);
            Assert.IsTrue(result == 1);
        }
        [TestMethod]
        public void TestCompareHands_ReturnOneWithFlushVsStraight()
        {
            IHand handTwo = new Hand(new List<ICard>() {
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Spades),
            });
            IHand handOne = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Nine, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Clubs),
            });
            var result = new PokerHandsChecker().CompareHands(handOne, handTwo);
            Assert.IsTrue(result == 1);
        }
        [TestMethod]
        public void TestCompareHands_ReturnOneWithFullHouseVsFlush()
        {
            IHand handTwo = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Nine, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Clubs),
            });
            IHand handOne = new Hand(new List<ICard>() {
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Clubs),
            });
            var result = new PokerHandsChecker().CompareHands(handOne, handTwo);
            Assert.IsTrue(result == 1);
        }
        [TestMethod]
        public void TestCompareHands_ReturnOneWithFourOfAKindVsFullHouse()
        {
            IHand handTwo = new Hand(new List<ICard>() {
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Clubs),
            });
            IHand handOne = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Clubs),
            });
            var result = new PokerHandsChecker().CompareHands(handOne, handTwo);
            Assert.IsTrue(result == 1);
        }
        [TestMethod]
        public void TestCompareHands_ReturnOneWithStraightFlushVsFourOfAKind()
        {
            IHand handTwo = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Clubs),
            });
            IHand handOne = new Hand(new List<ICard>() {
                new Card(CardFace.Nine, CardSuit.Clubs),
                new Card(CardFace.Eight, CardSuit.Clubs),
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Clubs),
            });
            var result = new PokerHandsChecker().CompareHands(handOne, handTwo);
            Assert.IsTrue(result == 1);
        }
        [TestMethod]
        public void TestCompareHands_ReturnOneWithRoyalFlushVsStraightFlush()
        {
            IHand handTwo = new Hand(new List<ICard>() {
                new Card(CardFace.Nine, CardSuit.Clubs),
                new Card(CardFace.Eight, CardSuit.Clubs),
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Clubs),
            });
            IHand handOne = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Clubs),
            });
            var result = new PokerHandsChecker().CompareHands(handOne, handTwo);
            Assert.IsTrue(result == 1);
        }
        /////EQUAL TO
        [TestMethod]
        public void TestCompareHands_ReturnZeroWithHighCardVsHighCard()
        {
            IHand handOne = new Hand(new List<ICard>() {
                new Card(CardFace.Two,  CardSuit.Clubs),
                new Card(CardFace.Four, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Diamonds),
                new Card(CardFace.Queen,CardSuit.Clubs),
            });
            IHand handTwo = new Hand(new List<ICard>() {
                new Card(CardFace.Seven,  CardSuit.Clubs),
                new Card(CardFace.Four, CardSuit.Hearts),
                new Card(CardFace.Three, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Diamonds),
                new Card(CardFace.King,CardSuit.Clubs),
            });
            var result = new PokerHandsChecker().CompareHands(handOne, handTwo);
            Assert.IsTrue(result == 0);
        }
        [TestMethod]
        public void TestCompareHands_ReturnZeroWithOnePairVsOnePair()
        {
            IHand handOne = new Hand(new List<ICard>() {
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Hearts),
                new Card(CardFace.Three, CardSuit.Spades),
                new Card(CardFace.Four, CardSuit.Diamonds),
                new Card(CardFace.Ten, CardSuit.Clubs),
            });
            IHand handTwo = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Diamonds),
                new Card(CardFace.Nine, CardSuit.Clubs),
            });
            var result = new PokerHandsChecker().CompareHands(handOne, handTwo);
            Assert.IsTrue(result == 0);

        }
        [TestMethod]
        public void TestCompareHands_ReturnZeroWithTwoPairVsTwoPair()
        {
            IHand handOne = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Diamonds),
                new Card(CardFace.Nine, CardSuit.Clubs),
            });
            IHand handTwo = new Hand(new List<ICard>() {
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Hearts),
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Diamonds),
                new Card(CardFace.Nine, CardSuit.Clubs),
            });
            var result = new PokerHandsChecker().CompareHands(handOne, handTwo);
            Assert.IsTrue(result == 0);
        }
        [TestMethod]
        public void TestCompareHands_ReturnZeroWithThreeOfAKindVsThreeOfAKind()
        {
            IHand handOne = new Hand(new List<ICard>() {
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Hearts),
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Nine, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Clubs),
            });
            IHand handTwo = new Hand(new List<ICard>() {
                new Card(CardFace.Three, CardSuit.Spades),
                new Card(CardFace.Three, CardSuit.Hearts),
                new Card(CardFace.Three, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Clubs),
            });
            var result = new PokerHandsChecker().CompareHands(handOne, handTwo);
            Assert.IsTrue(result == 0);
        }
        [TestMethod]
        public void TestCompareHands_ReturnZeroWithStraightVsStraight()
        {
            IHand handOne = new Hand(new List<ICard>() {
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.Eight, CardSuit.Diamonds),
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Spades),
            });
            IHand handTwo = new Hand(new List<ICard>() {
                new Card(CardFace.Six, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Diamonds),
                new Card(CardFace.Four, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Spades),
            });

            var result = new PokerHandsChecker().CompareHands(handOne, handTwo);
            Assert.IsTrue(result == 0);
        }
        [TestMethod]
        public void TestCompareHands_ReturnZeroWithFlushVsFlush()
        {
            IHand handOne = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Nine, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Clubs),
                new Card(CardFace.Three, CardSuit.Clubs),
            });
            IHand handTwo = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.Six, CardSuit.Spades),
                new Card(CardFace.Three, CardSuit.Spades),
            });
            var result = new PokerHandsChecker().CompareHands(handOne, handTwo);
            Assert.IsTrue(result == 0);
        }
        [TestMethod]
        public void TestCompareHands_ReturnZeroWithFullHouseVsFullHouse()
        {
            IHand handOne = new Hand(new List<ICard>() {
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Clubs),
            });
            IHand handTwo = new Hand(new List<ICard>() {
                new Card(CardFace.Nine, CardSuit.Spades),
                new Card(CardFace.Nine, CardSuit.Hearts),
                new Card(CardFace.Nine, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Two, CardSuit.Clubs),
            });
            var result = new PokerHandsChecker().CompareHands(handOne, handTwo);
            Assert.IsTrue(result == 0);
        }
        [TestMethod]
        public void TestCompareHands_ReturnZeroWithFourOfAKindVsFourOfAKind()
        {
            IHand handOne = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Hearts),
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Clubs),
            });
            IHand handTwo = new Hand(new List<ICard>() {
                new Card(CardFace.Two, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Hearts),
                new Card(CardFace.Two, CardSuit.Clubs),
                new Card(CardFace.Two, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Clubs),
            });
            var result = new PokerHandsChecker().CompareHands(handOne, handTwo);
            Assert.IsTrue(result == 0);
        }
        [TestMethod]
        public void TestCompareHands_ReturnZeroWithStraightFlushVsStraightFlush()
        {
            IHand handOne = new Hand(new List<ICard>() {
                new Card(CardFace.Nine, CardSuit.Clubs),
                new Card(CardFace.Eight, CardSuit.Clubs),
                new Card(CardFace.Seven, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Clubs),
                new Card(CardFace.Five, CardSuit.Clubs),
            });
            IHand handTwo = new Hand(new List<ICard>() {
                new Card(CardFace.Six, CardSuit.Spades),
                new Card(CardFace.Five, CardSuit.Spades),
                new Card(CardFace.Four, CardSuit.Spades),
                new Card(CardFace.Three, CardSuit.Spades),
                new Card(CardFace.Two, CardSuit.Spades),
            });
            var result = new PokerHandsChecker().CompareHands(handOne, handTwo);
            Assert.IsTrue(result == 0);
        }
        [TestMethod]
        public void TestCompareHands_ReturnZeroWithRoyalFlushVsRoyalFlush()
        {
            IHand handOne = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.King, CardSuit.Clubs),
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Ten, CardSuit.Clubs),
            });
            IHand handTwo = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Jack, CardSuit.Spades),
                new Card(CardFace.Ten, CardSuit.Spades),
            });
            var result = new PokerHandsChecker().CompareHands(handOne, handTwo);
            Assert.IsTrue(result == 0);
        }
    }
}
