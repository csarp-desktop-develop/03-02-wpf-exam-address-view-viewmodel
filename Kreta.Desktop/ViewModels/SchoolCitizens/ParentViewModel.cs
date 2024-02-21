using CommunityToolkit.Mvvm.ComponentModel;
using Kreta.Desktop.ViewModels.Base;


namespace Kreta.Desktop.ViewModels.SchoolCitizens
{
    public partial class ParentViewModel : BaseViewModel
    {
        [ObservableProperty]
        private string _title = "Szülői adatok";

    }
}
