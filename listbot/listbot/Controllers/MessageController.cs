using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using listbot.Models;

namespace listbot.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessageController : ControllerBase
    {

        public MessageController()
        {

        }

        // route: /message
        [HttpGet]
        public string Get()
        {
            return ("Welcome to the api");
        }

        [HttpPost]
        [Route("[route]")]
        public string PostMessage([FromBody] Recipe recipe)
        {
            return (recipe.mainIngredient);
        }
    }
}
