using System;
namespace EMAStudySMSWebAPI.Models.Scheduler
{
    public class SMS
    {
        public string recipientPhoneNumber { get; set; }
        public string senderPhoneNumber { get; set; }
        public string body { get; set; }
    }
}