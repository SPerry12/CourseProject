using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CookBookPlus.Models
{
    public class Recipes
    {
        [Key]
        public int RecipeID { get; set; }
        public int UserID { get; set; }
        public string RecipeName { get; set; }
        public string RecipeDirections { get; set; }
        public int Protein { get; set; }
        public int Carbs { get; set; }
        public int Fat { get; set; }
        public string UserComments { get; set; }
    }
}
