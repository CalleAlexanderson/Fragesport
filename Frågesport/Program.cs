using System;

namespace Frågesport
{
    class Program
    {
        static void Main(string[] args)
        {
            int question = 0;
            int points = 0;
            Console.WriteLine("Det hät är en frågesport om League of legends items");

            question = Rotation();

            Rotation();
            if (question == 1)
            {
                Question1();
                string answer1 = AnswerQuestion();


                if (answer1 == "c")
                {
                    Console.WriteLine("korrekt");
                    points++;
                }
                else
                {
                    Console.WriteLine("Inkorrekt");
                }

            }
            Rotation();
            if (question == 2)
            {
                Question2();
            }
            Console.ReadLine();



        }

        static void Question1()
        {
            Console.WriteLine("Hur många stacks har black cleavers armor shred passsive? \n A: 4 \n B: 5 \n C: 6 \n D: 7");
        }

        static void Question2()
        {
            Console.WriteLine("Hur mycket mana får man totalt från Tear of the goddess när den är full? \n A: 250 \n B: 500 \n C: 750 \n D: 1000 ");
        }

        static int Rotation()
        {
            int questionmet = 0;
            int game = 0;
            game++;
            while (game == 1)
            {
                questionmet++;
                game--;
            }
            return questionmet;
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
