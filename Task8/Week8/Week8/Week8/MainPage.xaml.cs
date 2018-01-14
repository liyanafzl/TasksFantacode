using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Week8
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
        public async void SQLOnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SQLiteSamplePage().GetSampleContentPage());
        }
        public async void GridOnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GridPage());
        }
        public async void AnimationOnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AnimationPage());
        }
        public async void GestureOnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GesturePage());
        }

    }
}
