using System.ComponentModel.DataAnnotations;

namespace CookBookPlus.Models
{
    public class Category
    {
        [Key]
        public int CateogryID { get; set; }
        public int RecipeID { get; set; }
        public string RecipeTags { get; set; }
        public string TagDescription { get; set; }
    }
}
