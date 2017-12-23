using Plugin.Settings;
using Plugin.Settings.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using TestSettings.Helpers;
namespace TestSettings
{
    public partial class MainPage : ContentPage
    {
        public string DisplayLangauge { get; set; }
        private string username { get; set; }
        public string UserName
        {
            get { return username; }
            set
            {
                username = value;
                if (value != null)
                    Settings.UserName = value;
            }
        }

        private string password { get; set; }
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                if (value != null)
                    Settings.Password = value;
            }
        }

        public MainPage()
        {
            InitializeComponent();
            DisplayLangauge = Settings.DisplayLanguage;
            if (!string.IsNullOrWhiteSpace(Settings.UserName))
                UserName = Settings.UserName;
            if (!string.IsNullOrWhiteSpace(Settings.Password))
                Password = Settings.Password;
            BindingContext = this;
        }
        //Label heading = new Label
        //{
        //    Text = "Display Language is " + TestSettings.Helpers.Settings.DisplayLanguage,
        //    HorizontalOptions = LayoutOptions.CenterAndExpand,
        //    FontAttributes = FontAttributes.Bold
        //};
    }
}
