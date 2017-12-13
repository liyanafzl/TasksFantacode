using System;
using System.Collections.Generic;
using System.Text;
using Week5.Models;

namespace Week5.ViewModels
{
    class ListViewModel
    {
        private List<TaskModel> _tasks = new List<TaskModel>();
        public List<TaskModel> tasks {
            get
            {
                return _tasks;
            }
            set
            {
                _tasks = value;

            }
        }
        public ListViewModel(List<TaskModel> list)
        {
            this.tasks = list;
        }

    }
}
