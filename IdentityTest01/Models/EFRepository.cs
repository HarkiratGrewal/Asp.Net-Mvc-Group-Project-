using IdentityTest01.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityTest01.Models
{
    public class EFRepository : IRepository
    {
        private AppDbContext context;

        public EFRepository(AppDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Recipe> Recipe => context.Recipes;
    }
}
