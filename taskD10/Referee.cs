using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskD10
{
    public class Referee
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public Referee()
        {
            Id = 10;
            Name = "Alii";
        }
        public override string ToString()
        {
            return $"refree {Name}";
        }
        
        public void observe(Location loc)
        {
            Console.WriteLine($"Referee {Name} is observing ball location {loc}");
        }

    }
}
