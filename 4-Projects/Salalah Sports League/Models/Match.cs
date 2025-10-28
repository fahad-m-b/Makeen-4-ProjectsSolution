using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Projects.Salalah_Sports_League.Models
{
    public class Match
    {
        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
        public int ScoreTeam1 { get; set; }
        public int ScoreTeam2 { get; set; }
        public Team Winner { get; set; }

        public Match(Team t1, Team t2)
        {
            Team1 = t1;
            Team2 = t2;
        }

        public void SetResult(int score1, int score2)
        {
            ScoreTeam1 = score1;
            ScoreTeam2 = score2;

            if (score1 > score2)
            {
                Winner = Team1;
                Team1.Points += 3;
            }
            else if (score2 > score1)
            {
                Winner = Team2;
                Team2.Points += 3;
            }
            else
            {
                Winner = null; // Draw
                Team1.Points += 1;
                Team2.Points += 1;
            }
        }

        public void ShowMatchInfo()
        {
            string result = Winner != null ? $"Winner: {Winner.Name}" : "Draw";
            Console.WriteLine($"{Team1.Name} {ScoreTeam1} - {ScoreTeam2} {Team2.Name} | {result}");
        }
    }
}
