using GroceryStore.Date;
using GroceryStore.Models;
using GroceryStoreApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryStore.Services
{
    public class IngredientServices
    {
        public bool CreateIngredient(IngredientCreate model)
        {
            var entity =
                new Ingredient()
                {
                    IngredientName = model.IngredientName,
                    RecipeId = model.RecipeId
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Ingredients.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
    }
}
