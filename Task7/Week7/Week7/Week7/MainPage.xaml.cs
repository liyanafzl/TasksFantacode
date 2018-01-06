using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Week7
{
	public partial class MainPage : ContentPage, INotifyPropertyChanged
	{
		public MainPage()
		{
			InitializeComponent();
            
		}
        public async void ProgressOnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProgressPage());
        }
        public async void ToolbarOnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ToolbarPage());
        }
        public async void StackPanelClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StackPanelPage());
        }

    }
}
