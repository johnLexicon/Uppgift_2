﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheatre
{
    class TicketOrderRepository
    {
        private List<TicketOrder> _ticketOrders = new List<TicketOrder>();

        internal List<TicketOrder> GetTicketOrders()
        {
            return _ticketOrders;
        }

        internal void AddOrder(TicketOrder order)
        {
            _ticketOrders.Add(order);
        }
    }
}
