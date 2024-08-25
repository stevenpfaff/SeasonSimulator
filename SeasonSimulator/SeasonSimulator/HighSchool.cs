using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SeasonSimulator
{
    class HighSchool
    {
        public static void Batting()
        {
            Console.WriteLine("Enter Player Name");
            var name = Console.ReadLine();
            Console.WriteLine("Enter Ratings On 20-80 Scale.");
            Console.WriteLine("Power tool, must end in 0.");
            int power = 0;
            var validInput = false;
            while (!validInput)
            {
                var powerInput = Console.ReadLine();
                validInput = int.TryParse(powerInput, out power);
                if (!validInput)
                {
                    Console.WriteLine("Enter Number Value.");
                    Console.Beep();
                }
            }
            Console.WriteLine("Hit tool, must end in 0.");
            int hit = 0;
            var validHitInput = false;
            while (!validHitInput)
            {
                var hitInput = Console.ReadLine();
                validHitInput = int.TryParse(hitInput, out hit);
                if (!validHitInput)
                {
                    Console.WriteLine("Enter Number Value.");
                    Console.Beep();
                }
            }
            //Eye tool effects strikeout and walk rate
            Console.WriteLine("Eye tool, must end in 0.");
            int eye = 0;
            var validEyeInput = false;
            while (!validEyeInput)
            {
                var eyeInput = Console.ReadLine();
                validEyeInput = int.TryParse(eyeInput, out eye);
                if (!validEyeInput)
                {
                    Console.WriteLine("Enter Number Value.");
                    Console.Beep();
                }
            }
            //reads user back name and ratings.
            Console.WriteLine("Name: " + name + " Power: " + power + " Hit: " + hit);
            Console.WriteLine("Set The Number of Plate Appearances You'd Like Your Player To Have.");
            int pa = 0;
            var validPaInput = false;
            while (!validPaInput)
            {
                var paInput = Console.ReadLine();
                validPaInput = int.TryParse(paInput, out pa);
                if (!validPaInput)
                {
                    Console.WriteLine("Enter Number Value.");
                    Console.Beep();
                }
            }
                int singles = 0;
                int doubless = 0;
                int triples = 0;
                int homeruns = 0;
                int strikeouts = 0;
                int walks = 0;
                int regouts = 0;

                Random rnds = new();
                int[] intArrs = new int[pa];
                for (int i = 0; i < pa; i++)
                {
                    int result = rnds.Next(1, 1000);
                    intArrs[i] = result++;
                // Minimum hit ratings, 20-30 Power
                if (eye <= 20)
                {
                    if (result <= 350)
                    {
                        strikeouts++;
                    }
                    else if (350 < result && result <= 400)
                    {
                        walks++;
                    }
                }
                else if (eye == 30)
                {
                    if (result <= 300)
                    {
                        strikeouts++;
                    }
                    else if (300 < result && result <= 400)
                    {
                        walks++;
                    }
                }
                else if (eye == 40)
                {
                    {
                        if (result <= 250)
                        {
                            strikeouts++;
                        }
                        else if (250 < result && result <= 400)
                        {
                            walks++;
                        }
                    }
                }
                else if (eye == 50)
                {
                    {
                        if (result <= 200)
                        {
                            strikeouts++;
                        }
                        else if (200 < result && result <= 400)
                        {
                            walks++;
                        }
                    }
                }
                else if (eye == 60)
                {
                    {
                        if (result <= 150)
                        {
                            strikeouts++;
                        }
                        else if (150 < result && result <= 400)
                        {
                            walks++;
                        }
                    }
                }
                else if (eye == 70)
                {
                    {
                        if (result <= 100)
                        {
                            strikeouts++;
                        }
                        else if (100 < result && result <= 400)
                        {
                            walks++;
                        }
                    }
                }
                else if (eye == 80)
                {
                    {
                        if (result <= 80)
                        {
                            strikeouts++;
                        }
                        else if (80 < result && result <= 400)
                        {
                            walks++;
                        }
                    }
                }
                if (power <= 20)
                {
                    if (810 < result && result <= 995)
                    {
                        singles++;
                    }
                    else if (990 < result && result <= 1000)
                    {
                        doubless++;
                    }
                }
                else if (power == 30)
                {
                    if (810 < result && result <= 990)
                    {
                        singles++;
                    }
                    else if (990 < result && result <= 1000)
                    {
                        doubless++;
                    }
                }
                else if (power == 40)
                {
                    if (750 < result && result <= 940)
                    {
                        singles++;
                    }
                    else if (940 < result && result <= 993)
                    {
                        doubless++;
                    }
                    else if (993 < result && result <= 995)
                    {
                        triples++;
                    }
                    else if (995 < result && result <= 1000)
                    {
                        homeruns++;
                    }
                }
                else if (power == 50)
                {
                    if (720 < result && result <= 970)
                    {
                        singles++;
                    }
                    else if (970 < result && result <= 993)
                    {
                        doubless++;
                    }
                    else if (993 < result && result <= 995)
                    {
                        triples++;
                    }
                    else if (995 < result && result <= 1000)
                    {
                        homeruns++;
                    }
                }
                else if (power == 60)
                {
                    if (680 < result && result <= 950)
                    {
                        singles++;
                    }
                    else if (950 < result && result <= 985)
                    {
                        doubless++;
                    }
                    else if (985 < result && result <= 987)
                    {
                        triples++;
                    }
                    else if (987 < result && result <= 1000)
                    {
                        homeruns++;
                    }
                }
                else if (power == 70)
                {
                    if (650 < result && result <= 900)
                    {
                        singles++;
                    }
                    else if (900 < result && result <= 975)
                    {
                        doubless++;
                    }
                    else if (975 < result && result <= 980)
                    {
                        triples++;
                    }
                    else if (980 < result && result <= 1000)
                    {
                        homeruns++;
                    }
                }
                else if (power == 80)
                {
                    if (650 < result && result <= 870)
                    {
                        singles++;
                    }
                    else if (870 < result && result <= 960)
                    {
                        doubless++;
                    }
                    else if (960 < result && result <= 970)
                    {
                        triples++;
                    }
                    else if (970 < result && result <= 1000)
                    {
                        homeruns++;
                    }
                }
                if (hit <= 20)
                {
                    if (400 < result && result <= 830)
                    {
                        regouts++;
                    }
                }
                else if (hit == 30)
                {
                    if (400 < result && result <= 810)
                    {
                        regouts++;
                    }
                }
                else if (hit == 40)
                {
                    if (400 < result && result <= 750)
                    {
                        regouts++;
                    }
                }
                else if (hit == 50)
                {
                    if (400 < result && result <= 720)
                    {
                        regouts++;
                    }
                }
                else if (hit == 60)
                {
                    if (400 < result && result <= 680)
                    {
                        regouts++;
                    }
                }
                else if (hit == 70)
                {
                    if (400 < result && result <= 650)
                    {
                        regouts++;
                    }
                }
                else if (hit == 80)
                {
                    if (400 < result && result <= 620)
                    {
                        regouts++;
                    }
                }

        }

                Console.WriteLine("Hits: {0}", singles + doubless + triples + homeruns);
                Console.WriteLine("Doubles: {0}", doubless);
                Console.WriteLine("Triples: {0}", triples);
                Console.WriteLine("Homeruns: {0}", homeruns);
                Console.WriteLine("Strikeouts: {0}", strikeouts);
                Console.WriteLine("Walks: {0}", walks);
                Console.WriteLine("At-Bats: {0}", singles + doubless + triples + homeruns + strikeouts + regouts);
                Console.WriteLine("Batting Average: {0}", ((double)singles + doubless + triples + homeruns) / (singles + doubless + triples + homeruns + strikeouts + regouts));
                Console.WriteLine("On Base Percentage: {0}", ((double)singles + doubless + triples + homeruns + walks) / (singles + doubless + triples + homeruns + strikeouts + regouts + walks));
                Console.WriteLine("Slugging Percentage: {0}", ((double)singles + (doubless * 2) + (triples * 3) + (homeruns * 4)) / (singles + doubless + triples + homeruns + strikeouts + regouts));
                Console.WriteLine("OPS: {0}", ((double)singles + (doubless * 2) + (triples * 3) + (homeruns * 4)) / (singles + doubless + triples + homeruns + strikeouts + regouts) + ((double)singles + doubless + triples + homeruns + walks) / (singles + doubless + triples + homeruns + strikeouts + regouts + walks));
                Console.ReadLine();
                Console.WriteLine("Enter 'Y' to run again");
                string restart = Console.ReadLine();
                if (restart.ToLower() == "y")
                {
                Batting();
                }
        }
    }
}
  
    
