using System;
using System.Collections.Generic;
using System.Text;

namespace TodoSample
{
    public class TodoList
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public IList<TodoItem> TodoItems { get; set; }
        public DateTime CreatedDate { get; private set; }

        public TodoList(string name)
        {
            if (name == null)
                throw new ArgumentNullException(nameof(name));
            this.Name = name;
        }
    }
}
