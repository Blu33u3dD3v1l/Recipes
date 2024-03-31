using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecipesShare.Data.Models;



namespace MyGymWeb.Data.Configuration
{

    internal class RecipeConfiguration : IEntityTypeConfiguration<Recipe>
    {
        public void Configure(EntityTypeBuilder<Recipe> builder)
        {
            builder
           .HasData(CreateProduct());
        }

        private List<Recipe> CreateProduct()
        {
            var recipe = new List<Recipe>()
          {
            new Recipe()
            {
                Id = 1,
                Name = "Peppers(meat and rice)",
                ImageUrl = "https://www.simplyrecipes.com/thmb/RX2jA-_cA83GnwMwtoH_MWZ45Fs=/300x200/filters:no_upscale():max_bytes(150000):strip_icc():format(webp)/Simply-Recipes-Pizza-Stuffed-Peppers-LEAD-4-86dfd730b28b4c42a113066eb54a3fdf.jpg",
                Description = "Pizza is high on my list of favorite foods, and the classic pairing of pepperoni and melty cheese is my go-to. I turn to these pizza stuffed peppers to incorporate those flavors into an easy weeknight dinner. These tender boats of bell pepper piled high with ground beef, rice, and onion are dressed up even further with pepperoni and cheese.",
                CookTime = 20,
                Author = "Admin"
                
            },
            new Recipe()
            {
                Id = 2,
                Name = "Teriyaki Chicken Noodle Soup",
                ImageUrl = "https://www.simplyrecipes.com/thmb/fVqUVoCgdL4lmutoomUjSyPXbW0=/450x300/filters:no_upscale():max_bytes(150000):strip_icc():format(webp)/Simply-Recipes-Teriyaki-Chicken-Noodle-Soup-LEAD-34c125bb3b224834b5cf30249cf1031f.jpg",
                Description = "This recipe for teriyaki chicken noodle soup is an easy, intuitive way to liven up a classic chicken noodle soup. Marinate and sear juicy chicken thighs, then reuse that flavorful teriyaki-style sauce to build up a rich, hearty broth. I love all the textures in this soup: wide udon noodles and crisp-tender bok choy beautifully balance the rich teriyaki flavors.",
                CookTime = 25,
                Author = "Admin",

            },

            new Recipe()
            {
                Id = 3,
                Name = "Challah French Toast",
                ImageUrl = "https://www.simplyrecipes.com/thmb/7gy-motpgtBFgATUrVcU4mPyX0M=/450x300/filters:no_upscale():max_bytes(150000):strip_icc():format(webp)/Simply-Recipes-Challah-French-Toast-LEAD-11-93f90c8d48324cc28a583180f9d8f32d.jpg",
                Description = "Whether you’ve got some leftover challah from Shabbat dinner or you’re buying a loaf specifically to make French toast, it’s the most wonderful (and easy!) Saturday morning breakfast out there. \r\n\r\nChallah is the best bread for French toast, bar none. It’s sturdy enough to stand up to its custard soak and a shower of maple syrup, yet tender and fluffy enough to cut.",
                CookTime = 20,
                Author = "Admin",


            },

            };
            return recipe;
       }
                       
    }
}
