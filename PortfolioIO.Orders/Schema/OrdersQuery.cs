﻿using System;
using System.Collections.Generic;
using System.Text;
using GraphQL.Types;
using PortfolioIO.Orders.Services;

namespace PortfolioIO.Orders.Schema
{
    public class OrdersQuery : ObjectGraphType<object>
    {
        public OrdersQuery(IOrderService orders)
        {
            Name = "Query";
            Field<ListGraphType<OrderType>>("orders", resolve: context => orders.GetOrderAsync());
        }
    }
}
