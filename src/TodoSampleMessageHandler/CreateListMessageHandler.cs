using System;
using System.Collections.Generic;
using System.Text;

namespace TodoSampleMessageHandler
{
    using TodoSample;
    using SomeMessagingFramework;

    public class CreateListMessageHandler : IMessageHandler<CreateListCommand>
    {
        private TodoSampleApplicationService todoSampleApplicationService = new TodoSampleApplicationService(new TodoRepository());

        public void HandleMessage(MessageHandlerContext<CreateListCommand> messageHandlerContext)
        {
            var createTodoListDto = new MapTodoList().Map(messageHandlerContext.Message);

            todoSampleApplicationService.CreateTodoList(createTodoListDto);
        }
    }
}
