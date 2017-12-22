using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Week3
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CalculatePage : ContentPage
	{
		public CalculatePage (string [] str)
		{
			InitializeComponent ();
            float sum = 0;float perc;int s;
            for(int i=0;i<8;i++)
            {
                s = Convert.ToInt32(str[i]);
                sum += s;
            }
            perc = sum / 400 * 100;
            string p = perc.ToString();
            percentage.Text = p;
		}
	}
}