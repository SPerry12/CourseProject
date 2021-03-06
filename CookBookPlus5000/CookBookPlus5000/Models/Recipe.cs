﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace CookBookPlus5000.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        [DisplayName("Recipe Name")]
        public string RecipeName{ get; set; }

        [DisplayName("Recipe Directions")]
        public string RecipeDirections { get; set; }
        
        public Category Category { get; set; } 
        public int Protein { get; set; }
        public int Carbs { get; set; }
        public int Fat { get; set; }
    }
}
