using System;
using System.Collections.Generic;
using System.Text;

namespace SomeMessagingFramework
{
    public interface IMessageHandler<T>
    {
        void HandleMessage(MessageHandlerContext<T> messageHanlderContext);
    }
}
