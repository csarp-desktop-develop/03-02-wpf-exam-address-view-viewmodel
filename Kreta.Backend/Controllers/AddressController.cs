using Kreta.Backend.Controllers.Assamblers;
using Kreta.Backend.Repos;
using Kreta.Shared.Dtos;
using Kreta.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace Kreta.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AddressController : BaseController<Address, AddressDto>
    {
        public AddressController(AddressAssambler assembler, IAddressRepo repo) : base(assembler, repo)
        {
        }
    }
}
