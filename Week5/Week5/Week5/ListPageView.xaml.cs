using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Week5.Models;
using Week5.ViewModels;

namespace Week5
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListPageView : ContentPage
	{
		public ListPageView (List<TaskModel> list)

        {
            InitializeComponent();
            BindingContext = new ListViewModel(list);

        }
    }
}