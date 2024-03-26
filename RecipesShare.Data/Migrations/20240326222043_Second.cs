using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecipesShare.Data.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Pizza is high on my list of favorite foods, and the classic pairing of pepperoni and melty cheese is my go-to. I turn to these pizza stuffed peppers to incorporate those flavors into an easy weeknight dinner. These tender boats of bell pepper piled high with ground beef, rice, and onion are dressed up even further with pepperoni and cheese.", "Peppers(meat and rice)" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Whether you’ve got some leftover challah from Shabbat dinner or you’re buying a loaf specifically to make French toast, it’s the most wonderful (and easy!) Saturday morning breakfast out there. \r\n\r\nChallah is the best bread for French toast, bar none. It’s sturdy enough to stand up to its custard soak and a shower of maple syrup, yet tender and fluffy enough to cut.", "https://www.simplyrecipes.com/thmb/7gy-motpgtBFgATUrVcU4mPyX0M=/450x300/filters:no_upscale():max_bytes(150000):strip_icc():format(webp)/Simply-Recipes-Challah-French-Toast-LEAD-11-93f90c8d48324cc28a583180f9d8f32d.jpg" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Name" },
                values: new object[] { "Pizza is high on my list of favorite foods, and the classic pairing of pepperoni and melty cheese is my go-to. I turn to these pizza stuffed peppers to incorporate those flavors into an easy weeknight dinner. These tender boats of bell pepper piled high with ground beef, rice, and onion are dressed up even further with pepperoni and cheese. They’re bursting with flavor and can be customized in various ways to match your go-to pizza order.\r\n\r\nTo make them even more weeknight-friendly, you don’t need to cook the peppers before stuffing. Plus, you can assemble the peppers up to 24 hours ahead of time and stash them in the fridge before baking.", "Peppers stuffed with minced meat and rice" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Whether you’ve got some leftover challah from Shabbat dinner or you’re buying a loaf specifically to make French toast, it’s the most wonderful (and easy!) Saturday morning breakfast out there. \r\n\r\nChallah is the best bread for French toast, bar none. It’s sturdy enough to stand up to its custard soak and a shower of maple syrup, yet tender and fluffy enough to cut with a fork. Cooked in a generous amount of butter, the thick slices of challah become beautifully browned after just a few minutes in the skillet. ", "https://www.simplyrecipes.com/thmb/RX2jA-_cA83GnwMwtoH_MWZ45Fs=/300x200/filters:no_upscale():max_bytes(150000):strip_icc():format(webp)/Simply-Recipes-Pizza-Stuffed-Peppers-LEAD-4-86dfd730b28b4c42a113066eb54a3fdf.jpg" });
        }
    }
}
