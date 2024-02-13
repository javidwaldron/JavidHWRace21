using System;
using System.Collections.Generic;

namespace JavidHWRace21
{
    /// <summary>
    /// Class representing individual player:
    /// name, cards in hand, score (sum of current card values), status (from enum PlayerStatus)
    /// </summary>
    public class Player
    {
        public string name;
        public List<Card> cards = new List<Card>();
        public PlayerStatus status = PlayerStatus.active;
        public int score;


        public Player(string n)
        {
            name = n;
        }

        /// <summary>
        /// Introduces player by name. Called by CardTable object.
        /// </summary>
        /// <param name="playerNum"></param>
        public void Introduce(int playerNum)
        {
            Console.WriteLine("" + name + " is now player #" + playerNum);

        }
    }
}