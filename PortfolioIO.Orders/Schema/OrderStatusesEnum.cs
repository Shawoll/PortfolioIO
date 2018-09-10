using System;
using System.Collections.Generic;
using System.Text;
using GraphQL.Types;

namespace PortfolioIO.Orders.Schema
{
    public class OrderStatusesEnum : EnumerationGraphType
    {
        public OrderStatusesEnum()
        {
            Name = "Order Values";
            AddValue("CREATED", "Order was created", 2);
            AddValue("PROCESSING", "Order is beeing processed", 4);
            AddValue("COMPLETED", "Order is completed", 8);
            AddValue("CANCELED", "Order is canceled", 16);
            AddValue("CLOSED", "Order is closed", 32);
        }
    }
}
