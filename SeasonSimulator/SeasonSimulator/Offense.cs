
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeasonSimulator
{
    class Offense
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
            int single = 0;
            int doubles = 0;
            int triple = 0;
            int homerun = 0;
            int strikeout = 0;
            int walk = 0;
            int regout = 0;

            Random rnd = new Random();
            int[] intArr = new int[pa];
            for (int i = 0; i < pa; i++)
            {
                int result = rnd.Next(1, 1000);
                intArr[i] = result++;
                // Minimum ratings starting at 20
                if (hit <= 20 && power <= 20)
                {
                    if (result <= 300)
                    {
                        strikeout++;
                    }
                    else if (300 < result && result <= 350)
                    {
                        walk++;
                    }
                    else if (350 < result && result <= 850)
                    {
                        regout++;
                    }
                    else if (850 < result && result <= 985)
                    {
                        single++;
                    }
                    else if (985 < result && result <= 996)
                    {
                        doubles++;
                    }
                    else if (996 < result && result <= 997)
                    {
                        triple++;
                    }
                    else if (997 < result && result <= 1000)
                    {
                        homerun++;
                    }
                }
                else if (hit == 30 && power == 20)
                {
                    if (result <= 250)
                    {
                        strikeout++;
                    }
                    else if (250 < result && result <= 330)
                    {
                        walk++;
                    }
                    else if (330 < result && result <= 800)
                    {
                        regout++;
                    }
                    else if (800 < result && result <= 960)
                    {
                        single++;
                    }
                    else if (960 < result && result <= 985)
                    {
                        doubles++;
                    }
                    else if (985 < result && result <= 990)
                    {
                        triple++;
                    }
                    else if (990 < result && result <= 1000)
                    {
                        homerun++;
                    }
                }
                else if (hit == 40 && power == 20)
                {
                    if (result <= 200)
                    {
                        strikeout++;
                    }
                    else if (200 < result && result <= 285)
                    {
                        walk++;
                    }
                    else if (285 < result && result <= 800)
                    {
                        regout++;
                    }
                    else if (800 < result && result <= 960)
                    {
                        single++;
                    }
                    else if (960 < result && result <= 985)
                    {
                        doubles++;
                    }
                    else if (985 < result && result <= 990)
                    {
                        triple++;
                    }
                    else if (990 < result && result <= 1000)
                    {
                        homerun++;
                    }
                }
                else if (hit == 50 && power == 20)
                {
                    if (result <= 150)
                    {
                        strikeout++;
                    }
                    else if (150 < result && result <= 250)
                    {
                        walk++;
                    }
                    else if (250 < result && result <= 775)
                    {
                        regout++;
                    }
                    else if (775 < result && result <= 960)
                    {
                        single++;
                    }
                    else if (960 < result && result <= 985)
                    {
                        doubles++;
                    }
                    else if (985 < result && result <= 990)
                    {
                        triple++;
                    }
                    else if (990 < result && result <= 1000)
                    {
                        homerun++;
                    }
                }
                else if (hit == 60 && power == 20)
                {
                    if (result <= 120)
                    {
                        strikeout++;
                    }
                    else if (120 < result && result <= 240)
                    {
                        walk++;
                    }
                    else if (240 < result && result <= 760)
                    {
                        regout++;
                    }
                    else if (760 < result && result <= 960)
                    {
                        single++;
                    }
                    else if (960 < result && result <= 985)
                    {
                        doubles++;
                    }
                    else if (985 < result && result <= 990)
                    {
                        triple++;
                    }
                    else if (990 < result && result <= 1000)
                    {
                        homerun++;
                    }
                }
                else if (hit == 70 && power == 20)
                {
                    if (result <= 100)
                    {
                        strikeout++;
                    }
                    else if (100 < result && result <= 220)
                    {
                        walk++;
                    }
                    else if (220 < result && result <= 750)
                    {
                        regout++;
                    }
                    else if (750 < result && result <= 960)
                    {
                        single++;
                    }
                    else if (960 < result && result <= 985)
                    {
                        doubles++;
                    }
                    else if (985 < result && result <= 990)
                    {
                        triple++;
                    }
                    else if (990 < result && result <= 1000)
                    {
                        homerun++;
                    }
                }
                else if (hit == 80 && power == 20)
                {
                    if (result <= 85)
                    {
                        strikeout++;
                    }
                    else if (85 < result && result <= 225)
                    {
                        walk++;
                    }
                    else if (225 < result && result <= 725)
                    {
                        regout++;
                    }
                    else if (725 < result && result <= 960)
                    {
                        single++;
                    }
                    else if (960 < result && result <= 985)
                    {
                        doubles++;
                    }
                    else if (985 < result && result <= 990)
                    {
                        triple++;
                    }
                    else if (990 < result && result <= 1000)
                    {
                        homerun++;
                    }
                }
                //30 Power
                else if (hit == 20 && power == 30)
                {
                    if (result <= 300)
                    {
                        strikeout++;
                    }
                    else if (300 < result && result <= 350)
                    {
                        walk++;
                    }
                    else if (350 < result && result <= 850)
                    {
                        regout++;
                    }
                    else if (850 < result && result <= 950)
                    {
                        single++;
                    }
                    else if (950 < result && result <= 980)
                    {
                        doubles++;
                    }
                    else if (980 < result && result <= 985)
                    {
                        triple++;
                    }
                    else if (985 < result && result <= 1000)
                    {
                        homerun++;
                    }
                }
                else if (hit == 30 && power == 30)
                {
                    if (result <= 250)
                    {
                        strikeout++;
                    }
                    else if (250 < result && result <= 330)
                    {
                        walk++;
                    }
                    else if (330 < result && result <= 800)
                    {
                        regout++;
                    }
                    else if (800 < result && result <= 950)
                    {
                        single++;
                    }
                    else if (950 < result && result <= 980)
                    {
                        doubles++;
                    }
                    else if (980 < result && result <= 985)
                    {
                        triple++;
                    }
                    else if (985 < result && result <= 1000)
                    {
                        homerun++;
                    }
                }
                else if (hit == 40 && power == 30)
                {
                    if (result <= 200)
                    {
                        strikeout++;
                    }
                    else if (200 < result && result <= 285)
                    {
                        walk++;
                    }
                    else if (285 < result && result <= 800)
                    {
                        regout++;
                    }
                    else if (800 < result && result <= 950)
                    {
                        single++;
                    }
                    else if (950 < result && result <= 980)
                    {
                        doubles++;
                    }
                    else if (980 < result && result <= 985)
                    {
                        triple++;
                    }
                    else if (985 < result && result <= 1000)
                    {
                        homerun++;
                    }
                }
                else if (hit == 50 && power == 30)
                {
                    if (result <= 150)
                    {
                        strikeout++;
                    }
                    else if (150 < result && result <= 250)
                    {
                        walk++;
                    }
                    else if (250 < result && result <= 775)
                    {
                        regout++;
                    }
                    else if (775 < result && result <= 950)
                    {
                        single++;
                    }
                    else if (950 < result && result <= 980)
                    {
                        doubles++;
                    }
                    else if (980 < result && result <= 985)
                    {
                        triple++;
                    }
                    else if (985 < result && result <= 1000)
                    {
                        homerun++;
                    }
                }
                else if (hit == 60 && power == 30)
                {
                    if (result <= 120)
                    {
                        strikeout++;
                    }
                    else if (120 < result && result <= 240)
                    {
                        walk++;
                    }
                    else if (240 < result && result <= 760)
                    {
                        regout++;
                    }
                    else if (760 < result && result <= 950)
                    {
                        single++;
                    }
                    else if (950 < result && result <= 980)
                    {
                        doubles++;
                    }
                    else if (980 < result && result <= 985)
                    {
                        triple++;
                    }
                    else if (985 < result && result <= 1000)
                    {
                        homerun++;
                    }
                }
                else if (hit == 70 && power == 30)
                {
                    if (result <= 100)
                    {
                        strikeout++;
                    }
                    else if (100 < result && result <= 220)
                    {
                        walk++;
                    }
                    else if (220 < result && result <= 750)
                    {
                        regout++;
                    }
                    else if (750 < result && result <= 950)
                    {
                        single++;
                    }
                    else if (950 < result && result <= 980)
                    {
                        doubles++;
                    }
                    else if (980 < result && result <= 985)
                    {
                        triple++;
                    }
                    else if (985 < result && result <= 1000)
                    {
                        homerun++;
                    }
                }
                else if (hit == 80 && power == 30)
                {
                    if (result <= 85)
                    {
                        strikeout++;
                    }
                    else if (85 < result && result <= 225)
                    {
                        walk++;
                    }
                    else if (225 < result && result <= 725)
                    {
                        regout++;
                    }
                    else if (725 < result && result <= 950)
                    {
                        single++;
                    }
                    else if (950 < result && result <= 980)
                    {
                        doubles++;
                    }
                    else if (980 < result && result <= 985)
                    {
                        triple++;
                    }
                    else if (985 < result && result <= 1000)
                    {
                        homerun++;
                    }
                }
                // 40 Power
                else if (hit == 20 && power == 40)
                {
                    if (result <= 300)
                    {
                        strikeout++;
                    }
                    else if (300 < result && result <= 350)
                    {
                        walk++;
                    }
                    else if (350 < result && result <= 850)
                    {
                        regout++;
                    }
                    else if (850 < result && result <= 930)
                    {
                        single++;
                    }
                    else if (930 < result && result <= 970)
                    {
                        doubles++;
                    }
                    else if (970 < result && result <= 975)
                    {
                        triple++;
                    }
                    else if (975 < result && result <= 1000)
                    {
                        homerun++;
                    }
                }
                else if (hit == 30 && power == 40)
                {
                    if (result <= 250)
                    {
                        strikeout++;
                    }
                    else if (250 < result && result <= 330)
                    {
                        walk++;
                    }
                    else if (330 < result && result <= 800)
                    {
                        regout++;
                    }
                    else if (800 < result && result <= 930)
                    {
                        single++;
                    }
                    else if (930 < result && result <= 970)
                    {
                        doubles++;
                    }
                    else if (970 < result && result <= 975)
                    {
                        triple++;
                    }
                    else if (975 < result && result <= 1000)
                    {
                        homerun++;
                    }
                }
                else if (hit == 40 && power == 40)
                {
                    if (result <= 200)
                    {
                        strikeout++;
                    }
                    else if (200 < result && result <= 285)
                    {
                        walk++;
                    }
                    else if (285 < result && result <= 800)
                    {
                        regout++;
                    }
                    else if (800 < result && result <= 930)
                    {
                        single++;
                    }
                    else if (930 < result && result <= 970)
                    {
                        doubles++;
                    }
                    else if (970 < result && result <= 975)
                    {
                        triple++;
                    }
                    else if (975 < result && result <= 1000)
                    {
                        homerun++;
                    }
                }
                else if (hit == 50 && power == 40)
                {
                    if (result <= 150)
                    {
                        strikeout++;
                    }
                    else if (150 < result && result <= 250)
                    {
                        walk++;
                    }
                    else if (250 < result && result <= 775)
                    {
                        regout++;
                    }
                    else if (775 < result && result <= 930)
                    {
                        single++;
                    }
                    else if (930 < result && result <= 970)
                    {
                        doubles++;
                    }
                    else if (970 < result && result <= 975)
                    {
                        triple++;
                    }
                    else if (975 < result && result <= 1000)
                    {
                        homerun++;
                    }
                }
                else if (hit == 60 && power == 40)
                {
                    if (result <= 120)
                    {
                        strikeout++;
                    }
                    else if (120 < result && result <= 240)
                    {
                        walk++;
                    }
                    else if (240 < result && result <= 760)
                    {
                        regout++;
                    }
                    else if (760 < result && result <= 930)
                    {
                        single++;
                    }
                    else if (930 < result && result <= 970)
                    {
                        doubles++;
                    }
                    else if (970 < result && result <= 975)
                    {
                        triple++;
                    }
                    else if (975 < result && result <= 1000)
                    {
                        homerun++;
                    }
                }
                else if (hit == 70 && power == 40)
                {
                    if (result <= 100)
                    {
                        strikeout++;
                    }
                    else if (100 < result && result <= 220)
                    {
                        walk++;
                    }
                    else if (220 < result && result <= 750)
                    {
                        regout++;
                    }
                    else if (750 < result && result <= 930)
                    {
                        single++;
                    }
                    else if (930 < result && result <= 970)
                    {
                        doubles++;
                    }
                    else if (970 < result && result <= 975)
                    {
                        triple++;
                    }
                    else if (975 < result && result <= 1000)
                    {
                        homerun++;
                    }
                }
                else if (hit == 80 && power == 40)
                {
                    if (result <= 85)
                    {
                        strikeout++;
                    }
                    else if (85 < result && result <= 225)
                    {
                        walk++;
                    }
                    else if (225 < result && result <= 725)
                    {
                        regout++;
                    }
                    else if (725 < result && result <= 930)
                    {
                        single++;
                    }
                    else if (930 < result && result <= 970)
                    {
                        doubles++;
                    }
                    else if (970 < result && result <= 975)
                    {
                        triple++;
                    }
                    else if (975 < result && result <= 1000)
                    {
                        homerun++;
                    }
                }
                // 50 Power
                else if (hit == 20 && power == 50)
                {
                    if (result <= 300)
                    {
                        strikeout++;
                    }
                    else if (300 < result && result <= 350)
                    {
                        walk++;
                    }
                    else if (350 < result && result <= 850)
                    {
                        regout++;
                    }
                    else if (850 < result && result <= 915)
                    {
                        single++;
                    }
                    else if (915 < result && result <= 965)
                    {
                        doubles++;
                    }
                    else if (965 < result && result <= 970)
                    {
                        triple++;
                    }
                    else if (970 < result && result <= 1000)
                    {
                        homerun++;
                    }
                }
                else if (hit == 30 && power == 50)
                {
                    if (result <= 250)
                    {
                        strikeout++;
                    }
                    else if (250 < result && result <= 330)
                    {
                        walk++;
                    }
                    else if (330 < result && result <= 800)
                    {
                        regout++;
                    }
                    else if (800 < result && result <= 915)
                    {
                        single++;
                    }
                    else if (915 < result && result <= 965)
                    {
                        doubles++;
                    }
                    else if (965 < result && result <= 970)
                    {
                        triple++;
                    }
                    else if (970 < result && result <= 1000)
                    {
                        homerun++;
                    }
                }
                else if (hit == 40 && power == 50)
                {
                    if (result <= 200)
                    {
                        strikeout++;
                    }
                    else if (200 < result && result <= 285)
                    {
                        walk++;
                    }
                    else if (285 < result && result <= 800)
                    {
                        regout++;
                    }
                    else if (800 < result && result <= 915)
                    {
                        single++;
                    }
                    else if (915 < result && result <= 965)
                    {
                        doubles++;
                    }
                    else if (965 < result && result <= 970)
                    {
                        triple++;
                    }
                    else if (970 < result && result <= 1000)
                    {
                        homerun++;
                    }
                }
                else if (hit == 50 && power == 50)
                {
                    if (result <= 150)
                    {
                        strikeout++;
                    }
                    else if (150 < result && result <= 250)
                    {
                        walk++;
                    }
                    else if (250 < result && result <= 775)
                    {
                        regout++;
                    }
                    else if (775 < result && result <= 915)
                    {
                        single++;
                    }
                    else if (915 < result && result <= 965)
                    {
                        doubles++;
                    }
                    else if (965 < result && result <= 970)
                    {
                        triple++;
                    }
                    else if (970 < result && result <= 1000)
                    {
                        homerun++;
                    }
                }
                else if (hit == 60 && power == 50)
                {
                    if (result <= 120)
                    {
                        strikeout++;
                    }
                    else if (120 < result && result <= 240)
                    {
                        walk++;
                    }
                    else if (240 < result && result <= 760)
                    {
                        regout++;
                    }
                    else if (760 < result && result <= 915)
                    {
                        single++;
                    }
                    else if (915 < result && result <= 965)
                    {
                        doubles++;
                    }
                    else if (965 < result && result <= 970)
                    {
                        triple++;
                    }
                    else if (970 < result && result <= 1000)
                    {
                        homerun++;
                    }
                }
                else if (hit == 70 && power == 50)
                {
                    if (result <= 100)
                    {
                        strikeout++;
                    }
                    else if (100 < result && result <= 220)
                    {
                        walk++;
                    }
                    else if (220 < result && result <= 750)
                    {
                        regout++;
                    }
                    else if (750 < result && result <= 915)
                    {
                        single++;
                    }
                    else if (915 < result && result <= 965)
                    {
                        doubles++;
                    }
                    else if (965 < result && result <= 970)
                    {
                        triple++;
                    }
                    else if (970 < result && result <= 1000)
                    {
                        homerun++;
                    }
                }
                else if (hit == 80 && power == 50)
                {
                    if (result <= 85)
                    {
                        strikeout++;
                    }
                    else if (85 < result && result <= 225)
                    {
                        walk++;
                    }
                    else if (225 < result && result <= 725)
                    {
                        regout++;
                    }
                    else if (725 < result && result <= 915)
                    {
                        single++;
                    }
                    else if (915 < result && result <= 965)
                    {
                        doubles++;
                    }
                    else if (965 < result && result <= 970)
                    {
                        triple++;
                    }
                    else if (970 < result && result <= 1000)
                    {
                        homerun++;
                    }
                }
                // 60 Power
                else if (hit == 20 && power == 60)
                {
                    if (result <= 300)
                    {
                        strikeout++;
                    }
                    else if (300 < result && result <= 350)
                    {
                        walk++;
                    }
                    else if (350 < result && result <= 850)
                    {
                        regout++;
                    }
                    else if (850 < result && result <= 900)
                    {
                        single++;
                    }
                    else if (900 < result && result <= 960)
                    {
                        doubles++;
                    }
                    else if (960 < result && result <= 965)
                    {
                        triple++;
                    }
                    else if (965 < result && result <= 1000)
                    {
                        homerun++;
                    }
                }
                else if (hit == 30 && power == 60)
                {
                    if (result <= 250)
                    {
                        strikeout++;
                    }
                    else if (250 < result && result <= 330)
                    {
                        walk++;
                    }
                    else if (330 < result && result <= 800)
                    {
                        regout++;
                    }
                    else if (800 < result && result <= 900)
                    {
                        single++;
                    }
                    else if (900 < result && result <= 960)
                    {
                        doubles++;
                    }
                    else if (960 < result && result <= 965)
                    {
                        triple++;
                    }
                    else if (965 < result && result <= 1000)
                    {
                        homerun++;
                    }
                }
                else if (hit == 40 && power == 60)
                {
                    if (result <= 200)
                    {
                        strikeout++;
                    }
                    else if (200 < result && result <= 285)
                    {
                        walk++;
                    }
                    else if (285 < result && result <= 800)
                    {
                        regout++;
                    }
                    else if (800 < result && result <= 900)
                    {
                        single++;
                    }
                    else if (900 < result && result <= 960)
                    {
                        doubles++;
                    }
                    else if (960 < result && result <= 965)
                    {
                        triple++;
                    }
                    else if (965 < result && result <= 1000)
                    {
                        homerun++;
                    }
                }
                else if (hit == 50 && power == 60)
                {
                    if (result <= 150)
                    {
                        strikeout++;
                    }
                    else if (150 < result && result <= 240)
                    {
                        walk++;
                    }
                    else if (240 < result && result <= 775)
                    {
                        regout++;
                    }
                    else if (775 < result && result <= 900)
                    {
                        single++;
                    }
                    else if (900 < result && result <= 960)
                    {
                        doubles++;
                    }
                    else if (960 < result && result <= 965)
                    {
                        triple++;
                    }
                    else if (965 < result && result <= 1000)
                    {
                        homerun++;
                    }
                }
                else if (hit == 60 && power == 60)
                {
                    if (result <= 120)
                    {
                        strikeout++;
                    }
                    else if (120 < result && result <= 240)
                    {
                        walk++;
                    }
                    else if (240 < result && result <= 760)
                    {
                        regout++;
                    }
                    else if (760 < result && result <= 900)
                    {
                        single++;
                    }
                    else if (900 < result && result <= 960)
                    {
                        doubles++;
                    }
                    else if (960 < result && result <= 965)
                    {
                        triple++;
                    }
                    else if (965 < result && result <= 1000)
                    {
                        homerun++;
                    }
                }
                else if (hit == 70 && power == 60)
                {
                    if (result <= 100)
                    {
                        strikeout++;
                    }
                    else if (100 < result && result <= 200)
                    {
                        walk++;
                    }
                    else if (200 < result && result <= 750)
                    {
                        regout++;
                    }
                    else if (750 < result && result <= 900)
                    {
                        single++;
                    }
                    else if (900 < result && result <= 960)
                    {
                        doubles++;
                    }
                    else if (960 < result && result <= 965)
                    {
                        triple++;
                    }
                    else if (965 < result && result <= 1000)
                    {
                        homerun++;
                    }
                }
                else if (hit == 80 && power == 60)
                {
                    if (result <= 85)
                    {
                        strikeout++;
                    }
                    else if (85 < result && result <= 225)
                    {
                        walk++;
                    }
                    else if (225 < result && result <= 725)
                    {
                        regout++;
                    }
                    else if (725 < result && result <= 900)
                    {
                        single++;
                    }
                    else if (900 < result && result <= 960)
                    {
                        doubles++;
                    }
                    else if (960 < result && result <= 965)
                    {
                        triple++;
                    }
                    else if (965 < result && result <= 1000)
                    {
                        homerun++;
                    }
                }
                // 70 Power
                else if (hit == 20 && power == 70)
                {
                    if (result <= 300)
                    {
                        strikeout++;
                    }
                    else if (300 < result && result <= 350)
                    {
                        walk++;
                    }
                    else if (350 < result && result <= 850)
                    {
                        regout++;
                    }
                    else if (850 < result && result <= 890)
                    {
                        single++;
                    }
                    else if (890 < result && result <= 955)
                    {
                        doubles++;
                    }
                    else if (955 < result && result <= 960)
                    {
                        triple++;
                    }
                    else if (960 < result && result <= 1000)
                    {
                        homerun++;
                    }
                }
                else if (hit == 30 && power == 70)
                {
                    if (result <= 250)
                    {
                        strikeout++;
                    }
                    else if (250 < result && result <= 330)
                    {
                        walk++;
                    }
                    else if (330 < result && result <= 800)
                    {
                        regout++;
                    }
                    else if (800 < result && result <= 890)
                    {
                        single++;
                    }
                    else if (890 < result && result <= 955)
                    {
                        doubles++;
                    }
                    else if (955 < result && result <= 960)
                    {
                        triple++;
                    }
                    else if (960 < result && result <= 1000)
                    {
                        homerun++;
                    }
                }
                else if (hit == 40 && power == 70)
                {
                    if (result <= 200)
                    {
                        strikeout++;
                    }
                    else if (200 < result && result <= 285)
                    {
                        walk++;
                    }
                    else if (285 < result && result <= 800)
                    {
                        regout++;
                    }
                    else if (800 < result && result <= 890)
                    {
                        single++;
                    }
                    else if (890 < result && result <= 955)
                    {
                        doubles++;
                    }
                    else if (955 < result && result <= 960)
                    {
                        triple++;
                    }
                    else if (960 < result && result <= 1000)
                    {
                        homerun++;
                    }
                }
                else if (hit == 50 && power == 70)
                {
                    if (result <= 150)
                    {
                        strikeout++;
                    }
                    else if (150 < result && result <= 250)
                    {
                        walk++;
                    }
                    else if (250 < result && result <= 775)
                    {
                        regout++;
                    }
                    else if (775 < result && result <= 890)
                    {
                        single++;
                    }
                    else if (890 < result && result <= 955)
                    {
                        doubles++;
                    }
                    else if (955 < result && result <= 960)
                    {
                        triple++;
                    }
                    else if (960 < result && result <= 1000)
                    {
                        homerun++;
                    }
                }
                else if (hit == 60 && power == 70)
                {
                    if (result <= 120)
                    {
                        strikeout++;
                    }
                    else if (120 < result && result <= 225)
                    {
                        walk++;
                    }
                    else if (225 < result && result <= 750)
                    {
                        regout++;
                    }
                    else if (750 < result && result <= 890)
                    {
                        single++;
                    }
                    else if (890 < result && result <= 955)
                    {
                        doubles++;
                    }
                    else if (955 < result && result <= 960)
                    {
                        triple++;
                    }
                    else if (960 < result && result <= 1000)
                    {
                        homerun++;
                    }
                }
                else if (hit == 70 && power == 70)
                {
                    if (result <= 100)
                    {
                        strikeout++;
                    }
                    else if (100 < result && result <= 220)
                    {
                        walk++;
                    }
                    else if (220 < result && result <= 750)
                    {
                        regout++;
                    }
                    else if (750 < result && result <= 890)
                    {
                        single++;
                    }
                    else if (890 < result && result <= 955)
                    {
                        doubles++;
                    }
                    else if (955 < result && result <= 960)
                    {
                        triple++;
                    }
                    else if (960 < result && result <= 1000)
                    {
                        homerun++;
                    }
                }
                else if (hit == 80 && power == 70)
                {
                    if (result <= 85)
                    {
                        strikeout++;
                    }
                    else if (85 < result && result <= 225)
                    {
                        walk++;
                    }
                    else if (225 < result && result <= 725)
                    {
                        regout++;
                    }
                    else if (725 < result && result <= 890)
                    {
                        single++;
                    }
                    else if (890 < result && result <= 955)
                    {
                        doubles++;
                    }
                    else if (955 < result && result <= 960)
                    {
                        triple++;
                    }
                    else if (960 < result && result <= 1000)
                    {
                        homerun++;
                    }
                }
                // 80 Power
                else if (hit == 20 && power == 80)
                {
                    if (result <= 300)
                    {
                        strikeout++;
                    }
                    else if (300 < result && result <= 350)
                    {
                        walk++;
                    }
                    else if (350 < result && result <= 850)
                    {
                        regout++;
                    }
                    else if (850 < result && result <= 870)
                    {
                        single++;
                    }
                    else if (870 < result && result <= 940)
                    {
                        doubles++;
                    }
                    else if (940 < result && result <= 950)
                    {
                        triple++;
                    }
                    else if (950 < result && result <= 1000)
                    {
                        homerun++;
                    }
                }
                else if (hit == 30 && power == 80)
                {
                    if (result <= 250)
                    {
                        strikeout++;
                    }
                    else if (250 < result && result <= 330)
                    {
                        walk++;
                    }
                    else if (330 < result && result <= 800)
                    {
                        regout++;
                    }
                    else if (800 < result && result <= 870)
                    {
                        single++;
                    }
                    else if (870 < result && result <= 940)
                    {
                        doubles++;
                    }
                    else if (940 < result && result <= 950)
                    {
                        triple++;
                    }
                    else if (950 < result && result <= 1000)
                    {
                        homerun++;
                    }
                }
                else if (hit == 40 && power == 80)
                {
                    if (result <= 200)
                    {
                        strikeout++;
                    }
                    else if (200 < result && result <= 285)
                    {
                        walk++;
                    }
                    else if (285 < result && result <= 800)
                    {
                        regout++;
                    }
                    else if (800 < result && result <= 870)
                    {
                        single++;
                    }
                    else if (870 < result && result <= 940)
                    {
                        doubles++;
                    }
                    else if (940 < result && result <= 950)
                    {
                        triple++;
                    }
                    else if (950 < result && result <= 1000)
                    {
                        homerun++;
                    }
                }
                else if (hit == 50 && power == 80)
                {
                    if (result <= 150)
                    {
                        strikeout++;
                    }
                    else if (150 < result && result <= 250)
                    {
                        walk++;
                    }
                    else if (250 < result && result <= 775)
                    {
                        regout++;
                    }
                    else if (775 < result && result <= 870)
                    {
                        single++;
                    }
                    else if (870 < result && result <= 940)
                    {
                        doubles++;
                    }
                    else if (940 < result && result <= 950)
                    {
                        triple++;
                    }
                    else if (950 < result && result <= 1000)
                    {
                        homerun++;
                    }
                }
                else if (hit == 60 && power == 80)
                {
                    if (result <= 120)
                    {
                        strikeout++;
                    }
                    else if (120 < result && result <= 240)
                    {
                        walk++;
                    }
                    else if (240 < result && result <= 760)
                    {
                        regout++;
                    }
                    else if (760 < result && result <= 870)
                    {
                        single++;
                    }
                    else if (870 < result && result <= 940)
                    {
                        doubles++;
                    }
                    else if (940 < result && result <= 950)
                    {
                        triple++;
                    }
                    else if (950 < result && result <= 1000)
                    {
                        homerun++;
                    }
                }
                else if (hit == 70 && power == 80)
                {
                    if (result <= 100)
                    {
                        strikeout++;
                    }
                    else if (100 < result && result <= 225)
                    {
                        walk++;
                    }
                    else if (225 < result && result <= 725)
                    {
                        regout++;
                    }
                    else if (725 < result && result <= 870)
                    {
                        single++;
                    }
                    else if (870 < result && result <= 940)
                    {
                        doubles++;
                    }
                    else if (940 < result && result <= 950)
                    {
                        triple++;
                    }
                    else if (950 < result && result <= 1000)
                    {
                        homerun++;
                    }
                }
                // Max Rating
                else if (hit == 80 && power == 80)
                {
                    if (result <= 85)
                    {
                        strikeout++;
                    }
                    else if (85 < result && result <= 225)
                    {
                        walk++;
                    }
                    else if (225 < result && result <= 725)
                    {
                        regout++;
                    }
                    else if (725 < result && result <= 870)
                    {
                        single++;
                    }
                    else if (870 < result && result <= 940)
                    {
                        doubles++;
                    }
                    else if (940 < result && result <= 950)
                    {
                        triple++;
                    }
                    else if (950 < result && result <= 1000)
                    {
                        homerun++;
                    }
                }
            }

            Console.WriteLine("Hits: {0}", single + doubles + triple + homerun);
            Console.WriteLine("Doubles: {0}", doubles);
            Console.WriteLine("Triples: {0}", triple);
            Console.WriteLine("Homeruns: {0}", homerun);
            Console.WriteLine("Strikeouts: {0}", strikeout);
            Console.WriteLine("Walks: {0}", walk);
            Console.WriteLine("At-Bats: {0}", single + doubles + triple + homerun + strikeout + regout);
            Console.WriteLine("Batting Average: {0}", ((double)single + doubles + triple + homerun) / (single + doubles + triple + homerun + strikeout + regout));
            Console.WriteLine("On Base Percentage: {0}", ((double)single + doubles + triple + homerun + walk) / (single + doubles + triple + homerun + strikeout + regout + walk));
            Console.WriteLine("Slugging Percentage: {0}", ((double)single + (doubles * 2) + (triple * 3) + (homerun * 4)) / (single + doubles + triple + homerun + strikeout + regout));
            Console.WriteLine("OPS: {0}", ((double)single + (doubles * 2) + (triple * 3) + (homerun * 4)) / (single + doubles + triple + homerun + strikeout + regout) + ((double)single + doubles + triple + homerun + walk) / (single + doubles + triple + homerun + strikeout + regout + walk));
            Console.ReadLine();
            Console.WriteLine("Enter y to run again");
            string restart = Console.ReadLine();
            if (restart.ToLower() == "y")
            {
                Batting();
            }
        }
    }
}