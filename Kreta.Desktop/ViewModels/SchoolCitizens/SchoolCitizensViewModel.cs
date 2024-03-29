﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Kreta.Desktop.ViewModels.Base;

namespace Kreta.Desktop.ViewModels.SchoolCitizens
{
    public partial class SchoolCitizensViewModel : BaseViewModel
    {
        private StudentViewModel _studentViewModel;
        private ParentViewModel _parentViewModel;
        private TeacherViewModel _teacherViewModel;

        public SchoolCitizensViewModel()
        {
            _currentSchoolCitizensChildView = new StudentViewModel();
            _studentViewModel = new StudentViewModel();
            _parentViewModel = new ParentViewModel();
            _teacherViewModel = new TeacherViewModel();
        }

        public SchoolCitizensViewModel(StudentViewModel studentViewModel, ParentViewModel parentViewModel, TeacherViewModel teacherViewModel)
        {
            _studentViewModel = studentViewModel;
            _parentViewModel = parentViewModel;
            _teacherViewModel = teacherViewModel;

            CurrentSchoolCitizensChildView = _teacherViewModel;
        }

        [ObservableProperty]
        private BaseViewModel _currentSchoolCitizensChildView;

        [RelayCommand]
        public void ShowStudentView()
        {
            CurrentSchoolCitizensChildView = _studentViewModel;
        }

        [RelayCommand]
        public void ShowTeacherView()
        {
            CurrentSchoolCitizensChildView = _teacherViewModel;
        }

        [RelayCommand]
        public void ShowParentView()
        {
            CurrentSchoolCitizensChildView = _parentViewModel;
        }
    }
}
