using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Poker
{
    class PokerExample
    {
        static void Main()
        {

            /*
            ICard card = new Card(CardFace.Ace, CardSuit.Clubs);
            Console.WriteLine(card);

            IHand hand = new Hand(new List<ICard>() { 
                new Card(CardFace.Ace, CardSuit.Clubs),
                new Card(CardFace.Ace, CardSuit.Diamonds),
                new Card(CardFace.King, CardSuit.Hearts),
                new Card(CardFace.King, CardSuit.Spades),
                new Card(CardFace.Seven, CardSuit.Diamonds),
            });
            */

            ///test for if 
            IHand hand = new Hand(new List<ICard>() {
                    new Card(CardFace.Two,  CardSuit.Clubs),
                    new Card(CardFace.Four, CardSuit.Hearts),
                    new Card(CardFace.King, CardSuit.Spades),
                    new Card(CardFace.Five, CardSuit.Diamonds),
                    new Card(CardFace.Queen,CardSuit.Clubs),
                });

            var result = new PokerHandsChecker().IsHighCard(hand);

            Assert.IsTrue(result, "IsHighCard - should have returned true for " +
               "5 cards, none of which are in order, have the same suit, or the same rank");

            Console.WriteLine(hand);

        }
    }
}
