﻿using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.RepositoryInterfaces
{
    interface IBookingsHistoryRepository : IAsyncRepository<Bookings_History>
    {
    }
}
