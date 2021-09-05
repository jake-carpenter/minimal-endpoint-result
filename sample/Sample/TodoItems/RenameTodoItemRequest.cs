using Microsoft.AspNetCore.Mvc;
using MinimalEndpointResult;

namespace Sample.TodoItems
{
    public class RenameTodoItemRequest
    {
        public int Id { get; set; }

        [FromBody]
        public string Name { get; init; }

        public record Handler(DataStore DataStore)
        {
            public IEndpointResult<None> Handle(RenameTodoItemRequest request)
            {
                if (!DataStore.TodoItems.TryGetValue(request.Id, out var todoItem))
                    return EndpointResult.Fail(404);

                todoItem.Name = request.Name;
                return EndpointResult.Ok();
            }
        }
    }
}
