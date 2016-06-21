            using System;
            using System.Collections.Generic;
            using System.Net;
            using System.Globalization;
            using System.Linq;
            using System.Runtime.CompilerServices;
          using System.Security.Cryptography.X509Certificates;
  using System.Collections;
    
    namespace PlayCards
    {
        /// <summary>
        /// Please complete both of the following exercises, being sure to follow all the guidelines listed below.
        /// Write a method, function, or procedure that sorts a standard deck of 52 playing Cards in ascending order. 
        /// You are free to determine what the term “ascending order” means for a deck of Cards, but be ready to discuss your choice during the interview.
        /// Write a method, function, or procedure that randomly shuffles a standard deck of 52 playing Cards.
        /// </summary>
        public class Deck
        {
    
            public static void Main (string [] args)
            {
                List<Card> initial = Card.CreateDeck ();
                Console.WriteLine ("Deck created with " + initial.Count + " items");

                // List<Card> sorted = Card.SortByFaceValue (initial);
                List<Card> sorted = Card.SortByFaceValue (initial);
                Console.WriteLine ("\nSorted by card face value.");
                PrintDeck (sorted);
    
                List<Card> shuffled = Card.ShuffleTheDeck (initial);
                Console.WriteLine ("\nShuffled deck: ");
                PrintDeck (shuffled);
    
            }
    
            public static void PrintDeck (List<Card> currentDeck)
            {       
                // print members of the deck 
                foreach (var item in currentDeck) {               
                    Console.WriteLine (item.suit + " " + item.faceValue);
                }
            }
        }
    
        public struct Card : IComparable<Card>
        {
            public Suit suit { get; private set; }
            public FaceValue faceValue { get; private set; }
    
            public Card (Suit suit, FaceValue rank) : this ()
            {
                this.suit = suit;
                this.faceValue = rank;
            }
    
            public override string ToString ()
            {
                return string.Format ("{0} {1}", (Char)this.suit, this.faceValue);
            }
    
            public int CompareTo (Card other)
            {
                return faceValue.CompareTo (other.faceValue);
            }
    
            /// <summary>
            //h/ Suit. Provide numerical alias to  Suit
            /// </summary>
            public enum Suit
            {
                Spades = 1,
                Hearts = 2,
                Diamonds = 3,
                Clubs = 4
            }
    
            // asuuming Aces are low & Jokers are Wild         
            public enum FaceValue
            {
                Two = 2,
                Three = 3,
                Four = 4,
                Five = 5,
                Six = 6,
                Seven = 7,
                Eight = 8,
                Nine = 9,
                Jack = 10,
                Queen = 11,
                King = 12,
                Ace = 1,
                Joker = 13
            }
    
    
            public static List<Card> CreateDeck ()
            {
                IEnumerable<Suit> suits = Enum.GetValues (typeof (Suit)).Cast<Suit> ();
                IEnumerable<FaceValue> faceValues = Enum.GetValues (typeof (FaceValue)).Cast<FaceValue> ();
    
                var result = from su in suits
                             from fv in faceValues
                             select new Card (su, fv);
                return result.ToList ();
            }
    
            public static List<Card> SortByFaceValue (List<Card> candidate)
            {            
                var result = candidate.OrderBy (x => x.faceValue).Take (52);
                return result.ToList ();
            }
    
            public static List<Card> ShuffleTheDeck (List<Card> startOrder)
            {    
                var shuffled = startOrder.OrderBy (x => Guid.NewGuid ()).Take (52);
                return shuffled.ToList ();
    
            }
    
    
        }
        
    }
