using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD350_W22SD_Lab2
{
    public abstract class Client
    {
        public string Username { get; set; }
        public string Email { get; set; }

        public string Description = "No Description";
        public string Password { get; set; }

        public virtual void GetDescription()
        {
            return Description;
        }
    }
}
