using _4_Projects.Salalah_Sports_League.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Projects.Salalah_Sports_League
{
    internal class Program
    {
        static void Main(string[] args)
        {
            League league = new League();

            Team teamA = new Team("Salalah Goats", "Hussam");
            teamA.AddPlayer(new Player("Ahmed", "Forward", 9));
            teamA.AddPlayer(new Player("Salim", "Midfielder", 8));

            Team teamB = new Team("Salalah Hawks", "Fahad");
            teamB.AddPlayer(new Player("Saeed", "Forward", 10));
            teamB.AddPlayer(new Player("Fayadh", "Goalkeeper", 1));

            league.AddTeam(teamA);
            league.AddTeam(teamB);

            Match match1 = new Match(teamA, teamB);
            match1.SetResult(2, 1);
            league.RecordMatch(match1);

            league.ShowAllMatches();
            league.ShowStandings();
        }
    }
}
