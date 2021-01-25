using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1_Facebook_
{
    class User
    {
        protected int id { get; set; }
        protected string Name { get; set; }
        protected string Email { get; set; }
        protected string Password { get; set; }

        public virtual void GetDetails()
        {}
        public virtual void DispalyDetails()
        {}
    }
}
