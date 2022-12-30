using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ticketapp
{
    public abstract class TicketType : Ticket
    {
        protected string ticketType;
        public abstract string GetDescription();
        public abstract decimal GetPrice();
    }
}