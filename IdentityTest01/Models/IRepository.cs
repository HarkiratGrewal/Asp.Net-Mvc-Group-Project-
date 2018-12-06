using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityTest01.Models
{
    public interface IRepository
    {
        IQueryable<Recipe> Recipe { get; }
    }
}
