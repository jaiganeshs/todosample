using System;
using System.Collections.Generic;
using System.Text;

namespace TodoSample
{
    public class UpsertService
    {
        private TodoDataAccess dataAccess;
        public UpsertService()
        {
                dataAccess=new TodoDataAccess();
        }
        public void CreateOrUpdateToDoList(TodoList todoList)
        {
            if (todoList.Id == 0)
            {
                var createdToDoList= dataAccess.CreateTodoList(todoList);
                dataAccess.CreateItem(todoList.TodoItems, createdToDoList.Id);
            }
            else
            {
                List<TodoItem> newItems=new List<TodoItem>();
                List<TodoItem> items = new List<TodoItem>();
                foreach (var item in todoList.TodoItems)
                {
                    if (item.CreatedDate != null)
                    {
                        newItems.Add(item);
                        dataAccess.CreateItem(newItems,todoList.Id);
                    }
                    else
                    {
                        items.Add(item);
                        dataAccess.Update(items);
                    }
                }
            }
        }
    }
}
