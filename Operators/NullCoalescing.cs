using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class NullCoalescing
    {
        public void NullCoalecingOperator()
        {
            int availableTickets=10;
            int? ticketsOnSale = 5;

            //Using null coalesce operator ??
            availableTickets = ticketsOnSale ?? 10;

            Console.WriteLine("Available Tickets={0}", availableTickets);
        }
    }
}
