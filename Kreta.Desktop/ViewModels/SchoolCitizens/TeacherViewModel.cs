using CommunityToolkit.Mvvm.ComponentModel;
using Kreta.Desktop.ViewModels.Base;

namespace Kreta.Desktop.ViewModels.SchoolCitizens
{
    public partial class TeacherViewModel : BaseViewModel
    {
        [ObservableProperty]
        private string _title="Tanárok kezelése";
    }
}
