using System;
using System.Collections.Generic;
using System.Text;
using Week5.Models;
using Xamarin.Forms;
using System.Runtime.CompilerServices;

using System.Windows.Input;
using System.Threading.Tasks;

using System.ComponentModel;
using Android.Content.Res;

namespace Week5.ViewModels
{
    public class TaskViewModel : INotifyPropertyChanged
    {
        private TaskModel _taskmodel;
        private string _message;
        public INavigation Navigation { get; set; }
        public ICommand viewlist { set; get; }
        List<TaskModel> list = new List<TaskModel>();
        public TaskModel taskmodel
        {
            get
            {
                return _taskmodel;
            }
            set
            {
                _taskmodel = value;
                OnPropertyChanged();
            }
        }

        public TaskViewModel(INavigation navigation)
        {
            taskmodel = new TaskModel
            {
                task = "",
                status = "",
                duedate = "",
                notes = "",
                priority = ""
            };
            this.Navigation = navigation;
            this.viewlist = new Command(async () => await GotoPage2());
        }
        
        public string message
        {
            get
            {
                return _message;
            } set
            {
                _message = value;
                OnPropertyChanged();
            }
        }
        public Command addtolist
        {
            get
            {
                return new Command(() =>
                {
                list.Add(taskmodel);
                message = "The task is " + taskmodel.task + " for date " + taskmodel.duedate + "priority" + taskmodel.priority + " status " + taskmodel.status;

                });
            }

        }
        

        public async Task GotoPage2()
        {
            /////
            await Navigation.PushAsync(new ListPageView());
        }




        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        
        //private TaskModel _taskmodel;
        //public TaskModel taskmodel
        //{
        //    get
        //    {
        //        return _taskmodel;

        //    }
        //    set
        //    {
        //        _taskmodel = value;
        //    }
        //}
        //public List<TaskModel> tasks = new List<TaskModel>();
        //public ICommand addtolist { set; get; }
        //public ICommand viewlist { set; get; }
        //public INavigation Navigation { get; set; }
        //public TaskViewModel(INavigation navigation)
        //{
        //    taskmodel = new TaskModel
        //    {
        //       task = "some task",
        //       status = "some staus",
        //       duedate = "some date",
        //       priority = "some priority",
        //       notes = "some notes "

        //};

        //    this.Navigation = navigation;
        //    this.viewlist = new Command(async () => await GotoPage2());
        //    addtolist = new Command(() =>
        //    {
        //        tasks.Add(taskmodel);

        //    });
        //}
        //    public async Task GotoPage2()
        //    {
        //        /////
        //        await Navigation.PushAsync(new ListPageView(tasks));
        //    }

    }
}

