using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Week6.Models;
using Week6.Views;
using Xamarin.Forms;

namespace Week6.ViewModels
{
    class MedicineViewModel:INotifyPropertyChanged
    {
        private List<Medicine> _mlist;
        public INavigation Navigation { get; set; }
        private Medicine _medmodel;
        public ICommand AddMedicine { set; get; }
        public ICommand ViewMedicine { set; get; }
        public Medicine medmodel
        {
            get
            {
                return _medmodel;
            }
            set
            {
                _medmodel = value;
                OnPropertyChanged();
            }
        }
        public List<Medicine> Mlist
        {
            get
            {
                return _mlist;
            }
            set
            {
                _mlist = value;
                OnPropertyChanged();
            }
        }
        public MedicineViewModel(INavigation navigation)
        {
            
          medmodel = new Medicine {};
            Mlist = new List<Medicine>();
            this.Navigation = navigation;
            this.ViewMedicine = new Command(async () => await GotoPage2());
            this.AddMedicine = new Command(() =>
            {
                Mlist.Add(medmodel);
                
            });
        }

        public async Task GotoPage2()
        {
            await Navigation.PushAsync(new MedicineListView(Mlist));
        }



        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
