using System;
using System.Collections.Generic;
using System.Linq; // currently only needed if we use alternate shuffle method

namespace JavidHWRace21
{
    /// <summary>
    /// Manages a standard deck of 52 cards, represented as a list of Card instances.
    /// </summary>
    public class Deck
    {
        List<Card> cards = new List<Card>();

        /// <summary>
        /// Constructor for an ordered deck of cards.
        /// </summary>
        public Deck()
        {
            Console.WriteLine("Building Deck..........");
            string[] suits = { "S", "H", "C", "D" };

            for (int cardVal = 1; cardVal <= 13; cardVal++)
            {
                foreach (string cardSuit in suits)
                {
                    string cardName;
                    string cardLongName;

                    switch (cardVal)
                    {
                        case 1:
                            cardName = "A";
                            cardLongName = "Ace of ";
                            break;
                        case 11:
                            cardName = "J";
                            cardLongName = "Jack of ";
                            break;
                        case 12:
                            cardName = "Q";
                            cardLongName = "Queen of ";
                            break;
                        case 13:
                            cardName = "K";
                            cardLongName = "King of ";
                            break;
                        default:
                            cardName = cardVal.ToString();
                            cardLongName = cardVal.ToString() + " of ";
                            break;
                    }

                    switch (cardSuit)
                    {
                        case "S":
                            cardLongName += "Spades";
                            break;
                        case "H":
                            cardLongName += "Hearts";
                            break;
                        case "C":
                            cardLongName += "Clubs";
                            break;
                        case "D":
                            cardLongName += "Diamonds";
                            break;
                    }
                    cards.Add(new Card { ID = cardName + cardSuit, name = cardLongName });
                }
            }
        }

        /// <summary>
        /// Randomly swap cards to shuffle the deck.
        /// </summary>
        public void Shuffle()
        {
            Console.WriteLine();
            Console.WriteLine("Shuffling Cards.....");
            Console.WriteLine();

            Random rng = new Random(); // rng is short for "Random Number Generator"

            // one-line method that uses Linq
            // (only uncomment this and comment out the multi-line approach
            // after you understand this approach!):
            // cards = cards.OrderBy(a => rng.Next()).ToList();

            // multi-line approach that uses Array notation on a list!
            // (this should be easier to understand):
            for (int i = 0; i < cards.Count; i++)
            {
                Card tmp = cards[i];
                int swapindex = rng.Next(cards.Count);
                cards[i] = cards[swapindex];
                cards[swapindex] = tmp;
            }
        }


        /// <summary>
        /// Shows all cards. Kinda hacky. See comment below.
        /// </summary>
        /* Maybe we can make a variation on this that's more useful,
         * but at the moment it's just really to confirm that our 
         * shuffling method(s) worked! And normally we want our card 
         * table to do all of the displaying, don't we?!
         */
        public void ShowAllCards()


        {

            Console.WriteLine("                              _____\r\n   _____                _____ |6    |\r\n  |2    | _____        |5    || o o | \r\n  |  o  ||3    | _____ | o o || o o | _____\r\n  |     || o o ||4    ||  o  || o o ||7    |\r\n  |  o  ||     || o o || o o ||____6|| o o | _____\r\n  |____2||  o  ||     ||____5|       |o o o||8    | _____\r\n         |____3|| o o |              | o o ||o o o||9    |\r\n                |____4|              |____7|| o o ||o o o|\r\n                                            |o o o||o o o|\r\n                                            |____8||o o o|\r\n                                                   |____9|\r\n \r\n\r\n");
        }
        /// <summary>
        /// Remove top card (defined here as last card in the list), an instance of Card
        /// </summary>
        /// <returns>the removed instance of Card, representing one of the 52 cards in the deck</returns>
        public Card DealTopCard()
        {
            Card card = cards[cards.Count - 1];
            cards.RemoveAt(cards.Count - 1);
            // Console.WriteLine("I'm giving you " + card);
            return card;
        }
    }
}

