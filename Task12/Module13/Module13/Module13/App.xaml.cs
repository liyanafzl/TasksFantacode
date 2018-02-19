using Prism;
using Prism.Ioc;
using Prism.Unity;
using Prism.Modularity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Module13.ViewModels;
using Module13.Views;
using Module13.Services;

namespace Module13
{
	public partial class App : PrismApplication
	{
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();
            NavigationService.NavigateAsync("MainPage");
        }
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
            containerRegistry.RegisterForNavigation<CameraPage, CameraPageViewModel>();
            containerRegistry.RegisterForNavigation<SpeakPage, SpeakPageViewModel>();
            
            containerRegistry.Register<IVisionAPI, VisionAPIService>();
            containerRegistry.Register<IAudioRecordService, AudioService>();
            containerRegistry.Register<ISpeechService, SpeechService>();

        }


    }
}
