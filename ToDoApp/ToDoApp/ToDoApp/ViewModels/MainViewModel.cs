using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public class MainViewModel : INotifyPropertyChanged
    {
        ToDoService toDoService { get; } = new ToDoService();
        private ObservableCollection<TodoItem> list{get; set;}
        public ObservableCollection<TodoItem> List
        {
            get
            {
                return list;
            }
            set
            {
                list = value;
                OnPropertyChanged();
            }
        }
        public MainViewModel()
        {
            list = new ObservableCollection<TodoItem>();
            
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
        private int _todoId { get; set; }
        public int todoId
        {
            get
            {
                return _todoId;
            }
            set
            {
                _todoId = value;
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
        private TodoItem onSelected { get; set; }
        public TodoItem OnSelected
        {
            get
            {
                return onSelected;
            }
            set
            {
                if (onSelected != value)
                {
                    onSelected = value;
                    OnPropertyChanged();
                    todoId = onSelected.todoId;
                    task = onSelected.task;
                    description = onSelected.description;
                    done = onSelected.done;
                }
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

        public ICommand DisplayButton => (new Command(async () => await DisplayCommand()));

        //  public event PropertyChangedEventHandler PropertyChanged;

        private async Task DisplayCommand()
        {
            List = new ObservableCollection<TodoItem>();
            try
            {

                var res = await toDoService.GetTodoList();
                if(res!=null)
                {
                    foreach (var x in res)
                    {
                        List.Add(x);
                    }
                }

            }
            catch (Exception ex)
            {
                task = "invalid";
                OnPropertyChanged("task");
            }


        }

        public ICommand DeleteButton => (new Command(async () => await DeleteCommand()));

        //  public event PropertyChangedEventHandler PropertyChanged;

        private async Task DeleteCommand()
        {

            try
            {
                todoId = OnSelected.todoId;
                task = OnSelected.task;
                description = OnSelected.description;
                done = OnSelected.done;


                await toDoService.DeleteToDo(todoId);

            }
            catch (Exception ex)
            {
                task = "invalid";
                OnPropertyChanged("task");
            }


        }

        public ICommand UpdateButton => (new Command(async () => await UpdateCommand()));
        private async Task UpdateCommand()
        {

           
                item = new TodoItem();
                item.task = task;
                item.description = description;
                item.done = done;
                item.todoId = todoId;
                bool res;
            try
            {
                res = await toDoService.UpdateTodo(item);
                

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
