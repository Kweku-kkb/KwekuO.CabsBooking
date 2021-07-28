using ApplicationCore.Entities;
using ApplicationCore.RepositoryInterfaces;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class CabTypesRepository : EfRepository<CabTypes>, ICabTypesRepository
    {
        public CabTypesRepository(CabsBookingDbContext dbContext) : base(dbContext)
        {

        }

        public async Task<List<CabTypes>> GetCabs()
        {
            var cabs = await _dbContext.CabTypes.OrderByDescending(m => m.CabTypeId).ToListAsync();
            return cabs;
        }
        public override async Task<CabTypes> GetByIdAsync(int id)
        {
            var cab = await _dbContext.CabTypes.Include(c => c.Bookings)
               .FirstOrDefaultAsync(c => c.CabTypeId == id);


            //var cab = await _dbContext.CabTypes.Include(c => c.Bookings).ThenInclude(c => c.Place)
            //    .FirstOrDefaultAsync(c => c.CabTypeId == id);

            if (cab == null)
            {
                throw new Exception($"No movie found with {id} ");
            }
            return cab;
        }
    }
}
