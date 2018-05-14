using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SpotzerOrderApi.Context;
using SpotzerOrderApi.ExceptionHandling;
using SpotzerOrderApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SpotzerOrderApi.Controllers
{/// <summary>
 /// HTTP Verb: Post
 /// </summary>
 /// 

    [CustomExceptionFilter]
    public class OrderProductController : ApiController
    {
        /// <summary>
        /// Recieve the orders from different partners
        /// </summary>
        /// <param name="dynamicOrder"></param>
        /// <returns></returns>
        /// 
        // modify the type of the db field
        private IOrderContext db = new OrderContext();
        // add these contructors
        public OrderProductController() { }

        public OrderProductController(IOrderContext context)
        {
            db = context;
        }

        [HttpPost]
        public IHttpActionResult Post([FromBody]Order dynamicOrder)
        {
            try
            {
                //Check model is valid or not
                if (ModelState.IsValid)
                {
                    //Add the input value into the context
                    db.Orders.Add(dynamicOrder);

                    //Save the changes in the database
                    db.SaveChanges();

                    //Return message- when data saved successfully in database
                    return Ok("Sold the products succesfully");
                }
                //Return message- One or more fields are invalid
                return BadRequest("Please provided data in the correct format");
            }
            catch (Exception ex)
            {
                return BadRequest("Please provided data in the correct format");
            }
        }
    }
}

