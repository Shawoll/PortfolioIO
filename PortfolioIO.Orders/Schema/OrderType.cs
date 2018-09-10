﻿using GraphQL.Types;
using PortfolioIO.Orders.Models;
using PortfolioIO.Orders.Services;

namespace PortfolioIO.Orders.Schema
{
    public class OrderType : ObjectGraphType<Order>
    {
        public OrderType(ICustomerService customers)
        {
            Field(o => o.Id);
            Field(o => o.Name);
            Field(o => o.Description);
            Field<CustomerType>("customer", resolve: context => customers.GetCustomerByIdAsync(context.Source.CustomerId));
            Field(o => o.Created);
        }
    }
}
