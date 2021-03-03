using System;
using System.Collections.Generic;

namespace Task_1
{
    public class SMSMessage
    {
        public void SendSMSMessage(List<Contact> contacts)
        {
            foreach (var contact in contacts)
            {
                Console.WriteLine($"Sending SMS to:{contact.Mobile}");
            }
        }
    }
}