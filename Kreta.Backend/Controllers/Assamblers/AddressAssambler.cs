using Kreta.Shared.Dtos;
using Kreta.Shared.Extensions;
using Kreta.Shared.Models;

namespace Kreta.Backend.Controllers.Assamblers
{
    public class AddressAssambler : Assambler<Address, AddressDto>
    {
        public override AddressDto ToDto(Address domainEntity)
        {
            return domainEntity.ToDto();
        }

        public override Address ToModel(AddressDto dto)
        {
            return dto.ToModel();
        }
    }
}
