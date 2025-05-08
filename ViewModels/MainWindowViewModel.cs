using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace FocusBugRepro.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        [ObservableProperty] private bool _isOpen;

        [RelayCommand]
        public void Open() => IsOpen = true;

        [RelayCommand]
        public void Close() => IsOpen = false;
    }
}
