using System;

namespace slutprojPRR2
{
    public class Card
    {
        public static Random random = new Random();

        private int value;

        public Card()
        {
            value = random.Next(1, 11);
        }
    }
}
