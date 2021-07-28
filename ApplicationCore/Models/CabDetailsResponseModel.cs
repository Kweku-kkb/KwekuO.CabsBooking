using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models
{
    public class CabDetailsResponseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<PlacesModel> Places { get; set; }
        //public List<CabTypeModel> CabTypes {get; set;}
        public List<BookingsModel> Bookings { get; set; }

        //fix this later
        //public List<Bookings_HistoryModel> Bookings_Histories { get; set; }

    }

    public class PlacesModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
