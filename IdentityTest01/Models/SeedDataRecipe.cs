using IdentityTest01.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityTest01.Models
{
    public static class SeedDataRecipe
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            //var context = serviceProvider.GetService<AppDbContext>();
            AppDbContext context = app.ApplicationServices.GetRequiredService<AppDbContext>();
            context.Database.Migrate();
            if (!context.Recipes.Any())
            {
                context.Recipes.AddRange(
                    new Recipe
                    {
                        RecipeName = "BBQ",
                        Category = "Meat"
                    },
                    new Recipe
                    {
                        RecipeName = "Sushi",
                        Category = "Meat"
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
