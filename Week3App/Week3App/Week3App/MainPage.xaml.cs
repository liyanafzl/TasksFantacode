using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Week3App
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            
		}

        private async void calculate_Clicked(object sender, EventArgs e)
        {
            String[] str = new String[8];
            str[0] = subject1.Text;
            str[1] = subject2.Text;
            str[2] = subject3.Text;
            str[3] = subject4.Text;
            str[4] = subject5.Text;
            str[5] = subject6.Text;
            str[6] = lab1.Text;
            str[7] = lab2.Text;
            await Navigation.PushAsync(new CalculatePage(str));
        }
    }
}
