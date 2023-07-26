using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using SocialNetwork.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.DataAccessLayer.Context
{
    public class SocialNetworkContext : IdentityDbContext<User>
    {
    }
}
