using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gibson4200.Models
{
    public class Airplane
    {
        public int AirplaneID { get; set; }
        public string description { get; set; }
        // add any other fields as appropriate
        //Order is on the "one" side of a one-to-many relationship with OrderDetail
        //and we indicate that with an ICollection
        public ICollection<FlightDetail> FlightDetail { get; set; }
        //Order is on the Many side of the one-to-many relation between Customer
        //and Order and we represent that relationship like this
        public int flyerID { get; set; }
        public virtual Flyer Flyer { get; set; }

    }
}