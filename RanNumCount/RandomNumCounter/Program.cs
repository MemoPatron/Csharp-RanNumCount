using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sjov
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double t1 = 0;
            double t2 = 0;
            double t3 = 0;
            double t4 = 0;
            double t5 = 0;
            double t6 = 0;
            double t7 = 0;
            double t8 = 0;
            double t9 = 0;
            double t10 = 0;

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Write the amount of random numbers you desire..");
            double antaltal = Convert.ToDouble(Console.ReadLine());
            double Antaltal = antaltal + 1;
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Magenta;
            //Console.BackgroundColor = ConsoleColor.Red;

            for (int j = 0; j < 13; j++)
            {
                Console.SetCursorPosition(18, 0 + j);
                Console.WriteLine("|");

                Console.SetCursorPosition(29, 0 + j);
                Console.WriteLine("|");

                Console.SetCursorPosition(40, 0 + j);
                Console.WriteLine("|");
            }
            for (int k = 0; k < 23; k++)
            {
                Console.SetCursorPosition(18 + k, 12);
                Console.WriteLine("#");

                Console.SetCursorPosition(18 + k, 0);
                Console.WriteLine("#");
            }


            DateTime start = DateTime.Now;
            for (int i = 0; i < Antaltal; i++)
            {
                double tal100p = Antaltal;
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(20, 1);
                Console.WriteLine("- Tal -");
                Console.SetCursorPosition(32, 1);
                Console.WriteLine("- % -");


                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green;

                //

                Console.SetCursorPosition(20, 2);
                Console.WriteLine($"1 = {t1}");

                Console.SetCursorPosition(32, 2);
                double p1 = (t1 * 100) / tal100p;
                Console.WriteLine($"{Math.Round(p1, 3)}%");

                //

                Console.SetCursorPosition(20, 3);
                Console.WriteLine($"2 = {t2}");

                Console.SetCursorPosition(32, 3);
                double p2 = (t2 * 100) / tal100p;
                Console.WriteLine($"{Math.Round(p2, 3)}%");

                //

                Console.SetCursorPosition(20, 4);
                Console.WriteLine($"3 = {t3}");

                Console.SetCursorPosition(32, 4);
                double p3 = (t3 * 100) / tal100p;
                Console.WriteLine($"{Math.Round(p3, 3)}%");

                //

                Console.SetCursorPosition(20, 5);
                Console.WriteLine($"4 = {t4}");

                Console.SetCursorPosition(32, 5);
                double p4 = (t4 * 100) / tal100p;
                Console.WriteLine($"{Math.Round(p4, 3)}%");

                //

                Console.SetCursorPosition(20, 6);
                Console.WriteLine($"5 = {t5}");

                Console.SetCursorPosition(32, 6);
                double p5 = (t5 * 100) / tal100p;
                Console.WriteLine($"{Math.Round(p5, 3)}%");

                //

                Console.SetCursorPosition(20, 7);
                Console.WriteLine($"6 = {t6}");

                Console.SetCursorPosition(32, 7);
                double p6 = (t6 * 100) / tal100p;
                Console.WriteLine($"{Math.Round(p6, 3)}%");

                //

                Console.SetCursorPosition(20, 8);
                Console.WriteLine($"7 = {t7}");

                Console.SetCursorPosition(32, 8);
                double p7 = (t7 * 100) / tal100p;
                Console.WriteLine($"{Math.Round(p7, 3)}%");

                //

                Console.SetCursorPosition(20, 9);
                Console.WriteLine($"8 = {t8}");

                Console.SetCursorPosition(32, 9);
                double p8 = (t8 * 100) / tal100p;
                Console.WriteLine($"{Math.Round(p8, 3)}%");

                //

                Console.SetCursorPosition(20, 10);
                Console.WriteLine($"9 = {t9}");

                Console.SetCursorPosition(32, 10);
                double p9 = (t9 * 100) / tal100p;
                Console.WriteLine($"{Math.Round(p9, 3)}%");

                //

                Console.SetCursorPosition(20, 11);
                Console.WriteLine($"10 = {t10}");

                Console.SetCursorPosition(32, 11);
                double p10 = (t10 * 100) / tal100p;
                Console.WriteLine($"{Math.Round(p10, 3)}%");

                //

                Random rd = new Random();
                int tal = rd.Next(1, 11);

                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.SetCursorPosition(0, 0);
                Console.WriteLine($"Current Num: {tal} ");

                Console.SetCursorPosition(0, 11);
                Console.WriteLine($"Total generated: \n{i}");

                if (tal == 1)
                {
                    t1++;
                }
                else if (tal == 2)
                {
                    t2++;
                }
                else if (tal == 3)
                {
                    t3++;
                }
                else if (tal == 4)
                {
                    t4++;
                }
                else if (tal == 5)
                {
                    t5++;
                }
                else if (tal == 6)
                {
                    t6++;
                }
                else if (tal == 7)
                {
                    t7++;
                }
                else if (tal == 8)
                {
                    t8++;
                }
                else if (tal == 9)
                {
                    t9++;
                }
                else if (tal == 10)
                {
                    t10++;
                }


            }

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(0, 4);
            DateTime end = DateTime.Now;
            Console.WriteLine($"It took:\n{(end - start).TotalSeconds:N2} Seconds");
            Console.WriteLine($"{((end - start).TotalSeconds) / 60:N0} Minutes");
            Console.WriteLine($"{((end - start).TotalSeconds) / 60 / 60:N0} Hours");

            Console.SetCursorPosition(0, 20);
            Console.WriteLine("Press any key to exit.");

            Console.ReadKey();
            Environment.Exit(1000);
        }
    }
}







