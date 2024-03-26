using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyGymWeb.Data.Configuration;
using RecipesShare.Data.Models;

namespace RecipesShare.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Recipe> Recipes { get; set; } = null!;



        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.ApplyConfiguration(new RecipeConfiguration());

            base.OnModelCreating(builder);
        }
    }
}
