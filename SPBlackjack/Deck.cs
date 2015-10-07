using System;
using System.Collections.Generic;
using System.Linq;
/// <summary>
/// Written by Nicolas Kheirallah
/// 04-10-2015
/// </summary>
namespace BlackJack
{
    class Deck
    {
        List<Card> deck = new List<Card>();
        private int currentCard;
        public static readonly int Deck_Size = 52;
        Random rand = new Random();
        public Deck()
        {
            currentCard = 0;
            foreach (CardSuits s in Enum.GetValues(typeof(CardSuits)))
            {
                foreach (CardValue v in Enum.GetValues(typeof(CardValue)))
                {
                    deck.Add(new Card(s,v));
                    
                }
            }
            
        }

        public void shuffle() //Shuffles the cards
        {
            int index;
            for (int i = 0; i < Deck_Size; i++)
            {
                index = (int) (Deck_Size * rand.NextDouble());
                Card tmp = deck[i];
                deck[i] = deck[index];
                deck[index] = tmp;
            }

            currentCard = 0;
        }

        public Card deal()
        {
            if (currentCard < Deck_Size)
            {
                return deck.ElementAt(currentCard++);
            }
            else
            {
                Console.WriteLine("All cards have been dealt");
                return null;
            }
            
        }
    }
}
