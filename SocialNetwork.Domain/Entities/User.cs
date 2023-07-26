using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.Domain.Entities
{
    public class User : IdentityUser
    {
        public string Name { get; set; } = null!;
        public DateTime? UpdatedOn { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
    }
}
