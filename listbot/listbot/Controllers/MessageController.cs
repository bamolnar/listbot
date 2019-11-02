using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace listbot.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessageController : ControllerBase
    {

        public MessageController()
        {

        }

        [HttpGet]
        public string Get()
        {
            return ("Welcome to the api");
        }
    }
}
