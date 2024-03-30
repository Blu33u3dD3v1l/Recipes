using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecipesShare.Data.Migrations
{
    /// <inheritdoc />
    public partial class recipemig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingredients_Recipes_RedipeId",
                table: "Ingredients");

            migrationBuilder.RenameColumn(
                name: "RedipeId",
                table: "Ingredients",
                newName: "RecipeId");

            migrationBuilder.RenameIndex(
                name: "IX_Ingredients_RedipeId",
                table: "Ingredients",
                newName: "IX_Ingredients_RecipeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredients_Recipes_RecipeId",
                table: "Ingredients",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingredients_Recipes_RecipeId",
                table: "Ingredients");

            migrationBuilder.RenameColumn(
                name: "RecipeId",
                table: "Ingredients",
                newName: "RedipeId");

            migrationBuilder.RenameIndex(
                name: "IX_Ingredients_RecipeId",
                table: "Ingredients",
                newName: "IX_Ingredients_RedipeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredients_Recipes_RedipeId",
                table: "Ingredients",
                column: "RedipeId",
                principalTable: "Recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
