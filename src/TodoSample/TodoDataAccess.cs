using System;
using System.Collections.Generic;
using System.Text;

namespace TodoSample
{
    public class TodoDataAccess
    {
        public TodoList CreateTodoList(TodoList todoList)
        {
            // this is the place where database related code goes in

            return new TodoList();
        }

        public void Update(IEnumerable<TodoItem> todoItemList)
        {
            // Database update for Item
        }

        public void CreateItem(IEnumerable<TodoItem> todoItemList,int listId)
        {
            //Database insert for ITem
        }
        public TodoList Get(int id)
        {
            return null;
        }
    }

    public class DbToDoList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
    }

    public class DbToDoItem
    {
        public int SrNo { get; }
        public int ListId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }
        public DateTime RequiredBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime StatusChangedDate { get; set; }
    }
}
