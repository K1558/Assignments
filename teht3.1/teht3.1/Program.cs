using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>();

            players.Add(new Player { Firstname = "Linda", Lastname = "Valimaki", Points = 60 , Team = "Espoo United" });
            players.Add(new Player { Firstname = "Annina", Lastname = "Rajahuhta", Points = 44 , Team = "Espoo United" });
            players.Add(new Player { Firstname = "Saila", Lastname = "Saari", Points = 39 , Team = "Karpat" });
            players.Add(new Player { Firstname = "Riikka", Lastname = "Noronen", Points = 39 , Team = "HPK" });
            players.Add(new Player { Firstname = "Tanja", Lastname = "Niskanen", Points=36, Team = "Kalpa" });

            players.Sort((x,y) => x.Team.CompareTo(y.Team));


            Console.WriteLine("Pelaajat joukkueittain: ");
            foreach (Player player in players)
            {
                Console.WriteLine(player.ToString());
            }

            Console.WriteLine("Pisteet: ");
            players.Sort((x, y) => y.Points.CompareTo(x.Points));
            foreach (Player player in players)
            {
                Console.WriteLine(player.ToString());
            }




        }
    }
}
