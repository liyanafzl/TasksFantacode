using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week6.Models;
using Week6.Views;
using Xamarin.Forms;

namespace Week6
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
       
        private async void SaveOnClicked(object sender, EventArgs e)
        {
            bool x = await DisplayAlert("Notification", "Do you want to save your profile?", "Save", "Cancel");
            if (x == true)
            {
                Profile newpro = new Profile();
                newpro.name = pname.Text;
                newpro.age = page.Text;
                newpro.gender = pgender.Text;
                newpro.height = myheight.Text;
                await Navigation.PushAsync(new ProfileView(newpro));
            }
        }
       
    }
}
