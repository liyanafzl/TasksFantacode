using System;
using System.Collections.Generic;
using System.Text;
using Week6.Models;

namespace Week6.ViewModels
{
    class MedicineListViewModel
    {
        
        private List<Medicine> _list;
        public List<Medicine> Mlist
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
        public MedicineListViewModel(List<Medicine> Listv)
        {
            this.Mlist = Listv;

        }
    }
}
