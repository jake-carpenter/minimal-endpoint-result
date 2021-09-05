using MinimalEndpointResult;

namespace Sample.TodoItems
{
    public class CompleteTodoItemRequest
    {
        public int Id { get; init; }

        public record Handler(DataStore DataStore)
        {
            public IEndpointResult Handle(CompleteTodoItemRequest request)
            {
                if (!DataStore.TodoItems.TryGetValue(request.Id, out var todoItem))
                    return EndpointResult.Fail(404);

                todoItem.IsComplete = !todoItem.IsComplete;
                return EndpointResult.Ok();
            }
        }
    }
}
