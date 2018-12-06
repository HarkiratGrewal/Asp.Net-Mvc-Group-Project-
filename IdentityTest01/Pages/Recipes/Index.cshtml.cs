using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IdentityTest01.Data;
using IdentityTest01.Models;

namespace IdentityTest01
{
    public class IndexModel : PageModel
    {
        private readonly IdentityTest01.Data.AppDbContext _context;

        public IndexModel(IdentityTest01.Data.AppDbContext context)
        {
            _context = context;
        }

        public IList<Recipe> Recipe { get;set; }

        public async Task OnGetAsync()
        {
            Recipe = await _context.Recipes.ToListAsync();
        }
    }
}
