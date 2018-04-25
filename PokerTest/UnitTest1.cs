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
        public void TestRoyalFlush_ReturnFalseWithFlushCards()
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
        public void TestFourOfAKind_ReturnFalseWithFullHouseCards()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Queen, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Hearts),
                new Card(CardFace.Queen, CardSuit.Clubs),
                new Card(CardFace.Jack, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Clubs),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsFourOfAKind(hand));
        }

        [TestMethod]
        public void TestFourOfAKind_ReturnFalseWithOnePairCards()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Ace, CardSuit.Hearts),
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

       /*Tests for FLUSH*/
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
        public void TestFlush_ReturnFalseWithHighCardCards()
        {
            IHand hand = new Hand(new List<ICard>() {
                new Card(CardFace.Ace, CardSuit.Spades),
                new Card(CardFace.Queen, CardSuit.Diamonds),
                new Card(CardFace.Jack, CardSuit.Clubs),
                new Card(CardFace.Six, CardSuit.Diamonds),
                new Card(CardFace.Five, CardSuit.Spades),
            });

            IPokerHandsChecker checker = new PokerHandsChecker();

            Assert.IsFalse(checker.IsFlush(hand));
        }

        [TestMethod]
        public void TestStraight_ReturnTrueWithStraightCards()
        {

        }

        [TestMethod]
        public void TestStraight_ReturnFalseWithRoyalFlushCards()
        {

        }

        [TestMethod]
        public void TestStraight_ReturnFalseWithStraightFlushCards()
        {

        }

        [TestMethod]
        public void TestStraight_ReturnFalseWithFourOfAKindCards()
        {

        }

        [TestMethod]
        public void TestStraight_ReturnFalseWithFullHouseCards()
        {

        }

        [TestMethod]
        public void TestStraight_ReturnFalseWithFlushCards()
        {

        }

        [TestMethod]
        public void TestStraight_ReturnFalseWithThreeOfAKindCards()
        {

        }

        [TestMethod]
        public void TestStraight_ReturnFalseWithTwoPairCards()
        {

        }

        [TestMethod]
        public void TestStraight_ReturnFalseWithOnePairCards()
        {

        }

        [TestMethod]
        public void TestStraight_ReturnFalseWithHighCardCards()
        {

        }

        [TestMethod]
        public void TestThreeOfAKind_ReturnTrueWithThreeOfAKindCards()
        {

        }

        [TestMethod]
        public void TestThreeOfAKind_ReturnFalseWithRoyalFlushCards()
        {

        }

        [TestMethod]
        public void TestThreeOfAKind_ReturnFalseWithStraightFlushCards()
        {

        }

        [TestMethod]
        public void TestThreeOfAKind_ReturnFalseWithFourOfAKindCards()
        {

        }

        [TestMethod]
        public void TestThreeOfAKind_ReturnFalseWithFullHouseCards()
        {

        }

        [TestMethod]
        public void TestThreeOfAKind_ReturnFalseWithFlushCards()
        {

        }

        [TestMethod]
        public void TestThreeOfAKind_ReturnFalseWithStraightCards()
        {

        }

        [TestMethod]
        public void TestThreeOfAKind_ReturnFalseWithTwoPairCards()
        {

        }

        [TestMethod]
        public void TestThreeOfAKind_ReturnFalseWithOnePairCards()
        {

        }

        [TestMethod]
        public void TestThreeOfAKind_ReturnFalseWithHighCardCards()
        {

        }

        [TestMethod]
        public void TestTwoPair_ReturnTrueWithRoyalFlushCards()
        {

        }

        [TestMethod]
        public void TestTwoPair_ReturnFalseWithStraightFlushCards()
        {

        }

        [TestMethod]
        public void TestTwoPair_ReturnFalseWithFourOfAKindCards()
        {

        }

        [TestMethod]
        public void TestTwoPair_ReturnFalseWithFullHouseCards()
        {

        }

        [TestMethod]
        public void TestTwoPair_ReturnFalseWithFlushCards()
        {

        }

        [TestMethod]
        public void TestTwoPair_ReturnFalseWithStraightCards()
        {

        }

        [TestMethod]
        public void TestTwoPair_ReturnFalseWithThreeOfAKindCards()
        {

        }

        [TestMethod]   
        public void TestTwoPair_ReturnFalseWithOnePairCards()
        {

        }

        [TestMethod]
        public void TestTwoPair_ReturnFalseWithHighCardCards()
        {

        }

        [TestMethod]
        public void TestOnePair_ReturnTrueWithOnePairCards()
        {

        }

        [TestMethod]
        public void TestOnePair_ReturnFalseWithRoyalFlushCards()
        {

        }

        [TestMethod]
        public void TestOnePair_ReturnFalseWithStraightFlushCards()
        {

        }

        [TestMethod]
        public void TestOnePair_ReturnFalseWithFourOfAKindCards()
        {

        }

        [TestMethod]
        public void TestOnePair_ReturnFalseWithFullHouseCards()
        {

        }

        [TestMethod]
        public void TestOnePair_ReturnFalseWithFlushCards()
        {

        }

        [TestMethod]
        public void TestOnePair_ReturnFalseWithStraightCards()
        {

        }

        [TestMethod]
        public void TestOnePair_ReturnFalseWithThreeOfAKindCards()
        {

        }

        [TestMethod]
        public void TestOnePair_ReturnFalseWithTwoPairCards()
        {

        }

        [TestMethod]
        public void TestOnePair_ReturnFalseWithHighCardCards()
        {

        }

        [TestMethod]
        public void TestHighCard_ReturnTrueWithHighCardCards()
        {

        }

        [TestMethod]
        public void TestHighCard_ReturnFalseWithRoyalFlushCards()
        {

        }

        [TestMethod]
        public void TestHighCard_ReturnFalseWithStraightFlushCards()
        {

        }

        [TestMethod]
        public void TestHighCard_ReturnFalseWithFourOfAKindCards()
        {

        }

        [TestMethod]
        public void TestHighCard_ReturnFalseWithFullHouseCards()
        {

        }

        [TestMethod]
        public void TestHighCard_ReturnFalseWithFlushCards()
        {

        }

        [TestMethod]
        public void TestHighCard_ReturnFalseWithStraightCards()
        {

        }

        [TestMethod]
        public void TestHighCard_ReturnFalseWithThreeOfAKindCards()
        {

        }

        [TestMethod]
        public void TestHighCard_ReturnFalseWithTwoPairCards()
        {

        }

        [TestMethod]
        public void TestHighCard_ReturnFalseWithOnePairCards()
        {

        }

    }
}
