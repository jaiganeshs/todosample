using System;
using System.Collections.Generic;
using System.Text;
using TodoSample;

namespace TodoSampleMessageHandler
{
    public class MapTodoList
    {
        public CreateTodoListDto Map(CreateListCommand command)
        {
            return new CreateTodoListDto
            {
                Name = command.Name
            };
        }
    }
}
