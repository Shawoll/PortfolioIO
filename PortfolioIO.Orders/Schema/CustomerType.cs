using GraphQL.Types;
using PortfolioIO.Orders.Models;

namespace PortfolioIO.Orders.Schema
{
    public class CustomerType : ObjectGraphType<Customer>
    {
        public CustomerType()
        {
            Field(c => c.Id);
            Field(c => c.Name);
        }
    }
}
