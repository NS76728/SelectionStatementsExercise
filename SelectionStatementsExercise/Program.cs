using System;

namespace SelectionStatementsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
           

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

          


        }
    }
}
