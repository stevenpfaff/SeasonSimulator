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

            Random rnds = new Random();
            int[] intArrs = new int[pa];
            for (int i = 0; i < pa; i++)
            {
                int result = rnds.Next(1, 1000);
                intArrs[i] = result++;
                // Minimum hit ratings, 20-30 Power
                if (hit <= 20 && power <= 30)
                {
                    if (result <= 300)
                    {
                        strikeouts++;
                    }
                    else if (300 < result && result <= 350)
                    {
                        walks++;
                    }
                    else if (350 < result && result <= 850)
                    {
                        regouts++;
                    }
                    else if (850 < result && result <= 995)
                    {
                        singles++;
                    }
                    else if (995 < result && result <= 1000)
                    {
                        doubless++;
                    }
                    else if (1001 < result && result <= 1001)
                    {
                        triples++;
                    }
                    else if (1001 < result && result <= 1001)
                    {
                        homeruns++;
                    }
                }
                else if (hit == 30 && power <= 30)
                {
                    if (result <= 250)
                    {
                        strikeouts++;
                    }
                    else if (250 < result && result <= 330)
                    {
                        walks++;
                    }
                    else if (330 < result && result <= 800)
                    {
                        regouts++;
                    }
                    else if (800 < result && result <= 995)
                    {
                        singles++;
                    }
                    else if (995 < result && result <= 1000)
                    {
                        doubless++;
                    }
                    else if (1001 < result && result <= 1001)
                    {
                        triples++;
                    }
                    else if (1001 < result && result <= 1001)
                    {
                        homeruns++;
                    }
                }
                else if (hit == 40 && power <= 30)
                {
                    if (result <= 220)
                    {
                        strikeouts++;
                    }
                    else if (220 < result && result <= 320)
                    {
                        walks++;
                    }
                    else if (320 < result && result <= 750)
                    {
                        regouts++;
                    }
                    else if (750 < result && result <= 990)
                    {
                        singles++;
                    }
                    else if (990 < result && result <= 1000)
                    {
                        doubless++;
                    }
                    else if (1001 < result && result <= 1001)
                    {
                        triples++;
                    }
                    else if (1001 < result && result <= 1001)
                    {
                        homeruns++;
                    }
                }
                else if (hit == 50 && power <= 30)
                {
                    if (result <= 200)
                    {
                        strikeouts++;
                    }
                    else if (200 < result && result <= 350)
                    {
                        walks++;
                    }
                    else if (350 < result && result <= 700)
                    {
                        regouts++;
                    }
                    else if (700 < result && result <= 975)
                    {
                        singles++;
                    }
                    else if (975 < result && result <= 997)
                    {
                        doubless++;
                    }
                    else if (997 < result && result <= 998)
                    {
                        triples++;
                    }
                    else if (998 < result && result <= 1000)
                    {
                        homeruns++;
                    }
                }
                else if (hit == 60 && power <= 30)
                {
                    if (result <= 180)
                    {
                        strikeouts++;
                    }
                    else if (180 < result && result <= 340)
                    {
                        walks++;
                    }
                    else if (340 < result && result <= 680)
                    {
                        regouts++;
                    }
                    else if (680 < result && result <= 970)
                    {
                        singles++;
                    }
                    else if (970 < result && result <= 997)
                    {
                        doubless++;
                    }
                    else if (997 < result && result <= 998)
                    {
                        triples++;
                    }
                    else if (998 < result && result <= 1000)
                    {
                        homeruns++;
                    }
                }
                else if (hit == 70 && power <= 30)
                {
                    if (result <= 150)
                    {
                        strikeouts++;
                    }
                    else if (150 < result && result <= 320)
                    {
                        walks++;
                    }
                    else if (320 < result && result <= 650)
                    {
                        regouts++;
                    }
                    else if (650 < result && result <= 960)
                    {
                        singles++;
                    }
                    else if (960 < result && result <= 996)
                    {
                        doubless++;
                    }
                    else if (996 < result && result <= 998)
                    {
                        triples++;
                    }
                    else if (998 < result && result <= 1000)
                    {
                        homeruns++;
                    }
                }
                else if (hit == 80 && power <= 30)
                {
                    if (result <= 120)
                    {
                        strikeouts++;
                    }
                    else if (120 < result && result <= 300)
                    {
                        walks++;
                    }
                    else if (300 < result && result <= 650)
                    {
                        regouts++;
                    }
                    else if (650 < result && result <= 950)
                    {
                        singles++;
                    }
                    else if (950 < result && result <= 993)
                    {
                        doubless++;
                    }
                    else if (993 < result && result <= 996)
                    {
                        triples++;
                    }
                    else if (996 < result && result <= 1000)
                    {
                        homeruns++;
                    }
                }
                //40 POWER
                else if (hit <= 20 && power == 40)
                {
                    if (result <= 320)
                    {
                        strikeouts++;
                    }
                    else if (320 < result && result <= 380)
                    {
                        walks++;
                    }
                    else if (380 < result && result <= 830)
                    {
                        regouts++;
                    }
                    else if (830 < result && result <= 980)
                    {
                        singles++;
                    }
                    else if (980 < result && result <= 996)
                    {
                        doubless++;
                    }
                    else if (996 < result && result <= 997)
                    {
                        triples++;
                    }
                    else if (997 < result && result <= 1000)
                    {
                        homeruns++;
                    }
                }
                else if (hit == 30 && power == 40)
                {
                    if (result <= 300)
                    {
                        strikeouts++;
                    }
                    else if (300 < result && result <= 380)
                    {
                        walks++;
                    }
                    else if (380 < result && result <= 810)
                    {
                        regouts++;
                    }
                    else if (810 < result && result <= 970)
                    {
                        singles++;
                    }
                    else if (970 < result && result <= 996)
                    {
                        doubless++;
                    }
                    else if (996 < result && result <= 997)
                    {
                        triples++;
                    }
                    else if (997 < result && result <= 1000)
                    {
                        homeruns++;
                    }
                }
                else if (hit == 40 && power == 40)
                {
                    if (result <= 250)
                    {
                        strikeouts++;
                    }
                    else if (250 < result && result <= 360)
                    {
                        walks++;
                    }
                    else if (360 < result && result <= 750)
                    {
                        regouts++;
                    }
                    else if (750 < result && result <= 970)
                    {
                        singles++;
                    }
                    else if (970 < result && result <= 996)
                    {
                        doubless++;
                    }
                    else if (996 < result && result <= 997)
                    {
                        triples++;
                    }
                    else if (997 < result && result <= 1000)
                    {
                        homeruns++;
                    }
                }
                else if (hit == 50 && power == 40)
                {
                    if (result <= 200)
                    {
                        strikeouts++;
                    }
                    else if (200 < result && result <= 350)
                    {
                        walks++;
                    }
                    else if (350 < result && result <= 720)
                    {
                        regouts++;
                    }
                    else if (720 < result && result <= 960)
                    {
                        singles++;
                    }
                    else if (960 < result && result <= 996)
                    {
                        doubless++;
                    }
                    else if (996 < result && result <= 997)
                    {
                        triples++;
                    }
                    else if (997 < result && result <= 1000)
                    {
                        homeruns++;
                    }
                }
                else if (hit == 60 && power == 40)
                {
                    if (result <= 180)
                    {
                        strikeouts++;
                    }
                    else if (180 < result && result <= 340)
                    {
                        walks++;
                    }
                    else if (340 < result && result <= 680)
                    {
                        regouts++;
                    }
                    else if (680 < result && result <= 950)
                    {
                        singles++;
                    }
                    else if (950 < result && result <= 993)
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
                else if (hit == 70 && power == 40)
                {
                    if (result <= 150)
                    {
                        strikeouts++;
                    }
                    else if (150 < result && result <= 320)
                    {
                        walks++;
                    }
                    else if (320 < result && result <= 650)
                    {
                        regouts++;
                    }
                    else if (650 < result && result <= 940)
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
                else if (hit == 80 && power == 40)
                {
                    if (result <= 120)
                    {
                        strikeouts++;
                    }
                    else if (120 < result && result <= 300)
                    {
                        walks++;
                    }
                    else if (300 < result && result <= 650)
                    {
                        regouts++;
                    }
                    else if (650 < result && result <= 930)
                    {
                        singles++;
                    }
                    else if (930 < result && result <= 990)
                    {
                        doubless++;
                    }
                    else if (990 < result && result <= 993)
                    {
                        triples++;
                    }
                    else if (993 < result && result <= 1000)
                    {
                        homeruns++;
                    }
                }
                //50 Power
                else if (hit == 20 && power == 50)
                {
                    if (result <= 320)
                    {
                        strikeouts++;
                    }
                    else if (320 < result && result <= 380)
                    {
                        walks++;
                    }
                    else if (380 < result && result <= 830)
                    {
                        regouts++;
                    }
                    else if (830 < result && result <= 970)
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
                else if (hit == 30 && power == 50)
                {
                    if (result <= 300)
                    {
                        strikeouts++;
                    }
                    else if (300 < result && result <= 380)
                    {
                        walks++;
                    }
                    else if (380 < result && result <= 810)
                    {
                        regouts++;
                    }
                    else if (830 < result && result <= 970)
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
                else if (hit == 40 && power == 50)
                {
                    if (result <= 250)
                    {
                        strikeouts++;
                    }
                    else if (250 < result && result <= 360)
                    {
                        walks++;
                    }
                    else if (360 < result && result <= 750)
                    {
                        regouts++;
                    }
                    else if (750 < result && result <= 970)
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
                //AVERAGE HIGHSCHOOL BAT
                else if (hit == 50 && power == 50)
                {
                    if (result <= 200)
                    {
                        strikeouts++;
                    }
                    else if (200 < result && result <= 350)
                    {
                        walks++;
                    }
                    else if (350 < result && result <= 720)
                    {
                        regouts++;
                    }
                    else if (750 < result && result <= 970)
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
                else if (hit == 60 && power == 50)
                {
                    if (result <= 180)
                    {
                        strikeouts++;
                    }
                    else if (180 < result && result <= 340)
                    {
                        walks++;
                    }
                    else if (340 < result && result <= 680)
                    {
                        regouts++;
                    }
                    else if (680 < result && result <= 940)
                    {
                        singles++;
                    }
                    else if (940 < result && result <= 990)
                    {
                        doubless++;
                    }
                    else if (990 < result && result <= 994)
                    {
                        triples++;
                    }
                    else if (994 < result && result <= 1000)
                    {
                        homeruns++;
                    }
                }
                else if (hit == 70 && power == 50)
                {
                    if (result <= 150)
                    {
                        strikeouts++;
                    }
                    else if (150 < result && result <= 320)
                    {
                        walks++;
                    }
                    else if (320 < result && result <= 650)
                    {
                        regouts++;
                    }
                    else if (650 < result && result <= 930)
                    {
                        singles++;
                    }
                    else if (930 < result && result <= 990)
                    {
                        doubless++;
                    }
                    else if (990 < result && result <= 994)
                    {
                        triples++;
                    }
                    else if (994 < result && result <= 1000)
                    {
                        homeruns++;
                    }
                }
                else if (hit == 80 && power == 50)
                {
                    if (result <= 120)
                    {
                        strikeouts++;
                    }
                    else if (120 < result && result <= 300)
                    {
                        walks++;
                    }
                    else if (300 < result && result <= 650)
                    {
                        regouts++;
                    }
                    else if (650 < result && result <= 920)
                    {
                        singles++;
                    }
                    else if (920 < result && result <= 988)
                    {
                        doubless++;
                    }
                    else if (988 < result && result <= 992)
                    {
                        triples++;
                    }
                    else if (992 < result && result <= 1000)
                    {
                        homeruns++;
                    }
                }
                //60 POWER
                else if (hit == 20 && power == 60)
                {
                    if (result <= 320)
                    {
                        strikeouts++;
                    }
                    else if (320 < result && result <= 380)
                    {
                        walks++;
                    }
                    else if (380 < result && result <= 820)
                    {
                        regouts++;
                    }
                    else if (820 < result && result <= 960)
                    {
                        singles++;
                    }
                    else if (960 < result && result <= 989)
                    {
                        doubless++;
                    }
                    else if (989 < result && result <= 990)
                    {
                        triples++;
                    }
                    else if (990 < result && result <= 1000)
                    {
                        homeruns++;
                    }
                }
                else if (hit == 30 && power == 60)
                {
                    if (result <= 300)
                    {
                        strikeouts++;
                    }
                    else if (300 < result && result <= 380)
                    {
                        walks++;
                    }
                    else if (380 < result && result <= 800)
                    {
                        regouts++;
                    }
                    else if (800 < result && result <= 955)
                    {
                        singles++;
                    }
                    else if (955 < result && result <= 988)
                    {
                        doubless++;
                    }
                    else if (988 < result && result <= 990)
                    {
                        triples++;
                    }
                    else if (990 < result && result <= 1000)
                    {
                        homeruns++;
                    }
                }
                else if (hit == 40 && power == 60)
                {
                    if (result <= 250)
                    {
                        strikeouts++;
                    }
                    else if (250 < result && result <= 380)
                    {
                        walks++;
                    }
                    else if (380 < result && result <= 740)
                    {
                        regouts++;
                    }
                    else if (740 < result && result <= 950)
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
                else if (hit == 50 && power == 60)
                {
                    if (result <= 200)
                    {
                        strikeouts++;
                    }
                    else if (200 < result && result <= 350)
                    {
                        walks++;
                    }
                    else if (350 < result && result <= 720)
                    {
                        regouts++;
                    }
                    else if (720 < result && result <= 950)
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
                else if (hit == 60 && power == 60)
                {
                    if (result <= 180)
                    {
                        strikeouts++;
                    }
                    else if (180 < result && result <= 340)
                    {
                        walks++;
                    }
                    else if (340 < result && result <= 680)
                    {
                        regouts++;
                    }
                    else if (680 < result && result <= 930)
                    {
                        singles++;
                    }
                    else if (930 < result && result <= 980)
                    {
                        doubless++;
                    }
                    else if (980 < result && result <= 985)
                    {
                        triples++;
                    }
                    else if (985 < result && result <= 1000)
                    {
                        homeruns++;
                    }
                }
                else if (hit == 70 && power == 60)
                {
                    if (result <= 150)
                    {
                        strikeouts++;
                    }
                    else if (150 < result && result <= 320)
                    {
                        walks++;
                    }
                    else if (320 < result && result <= 650)
                    {
                        regouts++;
                    }
                    else if (650 < result && result <= 920)
                    {
                        singles++;
                    }
                    else if (920 < result && result <= 980)
                    {
                        doubless++;
                    }
                    else if (980 < result && result <= 985)
                    {
                        triples++;
                    }
                    else if (985 < result && result <= 1000)
                    {
                        homeruns++;
                    }
                }
                else if (hit == 80 && power == 60)
                {
                    if (result <= 120)
                    {
                        strikeouts++;
                    }
                    else if (120 < result && result <= 300)
                    {
                        walks++;
                    }
                    else if (300 < result && result <= 630)
                    {
                        regouts++;
                    }
                    else if (630 < result && result <= 910)
                    {
                        singles++;
                    }
                    else if (910 < result && result <= 975)
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
                //70 POWER
                else if (hit <= 20 && power == 70)
                {
                    if (result <= 320)
                    {
                        strikeouts++;
                    }
                    else if (320 < result && result <= 400)
                    {
                        walks++;
                    }
                    else if (400 < result && result <= 820)
                    {
                        regouts++;
                    }
                    else if (820 < result && result <= 920)
                    {
                        singles++;
                    }
                    else if (920 < result && result <= 983)
                    {
                        doubless++;
                    }
                    else if (983 < result && result <= 985)
                    {
                        triples++;
                    }
                    else if (985 < result && result <= 1000)
                    {
                        homeruns++;
                    }
                }
                else if (hit == 30 && power == 70)
                {
                    if (result <= 300)
                    {
                        strikeouts++;
                    }
                    else if (300 < result && result <= 400)
                    {
                        walks++;
                    }
                    else if (400 < result && result <= 810)
                    {
                        regouts++;
                    }
                    else if (810 < result && result <= 920)
                    {
                        singles++;
                    }
                    else if (920 < result && result <= 983)
                    {
                        doubless++;
                    }
                    else if (983 < result && result <= 985)
                    {
                        triples++;
                    }
                    else if (985 < result && result <= 1000)
                    {
                        homeruns++;
                    }
                }
                else if (hit == 40 && power == 70)
                {
                    if (result <= 250)
                    {
                        strikeouts++;
                    }
                    else if (250 < result && result <= 380)
                    {
                        walks++;
                    }
                    else if (380 < result && result <= 780)
                    {
                        regouts++;
                    }
                    else if (780 < result && result <= 900)
                    {
                        singles++;
                    }
                    else if (900 < result && result <= 978)
                    {
                        doubless++;
                    }
                    else if (978 < result && result <= 980)
                    {
                        triples++;
                    }
                    else if (980 < result && result <= 1000)
                    {
                        homeruns++;
                    }
                }
                else if (hit == 50 && power == 70)
                {
                    if (result <= 200)
                    {
                        strikeouts++;
                    }
                    else if (200 < result && result <= 350)
                    {
                        walks++;
                    }
                    else if (350 < result && result <= 750)
                    {
                        regouts++;
                    }
                    else if (750 < result && result <= 900)
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
                else if (hit == 60 && power == 70)
                {
                    if (result <= 180)
                    {
                        strikeouts++;
                    }
                    else if (180 < result && result <= 340)
                    {
                        walks++;
                    }
                    else if (340 < result && result <= 740)
                    {
                        regouts++;
                    }
                    else if (740 < result && result <= 890)
                    {
                        singles++;
                    }
                    else if (890 < result && result <= 975)
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
                else if (hit == 70 && power == 70)
                {
                    if (result <= 150)
                    {
                        strikeouts++;
                    }
                    else if (150 < result && result <= 330)
                    {
                        walks++;
                    }
                    else if (330 < result && result <= 680)
                    {
                        regouts++;
                    }
                    else if (680 < result && result <= 870)
                    {
                        singles++;
                    }
                    else if (870 < result && result <= 970)
                    {
                        doubless++;
                    }
                    else if (970 < result && result <= 975)
                    {
                        triples++;
                    }
                    else if (975 < result && result <= 1000)
                    {
                        homeruns++;
                    }
                }
                else if (hit == 80 && power == 70)
                {
                    if (result <= 120)
                    {
                        strikeouts++;
                    }
                    else if (120 < result && result <= 320)
                    {
                        walks++;
                    }
                    else if (320 < result && result <= 650)
                    {
                        regouts++;
                    }
                    else if (650 < result && result <= 850)
                    {
                        singles++;
                    }
                    else if (850 < result && result <= 960)
                    {
                        doubless++;
                    }
                    else if (960 < result && result <= 965)
                    {
                        triples++;
                    }
                    else if (965 < result && result <= 1000)
                    {
                        homeruns++;
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
            string restarts = Console.ReadLine();
            if (restarts.ToLower() == "y")
            {
                Batting();
            }
        }
    }
}