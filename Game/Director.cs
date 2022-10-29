using System;

namespace HiloGame
{
    public class Director
    {
        bool isPlaying = true;

        Card myCard = new Card();

        Card nextCard = new Card();

        Card intScore = new Card();

        int totalScore;
        int current_card;
        int nextcard;
        string guess_card;

        public Director()
        {
            current_card = myCard.pick_card();
            totalScore = 100;
        }

        public void StartGame()
        {
            while (isPlaying)
            {
                getInputs();
                doUpdates();
                getRender();
            }
        }

        public void getInputs()
        {
            Console.WriteLine($"This card is: {current_card}");
            Console.Write("Higher or Lower? [h/l] ");
            guess_card = Console.ReadLine();
        }

        // Vin. Everything is completed up until the input. Complete the last 2 methods. Text us if you need help.
        public void doUpdates()
        {
            nextcard = nextCard.pick_card();
            Console.WriteLine($"Next Card: {nextcard}");
            if (guess_card == "h")
            {
                if (nextcard >= current_card)
                {
                    totalScore = totalScore + 100;
                }
                else if (nextcard < current_card)
                {
                    totalScore = totalScore - 75;
                }
            }
            else if (guess_card == "l")
            {
                if (nextcard < current_card)
                {
                    totalScore = totalScore + 100;
                }
                else if (nextcard > current_card)
                {
                    totalScore = totalScore - 75;
                }
            }
            if (totalScore <= 0)
            {
                isPlaying = false;
            }
            current_card = nextcard;
        }

        public void getRender()
        {
            if (!isPlaying)
            {
                return;
            }

            Console.WriteLine($"Your score is: {totalScore}\n");
            Console.Write("Would you like to play again (y/n)? ");
            string playagain = Console.ReadLine();
            if (playagain == "y")
            {
                isPlaying = true;
            }
            else if (playagain == "n")
            {
                Console.WriteLine("Thanks for playing!");
                isPlaying = false;
            }
        }
    }
}