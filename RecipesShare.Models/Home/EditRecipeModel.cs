﻿using RecipesShare.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace RecipesShare.Models.Home
{
    public class EditRecipeModel
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        [MaxLength(364)]
        public string Description { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;

        public int CookTime { get; set; }
        public string? Author { get; set; }
        public string? UserId { get; set; }

        public ApplicationUser? User { get; set; }

        public IQueryable<Ingredient>? Ingredients { get; set; }
        public string? Instructions { get; set; }
    }
}
