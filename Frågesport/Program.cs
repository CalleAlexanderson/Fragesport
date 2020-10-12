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

            question = Rotation(question);

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
                Console.ReadLine();
                Console.Clear();

            }

            question = Rotation(question);

            if (question == 2)
            {
                Question2();
                string answer2 = AnswerQuestion();
                if (answer2 == "d")
                {
                    Console.WriteLine("korrekt");
                    points++;
                }
                else
                {
                    Console.WriteLine("Inkorrekt");
                }
                Console.ReadLine();
                Console.Clear();
            }
            question = Rotation(question);

            if (question == 3)
            {
                Question3();
                string answer3 = AnswerQuestion();
                if (answer3 == "b")
                {
                    Console.WriteLine("korrekt");
                    points++;
                }
                else
                {
                    Console.WriteLine("Inkorrekt");
                }
                Console.ReadLine();
                Console.Clear();
            }

            question = Rotation(question);

            if (question == 4)
            {
                Question4();
                string answer4 = AnswerQuestion();
                if (answer4 == "b")
                {
                    Console.WriteLine("korrekt");
                    points++;
                }
                else
                {
                    Console.WriteLine("Inkorrekt");
                }
                Console.ReadLine();
                Console.Clear();
            }

            question = Rotation(question);

            if (question == 5)
            {
                Question5();
                string answer5 = AnswerQuestion();
                if (answer5 == "a")
                {
                    Console.WriteLine("korrekt");
                    points++;
                }
                else
                {
                    Console.WriteLine("Inkorrekt");
                }
                Console.ReadLine();
                Console.Clear();

            }

            Console.WriteLine("Du fick " + points + " poäng");
            if (points == 5)
            {
                Console.WriteLine("Du vann");
            }
            else
            {
                Console.WriteLine("Bättre lycka nästa gång");
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

        static void Question3()
        {
            Console.WriteLine("Hur mycket magic penetration ger sorcerer shoes? \n A: 15 \n B: 18 \n C: 20 \n D: 21");
        }

        static void Question4()
        {
            Console.WriteLine("Vad heter abyssal masks unique passive? \n A: Abyss \n B: Aura \n C: Magic aura \n D: Abyssal aura");
        }

        static void Question5()
        {
            Console.WriteLine("Vad är det dyraste föremålet på summoners rift? \n A: Trinity force \n B: Deatch cap \n C: Deaths dance \n D: The golden spatula");
        }

        static int Rotation(int currentQ)
        {
            int game = 0;
            game++;
            while (game == 1)
            {
                currentQ++;
                game--;
            }
            return currentQ;
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
