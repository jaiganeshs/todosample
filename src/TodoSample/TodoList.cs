using System;
using System.Collections.Generic;
using System.Text;

namespace TodoSample
{
    public class TodoList
    {
        public int Id { get; set; }
        public string Name { get; private set; }
        public IList<TodoItem> TodoItems { get; set; }
        public DateTime? CreatedDate { get; }

        public string SetName
        {
            set
            {
                if (value.Length > 20)
                    throw new Exception("Lenght greater");
                Name = value;
            }
        }

        public IList<TodoItem> SeItems
        {
            set
            {
                if (validate(value))
                    TodoItems = value;
                else
                {
                    throw  new Exception("Invalid Items");
                }
            }
        }

        private bool validate(IList<TodoItem> value)
        {
            throw new NotImplementedException();
        }
    }
}
