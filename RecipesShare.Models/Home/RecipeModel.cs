﻿namespace RecipesShare.Models.Home
{
    public class RecipeModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;

        public string CookTime { get; set; } = null!;
    }
}