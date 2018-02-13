using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Module13.ViewModels
{
    public class MainPageViewModel
    {
        INavigationService _navigationService;
        public DelegateCommand PlayCommand { get; private set; }
        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            PlayCommand = new DelegateCommand(NextPageAsync);
        }

        private async  void   NextPageAsync()
        {
            await _navigationService.NavigateAsync("CameraPage");
        }
    }
}
