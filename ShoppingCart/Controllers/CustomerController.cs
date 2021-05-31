using MediatR;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Core.Commands.Customer;
using System.Threading.Tasks;

namespace ShoppingCart.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly IMediator _mediatr;
        public CustomerController(IMediator mediatr)
        {
            _mediatr = mediatr;
        }

        [HttpGet]
        public async Task<int> GetAsync()
        {
            return await _mediatr.Send(new CreateCustomerCommand());
        }
    }
}
