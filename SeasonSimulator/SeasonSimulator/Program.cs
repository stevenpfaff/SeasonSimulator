using System;

namespace SeasonSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Run();
                static void Run()
                {
                    Console.WriteLine("Enter Player Name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter Ratings On 20-80 Scale, ending only in 0 or 5.");
                    Console.WriteLine("Power");
                    int power;
                    string powerStr = Console.ReadLine();
                    if (!int.TryParse(powerStr, out power))
                    {
                        Console.WriteLine("Enter Number Value.");
                    }
                    Console.WriteLine("Hit");
                    int hit;
                    string hitStr = Console.ReadLine();
                    if (!int.TryParse(hitStr, out hit))
                    {
                        Console.WriteLine("Enter Number Value.");
                    }
                    Console.WriteLine("Name: " + name + " Power: " + power + " Hit: " + hit);

                    int single = 0;
                    int doubles = 0;
                    int triple = 0;
                    int homerun = 0;
                    int strikeout = 0;
                    int walk = 0;
                    int regout = 0;

                    Random rnd = new Random();
                    int[] intArr = new int[700];
                    //700 = Plate appearances
                    for (int i = 0; i < 700; i++)
                    {
                        int result = rnd.Next(1, 100);
                        intArr[i] = result++;
                        //Begining of Minimum Power Rating
                        if (hit < 21 && power < 21)
                        {
                            if (result < 30)
                            {
                                strikeout++;
                            }
                            else if (30 < result && result < 35)
                            {
                                walk++;
                            }
                            else if (35 < result && result < 80)
                            {
                                regout++;
                            }
                            else if (80 < result && result < 99)
                            {
                                single++;
                            }
                            else if (99 < result && result < 100)
                            {
                                doubles++;
                            }
                        }
                        else if (hit < 31 && hit > 26 && power < 21)
                        {
                            if (result < 25)
                            {
                                strikeout++;
                            }
                            else if (25 < result && result < 33)
                            {
                                walk++;
                            }
                            else if (33 < result && result < 78)
                            {
                                regout++;
                            }
                            else if (78 < result && result < 96)
                            {
                                single++;
                            }
                            else if (96 < result && result < 100)
                            {
                                doubles++;
                            }
                        }
                        else if (hit < 36 && hit > 31 && power < 21)
                        {
                            if (result < 22)
                            {
                                strikeout++;
                            }
                            else if (22 < result && result < 30)
                            {
                                walk++;
                            }
                            else if (30 < result && result < 75)
                            {
                                regout++;
                            }
                            else if (75 < result && result < 99)
                            {
                                single++;
                            }
                            else if (99 < result && result < 100)
                            {
                                doubles++;
                            }
                        }
                        else if (hit < 41 && hit > 36 && power < 21)
                        {
                            if (result < 20)
                            {
                                strikeout++;
                            }
                            else if (20 < result && result < 30)
                            {
                                walk++;
                            }
                            else if (30 < result && result < 75)
                            {
                                regout++;
                            }
                            else if (75 < result && result < 98)
                            {
                                single++;
                            }
                            else if (98 < result && result < 100)
                            {
                                doubles++;
                            }
                        }
                        else if (hit < 46 && hit > 41 && power < 21)
                        {
                            if (result < 18)
                            {
                                strikeout++;
                            }
                            else if (18 < result && result < 30)
                            {
                                walk++;
                            }
                            else if (30 < result && result < 75)
                            {
                                regout++;
                            }
                            else if (75 < result && result < 98)
                            {
                                single++;
                            }
                            else if (98 < result && result < 100)
                            {
                                doubles++;
                            }
                        }
                        else if (hit < 51 && hit > 46 && power < 21)
                        {
                            if (result < 15)
                            {
                                strikeout++;
                            }
                            else if (15 < result && result < 27)
                            {
                                walk++;
                            }
                            else if (27 < result && result < 72)
                            {
                                regout++;
                            }
                            else if (72 < result && result < 97)
                            {
                                single++;
                            }
                            else if (97 < result && result < 100)
                            {
                                doubles++;
                            }
                        }
                        else if (hit < 56 && hit > 51 && power < 21)
                        {
                            if (result < 13)
                            {
                                strikeout++;
                            }
                            else if (13 < result && result < 25)
                            {
                                walk++;
                            }
                            else if (25 < result && result < 70)
                            {
                                regout++;
                            }
                            else if (70 < result && result < 95)
                            {
                                single++;
                            }
                            else if (95 < result && result < 100)
                            {
                                doubles++;
                            }
                        }
                        else if (hit < 61 && hit > 56 && power < 21)
                        {
                            if (result < 12)
                            {
                                strikeout++;
                            }
                            else if (12 < result && result < 25)
                            {
                                walk++;
                            }
                            else if (25 < result && result < 70)
                            {
                                regout++;
                            }
                            else if (70 < result && result < 95)
                            {
                                single++;
                            }
                            else if (95 < result && result < 100)
                            {
                                doubles++;
                            }
                        }
                        else if (hit < 66 && hit > 61 && power < 21)
                        {
                            if (result < 10)
                            {
                                strikeout++;
                            }
                            else if (10 < result && result < 22)
                            {
                                walk++;
                            }
                            else if (22 < result && result < 68)
                            {
                                regout++;
                            }
                            else if (68 < result && result < 94)
                            {
                                single++;
                            }
                            else if (94 < result && result < 99)
                            {
                                doubles++;
                            }
                            else if (99 < result && result < 100)
                            {
                                triple++;
                            }
                        }
                        else if (hit < 71 && hit > 66 && power < 21)
                        {
                            if (result < 9)
                            {
                                strikeout++;
                            }
                            else if (9 < result && result < 22)
                            {
                                walk++;
                            }
                            else if (22 < result && result < 68)
                            {
                                regout++;
                            }
                            else if (68 < result && result < 94)
                            {
                                single++;
                            }
                            else if (93 < result && result < 98)
                            {
                                doubles++;
                            }
                            else if (98 < result && result < 100)
                            {
                                triple++;
                            }
                        }
                        else if (hit < 76 && hit > 71 && power < 21)
                        {
                            if (result < 9)
                            {
                                strikeout++;
                            }
                            else if (9 < result && result < 22)
                            {
                                walk++;
                            }
                            else if (22 < result && result < 65)
                            {
                                regout++;
                            }
                            else if (65 < result && result < 90)
                            {
                                single++;
                            }
                            else if (90 < result && result < 96)
                            {
                                doubles++;
                            }
                            else if (96 < result && result < 99)
                            {
                                triple++;
                            }
                            else if (99 < result && result < 100)
                            {
                                homerun++;
                            }
                        }
                        else if (hit < 81 && hit > 76 && power < 21)
                        {
                            if (result < 8)
                            {
                                strikeout++;
                            }
                            else if (8 < result && result < 22)
                            {
                                walk++;
                            }
                            else if (22 < result && result < 62)
                            {
                                regout++;
                            }
                            else if (62 < result && result < 88)
                            {
                                single++;
                            }
                            else if (88 < result && result < 95)
                            {
                                doubles++;
                            }
                            else if (95 < result && result < 98)
                            {
                                triple++;
                            }
                            else if (98 < result && result < 100)
                            {
                                homerun++;
                            }
                        }
                        //30 Power
                        //Moved parameters for Hit and Power to increments of 10
                        else if (hit < 21 && power < 31 && power > 21)
                        {
                            if (result < 30)
                            {
                                strikeout++;
                            }
                            else if (30 < result && result < 35)
                            {
                                walk++;
                            }
                            else if (35 < result && result < 80)
                            {
                                regout++;
                            }
                            else if (80 < result && result < 99)
                            {
                                single++;
                            }
                            else if (99 < result && result < 100)
                            {
                                doubles++;
                            }
                        }
                        else if (hit < 31 && hit > 21 && power < 31 && power > 21)
                        {
                            if (result < 25)
                            {
                                strikeout++;
                            }
                            else if (25 < result && result < 33)
                            {
                                walk++;
                            }
                            else if (33 < result && result < 78)
                            {
                                regout++;
                            }
                            else if (78 < result && result < 96)
                            {
                                single++;
                            }
                            else if (96 < result && result < 100)
                            {
                                doubles++;
                            }
                        }
                        else if (hit < 41 && hit > 31 && power < 31 && power > 21)
                        {
                            if (result < 13)
                            {
                                strikeout++;
                            }
                            else if (13 < result && result < 25)
                            {
                                walk++;
                            }
                            else if (25 < result && result < 70)
                            {
                                regout++;
                            }
                            else if (70 < result && result < 95)
                            {
                                single++;
                            }
                            else if (95 < result && result < 98)
                            {
                                doubles++;
                            }
                            else if (98 < result && result < 99)
                            {
                                triple++;
                            }
                            else if (99 < result && result < 100)
                            {
                                homerun++;
                            }
                        }
                        else if (hit < 51 && hit > 41 && power < 31 && power > 21)
                        {
                            if (result < 12)
                            {
                                strikeout++;
                            }
                            else if (12 < result && result < 25)
                            {
                                walk++;
                            }
                            else if (25 < result && result < 70)
                            {
                                regout++;
                            }
                            else if (70 < result && result < 95)
                            {
                                single++;
                            }
                            else if (95 < result && result < 98)
                            {
                                doubles++;
                            }
                            else if (98 < result && result < 99)
                            {
                                triple++;
                            }
                            else if (99 < result && result < 100)
                            {
                                homerun++;
                            }
                        }
                        else if (hit < 61 && hit > 51 && power < 31 && power > 21)
                        {
                            if (result < 10)
                            {
                                strikeout++;
                            }
                            else if (10 < result && result < 22)
                            {
                                walk++;
                            }
                            else if (22 < result && result < 68)
                            {
                                regout++;
                            }
                            else if (68 < result && result < 94)
                            {
                                single++;
                            }
                            else if (94 < result && result < 98)
                            {
                                doubles++;
                            }
                            else if (98 < result && result < 99)
                            {
                                triple++;
                            }
                            else if (99 < result && result < 100)
                            {
                                homerun++;
                            }
                        }
                        else if (hit < 71 && hit > 61 && power < 31 && power > 21)
                        {
                            if (result < 9)
                            {
                                strikeout++;
                            }
                            else if (9 < result && result < 22)
                            {
                                walk++;
                            }
                            else if (22 < result && result < 68)
                            {
                                regout++;
                            }
                            else if (68 < result && result < 94)
                            {
                                single++;
                            }
                            else if (93 < result && result < 98)
                            {
                                doubles++;
                            }
                            else if (98 < result && result < 99)
                            {
                                triple++;
                            }
                            else if (99 < result && result < 100)
                            {
                                homerun++;
                            }
                        }
                        else if (hit < 81 && hit > 71 && power < 31 && power > 21)
                        {
                            if (result < 8)
                            {
                                strikeout++;
                            }
                            else if (8 < result && result < 22)
                            {
                                walk++;
                            }
                            else if (22 < result && result < 62)
                            {
                                regout++;
                            }
                            else if (62 < result && result < 88)
                            {
                                single++;
                            }
                            else if (88 < result && result < 95)
                            {
                                doubles++;
                            }
                            else if (95 < result && result < 97)
                            {
                                triple++;
                            }
                            else if (97 < result && result < 100)
                            {
                                homerun++;
                            }
                        }
                        //40 Power
                        //30-39 Power has same effect on all hit attributes
                        //Expanded Hit parameters to increments of 10-20
                        else if (hit < 21 && power < 41 && power > 31)
                        {
                            if (result < 30)
                            {
                                strikeout++;
                            }
                            else if (30 < result && result < 35)
                            {
                                walk++;
                            }
                            else if (35 < result && result < 80)
                            {
                                regout++;
                            }
                            else if (80 < result && result < 93)
                            {
                                single++;
                            }
                            else if (93 < result && result < 98)
                            {
                                doubles++;
                            }
                            else if (98 < result && result < 100)
                            {
                                homerun++;
                            }
                        }
                        else if (hit < 31 && hit > 21 && power < 41 && power > 31)
                        {
                            if (result < 25)
                            {
                                strikeout++;
                            }
                            else if (25 < result && result < 33)
                            {
                                walk++;
                            }
                            else if (33 < result && result < 78)
                            {
                                regout++;
                            }
                            else if (78 < result && result < 91)
                            {
                                single++;
                            }
                            else if (91 < result && result < 96)
                            {
                                doubles++;
                            }
                            else if (96 < result && result < 98)
                            {
                                triple++;
                            }
                            else if (98 < result && result < 100)
                            {
                                homerun++;
                            }
                        }
                        else if (hit < 41 && hit > 31 && power < 41 && power > 31)
                        {
                            if (result < 25)
                            {
                                strikeout++;
                            }
                            else if (25 < result && result < 33)
                            {
                                walk++;
                            }
                            else if (33 < result && result < 78)
                            {
                                regout++;
                            }
                            else if (78 < result && result < 90)
                            {
                                single++;
                            }
                            else if (90 < result && result < 95)
                            {
                                doubles++;
                            }
                            else if (95 < result && result < 97)
                            {
                                triple++;
                            }
                            else if (97 < result && result < 100)
                            {
                                homerun++;
                            }
                        }
                        else if (hit < 61 && hit > 41 && power < 41 && power > 31)
                        {
                            if (result < 15)
                            {
                                strikeout++;
                            }
                            else if (15 < result && result < 27)
                            {
                                walk++;
                            }
                            else if (27 < result && result < 72)
                            {
                                regout++;
                            }
                            else if (72 < result && result < 86)
                            {
                                single++;
                            }
                            else if (86 < result && result < 94)
                            {
                                doubles++;
                            }
                            else if (94 < result && result < 96)
                            {
                                triple++;
                            }
                            else if (96 < result && result < 100)
                            {
                                homerun++;
                            }
                        }
                        else if (hit < 81 && hit > 61 && power < 41 && power > 31)
                        {
                            if (result < 15)
                            {
                                strikeout++;
                            }
                            else if (15 < result && result < 27)
                            {
                                walk++;
                            }
                            else if (27 < result && result < 70)
                            {
                                regout++;
                            }
                            else if (70 < result && result < 85)
                            {
                                single++;
                            }
                            else if (85 < result && result < 93)
                            {
                                doubles++;
                            }
                            else if (93 < result && result < 95)
                            {
                                triple++;
                            }
                            else if (95 < result && result < 100)
                            {
                                homerun++;
                            }
                        }
                        //50 Power
                        //40-49 Power has same effect on all hit attributes
                        //Expanded Hit parameters to increments of 10-20
                        else if (hit < 21 && power < 51 && power > 41)
                        {
                            if (result < 30)
                            {
                                strikeout++;
                            }
                            else if (30 < result && result < 35)
                            {
                                walk++;
                            }
                            else if (35 < result && result < 80)
                            {
                                regout++;
                            }
                            else if (80 < result && result < 90)
                            {
                                single++;
                            }
                            else if (90 < result && result < 95)
                            {
                                doubles++;
                            }
                            else if (95 < result && result < 100)
                            {
                                homerun++;
                            }
                        }
                        else if (hit < 31 && hit > 21 && power < 51 && power > 41)
                        {
                            if (result < 25)
                            {
                                strikeout++;
                            }
                            else if (25 < result && result < 33)
                            {
                                walk++;
                            }
                            else if (33 < result && result < 78)
                            {
                                regout++;
                            }
                            else if (78 < result && result < 88)
                            {
                                single++;
                            }
                            else if (88 < result && result < 94)
                            {
                                doubles++;
                            }
                            else if (94 < result && result < 95)
                            {
                                triple++;
                            }
                            else if (95 < result && result < 100)
                            {
                                homerun++;
                            }
                        }
                        else if (hit < 41 && hit > 31 && power < 51 && power > 41)
                        {
                            if (result < 25)
                            {
                                strikeout++;
                            }
                            else if (25 < result && result < 33)
                            {
                                walk++;
                            }
                            else if (33 < result && result < 78)
                            {
                                regout++;
                            }
                            else if (78 < result && result < 88)
                            {
                                single++;
                            }
                            else if (88 < result && result < 93)
                            {
                                doubles++;
                            }
                            else if (93 < result && result < 94)
                            {
                                triple++;
                            }
                            else if (94 < result && result < 100)
                            {
                                homerun++;
                            }
                        }
                        else if (hit < 61 && hit > 41 && power < 51 && power > 41)
                        {
                            if (result < 15)
                            {
                                strikeout++;
                            }
                            else if (15 < result && result < 27)
                            {
                                walk++;
                            }
                            else if (27 < result && result < 72)
                            {
                                regout++;
                            }
                            else if (72 < result && result < 84)
                            {
                                single++;
                            }
                            else if (84 < result && result < 92)
                            {
                                doubles++;
                            }
                            else if (92 < result && result < 94)
                            {
                                triple++;
                            }
                            else if (94 < result && result < 100)
                            {
                                homerun++;
                            }
                        }
                        else if (hit < 81 && hit > 61 && power < 51 && power > 41)
                        {
                            if (result < 15)
                            {
                                strikeout++;
                            }
                            else if (15 < result && result < 27)
                            {
                                walk++;
                            }
                            else if (27 < result && result < 70)
                            {
                                regout++;
                            }
                            else if (70 < result && result < 83)
                            {
                                single++;
                            }
                            else if (83 < result && result < 92)
                            {
                                doubles++;
                            }
                            else if (92 < result && result < 94)
                            {
                                triple++;
                            }
                            else if (94 < result && result < 100)
                            {
                                homerun++;
                            }
                        }
                        //60 Power
                        //50-59 Power has same effect on all hit attributes
                        //Expanded Hit parameters to increments of 10-20
                        else if (hit < 21 && power < 61 && power > 51)
                        {
                            if (result < 30)
                            {
                                strikeout++;
                            }
                            else if (30 < result && result < 35)
                            {
                                walk++;
                            }
                            else if (35 < result && result < 80)
                            {
                                regout++;
                            }
                            else if (80 < result && result < 90)
                            {
                                single++;
                            }
                            else if (90 < result && result < 94)
                            {
                                doubles++;
                            }
                            else if (94 < result && result < 100)
                            {
                                homerun++;
                            }
                        }
                        else if (hit < 31 && hit > 21 && power < 61 && power > 51)
                        {
                            if (result < 25)
                            {
                                strikeout++;
                            }
                            else if (25 < result && result < 33)
                            {
                                walk++;
                            }
                            else if (33 < result && result < 78)
                            {
                                regout++;
                            }
                            else if (78 < result && result < 87)
                            {
                                single++;
                            }
                            else if (87 < result && result < 93)
                            {
                                doubles++;
                            }
                            else if (93 < result && result < 94)
                            {
                                triple++;
                            }
                            else if (94 < result && result < 100)
                            {
                                homerun++;
                            }
                        }
                        else if (hit < 41 && hit > 31 && power < 61 && power > 51)
                        {
                            if (result < 25)
                            {
                                strikeout++;
                            }
                            else if (25 < result && result < 33)
                            {
                                walk++;
                            }
                            else if (33 < result && result < 78)
                            {
                                regout++;
                            }
                            else if (78 < result && result < 86)
                            {
                                single++;
                            }
                            else if (86 < result && result < 93)
                            {
                                doubles++;
                            }
                            else if (93 < result && result < 94)
                            {
                                triple++;
                            }
                            else if (94 < result && result < 100)
                            {
                                homerun++;
                            }
                        }
                        else if (hit < 61 && hit > 41 && power < 61 && power > 51)
                        {
                            if (result < 15)
                            {
                                strikeout++;
                            }
                            else if (15 < result && result < 27)
                            {
                                walk++;
                            }
                            else if (27 < result && result < 72)
                            {
                                regout++;
                            }
                            else if (72 < result && result < 84)
                            {
                                single++;
                            }
                            else if (84 < result && result < 92)
                            {
                                doubles++;
                            }
                            else if (92 < result && result < 94)
                            {
                                triple++;
                            }
                            else if (94 < result && result < 100)
                            {
                                homerun++;
                            }
                        }
                        else if (hit < 81 && hit > 61 && power < 61 && power > 51)
                        {
                            if (result < 15)
                            {
                                strikeout++;
                            }
                            else if (15 < result && result < 27)
                            {
                                walk++;
                            }
                            else if (27 < result && result < 70)
                            {
                                regout++;
                            }
                            else if (70 < result && result < 82)
                            {
                                single++;
                            }
                            else if (82 < result && result < 91)
                            {
                                doubles++;
                            }
                            else if (91 < result && result < 93)
                            {
                                triple++;
                            }
                            else if (93 < result && result < 100)
                            {
                                homerun++;
                            }
                        }
                        //70-80 Power
                        //50-59 Power has same effect on all hit attributes
                        //Expanded Hit parameters to increments of 10-20
                        else if (hit < 21 && power < 81 && power > 61)
                        {
                            if (result < 32)
                            {
                                strikeout++;
                            }
                            else if (32 < result && result < 38)
                            {
                                walk++;
                            }
                            else if (38 < result && result < 82)
                            {
                                regout++;
                            }
                            else if (82 < result && result < 90)
                            {
                                single++;
                            }
                            else if (90 < result && result < 94)
                            {
                                doubles++;
                            }
                            else if (94 < result && result < 100)
                            {
                                homerun++;
                            }
                        }
                        else if (hit < 31 && hit > 21 && power < 81 && power > 61)
                        {
                            if (result < 30)
                            {
                                strikeout++;
                            }
                            else if (30 < result && result < 38)
                            {
                                walk++;
                            }
                            else if (38 < result && result < 80)
                            {
                                regout++;
                            }
                            else if (80 < result && result < 89)
                            {
                                single++;
                            }
                            else if (89 < result && result < 93)
                            {
                                doubles++;
                            }
                            else if (93 < result && result < 94)
                            {
                                triple++;
                            }
                            else if (94 < result && result < 100)
                            {
                                homerun++;
                            }
                        }
                        else if (hit < 41 && hit > 31 && power < 81 && power > 61)
                        {
                            if (result < 25)
                            {
                                strikeout++;
                            }
                            else if (25 < result && result < 33)
                            {
                                walk++;
                            }
                            else if (33 < result && result < 78)
                            {
                                regout++;
                            }
                            else if (78 < result && result < 84)
                            {
                                single++;
                            }
                            else if (84 < result && result < 92)
                            {
                                doubles++;
                            }
                            else if (92 < result && result < 94)
                            {
                                triple++;
                            }
                            else if (94 < result && result < 100)
                            {
                                homerun++;
                            }
                        }
                        else if (hit < 61 && hit > 41 && power < 81 && power > 61)
                        {
                            if (result < 15)
                            {
                                strikeout++;
                            }
                            else if (15 < result && result < 30)
                            {
                                walk++;
                            }
                            else if (30 < result && result < 70)
                            {
                                regout++;
                            }
                            else if (70 < result && result < 82)
                            {
                                single++;
                            }
                            else if (82 < result && result < 90)
                            {
                                doubles++;
                            }
                            else if (90 < result && result < 93)
                            {
                                triple++;
                            }
                            else if (93 < result && result < 100)
                            {
                                homerun++;
                            }
                        }
                        else if (hit < 81 && hit > 61 && power < 81 && power > 61)
                        {
                            if (result < 15)
                            {
                                strikeout++;
                            }
                            else if (15 < result && result < 40)
                            {
                                walk++;
                            }
                            else if (40 < result && result < 70)
                            {
                                regout++;
                            }
                            else if (70 < result && result < 82)
                            {
                                single++;
                            }
                            else if (82 < result && result < 90)
                            {
                                doubles++;
                            }
                            else if (90 < result && result < 93)
                            {
                                triple++;
                            }
                            else if (92 < result && result < 100)
                            {
                                homerun++;
                            }
                        }
                    }
                    Console.WriteLine("Hits {0}", single + doubles + triple + homerun);
                    Console.WriteLine("Doubles{0}", doubles);
                    Console.WriteLine("Triples{0}", triple);
                    Console.WriteLine("Homeruns{0}", homerun);
                    Console.WriteLine("Strikeouts{0}", strikeout);
                    Console.WriteLine("Walks{0}", walk);
                    Console.WriteLine("At-Bats{0}", single + doubles + triple + homerun + strikeout + regout);
                    Console.WriteLine("Batting Average{0}", ((double)single + doubles + triple + homerun) / (single + doubles + triple + homerun + strikeout + regout));
                    Console.WriteLine("On Base Percentage{0}", ((double)single + doubles + triple + homerun + walk) / (single + doubles + triple + homerun + strikeout + regout + walk));
                    Console.WriteLine("Slugging Percentage{0}", ((double)single + (doubles * 2) + (triple * 3) + (homerun * 4)) / (single + doubles + triple + homerun + strikeout + regout));
                    Console.ReadLine();
                    Console.WriteLine("Enter y to run again");
                    string restart = Console.ReadLine();
                    if (restart.ToLower() == "y")
                    {
                        Run();
                    }
                }
            }
        }
    }
}
