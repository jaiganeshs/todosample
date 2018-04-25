using System;
using System.Collections.Generic;
using System.Text;
using TodoSample;

namespace TodoSampleMessageHandler
{
    public class CreateListCommand
    {
        public string Name { get; set; }
        public TodoList TodoList { get; set; }
    }
}
