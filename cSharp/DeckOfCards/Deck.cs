using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    class Deck
    {
    // Give the Deck class a property called "cards" which is a list of Card objects.
        public List<Card> Cards {get;set;}
        // Deck Constructor
        public Deck()
        {
        // When initializing the deck, make sure that it has a list of 52 unique cards as its "cards" property.
            CreateDeck();
            Console.WriteLine(Cards.Count);
        }
        public void CreateDeck()
        {
            Cards = new List<Card>();
            int[] FaceValue = new int[] {1,2,3,4,5,6,7,8,9,10,11,12,13};
            string[] Suit = new string[] {"Hearts", "Diamonds", "Clubs", "Spades"};
            for(int i = 0; i < FaceValue.Length; i++)
            {
                for(int j = 0; j < Suit.Length; j++)
                {
                    Cards.Add(new Card(Suit[j], FaceValue[i]));
                }
            }
        }
        // Give the Deck a deal method that selects the "top-most" card, removes it from the list of cards, and returns the Card.
        public Card Deal()
        {
            Card rCard = Cards[0];
            Cards.RemoveAt(0);
            return rCard;
        }
        // Give the Deck a reset method that resets the cards property to contain the original 52 cards.
        public void Reset()
        {
            CreateDeck();
        }
        // Give the Deck a shuffle method that randomly reorders the deck's cards.
        public void Shuffle()
        {
            Random Rnd = new Random();
            for(int i = 0; i < Cards.Count; i++)
            {
                int Swap = Rnd.Next(Cards.Count);
                Card Card = Cards[i];
                Cards[i] = Cards[Swap];
                Cards[Swap] = Card;
            }
        }
        public void DisplayDeck()
        {
            for(int i = 0; i < Cards.Count; i++)
            {
                Console.WriteLine(Cards[i].StringVal);
            }
        }
    }
}