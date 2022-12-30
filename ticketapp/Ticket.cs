using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ticketapp
{
    public interface Ticket
    {
        string GetDescription();
        decimal GetPrice();
    }
}