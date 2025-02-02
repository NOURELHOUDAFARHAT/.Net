using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.domain
{
    public class Flight
    {
        public String Destination { get; set; }
        public String Departure { get; set; }
       public DateTime FlightDate { get; set; }
        public int FlightId { get; set; }
        public String EffectiveArrival { get; set; }
        public DateTime EffectiveArrivalDate { get; private set; }

        public int EstimationDuration { get; set; }
        public Plane plane { get; set; }
        public ICollection<Passenger> passengers { get; set; }
        
    }
}
