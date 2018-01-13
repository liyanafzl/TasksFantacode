using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Week8
{
    class DataItem
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Text { get; set; }
        public override string ToString()
        {
            return string.Format("Text: {0}", Text);       
        }
    }
}
