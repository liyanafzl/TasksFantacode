using System;
using System.Collections.Generic;
using System.Text;
using Week5.Models;
using Xamarin.Forms;
using System.Windows.Input;

namespace Week5.ViewModels
{
    public class TaskViewModel
    {
        public TaskModel taskmodel;
        public List<TaskModel> tasks = new List<TaskModel>();
        public ICommand addtolist { set; get; }
        public TaskViewModel()
        {
            //taskmodel = new TaskModel
            //{
            //    task = taskmodel.task,
            //    status = taskmodel.status,
            //    priority = taskmodel.priority,
            //    duedate = taskmodel.duedate,
            //    notes = taskmodel.notes
            //};
            addtolist = new Command(() =>
            {
                tasks.Add(taskmodel);

            });


        }

      
    }
}

