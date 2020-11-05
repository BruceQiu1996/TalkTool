using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CloboticsTalk.Module.Core.Abstractions.Entities
{
    public class UserRole:IdentityUserRole<int>
    {
        [ForeignKey(nameof(User))]
        public override int UserId { get; set; }
        public User User { get; set; }

        [ForeignKey(nameof(Role))]
        public override int RoleId { get; set; }
        public Role Role { get; set; }
    }
}
