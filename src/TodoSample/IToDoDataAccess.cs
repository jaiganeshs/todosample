using System.Collections.Generic;
using TodoSample;

namespace ToDoDataAccess
{
    public interface IToDoDataAccess
    {
        TodoList CreateTodoList(TodoList todoList);
        void Update(IEnumerable<TodoItem> todoItemList);
        void CreateItem(IEnumerable<TodoItem> todoItemList, int listId);
        TodoList Get(int id);
    }
}