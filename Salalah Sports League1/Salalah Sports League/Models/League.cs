using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _4_Projects.Salalah_Sports_League.Models
{
    public class League
    {
        public List<Team> Teams { get; set; } = new List<Team>();
        public List<Match> Matches { get; set; } = new List<Match>();

        public void AddTeam(Team team)
        {
            Teams.Add(team);
        }

        public void RecordMatch(Match match)
        {
            Matches.Add(match);
        }

        public void ShowStandings()
        {
            Console.WriteLine("\n--- League Standings ---");
            Teams.Sort((a, b) => b.Points.CompareTo(a.Points)); // Descending by points
            foreach (var team in Teams)
            {
                Console.WriteLine($"{team.Name} - {team.Points} pts");
            }
        }

        public void ShowAllMatches()
        {
            Console.WriteLine("\n--- Match Results ---");
            foreach (var match in Matches)
            {
                match.ShowMatchInfo();
            }
        }
    }
}
