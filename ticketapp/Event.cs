using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace ticketapp
{
    public class Event : TicketType
    {
        private string eventName;
        private decimal price;

        public Event(string eventName, decimal price)
        {
            this.eventName = eventName;
            this.price = price;
            ticketType = "Event";
        }

        public override string GetDescription()
        {
            return ticketType + ": " + eventName;
        }

        public override decimal GetPrice()
        {
            return price;
        }
    }
}