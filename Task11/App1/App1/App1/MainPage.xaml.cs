using App1.ViewModels;
using App1.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
        
        public async void OnButton1Clicked(object s, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }
        public async void OnButton2Clicked(object s, EventArgs e)
        {
            await Navigation.PushAsync(new Page3());
        }
    }
}
