using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace gibson4200.Models
{
    public class FlightDetail
    {
        public int flightdetailID { get; set; }
        public int ticketsOrdered { get; set; }
        public decimal price { get; set; }
        // the next two properties link the orderDetail to the Order
        public int AirplaneID { get; set; }
        public virtual Airplane Airplane { get; set; }
        // the next two properties link the orderDetail to the Product
        public int SeatID { get; set; }
        public virtual Seat Seat { get; set; }
    }
}