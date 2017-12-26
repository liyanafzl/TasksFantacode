using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ToDoApp.Models;
using ToDoApp.Sevices;
using Xamarin.Forms;

namespace ToDoApp.ViewModels
{
    public class MainViewModel: INotifyPropertyChanged
    {
        ToDoService toDoService { get; } = new ToDoService();
        public MainViewModel()
        {
            item = new TodoItem();
         
            item.task = task;
            item.description =description;
            item.done = done;

        }

        public TodoItem item { get; set; }

        private string _task { get; set; }
        public string task
        {
            get
            {
                return _task;
            }
            set
            {
                _task = value;
                OnPropertyChanged();
            }
        }
        private string _description { get; set; }
        public string description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
                OnPropertyChanged();
            }
        }
        private bool _done { get; set; }
        public bool done
        {
            get
            {
                return _done;
            }
            set
            {
                _done = value;
                OnPropertyChanged();
            }
        }

        public ICommand AddButton => (new Command(async () => await AddCommand()));

      //  public event PropertyChangedEventHandler PropertyChanged;

        private async Task AddCommand()
        {
            item = new TodoItem();

            item.task = task;
            item.description = description;
            item.done = done;

            bool res;
            try
            {



                res = await toDoService.PostTodo(item);


            }
            catch (Exception ex)
            {
                res = false;
            }


        }
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

    }
}
