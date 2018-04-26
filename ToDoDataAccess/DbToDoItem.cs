using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoDataAccess
{
    public class DbToDoItem
    {
        public int SrNo { get; }
        public int ListId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime RequiredBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime StatusChangedDate { get; set; }
    }
}
