using System;
using System.Net;
using EMAStudySMSWebAPI.Models.Scheduler;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace EMAStudySMSWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TwilioTriggerController : ControllerBase
    {
        // POST api/TwiioTrigger/some-json-package-i-guess
        [HttpPost]
        public void Post(string value)
        {
            //break here to inspect message from qualtrics.
            TriggerPackage triggerPackage = new TriggerPackage();
            triggerPackage.ExternalDataReference = "Not Implemented";
            triggerPackage.UserResponse = QuestionResponse.SomethingGood;

            //then send triggerPackage to Scheduler.
            //the probabilities are .3 for SomethingGood or SomethingBad
            //the probability is    .1 for NothingHappened
        }
    }
}