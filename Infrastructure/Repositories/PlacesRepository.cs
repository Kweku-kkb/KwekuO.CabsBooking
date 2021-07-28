using ApplicationCore.Entities;
using ApplicationCore.RepositoryInterfaces;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class PlacesRepository: EfRepository<Places>, IPlacesRepository
    {
        public PlacesRepository(CabsBookingDbContext dbContext): base(dbContext)
        {

        }
    }
}
