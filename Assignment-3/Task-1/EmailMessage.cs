using System;
using System.Collections.Generic;

namespace Task_1
{
    public class EmailMessage
    {
        public void SendEmailMessage(List<Contact> contacts)
        {
            foreach (var contact in contacts)
            {
                Console.WriteLine($"Sending Email to:{contact.Email}");
            }
        }
    }
}