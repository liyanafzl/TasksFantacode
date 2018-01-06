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
	public partial class ProgressPage : ContentPage
	{
		public ProgressPage ()
		{
			InitializeComponent ();
            MyProgress.ProgressTo(0.9, 1500, Easing.Linear);
		}

	}
}