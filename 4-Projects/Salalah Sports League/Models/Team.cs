using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Projects.Salalah_Sports_League.Models
{
    public class Team
    {
        public string Name { get; set; }
        public string Coach { get; set; }
        public List<Player> Players { get; set; } = new List<Player>();
        public int Points { get; set; } = 0;

        public Team(string name, string coach)
        {
            Name = name;
            Coach = coach;
        }

        public void AddPlayer(Player player)
        {
            Players.Add(player);
        }

        public void ShowTeamInfo()
        {
            Console.WriteLine($"Team: {Name}, Coach: {Coach}, Points: {Points}");
            foreach (var player in Players)
            {
                player.ShowInfo();
            }
        }
    }
}
