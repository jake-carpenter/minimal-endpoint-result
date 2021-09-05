using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using MinimalEndpointResult.AspNetCore.Mvc;

namespace Sample.TodoItems
{
    [ApiController]
    [Route("/todo-items")]
    public class TodoItemsController
    {
        private readonly IServiceProvider _serviceProvider;

        public TodoItemsController(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        [HttpPost]
        public IActionResult NewTodoItem(NewTodoItemRequest itemRequest)
        {
            return _serviceProvider.GetRequiredService<NewTodoItemRequest.Handler>()
                .Handle(itemRequest)
                .ToActionResult();
        }

        [HttpGet]
        public IActionResult ListTodoItems()
        {
            return _serviceProvider.GetRequiredService<ListTodoItemsRequest.Handler>()
                .Handle(new ListTodoItemsRequest())
                .ToActionResult();
        }

        [HttpPut("{id:int}/isComplete")]
        public IActionResult CompleteTodoItem(int id)
        {
            return _serviceProvider.GetRequiredService<CompleteTodoItemRequest.Handler>()
                .Handle(new CompleteTodoItemRequest { Id = id })
                .ToActionResult();
        }

        [HttpPut("{id:int}/name")]
        public IActionResult RenameTodoItem(int id, RenameTodoItemRequest request)
        {
            request.Id = id;

            return _serviceProvider.GetRequiredService<RenameTodoItemRequest.Handler>()
                .Handle(request)
                .ToActionResult();
        }
    }
}
