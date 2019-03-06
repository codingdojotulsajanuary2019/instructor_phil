using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck newDeck = new Deck();
            newDeck.Deal();
            newDeck.DisplayDeck();
            newDeck.Shuffle();
            newDeck.DisplayDeck();
            string[] Players = new string[] {"Michael", "Skylar", "Kunle", "Cros", "Jeremy", "Phil"};
            List<Player> Game = new List<Player>();
            for(int i=0; i<Players.Length; i++) {
                Game.Add(new Player(Players[i]));
            }
            for(int i=0; i<Players.Length; i++) {
                for(int j=0; j<2; j++) {
                    Game[i].Draw(newDeck);
                }
            }
            for(int i=0; i<Players.Length; i++) {
                Console.WriteLine($"--------------------------------- {Game[i].Name} cards ---------------------------------");
                for(int j = 0; j<Game[i].Hand.Count; j++)
                {
                    Console.WriteLine(Game[i].Hand[j].StringVal);
                }
            }
        }
    }
}
