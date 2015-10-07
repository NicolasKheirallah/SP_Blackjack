using System;

/// <summary>
/// Written by Nicolas Kheirallah
/// 04-10-2015
/// </summary>
namespace BlackJack
{
    class Card
    {/// <summary>
     /// Properties 
     /// </summary>
            public CardSuits Suits { get; set; }
            public CardValue Value { get; set; }

            public Card(CardSuits suits, CardValue value)
            {
                Suits = suits;
                Value = value;
            }
        public override String ToString()
        {
            return Value + " of " + Suits;
        }
    }
}
