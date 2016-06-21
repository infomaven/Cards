using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;




namespace PlayCards
{
    [TestFixture ()]
    public class DeckTest
    {
        //Deck testDeck;
        PlayCards.List<Card> testDeck;
        
        
        [SetUp]
        public void DeckCreation ()
        {
            //// create a new unsorted, unshuffled deck of cards
            //  PlayCards.Deck deck = new Deck ();
            //deck.SpawnNewDeck ();
            //  testDeck = deck;
            
          //  var result = Card.CreateDeck ();
         //   this.testDeck = result.Cast<Card> ().ToList ();
                       
        }

        [Test ()]
        public void TestCreateDeckCheckCount ()
        {            
            // verify that deck contains 52 cards
          //  Assert.AreEqual (52, testDeck.MyDeck.Count);

        }

        [Test ()]
        public void TestDeckSuits ()
        {
            // 4 card suits exist in the deck
        }

        [Test ()]
        public void TestPointValues ()
        {
            // each card suit contains full range of face values
        }

        [Test ()]
        public void TestShuffleDeck ()
        {
            // cards have no more than 2 cards  in asc order. suits may or may not be maintained
        }

        [Test ()]
        public void TestSortDeck ()
        {
            // cards are grouped by suit & points are in asc order
        }
    }

    class List<T>
    {
    }
}

