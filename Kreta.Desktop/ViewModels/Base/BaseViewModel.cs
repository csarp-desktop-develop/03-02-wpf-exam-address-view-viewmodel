using CommunityToolkit.Mvvm.ComponentModel;
using System.Threading.Tasks;

namespace Kreta.Desktop.ViewModels.Base
{
    public  abstract class BaseViewModel : ObservableObject
    {
        public async virtual Task  InitializeAsync()
        {
            await Task.CompletedTask;
        }
    }
}
