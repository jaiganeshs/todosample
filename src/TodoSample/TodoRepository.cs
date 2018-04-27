using System;
using System.Collections.Generic;
using System.Text;

namespace TodoSample
{
    public class TodoRepository
    {
        private IDictionary<int, TodoList> data = new Dictionary<int, TodoList>();
        public void CreateTodoList(TodoList todoList)
        {
            // this is the place where database related code goes in

        }
        public TodoList Get(int id)
        {
            return data[id];
        }
    }
}
