using App1.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Configuration
{
    public class ViewModelLocator
    {
        public MainViewModel MainViewModel { get; set; }

        public ViewModelLocator()

        {
            MainViewModel = new MainViewModel("Parameter");
        }
    }
}
