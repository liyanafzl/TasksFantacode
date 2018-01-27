using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Week11.Models;
using Week11.Services;

namespace Week11.ViewModels
{ 
    public class MainViewModel : INotifyPropertyChanged
    {
        private List<Employee> _EmployeesList;
        public List<Employee> EmployeesList
        {
            get
            {
                return _EmployeesList;

            }
            set
            {
                _EmployeesList = value;
                OnPropertyChanged();
            }
        }
        public MainViewModel()
        {
            InitializeDataAsync();
        }
        public async Task InitializeDataAsync()
        {
            var employeeServices = new EmployeeServices();
            EmployeesList = await employeeServices.GetEmployeesAsync();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
