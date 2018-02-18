using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Module14.ViewModels
{
    public class MathViewModel : INotifyPropertyChanged
    {

        private int valA;
        public int ValA
        {
            get
            {
                return valA;
            }
            set
            {
                valA = value;
                OnPropertyChanged();
            }
                
        }
        private int valB;
        public int ValB
        {
            get
            {
                return valB;
            }
            set
            {
                valB = value;
                OnPropertyChanged();
            }

        }
        private int result;
        public int Result
        {
            get
            {
                return result;
            }
            set
            {
                result = value;
                OnPropertyChanged();
            }

        }

        public ICommand AddCommand
        {
            get
            {
                return new Command(() =>
                {
                    Result = valA + valB;
                }
                );
            }
        }
        public ICommand MultiplyCommand
        {
            get
            {
                return new Command(() =>
                {
                    Result = valA * valB;
                }
                );
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
