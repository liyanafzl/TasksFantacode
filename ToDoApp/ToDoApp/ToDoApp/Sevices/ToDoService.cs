using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ToDoApp.Models;

namespace ToDoApp.Sevices
{
    public class ToDoService
    {
        private const string BaseUrl = "https://todointern.azurewebsites.net/api/";
        private HttpClient httpclient;
        public ToDoService()
        {
            httpclient = new HttpClient();
            httpclient.BaseAddress = new System.Uri(BaseUrl);
        }
        async public Task<ObservableCollection<TodoItem>> GetTodoList()
        {
            try
            {
                var result = await httpclient.GetAsync("Todo");
                if (result.IsSuccessStatusCode)
                {
                    var json = await result.Content.ReadAsStringAsync();
                    var todolist = JsonConvert.DeserializeObject<ObservableCollection<TodoItem>>(json);
                    return todolist;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                return null;
            }
        }

        async public Task<bool> PostTodo(TodoItem item)
        {
            try
            {
                var itemtosend = JsonConvert.SerializeObject(item);
                var content = new StringContent(itemtosend, Encoding.UTF8, "application/json");
                var result = await httpclient.PostAsync("Todo", content);
                if (result.IsSuccessStatusCode)
                    return true;
                return false;
            }
            catch(Exception e)
            {
                return false;
            }
        }
    }
}
