using System;

namespace SeasonSimulator
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter 'P' for Professional simulator, enter 'H' for Highschool simulator");
            string input = Console.ReadLine();
            switch (input)
            {
                case "P":
                    {
                        Offense.Batting();
                        break;
                    }
                case "H":
                    {
                        HighSchool.Batting();
                        break;
                    }
            }

        }
    }
}
