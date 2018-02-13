using Module13.Models;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Module13.ViewModels
{
    public class SpeakPageViewModel : BindableBase, INavigatedAware
    {
        INavigationService _navigationService;


        private string photoImage;
        public string PhotoImage
        {


            get { return photoImage; }
            set
            {
                SetProperty(ref photoImage, value);
                

            }
        }
        private string _word;
        public string word
        {


            get { return _word; }
            set
            {
                SetProperty(ref _word, value);        

            }
        }
        public SpeakPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            var element = parameters["ImageParam"];
            var path = parameters["ImagePath"];
            ImageResult res = (ImageResult)element;
            PhotoImage = path.ToString();
            word = res.Description.Tags[0];

        }
    }
}
