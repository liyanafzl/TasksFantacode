using System;
using System.Collections.Generic;
using System.Text;
using Week9.Models;
using Xamarin.Forms;

namespace Week9.UI
{
    public class CustomDataTemplateSelector : DataTemplateSelector
    {
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var emp = item as Employee;
            if(emp!=null && emp.Department == "Finance")
            {
                return new DataTemplate(typeof(FirstDataTemplate));
            }
            return new DataTemplate(typeof(SecondDataTemplate));
        }
    }
}
