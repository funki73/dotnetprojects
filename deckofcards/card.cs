using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    class Card
    {
            public string stringVal;
            public string Suit;

            public int Val;

            public Card (string stringVal, string suit, int val)
            {
                stringVal = stringVal;
                Suit = suit;
                Val = val;
            }
    }
}