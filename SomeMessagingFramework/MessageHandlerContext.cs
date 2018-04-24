using System;
using System.Collections.Generic;
using System.Text;

namespace SomeMessagingFramework
{
    public class MessageHandlerContext<T>
    {
        public T Message { get; set; }
        public string Headers { get; set; }
        public void AbandanMessage() { }
    }
}
