using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Week3App
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CalculatePage : ContentPage
	{
		public CalculatePage (String [] str)
		{
			InitializeComponent ();
            float sum = 0;
            for (int i = 0; i < 8; i++)
            {
                int x = Convert.ToInt32(str[i]);
                sum += x;
               
            }
            var per = sum/ 400 * 100;
            String perc = per.ToString();
            percentage.Text = perc;
		}
	}
}