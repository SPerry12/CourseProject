using System;

namespace CookBookPlus.Model
{
    public class Users
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string EmailAddress { get; set; }
        public string Country { get; set; }

    }

    public class UserRatingInfo
    {
        public int UserRatingId { get; set; }
        public int UserId { get; set; }
        public int UserRanking { get; set; }
        public string UserComments { get; set; }
    }

    public class Recipes
    {
        public int RecipeId { get; set; }
        public int UserId { get; set; }
        public string RecipeName { get; set; }
        public string RecipeDirections { get; set; }
        public int Protein { get; set; }
        public int Carbs { get; set; }
        public int Fats { get; set; }
    }

    public class RecipeRatingInfo
    {
        public int RecipeRatingId { get; set; }
        public int RecipeId { get; set; }
        public int RecipeRating { get; set; }
        public string RecipeComments { get; set; }
    }

    public class Category
    {
        public int CategoryId { get; set; }
        public int RecipeId { get; set; }
        public string RecipeTags { get; set; }
        public string TagDescription { get; set; }
    }
}
