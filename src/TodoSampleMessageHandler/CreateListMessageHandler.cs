using System;
using System.Collections.Generic;
using System.Text;

namespace TodoSampleMessageHandler
{
    using TodoSample;
    using SomeMessagingFramework;

    public class CreateListMessageHandler : IMessageHandler<CreateListCommand>
    {
        public void HandleMessage(MessageHandlerContext<CreateListCommand> messageHandlerContext)
        {
            var todoList = new MapTodoList().Map(messageHandlerContext.Message);
            TodoDataAccess todoDataAccess = new TodoDataAccess();
            todoDataAccess.CreateTodoList(todoList);
        }
    }
}
