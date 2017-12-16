using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Week5.Models;

namespace week5.viewmodels
{
    class ListViewModel
    {
        private List<TaskModel> _list;
        public List<TaskModel> List
        {
            get
            {
                return _list;
            }
            set
            {
                _list = value;
            }
        }
        public ListViewModel(List<TaskModel> List)
        {
            this.List = List;
        }
          

        //private list<taskmodel> _tasks = new list<taskmodel>();
        //public list<taskmodel> tasks
        //{
        //    get
        //    {
        //        return _tasks;
        //    }
        //    set
        //    {
        //        _tasks = value;

        //    }
        //}
        //public listviewmodel(list<taskmodel> list)
        //{
        //    this.tasks = list;
        //}

    }
}
