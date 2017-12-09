using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_week4
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListPage : ContentPage
	{
		public ListPage (List<Task> list,int n)
		{
			InitializeComponent ();
            //for (int i = 0; i < n; i++)
            //{
            //    t = list[i].task;
            //    s = list[i].status;
            //    p = list[i].priority;
            //    d = list[i].duedate;
            //    no = list[i].notes;
            //}
            ToDoList.ItemsSource = list;
           
		}
	}
}