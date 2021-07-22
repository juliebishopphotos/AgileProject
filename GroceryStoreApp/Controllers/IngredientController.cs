using GroceryStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GroceryStoreApp.Controllers
{
    public class IngredientController : ApiController
    {
        public IHttpActionResult Post(IngredientCreate ingriedient)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var create = CreateIngredient(ingriedient);

            if (!create)
                return InternalServerError();

            return Ok();
        }
    }
}
