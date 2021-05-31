using MediatR;
using ShoppingCart.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Core.Queries.Customer
{
    public class GetAllCustomersQuery : IRequest<List<Models.Customer>>
    {
    }
}
