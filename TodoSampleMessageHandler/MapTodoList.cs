using System;
using System.Collections.Generic;
using System.Text;

namespace TodoSampleMessageHandler
{
    public class MapTodoList
    {
        public TodoList Map(CreateListCommand command)
        {
            return new TodoList
            {
                Name = command.Name
            };
        }
    }
}
