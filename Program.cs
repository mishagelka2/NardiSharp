using System;

namespace NardiSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Player[] players = new Player[2];
            InitPlayers(ref players);

            //Field f = new Field(17, 25);

            //while (!f.GameOver)
            //{
            //    f.ReadIncomingValues();
            //}


        }
        static void InitPlayers(ref Player[] players)
        {
            Console.Clear();
            Console.WriteLine("Welcome, yopta");
            for (int i = 0; i < players.Length; i++)
            {
                Console.Write($"Enter P{i+1} name ");
                string p = Console.ReadLine();
                players[i] = new Player(p);
                Console.WriteLine();
            }
            //decide who goes first
            foreach(var p in players)
            {
                ThrowCubics(out int first, out int second);
                int biggest = GetBiggerNumber(first, second);

            }
        }

        static void ThrowCubics(out int first, out int second)
        {
            var rand = new Random();
            first = rand.Next(1, 6);
            second = rand.Next(1, 6);
        }

        static int GetBiggerNumber(int f, int s) => f >= s ? f : s;

    }
}
