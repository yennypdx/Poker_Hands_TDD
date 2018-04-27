using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PokerTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestShouldPassWithFiveCardsInHand()
        {

        }

        [TestMethod]
        public void TestShouldFailWithFourCardsInHand()
        {

        }

        /*Tests for ROYAL FLUSH*/
        [TestMethod]
        public void TestRoyalFlush_ReturnTrueWithRoyalFlushCards()
        {

        }

        [TestMethod]
        public void TestRoyalFlush_ReturnFalseWithStraightFlushCards()
        {

        }

        [TestMethod]
        public void TestRoyalFlush_ReturnFalseWithFourOfAkindCards()
        {

        }

        [TestMethod]
        public void TestRoyalFlush_ReturnFalseWithFullHouseCards()
        {

        }

        [TestMethod]
        public void TestRoyalFlush_ReturnFalseWithFlushCards()
        {

        }

        [TestMethod]
        public void TestRoyalFlush_ReturnFalseWithStraightCards()
        {

        }

        [TestMethod]
        public void TestRoyalFlush_ReturnFalseWithThreeOfAKindCards()
        {

        }

        [TestMethod]
        public void TestRoyalFlush_ReturnFalseWithTwoPairCards()
        {

        }

        [TestMethod]
        public void TestRoyalFlush_ReturnFalseWithOnePairCards()
        {

        }

        [TestMethod]
        public void TestRoyalFlush_ReturnFalseWithHighCardCards()
        {

        }

        /*Tests for STRAIGHT FLUSH*/
        [TestMethod]
        public void TestStraightFlush_ReturnTrueWithStraightFlushCards()
        {

        }

        [TestMethod]
        public void TestStraightFlush_ReturnFalseWithRoyalFlushCards()
        {

        }

        [TestMethod]
        public void TestStraightFlush_ReturnFalseWithFourOfAkindCards()
        {

        }

        [TestMethod]
        public void TestStraightFlush_ReturnFalseWithFullHouseCards()
        {

        }

        [TestMethod]
        public void TestStraightFlush_ReturnFalseWithFlushCards()
        {

        }

        [TestMethod]
        public void TestStraightFlush_ReturnFalseWithStraightCards()
        {

        }

        [TestMethod]
        public void TestStraightFlush_ReturnFalseWithThreeOfAKindCards()
        {

        }

        [TestMethod]
        public void TestStraightFlush_ReturnFalseWithTwoPairCards()
        {

        }

        [TestMethod]
        public void TestStraightFlush_ReturnFalseWithOnePairCards()
        {

        }

        [TestMethod]
        public void TestStraightFlush_ReturnFalseWithHighCardCards()
        {

        }

        /*Tests for FOUR OF A KIND*/
        [TestMethod]
        public void TestFourOfAKind_ReturnTrueWithFourOfAKindCards()
        {

        }

        [TestMethod]
        public void TestFourOfAKind_ReturnFalseWithRoyalFlushCards()
        {

        }

        [TestMethod]
        public void TestFourOfAKind_ReturnFalseWithStraightFlushCards()
        {

        }

        [TestMethod]
        public void TestFourOfAKind_ReturnFalseWithFullHouseCards()
        {

        }

        [TestMethod]
        public void TestFourOfAKind_ReturnFalseWithFlushCards()
        {

        }

        [TestMethod]
        public void TestFourOfAKind_ReturnFalseWithStraightCards()
        {

        }

        [TestMethod]     //this test return TRUE for "Three Of A Kind" case
        public void TestFourOfAKind_ReturnTrueWithThreeOfAKindCards()
        {

        }

        [TestMethod]
        public void TestFourOfAKind_ReturnFalseWithTwoPairCards()
        {

        }

        [TestMethod]
        public void TestFourOfAKind_ReturnFalseWithOnePairCards()
        {

        }

        [TestMethod]
        public void TestFourOfAKind_ReturnFalseWithHighCardCards()
        {

        }

        /*Tests for FULL HOUSE*/
        [TestMethod]
        public void TestFullHouse_ReturnTrueWithFullHouseCards()
        {

        }

        [TestMethod]
        public void TestFullHouse_ReturnFalseWithRoyalFlushCards()
        {

        }

        [TestMethod]
        public void TestFullHouse_ReturnFalseWithStraightFlushCards()
        {

        }

        [TestMethod]
        public void TestFullHouse_ReturnFalseWithFourOfAKindCards()
        {

        }

        [TestMethod]
        public void TestFullHouse_ReturnFalseWithFlushCards()
        {

        }

        [TestMethod]
        public void TestFullHouse_ReturnFalseWithStraightCards()
        {

        }

        [TestMethod]
        public void TestFullHouse_ReturnFalseWithThreeOfAKindCards()
        {

        }

        [TestMethod]
        public void TestFullHouse_ReturnFalseWithTwoPairCards()
        {

        }

        [TestMethod]
        public void TestFullHouse_ReturnFalseWithOnePairCards()
        {

        }

        [TestMethod]
        public void TestFullHouse_ReturnFalseWithHighCardCards()
        {

        }

        /*Tests for FLUSH*/
        [TestMethod]
        public void TestFlush_ReturnTrueWithFlushCards()
        {

        }

        [TestMethod]
        public void TestFlush_ReturnFalseWithRoyalFlushCards()
        {

        }

        [TestMethod]
        public void TestFlush_ReturnFalseWithStraightFlushCards()
        {

        }

        [TestMethod]
        public void TestFlush_ReturnFalseWithFourOfAKindCards()
        {

        }

        [TestMethod]
        public void TestFlush_ReturnFalseWithFullHouseCards()
        {

        }

        [TestMethod]
        public void TestFlush_ReturnFalseWithStraightCards()
        {

        }

        [TestMethod]
        public void TestFlush_ReturnFalseWithThreeOfAKindCards()
        {

        }

        [TestMethod]
        public void TestFlush_ReturnFalseWithTwoPairCards()
        {

        }

        [TestMethod]
        public void TestFlush_ReturnFalseWithOnePairCards()
        {

        }

        [TestMethod]
        public void TestFlush_ReturnFalseWithHighCardCards()
        {

        }

        /*Tests for STRAIGHT*/
        [TestMethod]
        public void TestStraight_ReturnTrueWithStraightCards()
        {

                //instantiate a new PokerChecker and call the test function
                var result = new PokerHandsChecker().IsStraight(hand);

                //assert statement
                Assert.IsTrue(result, "IsStraight - should have returned true for " +
                    "5 cards in a row of different suits");
            }

            [TestMethod]
            public void TestStraight_ReturnFalseWithRoyalFlushCards()
            {
                IHand hand = new Hand(new List<ICard>() {
                    new Card(CardFace.Ace, CardSuit.Clubs),
                    new Card(CardFace.King, CardSuit.Clubs),
                    new Card(CardFace.Queen, CardSuit.Clubs),
                    new Card(CardFace.Jack, CardSuit.Clubs),
                    new Card(CardFace.Ten, CardSuit.Clubs),
                 });

                var result = new PokerHandsChecker().IsStraight(hand);
                
                Assert.IsFalse(result, "IsStraight - should have returned false for " +
                    "5 cards, K-10, of the same suit");
            }

            [TestMethod]
            public void TestStraight_ReturnFalseWithStraightFlushCards()
            {
                IHand hand = new Hand(new List<ICard>() {
                    new Card(CardFace.Six, CardSuit.Clubs),
                    new Card(CardFace.Five, CardSuit.Clubs),
                    new Card(CardFace.Four, CardSuit.Clubs),
                    new Card(CardFace.Three, CardSuit.Clubs),
                    new Card(CardFace.Two, CardSuit.Clubs),
                 });

                var result = new PokerHandsChecker().IsStraight(hand);

                Assert.IsFalse(result, "IsStraight - should have returned false for " +
                    "5 cards in sequential rank, of the same suit");
            }

            [TestMethod]
            public void TestStraight_ReturnFalseWithFourOfAKindCards()
            {
                IHand hand = new Hand(new List<ICard>() {
                    new Card(CardFace.Two, CardSuit.Clubs),
                    new Card(CardFace.Two, CardSuit.Hearts),
                    new Card(CardFace.Two, CardSuit.Spades),
                    new Card(CardFace.Two, CardSuit.Diamonds),
                    new Card(CardFace.Ten, CardSuit.Clubs),
                });
                
                 var result = new PokerHandsChecker().IsStraight(hand);
                
                 Assert.IsFalse(result, "IsStraight - should have returned false for " +
                    "4 cards, with the same face and different suits");
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
                
                 var result = new PokerHandsChecker().IsStraight(hand);
                
                 Assert.IsFalse(result, "IsStraight - should have returned false for " +
                    "3 cards with one face and 2 cards with another face");
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

                var result = new PokerHandsChecker().IsStraight(hand);

                Assert.IsFalse(result, "IsStraight - should have returned false for " +
                    "5 cards, of the same suit and not in seqential order");
            }

            [TestMethod]
            public void TestStraight_ReturnFalseWithThreeOfAKindCards()
            {
                IHand hand = new Hand(new List<ICard>() {
                    new Card(CardFace.Two, CardSuit.Clubs),
                    new Card(CardFace.Two, CardSuit.Hearts),
                    new Card(CardFace.Two, CardSuit.Spades),
                    new Card(CardFace.Three, CardSuit.Diamonds),
                    new Card(CardFace.Ten, CardSuit.Clubs),
                });

                var result = new PokerHandsChecker().IsStraight(hand);

                Assert.IsFalse(result, "IsStraight - should have returned false for " +
                    "3 cards, with the same face and different suits");
            }

            [TestMethod]
            public void TestStraight_ReturnFalseWithTwoPairCards()
            {
                IHand hand = new Hand(new List<ICard>() {
                    new Card(CardFace.Two, CardSuit.Clubs),
                    new Card(CardFace.Two, CardSuit.Hearts),
                    new Card(CardFace.Three, CardSuit.Spades),
                    new Card(CardFace.Three, CardSuit.Diamonds),
                    new Card(CardFace.Ten, CardSuit.Clubs),
                });

                var result = new PokerHandsChecker().IsStraight(hand);

                Assert.IsFalse(result, "IsStraight - should have returned false for " +
                "2 pairs of cards, with the same face and different suits");
             }
    
            [TestMethod]
            public void TestStraight_ReturnFalseWithOnePairCards()
            {
                IHand hand = new Hand(new List<ICard>() {
                    new Card(CardFace.Two, CardSuit.Clubs),
                    new Card(CardFace.Two, CardSuit.Hearts),
                    new Card(CardFace.Four, CardSuit.Spades),
                    new Card(CardFace.Three, CardSuit.Diamonds),
                    new Card(CardFace.Ten, CardSuit.Clubs),
                });

                var result = new PokerHandsChecker().IsStraight(hand);

                Assert.IsFalse(result, "IsStraight - should have returned false for " +
                    "2 cards, with the same face and different suits");
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

                var result = new PokerHandsChecker().IsStraight(hand);

                 Assert.IsFalse(result, "IsStraight - should have returned false for " +
                "5 cards, none of which are in order, have the same suit, or the same rank");
            }

        /*Tests for THREE OF A KIND*/
        [TestMethod]
        public void TestThreeOfAKind_ReturnTrueWithThreeOfAKindCards()
        {

                var result = new PokerHandsChecker().IsThreeOfAKind(hand);

                Assert.IsTrue(result, "IsThreeOfAKind- should have returned true for " +
                    "3 cards with the same face and 2 cards with different faces");
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

                var result = new PokerHandsChecker().IsThreeOfAKind(hand);

                Assert.IsFalse(result, "IsThreeOfAKind - should have returned false for " +
                    "5 cards, K-10, of the same suit");
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

                var result = new PokerHandsChecker().IsThreeOfAKind(hand);

                Assert.IsFalse(result, "IsThreeOfAKind - should have returned false for " +
                    "5 cards in sequential rank, of the same suit");
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

                var result = new PokerHandsChecker().IsThreeOfAKind(hand);

                Assert.IsFalse(result, "IsThreeOfAKind - should have returned false for " +
                   "4 cards, with the same face and different suits");
            }

            [TestMethod]
            public void TestThreeOfAKind_ReturnFalseWithFullHouseCards()
            {
                IHand hand = new Hand(new List<ICard>() {
                    new Card(CardFace.Two, CardSuit.Clubs),
                    new Card(CardFace.Two, CardSuit.Hearts),
                    new Card(CardFace.Two, CardSuit.Spades),
                    new Card(CardFace.Three, CardSuit.Clubs),
                    new Card(CardFace.Three, CardSuit.Hearts),
                 });

                var result = new PokerHandsChecker().IsThreeOfAKind(hand);

                Assert.IsFalse(result, "IsThreeOfAKind - should have returned false for " +
                   "3 cards with one face and 2 cards with another face");
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

                var result = new PokerHandsChecker().IsThreeOfAKind(hand);

                Assert.IsFalse(result, "IsThreeOfAKind - should have returned false for " +
                    "5 cards, of the same suit and not in seqential order");
            }

            [TestMethod]
            public void TestThreeOfAKind_ReturnFalseWithStraightCards()
            {
                IHand hand = new Hand(new List<ICard>() {
                    new Card(CardFace.Six, CardSuit.Clubs),
                    new Card(CardFace.Five, CardSuit.Diamonds),
                    new Card(CardFace.Four, CardSuit.Hearts),
                    new Card(CardFace.Three, CardSuit.Spades),
                    new Card(CardFace.Two, CardSuit.Diamonds),
                 });

                var result = new PokerHandsChecker().IsThreeOfAKind(hand);

                Assert.IsFalse(result, "IsThreeOfAKind - should have returned false for " +
                    "5 cards in a row of different suits");
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

                var result = new PokerHandsChecker().IsThreeOfAKind(hand);

                Assert.IsFalse(result, "IsThreeOfAKind - should have returned false for " +
                "2 pairs of cards, with the same face and different suits");
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

                var result = new PokerHandsChecker().IsThreeOfAKind(hand);

                Assert.IsFalse(result, "IsThreeOfAKind - should have returned false for " +
                    "2 cards, with the same face and different suits");
            }

            [TestMethod]
            public void TestThreeOfAKind_ReturnFalseWithHighCardCards()
            {
                IHand hand = new Hand(new List<ICard>() {
                    new Card(CardFace.Two,  CardSuit.Clubs),
                    new Card(CardFace.Four, CardSuit.Hearts),
                    new Card(CardFace.King, CardSuit.Spades),
                    new Card(CardFace.Five, CardSuit.Diamonds),
                    new Card(CardFace.Queen,CardSuit.Clubs),
                });

                var result = new PokerHandsChecker().IsThreeOfAKind(hand);

                Assert.IsFalse(result, "IsThreeOfAKind - should have returned false for " +
               "5 cards, none of which are in order, have the same suit, or the same rank");
            }

        /*Tests for TWO PAIR*/
        [TestMethod]
        public void TestTwoPair_ReturnTrueWithTwoPairCards()
        {

        }

        [TestMethod]
        public void TestTwoPair_ReturnFalseWithRoyalFlushCards()
        {

                var result = new PokerHandsChecker().IsTwoPair(hand);

                Assert.IsFalse(result, "IsTwoPair - should have returned false for " +
                    "5 cards, K-10, of the same suit");
            }

            [TestMethod]
            public void TestTwoPair_ReturnFalseWithStraightFlushCards()
            {
                IHand hand = new Hand(new List<ICard>() {
                    new Card(CardFace.Six, CardSuit.Clubs),
                    new Card(CardFace.Five, CardSuit.Clubs),
                    new Card(CardFace.Four, CardSuit.Clubs),
                    new Card(CardFace.Three, CardSuit.Clubs),
                    new Card(CardFace.Two, CardSuit.Clubs),
                 });

                var result = new PokerHandsChecker().IsTwoPair(hand);

                Assert.IsFalse(result, "IsTwoPair - should have returned false for " +
                    "5 cards in sequential rank, of the same suit");
            }

            [TestMethod]
            public void TestTwoPair_ReturnFalseWithFourOfAKindCards()
            {
                IHand hand = new Hand(new List<ICard>() {
                    new Card(CardFace.Two, CardSuit.Clubs),
                    new Card(CardFace.Two, CardSuit.Hearts),
                    new Card(CardFace.Two, CardSuit.Spades),
                    new Card(CardFace.Two, CardSuit.Diamonds),
                    new Card(CardFace.Ten, CardSuit.Clubs),
                });

                var result = new PokerHandsChecker().IsTwoPair(hand);

                Assert.IsFalse(result, "IsTwoPair - should have returned false for " +
                   "4 cards, with the same face and different suits");
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

                var result = new PokerHandsChecker().IsTwoPair(hand);

                Assert.IsFalse(result, "IsTwoPair - should have returned false for " +
                   "3 cards with one face and 2 cards with another face");
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

                var result = new PokerHandsChecker().IsTwoPair(hand);

                Assert.IsFalse(result, "IsTwoPair - should have returned false for " +
                    "5 cards, of the same suit and not in seqential order");
            }

        [TestMethod]
        public void TTestTwoPair_ReturnFalseWithStraightCards()
        {

                Assert.IsFalse(result, "IsTwoPair - should have returned false for " +
                    "5 cards in a row of different suits");
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

                var result = new PokerHandsChecker().IsTwoPair(hand);

                Assert.IsFalse(result, "IsTwoPair - should have returned false for " +
                    "3 cards with the same face and 2 cards with different faces");
            }

        [TestMethod]    //this test return TRUE for "One Pair" case
        public void TestTwoPair_ReturnTrueWithOnePairCards()
        {

                Assert.IsTrue(result, "IsTwoPair - should have returned true for " +
                    "2 cards, with the same face and different suits");
            }

            [TestMethod]
            public void TestTwoPair_ReturnFalseWithHighCardCards()
            {
                IHand hand = new Hand(new List<ICard>() {
                    new Card(CardFace.Two,  CardSuit.Clubs),
                    new Card(CardFace.Four, CardSuit.Hearts),
                    new Card(CardFace.King, CardSuit.Spades),
                    new Card(CardFace.Five, CardSuit.Diamonds),
                    new Card(CardFace.Queen,CardSuit.Clubs),
                });

                var result = new PokerHandsChecker().IsTwoPair(hand);

                Assert.IsFalse(result, "IsTwoPair - should have returned false for " +
               "5 cards, none of which are in order, have the same suit, or the same rank");
            }

        /*Tests for ONE PAIR*/
        [TestMethod]
        public void TestOnePair_ReturnTrueWithOnePairCards()
        {

                Assert.IsTrue(result, "IsOnePair - should have returned true for " +
                    "2 cards, with the same face and different suits");
            }

            [TestMethod]
            public void TestOnePair_ReturnFalseWithRoyalFlushCards()
            {
                IHand hand = new Hand(new List<ICard>() {
                    new Card(CardFace.Ace, CardSuit.Clubs),
                    new Card(CardFace.King, CardSuit.Clubs),
                    new Card(CardFace.Queen, CardSuit.Clubs),
                    new Card(CardFace.Jack, CardSuit.Clubs),
                    new Card(CardFace.Ten, CardSuit.Clubs),
                 });

                var result = new PokerHandsChecker().IsOnePair(hand);

                Assert.IsFalse(result, "IsOnePair - should have returned false for " +
                    "5 cards, K-10, of the same suit");
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

                var result = new PokerHandsChecker().IsOnePair(hand);

                Assert.IsFalse(result, "IsOnePair - should have returned false for " +
                    "5 cards in sequential rank, of the same suit");
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

                var result = new PokerHandsChecker().IsOnePair(hand);

                Assert.IsFalse(result, "IsOnePair - should have returned false for " +
                   "4 cards, with the same face and different suits");
            }

            [TestMethod]
            public void TestOnePair_ReturnFalseWithFullHouseCards()
            {
                IHand hand = new Hand(new List<ICard>() {
                    new Card(CardFace.Two, CardSuit.Clubs),
                    new Card(CardFace.Two, CardSuit.Hearts),
                    new Card(CardFace.Two, CardSuit.Spades),
                    new Card(CardFace.Three, CardSuit.Clubs),
                    new Card(CardFace.Three, CardSuit.Hearts),
                 });

                var result = new PokerHandsChecker().IsOnePair(hand);

                Assert.IsFalse(result, "IsOnePair - should have returned false for " +
                   "3 cards with one face and 2 cards with another face");
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

                var result = new PokerHandsChecker().IsOnePair(hand);

                Assert.IsFalse(result, "IsOnePair - should have returned false for " +
                    "5 cards, of the same suit and not in seqential order");
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

                var result = new PokerHandsChecker().IsOnePair(hand);

                Assert.IsFalse(result, "IsOnePair - should have returned false for " +
                    "5 cards in a row of different suits");
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

                var result = new PokerHandsChecker().IsOnePair(hand);

                Assert.IsFalse(result, "IsOnePair - should have returned false for " +
                    "3 cards with the same face and 2 cards with different faces");
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

                var result = new PokerHandsChecker().IsOnePair(hand);

                Assert.IsFalse(result, "IsOnePair - should have returned true for " +
                "2 pairs of cards, with the same face and different suits");
            }

            [TestMethod]
            public void TestOnePair_ReturnFalseWithHighCardCards()
            {
                IHand hand = new Hand(new List<ICard>() {
                    new Card(CardFace.Two,  CardSuit.Clubs),
                    new Card(CardFace.Four, CardSuit.Hearts),
                    new Card(CardFace.King, CardSuit.Spades),
                    new Card(CardFace.Five, CardSuit.Diamonds),
                    new Card(CardFace.Queen,CardSuit.Clubs),
                });

                var result = new PokerHandsChecker().IsOnePair(hand);

                Assert.IsFalse(result, "IsOnePair - should have returned false for " +
               "5 cards, none of which are in order, have the same suit, or the same rank");
            }

        /*Tests for HIGH CARD*/
        [TestMethod]
        public void TestHighCard_ReturnTrueWithHighCardCards()
        {

                Assert.IsTrue(result, "IsHighCard - should have returned true for " +
               "5 cards, none of which are in order, have the same suit, or the same rank");
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

        }
    }
}
