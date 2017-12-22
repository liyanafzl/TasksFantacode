using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Week5.Models;
using Week5.ViewModels;

namespace Week5
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            BindingContext = new TaskViewModel(Navigation);
        }
        //public List<TaskModel> tasks = new List<TaskModel>();
        //private void Button_Clicked(object sender, EventArgs e)
        //{
        //    //tasks = new List<Task>();
        //    TaskModel newtask = new TaskModel();
        //    newtask.task = taskentry.Text;
        //    newtask.status = statusentry.Text;
        //    newtask.priority = priorityentry.Text;
        //    newtask.duedate = dateentry.Text;
        //    newtask.notes = notesentry.Text;
        //    tasks.Add(newtask);

        //}
        //public async void View_Clicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new ListPageView(tasks));
        //}
    }
}
