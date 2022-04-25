using System;

namespace advanced_2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            SportGameLeague<BasketBallTeam> basketBallLeague = new SportGameLeague<BasketBallTeam>();
            SportGameLeague<SoccerTeam> soccerLeague = new SportGameLeague<SoccerTeam>();

            basketBallLeague.AddTeam(new BasketBallTeam("Zalgiris"));
            soccerLeague.AddTeam(new SoccerTeam("Puliai"));

            Console.WriteLine("krepsinio lygos komandos:");
            basketBallLeague.PrintAllTeams();
            Console.WriteLine("futbolo lygos komandos:");
            soccerLeague.PrintAllTeams();
        }
    }
}
