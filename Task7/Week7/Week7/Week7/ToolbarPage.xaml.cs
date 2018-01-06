using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Week7
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ToolbarPage : ContentPage
	{
		public ToolbarPage ()
		{
			InitializeComponent ();
		}
        public async void NewOnClicked(object s, EventArgs e)
        {
            MyLabel.Text = "New Item!";
        }
	}
}