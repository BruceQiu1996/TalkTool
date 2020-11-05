using CloboticsTalk.Infrastructure.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloboticsTalk.Module.Core.Abstractions.Entities
{
    public class Role:IdentityRole<int>,IEntityWithTypedId<int>
    {
        public IList<UserRole> Users { get; set; } = new List<UserRole>();
    }
}
}
