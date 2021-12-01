using System;
using System.Collections.Generic;

namespace DeckOfCards
{
class Deck
    {
        public List<Card> Cards;
        public Deck()
        {
            Cards = new List<Card>();

            string[] suits = {"Hearts", "Diamonds", "Clubs", "Spades"};
            string[] stringVal = {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};
            for(int i = 0; i < suits.Length; i++)
            {
                for(int j = 0; j < stringVal.Length; j++)
                {
                    Cards.Add(new Card(suits[i], stringVal[j], j+1));
                    Console.WriteLine($"This is the {stringVal[j]} of {suits[i]}");
                }
            }
        }
    }
}