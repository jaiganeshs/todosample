using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoDataAccess
{
    public class DbToDoList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
