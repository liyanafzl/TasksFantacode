using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Week8.SQLite;
using Xamarin.Forms;

namespace Week8
{
    public class SQLiteSamplePage
    {
        private readonly SQLiteConnection _sQLiteConnection;

        public SQLiteSamplePage()
        {
            _sQLiteConnection = DependencyService.Get<ISQLite>().GetConnection();

            _sQLiteConnection.CreateTable<DataItem>();

            _sQLiteConnection.Insert(new DataItem
            {
                Text = "tutorial about sql"
            });
            _sQLiteConnection.Update(new DataItem
            {
                ID = 1,
                Text = "Creating a new row"

            });


        }
        public ContentPage GetSampleContentPage()
        {
            var entry = new Entry
            {
                Placeholder = "Text",
                WidthRequest = Device.OnPlatform<double>(300, 300, 260)
            };
            var addButton = new Button
            {
                Text = "Add Item"
            };
            addButton.Clicked += (s, e) =>
             {
                 _sQLiteConnection.Insert(new DataItem
                 {
                     Text = entry.Text

                 });
             };
            var listview = new ListView
            {
                ItemsSource = _sQLiteConnection.Table<DataItem>()
            };
            var refreshButton = new Button
            {
                Text = "Refresh"
            };
            refreshButton.Clicked += (s, e) =>
            {
                listview.ItemsSource = _sQLiteConnection.Table<DataItem>();
            };
            var contentPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Label
                        {
                            Text = "SQLite Sample",
                            FontSize = 50
                        },
                        new StackLayout
                        {
                            Orientation = StackOrientation.Horizontal,
                            Children =
                            {
                                entry,
                               
                            }
                        },
                        addButton,
                        refreshButton,
                        listview,
                    }
                }
            };
            return contentPage;



        }

    }
}
