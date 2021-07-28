using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.ServiceInterfaces
{
    class ICurrentUser
    {
        int UserId { get; }
        bool IsAuthenticated { get; }
        string Email { get; }
        string FullName { get; }
        bool IsAdmin { get; }
        bool IsSuperAdmin { get; }
    }
}
