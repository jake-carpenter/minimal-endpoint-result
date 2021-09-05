using System.Collections.Generic;
using System.Linq;
using Sample.TodoItems;

namespace Sample
{
    public class DataStore
    {
        public Dictionary<int, TodoItem> TodoItems => Data.TodoItems;

        public int GetNextId() => TodoItems.Count == 0 ? 1 : Data.TodoItems.Keys.Max() + 1;
    }
}
