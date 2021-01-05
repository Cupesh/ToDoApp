using System;
using System.Collections.Generic;
using System.Text;
using ToDoApp.Models;

namespace ToDoApp.ViewModels
{
    public class TodoItemViewModel : ViewModel
    {
        public TodoItemViewModel(TodoItem item) => Item = item;
        public event EventHandler ItemStatusChanged;
        public TodoItemViewModel Item { get; private set; }
        public string StatusText => Item.Completed ? "Reactivate" : "Completed";
    }
}
