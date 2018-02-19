using Module13.Models;
using Module13.Services;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Module13.ViewModels
{
    public class SpeakPageViewModel : BindableBase, INavigatedAware
    {
        INavigationService _navigationService;
        private  IAudioRecordService _audioRecordService;
        private ISpeechService _speechService;

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
        private string hears;
        public string hear
        {
            get { return hears; }
            set
            {
                SetProperty(ref hears, value);

            }
        }
        public SpeakPageViewModel(INavigationService navigationService, IAudioRecordService audioRecordService, ISpeechService speechService)
        {

            _audioRecordService = audioRecordService;
            _navigationService = navigationService;
            _speechService = speechService;
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
            
            String record =  await _audioRecordService.RecordAudio();
            //Device.StartTimer(TimeSpan.FromSeconds(1), TimeElapsed);
            //hear = hear.Replace(" ", String.Empty);
            hear = await _speechService.RecognizeSpeechAsync(record);

            //await Task.Delay(500);
            if (record != null)
            {
               // hear = await _speechService.RecognizeSpeechAsync(record);
                if(hear != null)
                {
                    await _audioRecordService.PlayAudio(hear);
                }
                else
                {
                    await _audioRecordService.PlayAudio("Please try again");
                }

                if (hear == word)
                {
                    await _audioRecordService.PlayAudio("Well Done");
                }
                else
                {
                    await _audioRecordService.PlayAudio("Incorrect. Please try again");
                }
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
