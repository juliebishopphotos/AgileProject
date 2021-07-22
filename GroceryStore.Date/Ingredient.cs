using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.Date
{
    public class Ingredient
    {
        [Key]
        public int IngredientId { get; set; }

        [Required]
        public string IngredientName { get; set; }

        [Required]
        [ForeignKey(nameof(Recipe))]
        public int RecipeId { get; set; }
        public virtual Recipe Recipe { get; set; }
    }
}
