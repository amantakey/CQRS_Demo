using MediatR;
using ShoppingCart.Core.Models;
using System;
using System.Collections.Generic;
using Models = ShoppingCart.Core.Models;


namespace ShoppingCart.Core.Queries.Order
{
    public class GetAllOrdersQuery : IRequest<List<Models.Order>>
    {
    }
}
