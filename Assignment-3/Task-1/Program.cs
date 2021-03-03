using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Task_1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var contacts = new List<Contact>()
            {
                new Contact{Email = "shakilvictor@gmail.com",Mobile = "01515263089"},
                new Contact{Email = "robiul35-1663@diu.edu.bd",Mobile = "01521334084"},
                new Contact{Email = "tysonmashuq@gmail.com",Mobile = "01521334086"},
            };

            Button button = new Button();

            button.Clicked+=new Button.SendMessage(new EmailMessage().SendEmailMessage);
            button.Clicked += new Button.SendMessage(new SMSMessage().SendSMSMessage);
            button.Click(contacts);
        }
        
    }
}
