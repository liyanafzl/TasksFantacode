using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week11.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Week11.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
			InitializeComponent ();
            BindingContext = new MainViewModel();
		}
	}
}