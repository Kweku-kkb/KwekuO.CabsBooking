using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class Places
    {
        public int PlaceId { get; set; }
        public string PlaceName { get; set; }

        //navigation
        public ICollection<Bookings> Bookings { get; set; }
        public ICollection<Bookings_History> Bookings_Histories { get; set; }

    }
}
