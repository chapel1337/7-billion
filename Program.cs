using System;
using System.Threading;

// written by chapel1337
// made on 8/20/2022
// inspired by cyriak, inspiration: https://www.youtube.com/watch?v=zKPhjkw3Y84

namespace _7_billion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "7 billion";
            Console.Beep(); // to let the user know that the application has started : )

            double rabbitAmount = 1;

            for (double i = 0; i < 100; i++)
            {
                if (rabbitAmount >= 7e9)
                {
                    for (int o = 5; o > 0; o--)
                    {
                        Console.Clear();
                        Console.WriteLine($"there are too many rabbits, exiting application before the amount gets out of hand in {o}");
                        Thread.Sleep(1000);
                    }
                    Environment.Exit(0);
                }
                else
                {
                    if (rabbitAmount == 1)
                    {
                        Console.WriteLine($"there is {rabbitAmount} rabbit");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine($"there are {rabbitAmount} rabbits");
                    }
                    rabbitAmount *= 2;
                    Thread.Sleep(1000);
                }
            }

            pause();
        }

        static void pause()
        {
            Console.ReadKey(true);
        }
    }
}
