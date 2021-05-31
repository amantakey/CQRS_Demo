using MediatR;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Core.Models;
using ShoppingCart.Core.Queries.Order;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShoppingCart.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IMediator _mediatr;
        public OrderController(IMediator mediatr)
        {
            _mediatr = mediatr;
        }

        [HttpGet]
        public async Task<List<Order>> GetAsync()
        {
            return await _mediatr.Send(new GetAllOrdersQuery());
        }
    }
}
