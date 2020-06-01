using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Twilio;
using Twilio.Rest.Api.V2010.Account;



namespace EMAStudySMSWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TwilioIntermediaryController : ControllerBase
    {
        // GET: api/TwilioIntermediary
        //Should return some basic stats; are there queued items, failed sends, etc....
        [HttpGet]
        public string Get()
        {
            string status = "Not implemented.";
            return status;
        }

        // POST: api/TwilioIntermediary/SMS_Object
        //This should get a specific type of object as described in 
        [HttpPost]
        public string Post()
        {
            string status = "Not implemented.";
            return status;
        }
    }
}
