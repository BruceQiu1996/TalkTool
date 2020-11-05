using CloboticsTalk.Infrastructure.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloboticsTalk.Module.Core.Abstractions.Entities
{
    /// <summary>
    /// 用户
    /// </summary>
    public class User : IdentityUser<int>, IEntityWithTypedId<int>, IExtendableObject
    {
        public User() 
        {
            this.CreateTime = DateTime.Now;
            this.UpdateTime = DateTime.Now;
        }
        public string DisplayName { get; set; }
        public string ExtensionData { get; set; }
        public bool IsActive { get; set; }
        public string LastLoginIp { get; set; }
        public DateTime? LastLoginTime { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
        public bool Sex { get; set; }
        public string NimToken { get; set; }
        public string Accid { get; set; }
    }
}
