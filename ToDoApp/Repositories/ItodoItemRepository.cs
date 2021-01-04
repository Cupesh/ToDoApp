using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ToDoApp.Models;

namespace ToDoApp.Repositories
{
    public interface ItodoItemRepository
    {
        event EventHandler<TodoItem> OnItemAdded;
        event EventHandler<TodoItem> OnItemUpdated;

        Task<List<TodoItem>> GetItems();
        Task AddItem(TodoItem item);
        Task UpdateItem(TodoItem item);
        Task AddOrUpdate(TodoItem item);
    }
}
