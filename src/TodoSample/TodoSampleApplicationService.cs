using System;
using System.Collections.Generic;
using System.Text;

namespace TodoSample
{
    public class TodoSampleApplicationService
    {
        private readonly TodoRepository todoRepository;

        public TodoSampleApplicationService(TodoRepository todoRepository)
        {
            if (null == todoRepository)
                throw new ArgumentNullException(nameof(todoRepository));

            this.todoRepository = todoRepository;
        }
        
        public void CreateTodoList(CreateTodoListDto createTodoListDto)
        {
            var todoList = new TodoList(createTodoListDto.Name);
            // validate
            // set the data in the entity
            // save the data
            todoRepository.CreateTodoList(todoList);
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
