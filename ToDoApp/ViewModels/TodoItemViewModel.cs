using System;
using System.Collections.Generic;
using System.Text;
using ToDoApp.Models;
using System.Windows.Input;
using Xamarin.Forms;

namespace ToDoApp.ViewModels
{
    public class TodoItemViewModel : ViewModel
    {
        public TodoItemViewModel(TodoItem item)
        {
            Item = item;
        }

        public event EventHandler ItemStatusChanged;
        public TodoItem Item { get; private set; }
        public string StatusText => Item.Completed ? "Reactivate" : "Completed";

        public ICommand ToggleCompleted => new Command((arg) =>
        {
            Item.Completed = !Item.Completed;
            ItemStatusChanged?.Invoke(this, new EventArgs());
        });
    }
}
