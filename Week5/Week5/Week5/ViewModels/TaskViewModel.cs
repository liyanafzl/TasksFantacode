using System;
using System.Collections.Generic;
using System.Text;
using Week5.Models;
using Xamarin.Forms;

namespace Week5.ViewModels
{
    public class TaskViewModel
    {
        public TaskModel taskmodel;
        public List<TaskModel> tasks = new List<TaskModel>();
        public TaskViewModel()
        {
            taskmodel = new TaskModel
            {
                task = taskmodel.task,
                status = taskmodel.status,
                priority = taskmodel.priority,
                duedate = taskmodel.duedate,
                notes = taskmodel.notes
            };
            
             
    }

    public Command addtolist
        {
            set
            {
                tasks.Add(taskmodel);
            }
       }
}

