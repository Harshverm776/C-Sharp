using System;

namespace Challenge_If_Statement_2
{
    class Program
    {
        static int highscore = 300;
        static string highscorePlayer = "Harsh";

        static void Main(string[] args)
        {
            CheckHighscore(250, "Deepansh");
            CheckHighscore(315, "Saini");
            CheckHighscore(350, "Anupam");

            Console.Read();
        }

        public static void CheckHighscore(int score, string playerName)
        {
            if (score > highscore)
            {
                highscore = score;
                highscorePlayer = playerName;

                Console.WriteLine("New highscore is " + score);
                Console.WriteLine("It is now held by " + playerName);

            }
            else
            {
                Console.WriteLine("The old highscore could not be broken. It is still "
                    + highscore + " and held by " + highscorePlayer);
            }
        }

    }
}
