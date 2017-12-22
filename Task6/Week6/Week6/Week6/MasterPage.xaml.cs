using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week6.Models;
using Week6.ViewModels;
using Week6.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Week6
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MasterPage : MasterDetailPage
	{
        
        public MasterPage()
        {
            InitializeComponent();
        }
        private async void ProfileButton(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
        private async void MedicineButton(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MedicineView());
        }
        private async void DoctorButton(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DoctorView());
        }


    }
}