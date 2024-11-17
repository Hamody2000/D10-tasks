using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskD10
{
    public class Football
    {
        public string Name { get; set; }

        public int Id { get; set; }
        Location location;

        public Location Location
        {
            get
            {
                return Location;
            }

            set
            {
                if (value != location)
                {
                    //fire the event

                    //BallLocationChanged(value);
                    BallLocationChanged?.Invoke(value);


                }
                location = value;
            }
        }

        public override string ToString()
        {
            return $"The Football is on location {location}";
        }



        public event Action<Location> BallLocationChanged;

    }
}
