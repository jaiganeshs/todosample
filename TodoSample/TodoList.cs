using System;
using System.Collections.Generic;
using System.Text;

namespace TodoSample
{
    public class TodoList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<TodoItem> TodoItems { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
