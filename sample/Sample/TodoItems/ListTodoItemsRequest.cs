using System.Collections.Generic;
using System.Linq;
using MinimalEndpointResult;

namespace Sample.TodoItems
{
    public class ListTodoItemsRequest
    {
        public record Handler(DataStore DataStore)
        {
            public IEndpointResult<IReadOnlyList<TodoItem>> Handle(ListTodoItemsRequest request)
            {
                var todoItems = DataStore.TodoItems.Values.ToList();
                return EndpointResult.Return(todoItems);
            }
        }
    }
}
