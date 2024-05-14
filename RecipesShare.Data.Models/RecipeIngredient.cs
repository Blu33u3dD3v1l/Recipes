﻿using System.ComponentModel.DataAnnotations;

namespace RecipesShare.Data.Models
{
    public class RecipeIngredient
    {

       
        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; } = null!;

        
        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; } = null!;
    }
}
