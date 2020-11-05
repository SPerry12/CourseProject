using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace CookBookPlus6000.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        [Required]
        [DisplayName("Recipe Name")]
        public string RecipeName { get; set; }
      
        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Image Name")]
        public string ImageName { get; set; }

        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile ImageFile { get; set; }

        [Required]
        [DisplayName("Recipe Directions")]
        public string RecipeDirections { get; set; }
       
        [Required]
        public Category Category { get; set; }
        public int Protein { get; set; }
        public int Carbs { get; set; }
        public int Fat { get; set; }
    }
}
