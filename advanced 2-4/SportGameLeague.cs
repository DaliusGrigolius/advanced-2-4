using System;
using System.Collections.Generic;

namespace advanced_2_4
{
    public class SportGameLeague<T>
    {
        private List<T> Teams { get; set; }

        public SportGameLeague()
        {
            this.Teams = new List<T>();
        }

        public void AddTeam(T team)
        {
            Teams.Add(team);
        }

        public void PrintAllTeams()
        {
            foreach (var team in Teams)
            {
                Console.WriteLine(team);
            }
        }
    }
}
