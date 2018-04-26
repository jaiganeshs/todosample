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
            UpsertService upsertService = new UpsertService();
            upsertService.CreateOrUpdateToDoList(todoList);
        }
    }
}
