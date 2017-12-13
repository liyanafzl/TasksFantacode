using System;
using System.Collections.Generic;
using System.Text;
using Week5.Models;
using Xamarin.Forms;
using System.Windows.Input;
using System.Threading.Tasks;
using System.ComponentModel;
namespace Week5.ViewModels
{
    public class TaskViewModel
    {
        public TaskModel taskmodel { get; set; }
        public List<TaskModel> tasks = new List<TaskModel>();
        public ICommand addtolist { set; get; }
        public ICommand viewlist { set; get; }
        public INavigation Navigation { get; set; }
        public TaskViewModel(INavigation navigation)
        {
            //taskmodel = new TaskModel
            //{
            //    task = taskmodel.task,
            //    status = taskmodel.status,
            //    priority = taskmodel.priority,
            //    duedate = taskmodel.duedate,
            //    notes = taskmodel.notes
            //};
            this.Navigation = navigation;
            this.viewlist = new Command(async () => await GotoPage2());
            addtolist = new Command(() =>
            {
                tasks.Add(taskmodel);

            });
        }
            public async Task GotoPage2()
            {
                /////
                await Navigation.PushAsync(new ListPageView(tasks));
            }

    }
}

