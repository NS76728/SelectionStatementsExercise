using System;

namespace SelectionStatementsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var r = new Random();
            var faveNum = r.Next(1, 1000);

            Console.WriteLine("What is my favorite number?");
            int use = int.Parse(Console.ReadLine());

            if (use < faveNum)
            {
                Console.WriteLine("Too Low");
            }
            else if(use > faveNum)
            {
                Console.WriteLine("Too High");
            }
            else
            {
                Console.WriteLine("Nevermind");
            }

            Console.WriteLine("What is your favorit subject?");
            Console.WriteLine("1: Math 2: Science 3: History 4: English 5: Art ");
            string use2 = Console.ReadLine();
                //int.Parse(Console.ReadLine());


            switch (use2)
            {
                case "math":
                    Console.WriteLine("Math is cool");
                    break;
                case "science":
                    Console.WriteLine("Science is cool");
                    break;
                case "history":
                    Console.WriteLine("History is cool");
                    break;
                case "english":
                    Console.WriteLine("English is cool");
                    break;
                case "art":
                    Console.WriteLine("Art is cool");
                    break;
                default:
                    Console.WriteLine("Thats not a subject choice or you spelt it wrong. (All lower case)");
                    break;
            }


        }
    }
}
