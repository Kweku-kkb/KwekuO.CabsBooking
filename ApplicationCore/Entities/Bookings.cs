using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class Bookings
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public DateTime? BookingDate { get; set; }
        public string BookingTime { get; set; }
        public int? FromPlace { get; set; }
        public int? ToPlace { get; set; }
        public string PickupAddress { get; set; }
        public string Landmark { get; set; }
        public DateTime? PickupDate { get; set; }
        public string PickupTime { get; set; }
        public int? CabTypeId { get; set; }
        public string ContactNo { get; set; }
        public string Status { get; set; }

        //navigation
        public CabTypes CabType { get; set; }
        public Places Place { get; set; }
    }
}
