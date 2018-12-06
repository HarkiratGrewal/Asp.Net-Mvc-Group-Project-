using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IdentityTest01.Data;
using IdentityTest01.Models;
using Microsoft.AspNetCore.Authorization;

namespace IdentityTest01
{
    [Authorize]
    public class DeleteModel : PageModel
    {
        private readonly IdentityTest01.Data.AppDbContext _context;

        public DeleteModel(IdentityTest01.Data.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Recipe Recipe { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Recipe = await _context.Recipes.FirstOrDefaultAsync(m => m.RecipeID == id);

            if (Recipe == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Recipe = await _context.Recipes.FindAsync(id);

            if (Recipe != null)
            {
                _context.Recipes.Remove(Recipe);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
