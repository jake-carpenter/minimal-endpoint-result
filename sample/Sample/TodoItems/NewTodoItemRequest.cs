using Microsoft.AspNetCore.Mvc;
using MinimalEndpointResult;

namespace Sample.TodoItems
{
    public class NewTodoItemRequest
    {
        [FromBody]
        public string Name { get; init; }

        public record Handler(DataStore DataStore)
        {
            public IEndpointResult<int> Handle(NewTodoItemRequest itemRequest)
            {
                var todoItem = new TodoItem { Id = DataStore.GetNextId(), Name = itemRequest.Name, IsComplete = false };
                DataStore.TodoItems.Add(todoItem.Id, todoItem);

                return EndpointResult.Return(todoItem.Id);
            }
        }
    }
}
