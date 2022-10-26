using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD350_W22SD_Lab2
{
    public abstract class BadgeDecorator : Client
    {
        public Client Client { get; set; }

        public abstract string GetBadges();
    }
}
