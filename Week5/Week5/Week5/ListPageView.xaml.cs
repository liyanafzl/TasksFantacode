using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Week5.Models;
using Week5.ViewModels;
using System.Collections.ObjectModel;
using week5.viewmodels;

namespace Week5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListPageView : ContentPage
    {
        public ListPageView(ObservableCollection<TaskModel> List)

        {
            InitializeComponent();
            BindingContext = new ListViewModel(List);


        }
    }
}