using Kreta.Shared.Models;
using Kreta.Shared.Responses;


namespace Kreta.HttpService.Service
{
    public interface IAddressService
    {
        public Task<List<Address>> SelectAllAddressAsync();
        public Task<ControllerResponse> UpdateAsync(Address address);
        public Task<ControllerResponse> DeleteAsync(Guid id);
        public Task<ControllerResponse> InsertAsync(Address address);
    }
}
