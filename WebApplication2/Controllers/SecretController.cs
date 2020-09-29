using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebApplication2.Models;


namespace WebApplication2.Controllers
{
    [Route("api/v1/secret")]
    [ApiController]
    public class SecretController : ControllerBase
    {
        [HttpGet]
        public Secret Get()
        {
            Secret _secret = new Secret();
            _secret.secret = "Dessa tider...";
           
            return _secret;
        }

       
    }
}
