using System;

namespace Frågesport
{
    class Program
    {
        static void Main(string[] args)
        {
            int question = 0;
            int points = 0;
            int game = 0;
            Console.WriteLine("Det hät är en frågesport om League of legends items  \n skriv s för att starta");
            string start = Console.ReadLine().ToLower();

            while (start == "s")
            {
                game = 1;
            }

            while (game == 1)
            {
                question++;
                game = 0;
            }

            if (question == 1 && game == 1)
            {

                string answer1 = AnswerQuestion();

                Question1();
                if (answer1 == "c")
                {
                    Console.WriteLine("korrekt");
                    points++;
                    game = 1;
                }
                else
                {
                    Console.WriteLine("Inkorrekt");
                    game = 1;
                }

            }




        }

        static void Question1()
        {
            Console.WriteLine("Hur många stacks har black cleavers armor shred passsive? \n A: 4 \n B: 5 \n C: 6 \n D: 7");
        }

        static string AnswerQuestion()
        {
            string answer = "";

            while (answer != "a" && answer != "b" && answer != "c" && answer != "d")
            {
                Console.WriteLine("Only a, b, c, or d is a valid answer");
                answer = Console.ReadLine().ToLower();
            }
            return answer;

        }
    }


}
