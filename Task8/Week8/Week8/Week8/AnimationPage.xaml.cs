using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Week8
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AnimationPage : ContentPage
	{
		public AnimationPage ()
		{
			InitializeComponent ();
		}
        public async void StartOnClicked(object s, EventArgs e)
        {
            await MainGrid.TranslateTo(200, 300, 1000, Easing.Linear);
            await MainGrid.RotateTo(90, 800, Easing.SinOut);
            await MainGrid.FadeTo(0.5, 600, Easing.CubicOut);
            await MainGrid.LayoutTo(new Rectangle(-200, -300, 300, 100));

        }
    }
}