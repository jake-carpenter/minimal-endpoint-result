using System.Collections.Generic;
using Sample.TodoItems;

namespace Sample
{
    public static class Data
    {
        public static Dictionary<int, TodoItem> TodoItems { get; } = new()
        {
            [1] = new TodoItem { Id = 1, Name = "foo", IsComplete = true },
            [2] = new TodoItem { Id = 2, Name = "bar", IsComplete = false },
            [3] = new TodoItem { Id = 3, Name = "baz", IsComplete = false },
        };
    }
}
