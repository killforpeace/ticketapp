using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ticketapp
{
    public class Customer
    {
        private string name;
        private List<Ticket> purchasedTickets;

        public Customer(string name)
        {
            this.name = name;
            purchasedTickets = new List<Ticket>();
        }

        public string GetName()
        {
            return name;
        }

        public void PurchaseTicket(Ticket ticket)
        {
            purchasedTickets.Add(ticket);
        }

        public void PrintPurchasedTickets()
        {
            Console.WriteLine("Tickets purchased by " + name + ":");
            foreach (Ticket ticket in purchasedTickets)
            {
                Console.WriteLine(ticket.GetDescription() + " - $" + ticket.GetPrice());
            }
        }
    }
}