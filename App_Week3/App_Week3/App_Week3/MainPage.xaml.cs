using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App_Week3
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
        public async void calculate_onClicked(object sender, EventArgs e)
        {
            string[] str = new string[8];
            str[0] = sub1.Text;
            str[1] = sub2.Text;
            str[2] = sub3.Text;
            str[3] = sub4.Text;
            str[4] = sub5.Text;
            str[5] = sub6.Text;
            str[6] = lab1.Text;
            str[7] = lab2.Text;
            await Navigation.PushAsync(new CalculatePage(str));
        }
	}
}
