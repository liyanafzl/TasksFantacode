using System;
using System.Collections.Generic;
using System.Text;
using Week5.Models;

namespace Week5.ViewModels
{
    class ListViewModel
    {
        public List<TaskModel> tasks = new List<TaskModel>();
        public ListViewModel(List<TaskModel> list)
        {
            this.tasks = list;
        }

    }
}
