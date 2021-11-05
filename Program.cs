using System;

namespace NardiSharp
{
    class Program
    {
        static void InitPlayers(ref Player[] players)
        {
            Console.Clear();
            Console.Write("Enter P1 name ");
            string p1 = Console.ReadLine();
            players[0] = new Player(p1);
            Console.WriteLine();

            Console.Write("Enter P2 name ");
            string p2 = Console.ReadLine();
            players[1] = new Player(p2);
            Console.WriteLine();
            
        }
        static void Main(string[] args)
        {
            Player[] players = new Player[2];
            InitPlayers(ref players);

            Field f = new Field(17, 25);

        }

    }
}
