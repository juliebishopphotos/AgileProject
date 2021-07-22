using System;
using System.Collections.Generic;
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
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Minutes { get; set; }
        public DietType TypeOfDiet { get; set; }
        public Guid UserId { get; set; }
    }
}
