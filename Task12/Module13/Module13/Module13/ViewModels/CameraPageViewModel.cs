using Plugin.Media.Abstractions;
using Prism.Commands;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Module13.ViewModels
{
    public class CameraPageViewModel
    {
        private readonly IVisionAPI _visionAPI;
        INavigationService _navigationService;
        public DelegateCommand CameraCommand { get; private set; }
        public CameraPageViewModel(INavigationService navigationService, IVisionAPI visionAPI)
        {
            _visionAPI = visionAPI;
            _navigationService = navigationService;
            CameraCommand = new DelegateCommand(NextPageAsync);
        }

        private async void NextPageAsync()
        {
            var photo = await Plugin.Media.CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions() { PhotoSize = PhotoSize.Medium, CompressionQuality = 60 });
            Models.ImageResult res = await _visionAPI.MakeAnalysisRequest(photo.Path);
            //var parameter = 
            //foreach (char i in word)
            //{
            //    string str = i.ToString();
            //    Services.AudioRecService.PlayAudio(str);
            //}
            //Services.AudioRecService.PlayAudio(word);
            //await _navigationService.NavigateAsync("SpeakPage");
        }
    }
}
