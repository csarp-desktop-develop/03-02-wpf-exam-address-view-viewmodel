using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FontAwesome.Sharp;
using Kreta.Desktop.ViewModels.Base;
using Kreta.Desktop.ViewModels.ControlPanel;
using Kreta.Desktop.ViewModels.OtherData;
using Kreta.Desktop.ViewModels.SchoolCitizens;
using Kreta.Desktop.ViewModels.SchoolClasses;
using Kreta.Desktop.ViewModels.SchoolGrades;
using Kreta.Desktop.ViewModels.SchoolSubjects;
using Kreta.Desktop.Views.OtherData;

namespace Kreta.Desktop.ViewModels
{
    public partial class MainViewModel : BaseViewModel
    {
        private ControlPanelViewModel _controlPanelViewModel;
        private SchoolCitizensViewModel _schoolCitizensViewModel;
        private SchoolClassesViewModel _schoolClassesViewModel;
        private SchoolSubjectsViewModel _schoolSubjectsViewModel;
        private SchoolGradesViewModel _schoolOsztalyzatokViewModel;
        private OtherDataViewModel _otherDataViewModel;

        public MainViewModel()
        {
            _controlPanelViewModel = new ControlPanelViewModel();
            _schoolCitizensViewModel = new SchoolCitizensViewModel();
            _schoolClassesViewModel = new SchoolClassesViewModel();
            _schoolSubjectsViewModel = new SchoolSubjectsViewModel();
            _schoolOsztalyzatokViewModel = new SchoolGradesViewModel();
            _otherDataViewModel = new OtherDataViewModel();

            _currentChildView = new ControlPanelViewModel();
        }

        public MainViewModel(
            ControlPanelViewModel controlPanelViewModel,
            SchoolCitizensViewModel schoolCitizensViewModel,
            SchoolClassesViewModel schoolClassesViewModel,
            SchoolSubjectsViewModel schoolSubjectsViewModel,
            SchoolGradesViewModel schoolOsztalyzatokViewModel,
            OtherDataViewModel otherDataViewModel

            )
        {
            _controlPanelViewModel = controlPanelViewModel;
            _schoolCitizensViewModel = schoolCitizensViewModel;
            _schoolClassesViewModel = schoolClassesViewModel;
            _schoolSubjectsViewModel = schoolSubjectsViewModel;
            _schoolOsztalyzatokViewModel = schoolOsztalyzatokViewModel;
            _otherDataViewModel=otherDataViewModel;

            CurrentChildView = _controlPanelViewModel;
            ShowDashbord();
        }

        [ObservableProperty]
        private string _caption = string.Empty;

        [ObservableProperty]
        private IconChar _icon = new IconChar();

        [ObservableProperty]
        private BaseViewModel _currentChildView;

        [RelayCommand]
        public void ShowDashbord()
        {
            Caption = "Vezérlőpult";
            Icon=IconChar.SolarPanel;
            CurrentChildView = _controlPanelViewModel;
        }

        [RelayCommand]
        public void ShowSchoolCitizens()
        {
            Caption = "Iskolapolgárok";
            Icon = IconChar.UserGroup;
            CurrentChildView = _schoolCitizensViewModel;
        }

        [RelayCommand]
        public void ShowSchoolClasses()
        {
            Caption = "Osztályok";
            Icon = IconChar.ChalkboardUser;
            CurrentChildView = _schoolClassesViewModel;
        }
        [RelayCommand]
        public void ShowSchoolSubjects()
        {
            Caption = "Tantárgyak";
            Icon = IconChar.GraduationCap;
            CurrentChildView = _schoolSubjectsViewModel;
        }

        [RelayCommand]
        public void ShowOsztalyzatok()
        {
            Caption = "Osztályzatok";
            Icon = IconChar.GraduationCap;
            CurrentChildView = _schoolOsztalyzatokViewModel;
        }

        [RelayCommand]
        public void ShowOtherData()
        {
            Caption = "Egyéb információk";
            Icon = IconChar.Database;
            CurrentChildView = _otherDataViewModel;
        }
    }
}
