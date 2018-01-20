using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week9.Models;
using Xamarin.Forms;

namespace Week9
{
	public partial class MainPage : ContentPage
	{
        List<Employee> list = new List<Employee>();
        Employee emp1 = new Employee();
        Employee emp4 = new Employee();
        Employee emp3 = new Employee();

        Employee emp2 = new Employee();


        public MainPage()
		{
			InitializeComponent();
            emp1.Name = "abc"; emp1.Department = "Finance";
            emp2.Name = "def"; emp2.Department = "Managerial";
            emp3.Name = "abc"; emp3.Department = "Finance";
            emp4.Name = "abc"; emp4.Department = "Managerial";
            list.Add(emp1);
            list.Add(emp2);
            list.Add(emp3);
            list.Add(emp4);

            MainListView.ItemsSource = list;
		}
        
	}
}
