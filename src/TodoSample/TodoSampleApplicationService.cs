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
        
        public void CreateTodoList(CreateTodoListDto createTodoListDto)
        {
            var todoList = new TodoList(createTodoListDto.Name);
            // validate
            // set the data in the entity
            // save the data
            todoDataAccess.CreateTodoList(todoList);
        }

        public void ChangeListName(int listId, string newName)
        {

        }
    }

    public class CreateTodoListDto
    {
        public string Name { get; set; }
    }
}
