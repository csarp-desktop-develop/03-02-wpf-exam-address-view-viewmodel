using CommunityToolkit.Mvvm.ComponentModel;
using Kreta.Desktop.ViewModels.Base;
using Kreta.HttpService.Service;
using Kreta.Shared.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Kreta.Desktop.ViewModels.OtherData
{
    public partial class AddressViewModel : BaseViewModel
    {
        private readonly IAddressService _addressService;

        [ObservableProperty]
        public ObservableCollection<Address> _addresses;
        public AddressViewModel()
        {
            _addressService = new AddressService();
            _addresses = new ObservableCollection<Address>();
        }

        public AddressViewModel(IAddressService addressService)
        {
            _addressService = addressService;            
        }

        public async override Task InitializeAsync()
        {
            if (_addressService is not null)
            {
                List<Address> fromBackend= await _addressService.SelectAllAddressAsync();
                Addresses = new ObservableCollection<Address>(fromBackend);
            }
            await base.InitializeAsync();
        }
    }
}
