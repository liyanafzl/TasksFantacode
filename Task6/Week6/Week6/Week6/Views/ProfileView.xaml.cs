using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week6.Models;
using Week6.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Week6.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProfileView : ContentPage
	{
		public ProfileView (Profile newpro )
		{
			InitializeComponent ();
           BindingContext = new ProfileViewModel(newpro);
        }
	}
}