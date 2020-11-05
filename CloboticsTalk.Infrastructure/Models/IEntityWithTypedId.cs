using System;
using System.Collections.Generic;
using System.Text;

namespace CloboticsTalk.Infrastructure.Models
{
    public interface IEntityWithTypedId<Tid>
    {
        Tid Id { get; }
    }
}
