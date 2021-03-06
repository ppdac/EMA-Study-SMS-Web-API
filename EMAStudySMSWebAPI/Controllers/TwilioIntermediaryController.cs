﻿using System;
using System.Net;
using EMAStudySMSWebAPI.Models.Configuration;
using EMAStudySMSWebAPI.Models.Scheduler;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Twilio;
using Twilio.Rest.Api.V2010.Account;



namespace EMAStudySMSWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TwilioIntermediaryController : ControllerBase
    {
        private readonly TwilioCredentials _twilioCredentials;

        public TwilioIntermediaryController(IOptions<TwilioCredentials> twilioCredentials)
        {
            if (twilioCredentials != null)
                _twilioCredentials = twilioCredentials.Value;
            else
                throw new ArgumentException(nameof(twilioCredentials));
        }

        // POST: api/TwilioIntermediary/SMS_Object
        //This should get a specific type of object as described in AB#10
        //Implemented in /Models/Schedule/SMS.cs
        [HttpPost]
        public HttpStatusCode Post(SMS sms)
        {
            TwilioClient.Init(_twilioCredentials.AccountSID, _twilioCredentials.AuthToken);
            var options = new CreateMessageOptions(new Twilio.Types.PhoneNumber(sms.recipientPhoneNumber));
            options.From = sms.senderPhoneNumber;
            options.Body = sms.body;
            var message = MessageResource.Create(options);
            var statusCode = TwilioClient.GetRestClient().HttpClient.LastResponse.StatusCode;

            return statusCode;
        }

        // GET: api/TwilioIntermediary
        //Should return some basic stats; are there queued items, failed sends, etc....
        [HttpGet]
        public string Get()
        {
            string status = "Not implemented.";
            return status;
        }
    }
}
