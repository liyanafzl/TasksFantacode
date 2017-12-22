using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week6.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Week6.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DoctorListView : ContentPage
	{
		public DoctorListView (List<Doctor> list)
        {
            InitializeComponent();
            DoctorList.ItemsSource = list;

        }
    }
}