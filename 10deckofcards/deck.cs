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
            this.Reset();
        }

        public Card Deal()
            {
                Card card = Cards[0];
                System.Console.WriteLine($"You were dealt {card.StringVal} of {card.Suit}");
                Cards.RemoveAt(0);
                return card;
            }

        public void Reset()
        {
            Cards.Clear();
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

        public void Shuffle()
        {
            List<Card> cards = this.Cards;
            List<Card> shuffled = new List<Card>();
            Random card = new Random();
            while(cards.Count > 0)
            {
                int idx = card.Next(0, cards.Count);
                shuffled.Add(cards[idx]);
                cards.RemoveAt(idx);
            }
            this.Cards = shuffled;
        }
    }
}

        // public List<Card> Reset()
        // {
        //     Card.Clear();
        //     for(int i = 0; i < 4; i++)
        //     {
        //         int j = 1;
        //         while(j < 14)
        //         {
        //             Card.Add(new Card(Card.Suits[i], j));
        //             j++;
        //         }
        //     }
        //     return Card;