using System;

namespace HiloGame
{
    public class Card
    {
        int number = 0;

        public Card() { }

        public int pick_card()
        {
            Random random = new Random();
            number = random.Next(1, 13);
            return number;
        }
    }
}