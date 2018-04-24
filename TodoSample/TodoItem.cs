using System;
using System.Collections.Generic;
using System.Text;

namespace TodoSample
{
    public class TodoItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Completed { get; set; }
        public string Status { get; set; }
        public DateTime RequiredBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime StatusChangedDate { get; set; }
    }
}
