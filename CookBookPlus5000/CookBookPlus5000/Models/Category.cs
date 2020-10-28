using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CookBookPlus5000.Models
{
    public enum Category
    {
        Breakfast,
        Lunch,
        [Display(Name = "Main dishes: Beef")]
        Beef,
        [Display(Name = "Main dishes: Poultry")]
        Poultry,
        [Display(Name = "Main dishes: Pork")]
        Pork,
        [Display(Name = "Main dishes: Seafood")]
        Seafood,
        [Display(Name = "Main dishes: Vegetarian")]
        Vegetarian,
        [Display(Name = "Side dishes: Vegetables")]
        Vegetables,
        [Display(Name = "Side dishes: Other")]
        Other,
        Beverages,
        Appetizers,
        Soups,
        Salads,
        Desserts,
        Breads,
        Holidays,
        Entertaining
    }
}
