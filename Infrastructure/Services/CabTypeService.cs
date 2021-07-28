using ApplicationCore.Models;
using ApplicationCore.RepositoryInterfaces;
using ApplicationCore.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class CabTypeService : ICabTypesService
    {
        private readonly ICabTypesRepository _cabTypesRepository;

        public CabTypeService(ICabTypesRepository cabTypesRepository)
        {
            _cabTypesRepository = cabTypesRepository;
        }

        public async Task<List<CabTypeModel>> GetAllCabTypes()
        {
            var cabs = await _cabTypesRepository.GetCabs();

            var cabCards = new List<CabTypeModel>();
            foreach (var cab in cabs)
            {
                cabCards.Add(new CabTypeModel
                {
                    CabTypeId = cab.CabTypeId,
                    CabTypeName = cab.CabTypeName
                });
            }
            return cabCards;
        }

        public async Task<CabDetailsResponseModel> GetCabDetails(int id)
        {
            var cabTypes = await _cabTypesRepository.GetByIdAsync(id);

            var cabDetails = new CabDetailsResponseModel()
            {
                Id = cabTypes.CabTypeId,
                Name = cabTypes.CabTypeName 
            };

            cabDetails.Bookings = new List<BookingsModel>();
            foreach (var booking in cabTypes.Bookings)
            {
                cabDetails.Bookings.Add(new BookingsModel
                {
                    Id = booking.Id,
                    Email = booking.Email,
                    BookingDate = booking.BookingDate,
                    BookingTime = booking.BookingTime,
                    FromPlace = booking.FromPlace,
                    ToPlace = booking.ToPlace,
                    PickupAddress = booking.PickupAddress,
                    Landmark = booking.Landmark,
                    PickupDate = booking.PickupDate,
                    PickupTime = booking.PickupTime,
                    CabTypeId = booking.CabTypeId,
                    ContactNo = booking.ContactNo,
                    Status = booking.Status
                });

            }

            //cabDetails.Places = new List<PlacesModel>();
            //foreach (var place in cabTypes.Places)
            //{
            //    cabDetails.Places.Add(new PlacesModel
            //    {
            //        Id = place.Id,
            //        Name = place.Name
            //    });
            //}

            //return cabDetails;

        }
    }
}
