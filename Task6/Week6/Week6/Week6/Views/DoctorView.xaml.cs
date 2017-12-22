using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week6.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Week6.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DoctorView : ContentPage
	{
        public DoctorView()
        {
            InitializeComponent();
        }

        public List<Doctor> docs = new List<Doctor>();
        private void add_doctor(object sender, EventArgs e)
        {
            Doctor docmodel = new Doctor();
            docmodel.dname = ddname.Text;
            docmodel.date = ddate.Text;
           
            docs.Add(docmodel);

        }
        public async void view_doctor(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DoctorListView(docs));
        }
    }
	
}