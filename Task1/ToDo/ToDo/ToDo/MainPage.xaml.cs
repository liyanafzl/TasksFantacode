using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace ToDo
{
    public partial class MainPage : ContentPage
    {
        List<string> member ;
        public MainPage()
        {
          
            InitializeComponent();
          
        }
        public void OnSave(object o, EventArgs e)
        {
            member = new List<string>();
            
            member.Add(item1.Text);
            member.Add(item2.Text);
            member.Add(item3.Text);
            member.Add(item4.Text);
            member.Add(item5.Text);
            member.Add(item6.Text);
        }
        public void OnView(object o, EventArgs e)
        {
            //foreach (string i in member)
            //{
            //    // await DisplayAlert("Members", i, "cancel");
            //    Label l = new Label();
            //    l.Text = i;
            //}
            item1.Text = "";
            item2.Text = "";
            item3.Text = "";
            item4.Text = "";
            item5.Text = "";
            item6.Text = "";
     
            listview.ItemsSource = member;
            
        }
    }
}
        //class Person
        //{
        //    public Person(string name, DateTime birthday, Color favoriteColor)
        //    {
        //        this.Name = name;
        //        this.Birthday = birthday;
        //        this.FavoriteColor = favoriteColor;
        //    }

        //    public string Name { private set; get; }

        //    public DateTime Birthday { private set; get; }

        //    public Color FavoriteColor { private set; get; }
        //};

        //public class Employee
        //{
        //    public string DisplayName { get { return DisplayName; } set { DisplayName = "someone"; } }
        //}

        //public MainPage()
        //{

         

        //    ObservableCollection<Employee> employeeList = new ObservableCollection<Employee>();
            
        //    //Mr. Mono will be added to the ListView because it uses an ObservableCollection
        //    employeeList.Add(new Employee() { DisplayName = "Mr. Mono" });

        //    EmployeeView.ItemsSource = employeeList;
        //    InitializeComponent();
        //    Mylabel.Text = "My To Do List";

            //    Label header = new Label
            //    {
            //        Text = "My ToDo List",
            //        FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
            //        HorizontalOptions = LayoutOptions.Center
            //    };

            //    // Define some data.
            //    List<Person> people = new List<Person>
            //    {
            //        new Person("Abigail", new DateTime(1975, 1, 15), Color.Aqua),
            //        new Person("Bob", new DateTime(1976, 2, 20), Color.Black),
            //        // ...etc.,...
            //        new Person("Yvonne", new DateTime(1987, 1, 10), Color.Purple),
            //        new Person("Zachary", new DateTime(1988, 2, 5), Color.Red)
            //    };

            //    // Create the ListView.
            //    ListView listView = new ListView
            //    {
            //        // Source of data items.
            //        ItemsSource = people,

            //        // Define template for displaying each item.
            //        // (Argument of DataTemplate constructor is called for 
            //        //      each item; it must return a Cell derivative.)
            //        ItemTemplate = new DataTemplate(() =>
            //        {
            //            // Create views with bindings for displaying each property.
            //            Label nameLabel = new Label();
            //            nameLabel.SetBinding(Label.TextProperty, "Name");

            //            Label birthdayLabel = new Label();
            //            birthdayLabel.SetBinding(Label.TextProperty,
            //                new Binding("Birthday", BindingMode.OneWay,
            //                    null, null, "Born {0:d}"));

            //            BoxView boxView = new BoxView();
            //            boxView.SetBinding(BoxView.ColorProperty, "FavoriteColor");

            //            // Return an assembled ViewCell.
            //            return new ViewCell
            //            {
            //                View = new StackLayout
            //                {
            //                    Padding = new Thickness(0, 5),
            //                    Orientation = StackOrientation.Horizontal,
            //                    Children =
            //                        {
            //                            boxView,
            //                            new StackLayout
            //                            {
            //                                VerticalOptions = LayoutOptions.Center,
            //                                Spacing = 0,
            //                                Children =
            //                                {
            //                                    nameLabel,
            //                                    birthdayLabel
            //                                }
            //                                }
            //                        }
            //                }
            //            };
            //        })
            //    };

            //    // Accomodate iPhone status bar.
            //    this.Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 5);

            //    // Build the page.
            //    this.Content = new StackLayout
            //    {
            //        Children =
            //        {
            //            header,
            //            listView
            //        }
            //    };
            //}
        