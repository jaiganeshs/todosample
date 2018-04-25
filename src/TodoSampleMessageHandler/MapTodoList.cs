using System;
using System.Collections.Generic;
using System.Text;
using TodoSample;

namespace TodoSampleMessageHandler
{
    public class MapTodoList
    {
        public TodoList Map(CreateListCommand command)
        {
            return new TodoList
            {
                Name = command.Name,
                TodoItems = command.TodoList.TodoItems
            };
        }
    }
}
