using System;
using System.Collections.Generic;
using System.Text;

namespace TodoSample
{
    public class TodoSampleApplicationService
    {
        private readonly TodoDataAccess todoDataAccess;

        public TodoSampleApplicationService(TodoDataAccess todoDataAccess)
        {
            if (null == todoDataAccess)
                throw new ArgumentNullException(nameof(todoDataAccess));

            this.todoDataAccess = todoDataAccess;
        }
        
        public void CreateTodoList(TodoList todoList)
        {
            // validate
            // set the data in the entity
            // save the data
            todoDataAccess.CreateTodoList(todoList);
        }
    }
}
