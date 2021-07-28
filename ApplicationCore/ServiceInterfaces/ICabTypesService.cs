using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.ServiceInterfaces
{
    public interface ICabTypesService
    {
        Task<List<CabTypeModel>> GetAllCabTypes();
        Task<CabDetailsResponseModel> GetCabDetails(int id);
    }
}
