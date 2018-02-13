using Module13.Models;
using Prism.Commands;
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
        private readonly IAudioRecordService _audioRecordService;
        public DelegateCommand PlayCommand { get; private set; }
        public DelegateCommand SpeakCommand { get; private set; }
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
        private string _caption;
        public string caption
        {


            get { return _caption; }
            set
            {
                SetProperty(ref _caption, value);

            }
        }
        public SpeakPageViewModel(INavigationService navigationService, IAudioRecordService audioRecordService)
        {
            _audioRecordService = audioRecordService;
            _navigationService = navigationService;
            PlayCommand = new DelegateCommand(OnPlay);
            SpeakCommand = new DelegateCommand(ToSpeak);
        }

        private async void OnPlay()
        {
            
            foreach (char i in word)
            {
                string str = i.ToString();
                await _audioRecordService.PlayAudio(str);
            }
           await _audioRecordService.PlayAudio(word);
        }
        private async void ToSpeak()
        {

           string speech =  await _audioRecordService.RecordAudio();
            await _audioRecordService.PlayAudio(speech);
            if (speech==word)
            {
                await _audioRecordService.PlayAudio("Well Done");
            }
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
            if(word=="indoor")
                word = res.Description.Tags[1];
           

        }
    }
}
