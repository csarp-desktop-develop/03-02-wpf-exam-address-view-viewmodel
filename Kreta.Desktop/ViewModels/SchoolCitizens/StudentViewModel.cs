using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Kreta.Desktop.ViewModels.Base;
using Kreta.Shared.Models.SchoolCitizens;
using System.Collections.ObjectModel;

namespace Kreta.Desktop.ViewModels.SchoolCitizens
{
    public partial class StudentViewModel : BaseViewModel
    {
        [ObservableProperty]
        private ObservableCollection<string> _educationLevels = new();

        [ObservableProperty]
        private ObservableCollection<Student> _students = new();

        [ObservableProperty]
        private Student _selectedStudent;

        private string _selectedEducationLevel = string.Empty;
        public string SelectedEducationLevel
        {
            get => _selectedEducationLevel;
            set
            {
                SetProperty(ref _selectedEducationLevel, value);
                SelectedStudent.EducationLevel = _selectedEducationLevel;
            }
        }

        public StudentViewModel()
        {
            //Students.Add(new Student("Elek", "Teszt", System.DateTime.Now, 9, SchoolClassType.ClassA, ""));
            SelectedStudent = new Student();
            SelectedEducationLevel = string.Empty;
        }

        [RelayCommand]
        public void DoSave(Student newStudent)
        {
            Students.Add(newStudent);
            OnPropertyChanged(nameof(Students));
        }

        [RelayCommand]
        void DoNewStudent()
        {
            SelectedStudent = new Student();
        }

        [RelayCommand]
        public void DoRemove(Student studentToDelete)
        {
            Students.Remove(studentToDelete);
            OnPropertyChanged(nameof(Students));
        }
    }
}
