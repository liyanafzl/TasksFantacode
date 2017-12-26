using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoApp.Models
{
 
        public class TodoItem
        {
            string _todoId;
            string _task;
            string _description;
            DateTime _date;
            bool _done;

            [JsonProperty(PropertyName = "todoId")]
            public string todoId
        {
                get { return _todoId; }
                set { _todoId = value; }
            }

            [JsonProperty(PropertyName = "task")]
            public string task
        {
                get { return _task; }
                set { _task = value; }
            }
        [JsonProperty(PropertyName = "description")]
        public string description
        {
            get { return _description; }
            set { _description = value; }
        }

        [JsonProperty(PropertyName = "date")]
            public DateTime date
        {
            get { return _date; }
            set { _date = value; }
        }

        [JsonProperty(PropertyName = "done")]
        public bool done
        {
            get { return _done; }
            set { _done = value; }
        }


    }
}
