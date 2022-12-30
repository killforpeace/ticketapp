using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ticketapp
{
    public class TicketSales
    {
        private List<Ticket> tickets;

        public TicketSales()
        {
            tickets = new List<Ticket>();
        }

        public void AddTicket(Ticket ticket)
        {
            tickets.Add(ticket);
        }

        public void PrintInventory()
        {
            foreach (Ticket ticket in tickets)
            {
                Console.WriteLine(ticket.GetDescription() + " - $" + ticket.GetPrice());
            }
        }
    }
}