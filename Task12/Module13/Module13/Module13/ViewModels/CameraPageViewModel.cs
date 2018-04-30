using Plugin.Media.Abstractions;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Module13.ViewModels
{
    public class CameraPageViewModel : BindableBase
    {
        private readonly IVisionAPI _visionAPI;
        INavigationService _navigationService;
        public DelegateCommand CameraCommand { get; private set; }
        public CameraPageViewModel(INavigationService navigationService, IVisionAPI visionAPI)
        {
            ButtonVisibility = true;
            TextVisibility = true;
            AnimationVisibility = false;
            _visionAPI = visionAPI;
            _navigationService = navigationService;
            CameraCommand = new DelegateCommand(NextPageAsync);
        }
        private bool _AnimationVisibility;
        public bool AnimationVisibility
        {
            get
            {
                return _AnimationVisibility;
            }
            set
            {
                SetProperty(ref _AnimationVisibility, value);
            }
        }
        private bool _ButtonVisibility;
        public bool ButtonVisibility
        {
            get
            {
                return _ButtonVisibility;
            }
            set
            {
                SetProperty(ref _ButtonVisibility, value);
            }
        }
        private bool _TextVisibility;
        public bool TextVisibility
        {
            get
            {
                return _TextVisibility;
            }
            set
            {
                SetProperty(ref _TextVisibility, value);
            }
        }

        private async void NextPageAsync()
        {
            
            var photo = await Plugin.Media.CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions() { PhotoSize = PhotoSize.Custom, CustomPhotoSize=45, CompressionQuality = 60 });
           
            ButtonVisibility = false;
            TextVisibility = false;
            AnimationVisibility = true;
            Models.ImageResult res = await _visionAPI.MakeAnalysisRequest(photo.Path);
            AnimationVisibility = false;
            var parameter = new NavigationParameters();
            parameter.Add("ImageParam",res);
            parameter.Add("ImagePath", photo.Path);

            //foreach (char i in word)
            //{
            //    string str = i.ToString();
            //    Services.AudioRecService.PlayAudio(str);
            //}
            //Services.AudioRecService.PlayAudio(word);
            await _navigationService.NavigateAsync(new Uri("SpeakPage",UriKind.Relative),parameter);
            ButtonVisibility = true;
        }
    }
}
