﻿using System.ComponentModel.DataAnnotations;


namespace RecipesShare.Models.Home
{
    public class EditUserFormModel
    {
        [Key]
        public string Id { get; set; } = null!;
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? ImageUrl { get; set; }
        public string? Location { get; set; }
        public string? AboutMe { get; set; }
        public string? Country { get; set; }
        public string? Sex { get; set; }
    }
}
