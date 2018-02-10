using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace App1.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string _Parameter2;
        public string Parameter2
        {
            get
            {
                return _Parameter2;
            }
            set
            {
                _Parameter2 = value;
                OnPropertyChanged();
            }
                
        }
        private string _Parameter3;
        public string Parameter3
        {
            get
            {
                return _Parameter3;
            }
            set
            {
                _Parameter3 = value;
                OnPropertyChanged();
            }

        }
        private string _CommandParameter;
        public string CommandParameter
        {
            get
            {
                return _CommandParameter;
            }
            set
            {
                _CommandParameter = value;
                OnPropertyChanged();
            }

        }
        

        public MainViewModel(string para)
        {
            CommandParameter = para;
            Parameter2 = "String from MainViewModel-1";
            Parameter3 = "String From MainViewModel-2";


        }
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

    }
}
