using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    public class Button
    {
        public delegate void SendMessage(List<Contact> contacts);

        public event SendMessage Clicked;

        public void Click(List<Contact> contacts)
        {
            Clicked(contacts);
        }
    }
}
