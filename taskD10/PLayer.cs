using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskD10
{
    public class PLayer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Team { get; set; }

        public int Number { get; set; }

        public PLayer()
        {
            Id = 10;
            Name = "Hamody";
            Number = 10;
            Team = "Ahly";
        }

        public override string ToString()
        {
            return $"player {Name} team {Team} ";
        }


        public void run(Location location)
        {
            Console.WriteLine($"Player {Name} Team {Team} is running to location {location}");
        }

    }
}
