using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    // Give the Player class a name property.
    // Give the Player a hand property that is a List of type Card.
    // Give the Player a draw method of which draws a card from a deck, adds it to the player's hand and returns the Card.
    // Note this method will require reference to a deck object
    // Give the Player a discard method which discards the Card at the specified index from the player's hand and returns this Card or null if the index does not exist.
    class Player
    {
        public string Name {get; set;}
        public List<Card> Hand {get; set;}
        // Player Constructor
        public Player(string name)
        {
            Name = name;
            Hand = new List<Card>();
        }

        public Card Draw(Deck Deck)
        {
            Card NewCard = Deck.Deal();
            Hand.Add(NewCard);
            return NewCard;
        }

        public Card Discard(int Idx)
        {
            Card Discard = Hand[Idx];
            Hand.RemoveAt(Idx);
            return Discard;
        }
    }
}