using System;

namespace DeckOfCards
{
    // Give the Card class a property "stringVal" which will hold the value of the card ex. (Ace, 2, 3, 4, 5, 6, 7, 8, 9, 10, Jack, Queen, King). This "val" should be a string.
    // Give the Card a property "suit" which will hold the suit of the card (Clubs, Spades, Hearts, Diamonds).
    // Give the Card a property "val" which will hold the numerical value of the card 1-13 as integers.
    class Card
    {
        private string Suit;
        private int Val;
        protected int Num = 0;
        private string stringVal;

        public string StringVal{
            get{
                string val;
                switch (Val)
                {
                    case 1:
                        val = "Ace";
                        break;
                    case 11:
                        val = "Jack";
                        break;
                    case 12:
                        val = "Queen";
                        break;
                    case 13:
                        val = "King";
                        break;
                    default:
                        val = Val.ToString();
                        break;
                }
                return $"{val} of {Suit}";
            }
        }
        //Card Constructor
        public Card(string suit, int val)
        {
            Suit = suit;
            Val = val;
        }
    }
}