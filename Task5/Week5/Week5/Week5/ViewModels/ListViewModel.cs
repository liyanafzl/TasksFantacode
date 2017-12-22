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
        public List<TaskModel> Listv
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
        public ListViewModel(List<TaskModel> Listv)
        {
            this.Listv = Listv;

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
