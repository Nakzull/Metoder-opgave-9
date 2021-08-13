using System;
using System.Collections.Generic;

namespace Metoder_opgave_9
{

    class Program

    {
        static void Main(string[] args)
        {
            int[] userNumbers = new int[7];
            while (true)
            {
                InsertNumbers(userNumbers);
                int sammeTal = 0;
                Random random = new Random();
                List<int> lottoVinderTal = new List<int>();
                for (int i = 0; i < 7; i++)
                {
                    lottoVinderTal.Add(random.Next(1, 21));
                }
                for (int i = 0; i < 7; i++)
                {
                    if (userNumbers[i] == lottoVinderTal[i])
                        sammeTal++;
                }
                if (sammeTal < 2)
                    Console.WriteLine("You didn't win this time.. Better luck next time!");
                else if (sammeTal == 2)
                    Console.WriteLine("Congratz you've won 50$!");
                else if (sammeTal == 3)
                    Console.WriteLine("Congratz you've won 100$!");
                else if (sammeTal == 4)
                    Console.WriteLine("Congratz you've won 150$!");
                else if (sammeTal == 5)
                    Console.WriteLine("Congratz you've won 200$!");
                else if (sammeTal == 6)
                    Console.WriteLine("Congratz you've won 250$!");
                else
                    Console.WriteLine("Congratz you've won 500$!");
            }
        }
        public static int[] InsertNumbers(int[] a)
        {
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Number " + (i + 1));
                a[i] = int.Parse(Console.ReadLine());
            }
            return a;
        }
    }
}