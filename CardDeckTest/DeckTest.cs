using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;




namespace PlayCards
{
  

    
    
    [TestFixture ()]
    public class DeckTest
    {
     
        [SetUp]
        public void DeckCreation ()
        {
                     
        }

        [Test ()]
        public void TestCreateDeckCheckCount ()
        {
            Card.CreateDeck ();
                     
            // verify that deck contains 52 cards
            Assert.AreEqual (52, Card.fullDeck.Count);

        }

        [Test ()]
        public void TestDeckSuits ()
        {
            // 4 card suits exist in the deck
            var result = Enum.GetValues (typeof (Card.Suit));

            Assert.AreEqual (4, result.Length);
        }

        [Test ()]
        public void TestPointValues ()
        {
            // each card suit contains full range of face values
            var result = Enum.GetValues (typeof (Card.FaceValue));

            Assert.AreEqual (13, result.Length);
        }

        [Test ()]
        public void TestShuffleDeck ()
        {
            // capture samples of a blank deck and a shuffled deck
            Card.CreateDeck ();
            var genericDeck = Card.fullDeck;           
            Card.CreateDeck ();
            var shuffledDeck = Card.ShuffleTheDeck (Card.fullDeck);
            
            Assert.AreNotEqual ( genericDeck, shuffledDeck);
            
           
        }

        [Test ()]
        public void TestSortDeck ()
        {
            // capture blank deck & sorted deck samples
            Card.CreateDeck ();
            var genericDeck = Card.fullDeck;
            Card.CreateDeck ();
            var sortedDeck = Card.SortByFaceValue (Card.fullDeck);
            
            Assert.AreNotEqual ( genericDeck, sortedDeck);
        }
    }

    
}

