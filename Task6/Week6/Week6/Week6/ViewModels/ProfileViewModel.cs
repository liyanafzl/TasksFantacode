using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Week6.Models;
using Xamarin.Forms;

namespace Week6.ViewModels
{
    class ProfileViewModel: INotifyPropertyChanged
    {
        private String _sname;
        public String sname
        {
            get
            {
                return _sname;
            }
            set
            {
                _sname = value;
                OnPropertyChanged();
            }
        }
        private String _sage;
        public String sage
        {
            get
            {
                return _sage;
            }
            set
            {
                _sage = value;
                OnPropertyChanged();
            }
        }
        private String _sgender;
        public String sgender
        {
            get
            {
                return _sgender;
            }
            set
            {
                _sgender = value;
                OnPropertyChanged();
            }
        }
        private String _sheight;
        public String sheight
        {
            get
            {
                return _sheight;
            }
            set
            {
                _sheight = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

       
       
        public ProfileViewModel(Profile newpro)
        {
            
            sname = newpro.name;
            sage = newpro.age;
            sgender = newpro.gender;
            sheight = newpro.height;
            
        }

        


    }
}
