using System;
using System.Collections.Generic;
using TodoSample;

namespace ToDoDataAccess 
{
    public class TodoDataAccess : IToDoDataAccess
    {
        public TodoList CreateTodoList(TodoList todoList)
        {
            //Map To DbModel Or create db model here
            // this is the place where database related code goes in

            return new TodoList();
        }
        public void Update(IEnumerable<TodoItem> todoItemList)
        {
            //Map To DbModel Or create db model here
            // Database update for Item
        }

        public void CreateItem(IEnumerable<TodoItem> todoItemList,int listId)
        {
            //Map To DbModel Or create db model here
            //Database insert for ITem
        }
        public TodoList Get(int id)
        {
            //Get data
            //Map To ToDoModel Or create To Do model here
            return null;
        }
    }
}
