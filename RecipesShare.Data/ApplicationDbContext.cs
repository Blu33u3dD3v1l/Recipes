using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyGymWeb.Data.Configuration;
using RecipesShare.Data.Models;
using System.Reflection.Emit;

namespace RecipesShare.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Recipe> Recipes { get; set; } = null!;
        public DbSet<Ingredient> Ingredients { get; set; } = null!;
        public DbSet<ApplicationUser> ApplicationUser { get; set; } = null!;
        public DbSet<RecipeIngredient> RecipeIngredients { get; set; }
        public DbSet<UserRecipe> UserRecipes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<RecipeIngredient>()
                .HasKey(ri => new { ri.RecipeId, ri.IngredientId });

            builder.Entity<UserRecipe>()
                .HasKey(x => new { x.UserId, x.RecipeId });

            builder.Entity<UserRecipe>()
                .HasOne(ur => ur.User)
                .WithMany(u => u.UserRecipes)
                .HasForeignKey(ur => ur.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            
            builder.ApplyConfiguration(new RecipeConfiguration());

            base.OnModelCreating(builder);
        }
    }
}
