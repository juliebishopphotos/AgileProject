using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.Date
{
    public enum DietType
    {
        Vegan,
        Vegetarian,
        Pescatarian, 
        Gluten_Free,
        Nut_Free
    }
    public class Recipe
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int Minutes { get; set; }
        [Required]
        public DietType TypeOfDiet { get; set; }
        [Required]
        public Guid UserId { get; set; }
    }
}
