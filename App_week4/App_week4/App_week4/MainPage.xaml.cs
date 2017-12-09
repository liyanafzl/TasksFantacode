using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App_week4
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();

        }
        public List<Task> tasks = new List<Task>();
        public int i = 0;
        private void Button_Clicked(object sender, EventArgs e)
        {
            //tasks = new List<Task>();
            Task newtask = new Task();
            newtask.task = taskentry.Text;
            newtask.status = statusentry.Text;
            newtask.priority = priorityentry.Text;
            newtask.duedate = dateentry.Text;
            newtask.notes = notesentry.Text;
            tasks.Add(newtask);
            i += 1;
        }
        public async void View_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListPage(tasks,i));
        }
    }
    
}

